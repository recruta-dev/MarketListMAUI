namespace MarketList_MAUI.Repositories;

public class ItemRepository : RepositoryAbstract<Item>
{
    public override async Task<int> AddTypeT(Item entity)
        => await _dbConnection!.InsertAsync(entity);

    public override async Task<int> DeleteTypeT(Item entity)
        => await _dbConnection!.DeleteAsync(entity);

    public override async Task<List<Item>> GetTypeT()
        => await _dbConnection!.Table<Item>().ToListAsync();

    public override async Task<Item> GetTypeT(int id)
        => await _dbConnection!.Table<Item>().FirstOrDefaultAsync(a => a.Id == id);

    public override async Task<int> UpdatetypeT(Item entity)
        => await _dbConnection!.UpdateAsync(entity);
}
