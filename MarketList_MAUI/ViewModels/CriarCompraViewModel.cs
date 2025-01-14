namespace MarketList_MAUI.ViewModels;

public class CriarCompraViewModel : ViewModelBase<Compra, Item>
{
	private ObservableCollection<string>? _mercados;

	public ObservableCollection<string>? Mercados
	{
		get =>_mercados;
		set
		{ 
			_mercados = value; 
			OnPropertyChanged(nameof(Mercados));
		}
	}

	public CriarCompraViewModel()
	{
		Mercados = new ObservableCollection<string>
		{
			"Stok Center",
			"Bistek",
			"Macromix",
			"Bom Rancho"
		};
	}
}
