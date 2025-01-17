namespace MarketList_MAUI.ViewModels;

public class CriarCompraViewModel : ViewModelBase<Compra, Item>
{
	private Item? _produto;
	public Item? Produto
	{
		get => _produto;
		set
		{ 
			_produto = value;
			OnPropertyChanged(nameof(Produto));
		}
	}
	private bool _mercadoPreenchido;
	public bool MercadoPreenchido
	{
		get => _mercadoPreenchido;
		set 
		{
			_mercadoPreenchido = value;
			OnPropertyChanged(nameof(MercadoPreenchido));
		}
	}

	public CriarCompraViewModel()
	{
		Produto = new Item();
		MercadoPreenchido = false;
	}

	private void Adicionar()
	{
		ItemCollection!.Add(Produto!);
		Produto = new Item();
		OnPropertyChanged(nameof(ItemCollection));
	}
	private void PreencherMercado()
	{
		if (string.IsNullOrWhiteSpace(CurrentItem!.Mercado))
			MercadoPreenchido = false;
		else if (CurrentItem.Mercado.Length > 3)
			MercadoPreenchido = true;
	}

	public ICommand AdicionarCommand => new Command(Adicionar);
	public ICommand PreencherMercadoCommand => new Command(PreencherMercado);
}
