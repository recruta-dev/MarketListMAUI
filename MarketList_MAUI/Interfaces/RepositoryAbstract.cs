namespace MarketList_MAUI.Interfaces;

public abstract class RepositoryAbstract<TypeT> where TypeT : class
{
    protected SQLiteAsyncConnection? _dbConnection;

    protected async Task InitializeAsync()
    {
        if (_dbConnection is null)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MarketList.db3");

            _dbConnection = new SQLiteAsyncConnection(dbPath);
        }
    }
    public abstract Task<int> AddTypeT(TypeT entity);
    public abstract Task<int> DeleteTypeT(TypeT entity);
    public abstract Task<List<TypeT>> GetTypeT();
    public abstract Task<TypeT> GetTypeT(int id);
    public abstract Task<int> UpdatetypeT(TypeT entity);
}
