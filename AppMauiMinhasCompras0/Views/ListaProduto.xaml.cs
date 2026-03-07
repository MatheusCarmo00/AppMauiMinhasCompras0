namespace AppMauiMinhasCompras0.Views;

public partial class ListaProdutos : ContentPage
{
	public ListaProdutos()
	{
		InitializeComponent();
	}

	private void ToolbarItem_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new Views.NovoProduto());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}