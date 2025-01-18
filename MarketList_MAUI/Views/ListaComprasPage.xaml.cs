namespace MarketList_MAUI.Views;

public partial class ListaComprasPage : ContentPage
{
	private readonly ViewModelBase<Compra, Item> _viewModel;

	public ListaComprasPage(ViewModelBase<Compra, Item> viewModel)
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

    private void NumericEdit_ValueChanged(object sender, EventArgs e)
    {
		var viewModel = (ListaCompraViewModel)_viewModel;
		viewModel.AlterarValorCommand.Execute(null);
    }
}