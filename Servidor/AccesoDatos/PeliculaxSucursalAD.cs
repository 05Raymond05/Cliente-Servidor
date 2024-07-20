using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PeliculaxSucursalAD
    {
        private string cadenaConexion;

        public PeliculaxSucursalAD()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }
        public void AgregarPeliculaxSucursal(PeliculaxSucursal ppeliculasucursal)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;



            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	PeliculaxSucursal (IdSucursal, IdPelicula, Cantidad)" +
                        " Values (@param1,	@param2, @param3)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", ppeliculasucursal.Pelicula.IdPelicula);
            comando.Parameters.AddWithValue("@param2", ppeliculasucursal.Sucursal.IdSucursal);
            comando.Parameters.AddWithValue("@param3", ppeliculasucursal.Cantidad);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable ObtenerPeliculaxSucursal()
        {
            string query = @"
                SELECT 
                    Sucursal.IdSucursal, 
                    Sucursal.Nombre AS NombreSucursal, 
                    Sucursal.Direccion, 
                    Sucursal.Telefono, 
                    Sucursal.Activo AS SucursalActiva, 
                    Encargado.Identificacion AS IdEncargado, 
                    Pelicula.IdPelicula, 
                    Pelicula.Titulo, 
                    Pelicula.AnioLanzamiento, 
                    Pelicula.Idioma, 
                    PeliculaxSucursal.Cantidad,
                    CategoriaPelicula.NombreCategoria AS CategoriaPelicula
                FROM 
                    PeliculaxSucursal
                INNER JOIN 
                    Sucursal ON PeliculaxSucursal.IdSucursal = Sucursal.IdSucursal
                INNER JOIN 
                    Pelicula ON PeliculaxSucursal.IdPelicula = Pelicula.IdPelicula
                INNER JOIN 
                    Encargado ON Sucursal.IdEncargado = Encargado.IdEncargado
                INNER JOIN 
                    CategoriaPelicula ON Pelicula.IdCategoria = CategoriaPelicula.IdCategoria
                ORDER BY 
                    Sucursal.IdSucursal, Pelicula.IdPelicula;
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
