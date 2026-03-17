namespace PracticaGrupalEnero;

public partial class App : Application
{
	static public ListaPublicaciones LAPublicaciones = new ListaPublicaciones();

	public class MockDataInitializer
	{
		public static ListaPublicaciones InicializarMockData()
		{
			var publicaciones = new ListaPublicaciones
			{
				new ClasePublicacion("P5", "Libro de Física", new DateTime(2020, 9, 12), TipoPublicacion.LIBRO_COMPLETO, EstadoPublicacion.ACEPTADO, new List<string> { "Laura Martínez", "José Ortega" }),
				new ClasePublicacion("P6", "Capítulo de Biología Molecular", new DateTime(2019, 3, 25), TipoPublicacion.CAPITULO_LIBRO, EstadoPublicacion.REVISION, new List<string> { "Carmen Ruiz" }),
				new ClasePublicacion("P7", "Artículo sobre Blockchain", new DateTime(2021, 8, 15), TipoPublicacion.ARTICULO_REVISTA, EstadoPublicacion.RECHAZADO, new List<string> { "Alberto Gómez", "Raquel Castro" }),
				new ClasePublicacion("P8", "Congreso de Inteligencia Artificial", new DateTime(2022, 11, 5), TipoPublicacion.CONGRESO, EstadoPublicacion.ACEPTADO, new List<string> { "Elena Torres", "Diego Navarro" }),
				new ClasePublicacion("P9", "Libro de Química", new DateTime(2023, 6, 18), TipoPublicacion.LIBRO_COMPLETO, EstadoPublicacion.REVISION, new List<string> { "Luis González" }),
				new ClasePublicacion("P10", "Capítulo de Robótica", new DateTime(2020, 2, 14), TipoPublicacion.CAPITULO_LIBRO, EstadoPublicacion.ACEPTADO, new List<string> { "Marta Sánchez", "David López" }),
				new ClasePublicacion("P11", "Artículo sobre Big Data", new DateTime(2023, 4, 7), TipoPublicacion.ARTICULO_REVISTA, EstadoPublicacion.ACEPTADO, new List<string> { "Andrés Romero", "Clara Medina" }),
				new ClasePublicacion("P12", "Congreso de Realidad Virtual", new DateTime(2021, 12, 20), TipoPublicacion.CONGRESO, EstadoPublicacion.RECHAZADO, new List<string> { "Francisco Rivas" }),
				new ClasePublicacion("P13", "Libro de Historia", new DateTime(2018, 9, 10), TipoPublicacion.LIBRO_COMPLETO, EstadoPublicacion.ACEPTADO, new List<string> { "Sofía Vega", "Julio Cano" }),
				new ClasePublicacion("P14", "Capítulo de Programación Avanzada", new DateTime(2019, 5, 22), TipoPublicacion.CAPITULO_LIBRO, EstadoPublicacion.REVISION, new List<string> { "Ángela Ferrer", "Miguel Álvarez" }),
				new ClasePublicacion("P15", "Artículo sobre Machine Learning", new DateTime(2022, 1, 9), TipoPublicacion.ARTICULO_REVISTA, EstadoPublicacion.ACEPTADO, new List<string> { "Roberto Núñez", "Claudia Herrera" }),
				new ClasePublicacion("P16", "Congreso de Innovación Educativa", new DateTime(2020, 6, 30), TipoPublicacion.CONGRESO, EstadoPublicacion.ACEPTADO, new List<string> { "Teresa Morales", "Pablo Díaz" })

			};

			return publicaciones;
		}
	}
	public App()
	{
		InitializeComponent();
		LAPublicaciones = MockDataInitializer.InicializarMockData();
		MainPage = new AppShell();
		

	}

}
