namespace MarketList_MAUI.Views;

public partial class CriarCompraPage : ContentPage
{
	private readonly CriarCompraViewModel _viewModel;

	public CriarCompraPage(CriarCompraViewModel viewModel)
	{
		InitializeComponent();

		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}