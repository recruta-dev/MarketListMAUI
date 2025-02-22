﻿namespace MarketList_MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress(useLocalization: false)
            .UseDevExpressControls()
            .UseDevExpressCollectionView()
            .UseDevExpressEditors()
            .UseDevExpressDataGrid()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif
        //Views
        builder.Services.AddTransient<HistoricoPage>();
        builder.Services.AddTransient<HistoricoDetailPage>();
        builder.Services.AddTransient<ListaComprasPage>();
        builder.Services.AddTransient<CriarCompraPage>();
        builder.Services.AddTransient<NovaCompraPage>();

        //ViewModels
        builder.Services.AddScoped<ViewModelBase<Compra, Compra>, HistoricoViewModel>();
        builder.Services.AddScoped<ViewModelBase<Item, Item>, HistoricoDetailViewModel>();
        builder.Services.AddScoped<ViewModelBase<Compra, Item>, ListaCompraViewModel>();
        builder.Services.AddScoped<CriarCompraViewModel>();
        builder.Services.AddScoped<NovaCompraViewModelAbstract, NovaCompraViewModel>();

        //Repositories
        builder.Services.AddSingleton<RepositoryAbstract<Compra>, CompraRepository>();
        builder.Services.AddSingleton<RepositoryAbstract<Item>, ItemRepository>();

        return builder.Build();
    }
}
