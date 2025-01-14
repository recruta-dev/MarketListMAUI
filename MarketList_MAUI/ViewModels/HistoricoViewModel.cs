namespace MarketList_MAUI.ViewModels;

public class HistoricoViewModel : ViewModelBase<Compra, Compra>
{
    public HistoricoViewModel() { }

    protected override void Load()
    {
        ItemCollection = new ObservableCollection<Compra>
        {
            new Compra { Id = 1, Mercado = "Stok Center", RealizadaEm = DateTime.Now.AddDays(-5) },
            new Compra { Id = 2, Mercado = "Asun", RealizadaEm = DateTime.Now.AddDays(-4) },
            new Compra { Id = 3, Mercado = "Macromix", RealizadaEm = DateTime.Now.AddDays(-8) },
            new Compra { Id = 4, Mercado = "Rede Polo", RealizadaEm = DateTime.Now.AddDays(-6) },
            new Compra { Id = 5, Mercado = "Bom Rancho", RealizadaEm = DateTime.Now.AddDays(-1) },
            new Compra { Id = 6, Mercado = "Bistek", RealizadaEm = DateTime.Now.AddDays(-7) },
            new Compra { Id = 7, Mercado = "Nacional", RealizadaEm = DateTime.Now.AddDays(-2) },
            new Compra { Id = 8, Mercado = "Big Jóia", RealizadaEm = DateTime.Now.AddDays(-9) },
            new Compra { Id = 9, Mercado = "Beira Rio", RealizadaEm = DateTime.Now.AddDays(-3) }
        };
    }

    private async void OpenCompra(Compra item)
    {
        var parameters = new Dictionary<string, object>
        {
            { "IdCompra" , item.Id }
        };
        await Shell.Current.GoToAsync(nameof(HistoricoDetailPage), true, parameters);
    }
    private async void CriarCompra()
    {
        await Shell.Current.GoToAsync(nameof(CriarCompraPage), true);
    }

    public ICommand OpenCompraCommand { get => new Command<Compra>(OpenCompra); }
    public ICommand CriarCompraCommand => new Command(CriarCompra);
}
