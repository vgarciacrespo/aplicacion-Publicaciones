namespace PracticaGrupalEnero;

public partial class AgregarAutorPage : ContentPage
{
	ListaPublicaciones LAPublicaciones;
	public AgregarAutorPage()
	{
		InitializeComponent();
		LAPublicaciones = App.LAPublicaciones;
	}

	 private void limpiar()
	{
		IDPublicacion.Text = string.Empty;
		NombreAutor.Text=string.Empty;
	}

	private async void OnClickedAgregarAutor(object sender, EventArgs e){
		if (string.IsNullOrEmpty(IDPublicacion.Text) || string.IsNullOrEmpty(NombreAutor.Text))
			await DisplayAlert("Aviso", "NO has introducido alguno de los campos", "OK");
		
    	else
   		 	{
        	ClasePublicacion publicacion = LAPublicaciones.Buscar(IDPublicacion.Text);
        	if (publicacion != null)
     		{
				if (publicacion.Autores == null)
				{
    				publicacion.Autores = new List<string>();
				}
            	publicacion.Autores.Add(NombreAutor.Text);
            	await DisplayAlert("Éxito", $"Autor '{NombreAutor.Text}' agregado a la publicación con ID '{IDPublicacion.Text}'.", "OK");
        	}else{
				await DisplayAlert("Aviso", "NO existe la publicacion", "OK");
			}
			}
			limpiar();
	}

}