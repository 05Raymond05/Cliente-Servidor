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
    public class PeliculaxSucursalBLL
    {
        PeliculaxSucursalAD servicio_datos = new PeliculaxSucursalAD();

        public bool Guardar_PeliculaxSucursal(PeliculaxSucursal peliculaxSucursal_nueva)
        {
            return servicio_datos.AgregarPeliculaxSucursal(peliculaxSucursal_nueva);
        }

        public List<PeliculaxSucursal> ObtenerPeliculaxSucursal()
        {
            return servicio_datos.ObtenerPeliculaxSucursal();
        }

    }
}