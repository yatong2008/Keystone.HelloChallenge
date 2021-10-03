using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;
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
            throw new NotImplementedException();
        }
    }
}
