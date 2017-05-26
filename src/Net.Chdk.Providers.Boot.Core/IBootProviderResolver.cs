using System.Collections.Generic;

namespace Net.Chdk.Providers.Boot
{
    public interface IBootProviderResolver
    {
        IEnumerable<KeyValuePair<string, IBootProvider>> GetBootProviders();
        IBootProvider GetBootProvider(string categoryName);
    }
}
