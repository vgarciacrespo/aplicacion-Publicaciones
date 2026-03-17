namespace PracticaGrupalEnero;

public partial class VisualizarPorTipoPage : ContentPage
{
    public VisualizarPorTipoPage(List<ClasePublicacion> publicacionesFiltradas)
    {
        InitializeComponent();

        PublicacionesListView.ItemsSource = publicacionesFiltradas;
    }
}
