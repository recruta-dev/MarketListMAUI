namespace MarketList_MAUI.Views;

public partial class HistoricoDetailPage : ContentPage
{
	private readonly ViewModelBase<Item, Item> _viewModel;

	public HistoricoDetailPage(ViewModelBase<Item, Item> viewModel)
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