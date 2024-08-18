namespace Custom_Database.Repository.Interfaces;

internal interface IRecordStorage
{
    Task UpdateAsync(uint recordId, byte[] data);

    Task<byte[]> GetAsync(uint recordId);
    
    Task<uint> CreateAsync();
    
    /// <summary>
    /// This creates a new record with given data and returns its Id.
    /// </summary>
    Task<uint> CreateAsync(byte[] data);

    /// <summary>
    /// Similar to CreateAsync(byte[] data) but with dataGenerator which generates data after a record is allocated.
    /// </summary>
    Task<uint> CreateAsync(Func<uint, byte[]> dataGenerator);

    Task DeleteAsync(uint recordId);
}
