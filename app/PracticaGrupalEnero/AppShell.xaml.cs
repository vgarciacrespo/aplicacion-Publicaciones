namespace PracticaGrupalEnero;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("AgregarPublicacionPage", typeof(AgregarPublicacionPage));
		Routing.RegisterRoute("AgregarAutorPage", typeof(AgregarAutorPage));
		Routing.RegisterRoute("ListarPublicacionesPage", typeof(ListarPublicacionesPage));
		Routing.RegisterRoute("BuscarPorTipoPage", typeof(BuscarPorTipoPage));
		Routing.RegisterRoute("EliminarPublicacionPage", typeof(EliminarPublicacionPage));
		Routing.RegisterRoute("ModificarEstadoPage", typeof(ModificarEstadoPage));
		Routing.RegisterRoute("BuscarPorAutorPage",typeof(BuscarPorAutorPage));

	}
}
