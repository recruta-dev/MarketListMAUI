namespace MarketList_MAUI.Views;

public partial class NovaCompraPage : ContentPage
{
	private readonly NovaCompraViewModelAbstract _viewModel;

	public NovaCompraPage(NovaCompraViewModelAbstract viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
		_viewModel = viewModel;
	}

	private void TextEdit_Completed(object sender, EventArgs e)
		=> _viewModel.InserirNomeCommand.Execute(null);

    private void NumericEdit_ValueChanged(object sender, EventArgs e)
		=> _viewModel.AlterarValorCommand.Execute(null);
}