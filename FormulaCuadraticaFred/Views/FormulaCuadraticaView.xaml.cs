using FormulaCuadraticaFred.ViewModels; 

namespace FormulaCuadraticaFred.Views;

public partial class FormulaCuadraticaView : ContentPage
{
	FormulaCuadraticaViewModel ViewModel;
	public FormulaCuadraticaView()
	{
		InitializeComponent();
		ViewModel = new FormulaCuadraticaViewModel();
	}
}