namespace MarketList_MAUI.Repositories;

public class CompraRepository : RepositoryAbstract<Compra>
{
    public override async Task<int> AddTypeT(Compra entity)
        => await _dbConnection!.InsertAsync(entity);

    public override async Task<int> DeleteTypeT(Compra entity)
        => await _dbConnection!.DeleteAsync(entity);

    public override async Task<List<Compra>> GetTypeT()
        => await _dbConnection!.Table<Compra>().ToListAsync();

    public override async Task<Compra> GetTypeT(int id)
        => await _dbConnection!.Table<Compra>().FirstOrDefaultAsync(a => a.Id == id);

    public override async Task<int> UpdatetypeT(Compra entity)
        => await _dbConnection!.UpdateAsync(entity);
}
