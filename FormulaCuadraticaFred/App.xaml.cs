using FormulaCuadraticaFred.Views;

namespace FormulaCuadraticaFred
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FormulaCuadraticaView();
        }
    }
}
