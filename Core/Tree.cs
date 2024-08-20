using Custom_Database.Core.Interfaces;
using Custom_Database.Repository.Interfaces;

namespace Custom_Database.Core;

internal class Tree<K, V> : IIndex<K, V>
{
    private readonly ITreeNodeManager<K, V> nodeManager;
    private readonly bool allowDuplicateKeys;

    public Tree(ITreeNodeManager<K, V> nodeManager, bool allowDuplicateKeys = false)
    {
        ArgumentNullException.ThrowIfNull(nodeManager);

        this.nodeManager = nodeManager;
        this.allowDuplicateKeys = allowDuplicateKeys;
    }

    public bool Delete(K key, V value, IComparer<V> valueComparer = null)
    {
        throw new NotImplementedException();
    }

    public bool Delete(K key)
    {
        throw new NotImplementedException();
    }

    public Task<Tuple<K, V>> GetAsync(K key)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tuple<K, V>>> GetLargerThanAsync(K key)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tuple<K, V>>> GetLargerThanOrEqualToAsync(K key)
    {
        throw new NotImplementedException();
    }

    public Task InsertAsync(K key, V value)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Tuple<K, V>> LessThan(K key)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Tuple<K, V>> LessThanOrEqualTo(K key)
    {
        throw new NotImplementedException();
    }
}
