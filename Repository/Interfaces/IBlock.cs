namespace Custom_Database.Repository.Interfaces;

internal interface IBlock : IDisposable
{
    /// <summary>
    ///  Id of a block, must be unique.
    /// </summary>
    uint Id { get; }
    
    /// <summary>
    /// A block may contain one or more header metadata.
    /// Each header identified by a number and 8 bytes value.
    /// </summary>
    /// <param name="field"></param>
    /// <returns></returns>
    Task<long> GetHeaderAsync(int field);

    /// <summary>
    /// Change the value of specified header. Data must not be overwritten to disk untill block is disposed.
    /// </summary>
    /// <returns></returns>
    Task SetHedearAsync(int field, long value);

    /// <summary>
    /// Read content of this block (src) into given buffer (dst).
    /// </summary>
    /// <returns></returns>
    Task ReadAsync(byte[] dst, int dstOffset, int srcOffset, int count);

    /// <summary> 
    /// Write content of a given buffer (src) into this (dst).
    /// </summary>
    Task WriteAsync(byte[] src, int srcOffset, int dstOffset, int count);
}
