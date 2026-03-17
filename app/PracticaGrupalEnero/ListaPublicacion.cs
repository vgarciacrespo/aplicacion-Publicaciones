using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PracticaGrupalEnero
{
    public class ListaPublicaciones : List<ClasePublicacion>
    {
        public ClasePublicacion Buscar(string id)
        {
            foreach (ClasePublicacion publicacion in this)
            {
                if (publicacion.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                    return publicacion;
            }
            return null;
        }

         public ClasePublicacion BuscarTitulo(string TituloPublicacion)
        {
            foreach (ClasePublicacion publicacion in this)
            {
                if (publicacion.TituloPublicacion.Equals(TituloPublicacion, StringComparison.OrdinalIgnoreCase))
                    return publicacion;
            }
            return null;
        }


        public bool Insertar(ClasePublicacion publicacion)
        {
            if (Buscar(publicacion.Id) == null)
            {
                this.Add(publicacion);
                return true;
            }
            return false;
        }
    }

}
