namespace PracticaGrupalEnero;

public partial class ListarPublicacionesPage : ContentPage
{
	ListaPublicaciones LAPublicaciones;
	public ListarPublicacionesPage()
	{
		InitializeComponent();
		LAPublicaciones = App.LAPublicaciones;

		PublicacionesListView.ItemsSource = App.LAPublicaciones;
	}

	private async void SeleccionarPublicacion(object sender, SelectedItemChangedEventArgs e){
		if(e.SelectedItem is ClasePublicacion publicacionSeleccionada){
			bool respuesta = await DisplayAlert("Ver Detalles", "Quieres ver mas detalles de la publicación ?", "Si", "No");

			if(respuesta)
			{
				await Navigation.PushAsync(new DetallePublicacionPage(publicacionSeleccionada));
			}
			 PublicacionesListView.SelectedItem = null;
		}
	}
}