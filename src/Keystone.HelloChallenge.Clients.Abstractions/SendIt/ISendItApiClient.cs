using System.Collections.Generic;
using System.Threading;

namespace Keystone.HelloChallenge.Support.SendIt
{
    public interface ISendItApiClient
    {
        IAsyncEnumerable<ShippingRate> GetRatesAsync(CancellationToken cancellationToken);
    }
}
