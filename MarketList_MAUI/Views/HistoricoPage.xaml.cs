namespace MarketList_MAUI.Views;

public partial class HistoricoPage : ContentPage
{
	private readonly ViewModelBase<Compra> _viewModel;

	public HistoricoPage(ViewModelBase<Compra> viewModel)
	{
		InitializeComponent();

		_viewModel = viewModel;
		BindingContext = _viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		_viewModel.LoadCommand.Execute(null);
    }
}