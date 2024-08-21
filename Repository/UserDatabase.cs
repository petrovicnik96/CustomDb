using Custom_Database.Core;
using System.ComponentModel.Design;

namespace Custom_Database.Repository;

internal class UserDatabase : IDisposable
{
    private readonly Stream mainDatabaseFile;
    private readonly Stream primaryIndexFile;
    private readonly Stream secondaryIndexFile;
    private readonly Tree<Guid, uint> primaryIndex;
    private readonly Tree<Tuple<string, int>, uint> secondaryIndex;

    // to do
    // add record storage
    // add user serializer


    #region Dispose
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (disposing && !disposed)
        {

        }
    }
}