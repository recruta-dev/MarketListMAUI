namespace MarketList_MAUI.ViewModels;

public class HistoricoDetailViewModel : ViewModelBase<Item>
{
    public HistoricoDetailViewModel() { }

    protected override void Load()
    {
        CurrentItem = new Item();
    }
}
