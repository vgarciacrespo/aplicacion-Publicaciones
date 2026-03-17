namespace PracticaGrupalEnero;

public partial class AgregarPublicacionPage : ContentPage
{
	ListaPublicaciones LAPublicaciones;
	public AgregarPublicacionPage()
	{
		InitializeComponent();
		FechaPublicacionPicker.Date = DateTime.Now;
		LAPublicaciones = App.LAPublicaciones;
	}

	 private void limpiar()
	{
		PonerID.Text = string.Empty;
		TitPublicacion.Text = string.Empty;
		FechaPublicacionPicker.Date = DateTime.Now;
	}

	private async void OnClickedButonSubir(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(PonerID.Text)|| PickerEstadoPublicacion.SelectedItem==null || PickerTipoPublicacion.SelectedItem ==null ||string.IsNullOrEmpty(TitPublicacion.Text))
			await DisplayAlert("Aviso", "NO has introducido un ID", "OK");
		else
		{
			TipoPublicacion tipoPublicacion = (TipoPublicacion)Enum.Parse(typeof(TipoPublicacion),PickerTipoPublicacion.SelectedItem.ToString());
			EstadoPublicacion estadoPublicacion = (EstadoPublicacion)Enum.Parse(typeof(EstadoPublicacion),PickerEstadoPublicacion.SelectedItem.ToString());
			DateTime fechaPublicacion = FechaPublicacionPicker.Date;
			ClasePublicacion publicacion = new ClasePublicacion(PonerID.Text, TitPublicacion.Text, fechaPublicacion, tipoPublicacion, estadoPublicacion, null);		
			if (LAPublicaciones.Insertar(publicacion)==true)
				await DisplayAlert("Aviso", "Publicacion Insertado", "OK");
			else
				await DisplayAlert("Aviso", "Publicacion ya existente", "OK");

			limpiar();
		}
	}
}