namespace PracticaGrupalEnero;

public partial class DetallePublicacionPage : ContentPage
{
	public DetallePublicacionPage(ClasePublicacion publicacionSeleccionada)
	{
		InitializeComponent();

		ID.Text = $"ID: {publicacionSeleccionada.Id}";
		TituloPublicacionMostrar.Text = $"Titulo: {publicacionSeleccionada.TituloPublicacion}";
		TipoPublicacionMostar.Text = $"Tipo Publicacion: {publicacionSeleccionada.Tipo}";
		EstadoPublicacionMostrar.Text = $"Estado Publicacion: {publicacionSeleccionada.Estado}";
		FechaPublicacionMostrar.Text = $"Fecha Publicacion: {publicacionSeleccionada.FechaPublicacion:yyyy-MM-dd}";
		AutoresMostar.Text = $"Nombre Autores: { publicacionSeleccionada.AutoresString}";
	}
}