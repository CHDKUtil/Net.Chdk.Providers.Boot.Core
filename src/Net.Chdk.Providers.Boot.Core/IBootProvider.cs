using System.Collections.Generic;

namespace Net.Chdk.Providers.Boot
{
    public interface IBootProvider
    {
        string FileName { get; }
        IDictionary<int, byte[]> GetBytes(string fileSystem);
    }
}
