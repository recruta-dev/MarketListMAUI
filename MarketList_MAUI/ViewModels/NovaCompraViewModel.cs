namespace MarketList_MAUI.ViewModels;

public class NovaCompraViewModel : NovaCompraViewModelAbstract
{
    public NovaCompraViewModel() : base() { }

    protected override void Adicionar()
    {
        var novo = new Item();
        novo.Habilitado = true;
        Produtos!.Add(novo);
        OnPropertyChanged(nameof(Produtos));
    }

    protected override void AlterarValor()
    {
        ValorTotal = Produtos!.Sum(a => a.Valor);
    }

    protected override void InserirNome()
    {
        if (string.IsNullOrWhiteSpace(ProdutoSelecionado!.Nome))
            ProdutoSelecionado.Habilitado = true;
        else if (ProdutoSelecionado.Nome.Length > 3)
            ProdutoSelecionado.Habilitado = false;
    }

    protected override void PreencherMercado()
    {
        if (string.IsNullOrWhiteSpace(Mercado))
            MercadoPreenchido = false;
        else if (Mercado.Length > 3)
            MercadoPreenchido = true;
    }
}
