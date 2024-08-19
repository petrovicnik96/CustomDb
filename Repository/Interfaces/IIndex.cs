namespace Custom_Database.Repository.Interfaces;

internal interface IIndex<K, V>
{
    /// <summary>
    /// Create a new entry in this index that maps key K to value V
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    Task InsertAsync(K key, V value);

    Task<Tuple<K, V>> GetAsync(K key);
}
