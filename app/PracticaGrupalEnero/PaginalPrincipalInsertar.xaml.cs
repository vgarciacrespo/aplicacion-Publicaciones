namespace PracticaGrupalEnero;

public partial class PaginalPrincipalInsertar : ContentPage
{

   ListaPublicaciones LAPublicaciones;
	public PaginalPrincipalInsertar()
	{
		InitializeComponent();
      LAPublicaciones = App.LAPublicaciones;
	}

	    private async void OnAgregarPublicacionClicked(object sender, EventArgs e)
    {
       await  Shell.Current.GoToAsync("AgregarPublicacionPage");
    }

	 private async void OnAgregarAutorClicked(object sender, EventArgs e)
    {
       await  Shell.Current.GoToAsync("AgregarAutorPage");
    }
    
    private async void OnListarPublicacionesClicked(object sender, EventArgs e)
    {
       await Shell.Current.GoToAsync("ListarPublicacionesPage");
    }


    private async void OnBuscarPorTipoClicked(object sender, EventArgs e)
    {
         await Shell.Current.GoToAsync("BuscarPorTipoPage");
    }
    
   private async void OnModificarEstadoClicked(object sender, EventArgs e)
    {
         await Shell.Current.GoToAsync("ModificarEstadoPage");
    }


    private async void OnBuscarPorAutorClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("BuscarPorAutorPage");
    }

    private async void OnEliminarPublicacionClicked(object sender, EventArgs e)
    {
    	await Shell.Current.GoToAsync("EliminarPublicacionPage");
    }



	
}