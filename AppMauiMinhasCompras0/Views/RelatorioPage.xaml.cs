namespace AppMauiMinhasCompras0.Views;

public partial class RelatorioPage : ContentPage
{
	public RelatorioPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        DateTime inicio = dataInicio.Date;
        DateTime fim = dataFim.Date;

        var resultado = await App.Db.FiltrarPorPeriodo(inicio, fim);

        listaProdutos.ItemsSource = resultado;
    }
}