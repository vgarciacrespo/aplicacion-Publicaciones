namespace PracticaGrupalEnero;

public partial class EliminarPublicacionPage : ContentPage
{

	ListaPublicaciones LAPublicaciones;
	public EliminarPublicacionPage()
	{
		InitializeComponent();
		LAPublicaciones = App.LAPublicaciones;
	}

	private async void OnEliminarPorTituloClicked(object sender, EventArgs e)
    {

        string titulo = IntroducirTitulo.Text;
        if (string.IsNullOrWhiteSpace(titulo))
        {
            await DisplayAlert("Error", "Por favor, introduce un título.", "OK");
            return;
        }


        ClasePublicacion publicacionAEliminar = LAPublicaciones.BuscarTitulo(titulo);

        if (publicacionAEliminar != null)
        {
            
            bool confirmacion = await DisplayAlert("Confirmar", 
                $"¿Estás seguro de que deseas eliminar la publicación '{publicacionAEliminar.TituloPublicacion}'?", 
                "Sí", 
                "No");

            if (confirmacion)
            {
                
                LAPublicaciones.Remove(publicacionAEliminar);
                await DisplayAlert("Éxito", "La publicación ha sido eliminada.", "OK");

                IntroducirTitulo.Text = string.Empty;
            }
        }
        else
        {
            await DisplayAlert("Error", "No se encontró ninguna publicación con ese título.", "OK");
        }
    }

}
