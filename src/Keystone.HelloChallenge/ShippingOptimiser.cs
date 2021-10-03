using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Keystone.HelloChallenge.Support.QuickShip;
using Keystone.HelloChallenge.Support.SendIt;
using Keystone.HelloChallenge.Models;

namespace Keystone.HelloChallenge
{
    /// <summary>
    ///     Implement your solution in this class.
    /// </summary>
    internal sealed class ShippingOptimiser : IShippingOptimiser
    {
        private readonly ILogger _log;
        private readonly IQuickShipApiClient _quickShipApiClient;
        private readonly ISendItApiClient _sendItApiClient;

        public ShippingOptimiser(
            ILogger<ShippingOptimiser> log,
            ISendItApiClient sendItApiClient,
            IQuickShipApiClient quickShipApiClient)
        {
            _log = log ?? throw new ArgumentNullException(nameof(log));
            _sendItApiClient = sendItApiClient ?? throw new ArgumentNullException(nameof(sendItApiClient));
            _quickShipApiClient = quickShipApiClient ?? throw new ArgumentNullException(nameof(quickShipApiClient));
        }

        public async Task<Carrier> SelectBestCarrierAsync(Shipment shipment, CancellationToken cancellationToken)
        {
            decimal quickShipSum = 0;
            decimal sendItSum = 0;
            var quickShipShippingClasses = new List<string>();
            var sendItRateCodes = new List<string>();

            foreach (var shipmentLine in shipment.ShipmentLines)
            {
                var quickShippingPrice = await _quickShipApiClient.CalculateShippingPriceAsync(shipmentLine.CubicWeight, shipmentLine.DeclaredValue, cancellationToken);
                _log.LogDebug($"Calculate QuickShipping from item code: {shipmentLine.ItemCode}, pick shipping class: {quickShippingPrice.ShippingClass}");
                quickShipShippingClasses.Add(quickShippingPrice.ShippingClass);
                quickShipSum += quickShippingPrice.Price;

                await foreach (var rate in _sendItApiClient.GetRatesAsync(cancellationToken))
                {
                    if (!(rate.MaxCubicWeight >= shipmentLine.CubicWeight) || rate.MaxParcelValue < shipmentLine.DeclaredValue) continue;
                    _log.LogDebug($"Calculate SendIt from item code: {shipmentLine.ItemCode}, pick rate code: {rate.RateCode}");

                    sendItSum += (rate.PricePerUnitValue * shipmentLine.DeclaredValue + rate.PricePerUnitWeight * (decimal)shipmentLine.CubicWeight);
                    sendItRateCodes.Add(rate.RateCode);
                    break;
                }
            }

            if (quickShipSum <= sendItSum)
            {
                return new Carrier(nameof(_quickShipApiClient), string.Join(", ", quickShipShippingClasses), quickShipSum);
            }

            return new Carrier(nameof(_sendItApiClient), string.Join(", ", sendItRateCodes), sendItSum);
        }
    }
}
