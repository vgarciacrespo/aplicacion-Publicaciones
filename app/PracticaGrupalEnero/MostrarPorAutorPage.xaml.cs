namespace PracticaGrupalEnero;

public partial class MostrarPorAutorPage : ContentPage
{
    public MostrarPorAutorPage(List<ClasePublicacion> publicacionesFiltradas)
    {
        InitializeComponent();
        PublicacionesListView.ItemsSource = publicacionesFiltradas; 
    }
}
