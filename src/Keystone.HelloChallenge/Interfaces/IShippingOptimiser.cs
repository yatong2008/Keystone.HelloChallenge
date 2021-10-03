using System.Threading;
using System.Threading.Tasks;
using Keystone.HelloChallenge.Models;

namespace Keystone.HelloChallenge
{
    internal interface IShippingOptimiser
    {
        Task<Carrier> SelectBestCarrierAsync(Shipment shipment, CancellationToken cancellationToken);
    }
}
