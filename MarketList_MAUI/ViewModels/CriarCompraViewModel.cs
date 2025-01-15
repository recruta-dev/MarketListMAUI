namespace MarketList_MAUI.ViewModels;

public class CriarCompraViewModel : ViewModelBase<Compra, Item>
{
	private Item _produto;
	public Item Produto
	{
		get => _produto;
		set
		{ 
			_produto = value;
			OnPropertyChanged(nameof(Produto));
		}
	}

	public CriarCompraViewModel()
	{
		Produto = new Item();
	}

	private void Adicionar(string produto)
	{
		ItemCollection!.Add(Produto);
		Produto = new Item();
		OnPropertyChanged(nameof(ItemCollection));
	}

	public ICommand AdicionarCommand => new Command<string>(Adicionar);
}
