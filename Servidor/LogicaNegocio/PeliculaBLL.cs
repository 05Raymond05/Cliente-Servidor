using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    //Esta clase es referencia del video "Sesión Virtual 1 Tutor: Johan Acosta Ibañez"
    public class PeliculaBLL
    {
        PeliculaAD servicio_datos = new PeliculaAD();

        public bool Guardar_Pelicula(Pelicula pelicula_nueva)
        {
            return servicio_datos.AgregarPelicula(pelicula_nueva);
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return servicio_datos.ObtenerPeliculas();
        }

    }
}