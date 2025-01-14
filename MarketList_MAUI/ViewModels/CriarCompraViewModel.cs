namespace MarketList_MAUI.ViewModels;

public class CriarCompraViewModel : ViewModelBase<Compra, Item>
{
	private string? _novoProduto;
	public string? NovoProduto
	{
		get => _novoProduto;
		set
		{
			_novoProduto = value;
			OnPropertyChanged(nameof(NovoProduto));
		}
	}


	public CriarCompraViewModel() { }

	private void Adicionar(string produto)
	{
		ItemCollection!.Add(new Item { Nome = produto });
		NovoProduto = string.Empty;
		OnPropertyChanged(nameof(ItemCollection));
	}

	public ICommand AdicionarCommand => new Command<string>(Adicionar);
}
