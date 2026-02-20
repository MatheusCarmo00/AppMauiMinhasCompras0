namespace AppMauiMinhasCompras0
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ListaProdutos());
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
            //return new Window(new AppShell());
        //}
    }
}