namespace Custom_Database.Core.Interfaces;

internal interface IRecordStorage
{
    Task UpdateAsync(uint recordId, byte[] data);
    Task<byte[]> FindAsync(uint recordId);
    Task<uint> CreateAsync();
    Task<uint> CreateAsync(byte[] data);
    Task<uint> CreateAsync(Func<uint, byte[]> dataGenerator);
    Task DeleleAsync(uint recordId);
}
