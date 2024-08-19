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

    /// <summary>
    /// Find all entries that contain a key larger than or equal to specified key.
    /// </summary>
    Task<IEnumerable<Tuple<K, V>>> GetLargerThanOrEqualToAsync(K key);

    /// <summary>
    /// Find all entries that contain a key larger than specified key.
    /// </summary>
    Task<IEnumerable<Tuple<K, V>>> GetLargerThanAsync(K key);

    /// <summary>
    /// Find all entries that contain a key less than or equal specified key
    /// </summary>
    IEnumerable<Tuple<K, V>> LessThanOrEqualTo(K key);

    /// <summary>
    /// Find all entries that contain a key less than specified key
    /// </summary>
    IEnumerable<Tuple<K, V>> LessThan(K key);

    /// <summary>
    /// Delete an entry from this index, optionally use specified IComparer to compare values
    /// </summary>
    /// <param name="key">Key.</param>
    /// <param name="value">Value.</param>
    /// <param name="valueComparer">Value comparer; Default value is Comparer[k].Default</param>
    bool Delete(K key, V value, IComparer<V> valueComparer = null);

    /// <summary>
    /// Delete all entries of given key
    /// </summary>
    /// <param name="key">Key.</param>
    bool Delete(K key);
}
