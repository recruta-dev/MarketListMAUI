﻿namespace MarketList_MAUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(HistoricoPage), typeof(HistoricoPage));
    }
}
