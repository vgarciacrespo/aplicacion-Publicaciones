namespace PracticaGrupalEnero;

public partial class ModificarEstadoPage : ContentPage
{
	ListaPublicaciones LAPublicaciones;
	public ModificarEstadoPage()
	{
		InitializeComponent();
		LAPublicaciones = App.LAPublicaciones;
		
	}

	private void OnSwitchSeleccionarDatos(object sender, ToggledEventArgs e){
		if(e.Value){
			SeleccionarDatos.Text = "Escoger por Título";
		}else{
			SeleccionarDatos.Text = "Escoger por ID";
		}
	}


	public async void OnClickedButtonModificar(object sender, EventArgs e){

		ClasePublicacion publicacion;

		if (string.IsNullOrEmpty(IntroduceDatos.Text))
        {
            await DisplayAlert("Error", "Debes introducir los datos necesarios.", "OK");
            return ;
        }
		if(SeleccionarDatosSwitch.IsToggled){
			 publicacion = LAPublicaciones.BuscarTitulo(IntroduceDatos.Text);
		}else{
			publicacion = LAPublicaciones.Buscar(IntroduceDatos.Text);
		}
		if (publicacion == null)
        {
            await DisplayAlert("Error", "No se encontró ninguna publicación con el criterio especificado.", "OK");
            return;
        }
		 if (PickerEstadoPublicacion.SelectedItem == null)
    {
        await DisplayAlert("Error", "Debes seleccionar un estado para modificar.", "OK");
        return;
    }

		
		string estadoSeleccionado = PickerEstadoPublicacion.SelectedItem.ToString();
		if (!Enum.TryParse(estadoSeleccionado, out EstadoPublicacion nuevoEstado))
		{
			await DisplayAlert("Error", "El estado seleccionado no es válido.", "OK");
			return;
		}

		
		string estadoOriginal = publicacion.Estado.ToString();
		publicacion.Estado = nuevoEstado;
       
        await DisplayAlert("Éxito", $"La publicación '{publicacion.TituloPublicacion}' ha cambiado de estado: '{estadoOriginal}' ->r '{publicacion.Estado}'.", "OK");
	}



}