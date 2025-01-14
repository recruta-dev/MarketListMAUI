namespace MarketList_MAUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(HistoricoPage), typeof(HistoricoPage));
        Routing.RegisterRoute(nameof(HistoricoDetailPage), typeof(HistoricoDetailPage));
        Routing.RegisterRoute(nameof(ListaComprasPage), typeof(ListaComprasPage));
        Routing.RegisterRoute(nameof(CriarCompraPage), typeof(CriarCompraPage));
    }
}
