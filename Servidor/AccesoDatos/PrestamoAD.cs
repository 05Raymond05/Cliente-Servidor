using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PrestamoAD
    {
        private string cadenaConexion;
        public PrestamoAD()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        public bool AgregarPrestamo(Prestamo pprestamo)
        {
            string query = @"INSERT INTO Prestamo (IdPrestamo, IdCliente, IdSucursal, IdPelicula, FechaPrestamo, PendienteDevolucion)
            VALUES (@IdPrestamo, @IdCliente, @IdSucursal, @IdPelicula, @FechaPrestamo, @PendienteDevolucion)";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdCliente", pprestamo.IdCliente);
                command.Parameters.AddWithValue("@IdSucursal", pprestamo.IdSucursal);
                command.Parameters.AddWithValue("@IdPelicula", pprestamo.IdPelicula);
                command.Parameters.AddWithValue("@Devolucion", pprestamo.FechaPrestamo);
                command.Parameters.AddWithValue("@FechaPrestamo", pprestamo.Devolucion);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al agregar el préstamo: " + ex.Message);
                    return false;
                }
            }

        }

        public DataTable ObtenerPrestamosPorCliente(int idCliente)
        {
            string query = @"
                SELECT 
                    IdPrestamo, 
                    IdCliente, 
                    IdSucursal, 
                    IdPelicula, 
                    FechaPrestamo, 
                    PendienteDevolucion
                FROM 
                    Prestamo
                WHERE 
                    IdCliente = @IdCliente;";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@IdCliente", idCliente);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void ActualizarCantidadPelicula(int idSucursal, int idPelicula, int cantidad)
        {
            string query = @"
                    UPDATE 
                        PeliculaxSucursal
                    SET 
                        Cantidad = Cantidad + @Cantidad
                    WHERE 
                        IdSucursal = @IdSucursal AND IdPelicula = @IdPelicula;";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cantidad", cantidad);
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                command.Parameters.AddWithValue("@IdPelicula", idPelicula);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


    }
}
