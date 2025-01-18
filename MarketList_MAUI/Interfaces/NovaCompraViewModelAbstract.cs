namespace MarketList_MAUI.Interfaces;

public abstract class NovaCompraViewModelAbstract : ViewModelBase
{
    private string? _mercado;
    public string? Mercado
    {
        get => _mercado;
        set 
        { 
            _mercado = value;
            OnPropertyChanged(nameof(Mercado));
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
    private ObservableCollection<Item>? _produtos;
    public ObservableCollection<Item>? Produtos
    {
        get => _produtos;
        set 
        { 
            _produtos = value;
            OnPropertyChanged(nameof(Produtos));
        }
    }
    private Item? _produtoSelecionado;
    public Item? ProdutoSelecionado
    {
        get => _produtoSelecionado;
        set
        {
            _produtoSelecionado = value;
            OnPropertyChanged(nameof(ProdutoSelecionado));
        }
    }
    private decimal _valorTotal;
    public decimal ValorTotal
    {
        get => _valorTotal;
        set 
        { 
            _valorTotal = value;
            OnPropertyChanged(nameof(ValorTotal));
        }
    }

    public NovaCompraViewModelAbstract()
    {
        Produtos = new ObservableCollection<Item>();
        ProdutoSelecionado = new Item();
    }

    protected abstract void Adicionar();
    protected abstract void PreencherMercado();
    protected abstract void InserirNome();
    protected abstract void AlterarValor();
    public ICommand AdicionarCommand => new Command(Adicionar);
    public ICommand PreencherMercadoCommand => new Command(PreencherMercado);
    public ICommand InserirNomeCommand => new Command(InserirNome);
    public ICommand AlterarValorCommand => new Command(AlterarValor);
}
