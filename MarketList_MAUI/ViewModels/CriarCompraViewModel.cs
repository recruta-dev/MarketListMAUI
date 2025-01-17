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
	private bool _popupSalvar;
	public bool PopupSalvar
	{
		get => _popupSalvar;
		set 
		{ 
			_popupSalvar = value; 
			OnPropertyChanged(nameof(PopupSalvar));
		}
	}

	public CriarCompraViewModel()
	{
		Produto = new Item();
		MercadoPreenchido = false;
		PopupSalvar = false;
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
	private void NovaCompra()
	{
		try
		{
			if (ItemCollection!.Count == 0)
				throw new Exception("Compra não pode ser vazia");

			PopupSalvar = true;
	}
		catch (Exception ex)
		{
			OnCompraVazia(ex);
		}
	}
	public void Salvar()
	{
		PopupSalvar = false;
	}
	public void Exportar()
	{
		PopupSalvar = false;
	}

	public ICommand AdicionarCommand => new Command(Adicionar);
	public ICommand PreencherMercadoCommand => new Command(PreencherMercado);
	public ICommand NovaCompraCommand => new Command(NovaCompra);
	public ICommand SalvarCommand => new Command(Salvar);
	public ICommand ExportarCommand => new Command(Exportar);

	public event ErrorEventHandler? CompraVaziaEvent;
	protected void OnCompraVazia(Exception ex) => CompraVaziaEvent.Invoke(this, new ErrorEventArgs(ex));
}
