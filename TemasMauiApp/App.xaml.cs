using Microsoft.Maui.Controls;

namespace TemasMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        // Este método reemplaza el uso de Application.Current.MainPage
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage());
        }
    }
}
