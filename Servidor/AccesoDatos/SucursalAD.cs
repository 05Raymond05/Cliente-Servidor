using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entidades;

namespace AccesoDatos
{
    public class SucursalAD
    {
        private string cadenaConexion;

        public SucursalAD()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }


        public bool AddSucursal(Sucursal sucursal)
        {
            string query = @"
                INSERT INTO Sucursal (IdSucursal, IdEncargado, Nombre, Direccion, Telefono, Activo)
                VALUES (@IdSucursal, @IdEncargado, @Nombre, @Direccion, @Telefono, @Activo)";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
                command.Parameters.AddWithValue("@IdEncargado", sucursal.Encargado.IdEncargado);
                command.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
                command.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
                command.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
                command.Parameters.AddWithValue("@Activo", sucursal.Activo);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al agregar la sucursal: " + ex.Message);
                    return false;
                }
            }
        }
         

        public DataTable ObtenerSucursales()
        {
            string query = @"
                SELECT 
                    Sucursal.IdSucursal, 
                    Sucursal.Nombre AS NombreSucursal, 
                    Sucursal.Direccion, 
                    Sucursal.Telefono, 
                    Sucursal.Activo AS SucursalActiva, 
                    Encargado.Identificacion AS IdEncargado
                FROM 
                    Sucursal
                INNER JOIN 
                    Encargado ON Sucursal.IdEncargado = Encargado.IdEncargado
                ORDER BY 
                    Sucursal.IdSucursal;
            ";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
