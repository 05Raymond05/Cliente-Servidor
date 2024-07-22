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
    public class SucursalBLL
    {
        SucursalAD servicio_datos = new SucursalAD();

        public bool Guardar_Sucursal(Sucursal sucursal_nueva)
        {
            return servicio_datos.AddSucursal(sucursal_nueva);
        }

        public List<Sucursal> ObtenerSucursales()
        {
            return servicio_datos.ObtenerSucursales();
        }
    }
}
