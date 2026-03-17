namespace PracticaGrupalEnero;

public partial class BuscarPorAutorPage : ContentPage
{
    ListaPublicaciones LAPublicaciones;

    public BuscarPorAutorPage()
    {
        InitializeComponent();
        LAPublicaciones = App.LAPublicaciones; 
	}

   
    private async void OnClickedMostrarPublicaciones(object sender, EventArgs e)
    {
        
        if (string.IsNullOrEmpty(NombreAutor.Text))
        {
            await DisplayAlert("Error", "Por favor, introduce un nombre de autor.", "OK");
            return;
        }

        string autorBuscado = NombreAutor.Text.Trim();
        List<ClasePublicacion> publicacionesFiltradas = new List<ClasePublicacion>();

 
        foreach (ClasePublicacion publicacion in LAPublicaciones)
        {
            if (publicacion.Autores != null)
            {
                foreach (string autor in publicacion.Autores)
                {
                    if (autor.Equals(autorBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        publicacionesFiltradas.Add(publicacion);
                        break; 
                    }
                }
            }
        }
		if (publicacionesFiltradas.Count == 0)
    {
        await DisplayAlert("Sin resultados", "No se encontraron publicaciones para el autor especificado.", "OK");
        return;
    }

    await Navigation.PushAsync(new MostrarPorAutorPage(publicacionesFiltradas));

    }
	
}
