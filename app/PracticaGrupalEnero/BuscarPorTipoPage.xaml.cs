namespace PracticaGrupalEnero;

public partial class BuscarPorTipoPage : ContentPage
{
	 ListaPublicaciones LAPublicaciones;
	public BuscarPorTipoPage()
	{
		InitializeComponent();
		LAPublicaciones = App.LAPublicaciones;
	}

    private async void OnClickedButonVisualizar(object sender, EventArgs e)
    {

        if (PickerTipo.SelectedItem == null)
        {
            await DisplayAlert("Error", "Debes seleccionar un tipo de publicación.", "OK");
            return;
        }
		 string tipoSeleccionado = PickerTipo.SelectedItem.ToString();
        if (Enum.TryParse(tipoSeleccionado, out TipoPublicacion tipo))
        {
			List<ClasePublicacion> publicacionesFiltradas = new List<ClasePublicacion>();
			foreach (ClasePublicacion publicacion in LAPublicaciones)
			{
				if (publicacion.Tipo == tipo)
				{
					publicacionesFiltradas.Add(publicacion);
				}
        	}
			await Navigation.PushAsync(new VisualizarPorTipoPage(publicacionesFiltradas));
        }
		else
        {
            await DisplayAlert("Error", "Tipo de publicación no válido.", "OK");
		}
	}
}



