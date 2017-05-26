using System.Collections.Generic;

namespace Net.Chdk.Providers.Boot
{
    public interface IScriptProvider
    {
        IDictionary<int, byte[]> GetBytes(string fileSystem);
        IDictionary<string, byte[]> GetFiles();
    }
}
