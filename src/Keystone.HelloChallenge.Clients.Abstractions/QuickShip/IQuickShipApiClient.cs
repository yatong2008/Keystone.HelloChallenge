using System.Threading;
using System.Threading.Tasks;

namespace Keystone.HelloChallenge.Support.QuickShip
{
    public interface IQuickShipApiClient
    {
        Task<ShippingPrice> CalculateShippingPriceAsync(double cubicWeight, decimal packageValue, CancellationToken cancellationToken);
    }
}
