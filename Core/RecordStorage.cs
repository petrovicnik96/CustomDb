using Custom_Database.Core.Interfaces;

namespace Custom_Database.Core;

class RecordStorage : IRecordStorage
{
    public Task<uint> CreateAsync()
    {
        throw new NotImplementedException();
    }

    public Task<uint> CreateAsync(byte[] data)
    {
        throw new NotImplementedException();
    }

    public Task<uint> CreateAsync(Func<uint, byte[]> dataGenerator)
    {
        throw new NotImplementedException();
    }

    public Task DeleleAsync(uint recordId)
    {
        throw new NotImplementedException();
    }

    public Task<byte[]> FindAsync(uint recordId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(uint recordId, byte[] data)
    {
        throw new NotImplementedException();
    }
}
