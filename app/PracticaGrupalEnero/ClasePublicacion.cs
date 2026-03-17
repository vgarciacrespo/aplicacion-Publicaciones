using System;

namespace PracticaGrupalEnero;

public enum TipoPublicacion{LIBRO_COMPLETO, CAPITULO_LIBRO, ARTICULO_REVISTA, CONGRESO}

public enum EstadoPublicacion{REVISION, ACEPTADO, RECHAZADO}
public class ClasePublicacion
{
	public string Id{ get; set;}
	public string TituloPublicacion{ get; set;}
	public DateTime FechaPublicacion{ get; set;}
	public TipoPublicacion Tipo{get;set;}
	public EstadoPublicacion Estado{get;set; }
	public List<string>  Autores{get; set;}


	public ClasePublicacion(string id, string tituloPublicacion, DateTime fechaPublicacion, TipoPublicacion tipo, EstadoPublicacion estado, List<string> autores){
		Id = id;
		TituloPublicacion = tituloPublicacion;
		FechaPublicacion = fechaPublicacion;
		Tipo = tipo;
		Estado = estado;
		Autores = autores;
	}
	public string AutoresString => Autores != null && Autores.Count > 0
        ? string.Join(", ", Autores)
        : "Sin autores";
    public override string ToString()
    {
       return $"{Id} - {TituloPublicacion} - {FechaPublicacion:yyyy-MM-dd} - {Tipo} - {Estado} - {AutoresString}";
    }
	

}
