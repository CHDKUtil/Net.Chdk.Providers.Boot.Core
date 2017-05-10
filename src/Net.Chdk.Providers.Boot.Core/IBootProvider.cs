using System.Collections.Generic;

namespace Net.Chdk.Providers.Boot
{
    public interface IBootProvider
    {
        string FileName { get; }
        int[][] Offsets { get; }
        byte[] Prefix { get; }

        IDictionary<int, byte[]> GetBytes(string fileSystem);
    }
}
