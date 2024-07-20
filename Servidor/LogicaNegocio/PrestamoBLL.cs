using AccesoDatos;
using Entidades;
using System.Data;
using System;

namespace LogicaNegocio
{
    public class PrestamoBLL
    {
        private PrestamoAD servicio_datos_prestamo;
        private PeliculaxSucursalAD servicio_datos_peliculaXsucursal;

        public PrestamoBLL()
        {
            servicio_datos_prestamo = new PrestamoAD();
            servicio_datos_peliculaXsucursal = new PeliculaxSucursalAD();
        }

        //Validar que no tenga actualmente un prestamo de la misma pelicula
        public bool ValidarPrestamoExistente(int idCliente, int idPelicula)
        {
            DataTable prestamos = servicio_datos_prestamo.ObtenerPrestamosPorCliente(idCliente);
            foreach (DataRow row in prestamos.Rows)
            {
                if (Convert.ToInt32(row["IdPelicula"]) == idPelicula && Convert.ToBoolean(row["PendienteDevolucion"]))
                {
                    return true; // El cliente ya tiene un préstamo pendiente de esta película
                }
            }
            return false;
        }

        //validar que la pelicula seleccionada en la sucursal tenga inventario mayor a 0
        public bool ValidarInventarioPelicula(int idSucursal, int idPelicula)
        {
            DataTable inventario = servicio_datos_peliculaXsucursal.ObtenerPeliculaxSucursal();
            foreach (DataRow row in inventario.Rows)
            {
                if (Convert.ToInt32(row["IdSucursal"]) == idSucursal && Convert.ToInt32(row["IdPelicula"]) == idPelicula)
                {
                    int cantidad = Convert.ToInt32(row["Cantidad"]);
                    return cantidad > 0; // Hay inventario disponible
                }
            }
            return false;
        }

        //Actualizar la cantidad en -1 de esa pelicula en sucursal x pelicula
        public void ActualizarInventarioPelicula(int idSucursal, int idPelicula)
        {
            servicio_datos_prestamo.ActualizarCantidadPelicula(idSucursal, idPelicula, -1);
        }

        public bool Guardar_Prestamo(Prestamo pprestamo)
        {
            return servicio_datos_prestamo.AgregarPrestamo(pprestamo);
        }
    }
}
