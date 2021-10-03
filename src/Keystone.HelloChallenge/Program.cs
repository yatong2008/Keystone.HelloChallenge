using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Keystone.HelloChallenge.Support;
using Keystone.HelloChallenge.Data;
using System;

namespace Keystone.HelloChallenge
{
    /// <summary>
    ///     Please don't change this file, assume that it's behaviour represents some fixed external component of the system.
    /// </summary>
    public static class Program
    {
        public static async Task Main()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddQuickShipApiClient()
                .AddSendItApiClient()
                .AddLogging(lb => lb.AddConsole())
                .AddSingleton<IShippingOptimiser, ShippingOptimiser>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var shipments = SampleShipments.Get();

            var optimiser = serviceProvider.GetRequiredService<IShippingOptimiser>();
           
            foreach (var shipment in shipments)
            {
                var carrier = await optimiser.SelectBestCarrierAsync(shipment, default);
                Console.WriteLine($"Shipment {shipment.Code} will be carried by {carrier.Name} service {carrier.RateCode} for ${carrier.Price:F2}");
            }
        }
    }
}
