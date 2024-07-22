using Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class PeliculaxSucursalAD
    {
        private string cadenaConexion;

        public PeliculaxSucursalAD()
        {
            // Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        public bool AgregarPeliculaxSucursal(PeliculaxSucursal ppeliculasucursal)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "INSERT INTO PeliculaxSucursal (IdSucursal, IdPelicula, Cantidad)" +
                        " VALUES (@param1, @param2, @param3)";

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", ppeliculasucursal.Pelicula.IdPelicula);
            comando.Parameters.AddWithValue("@param2", ppeliculasucursal.Sucursal.IdSucursal);
            comando.Parameters.AddWithValue("@param3", ppeliculasucursal.Cantidad);

            conexion.Open();

            int result = comando.ExecuteNonQuery();

            conexion.Close();

            return result > 0;
        }

        public List<PeliculaxSucursal> ObtenerPeliculaxSucursal()
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
                    Pelicula.AnoLanzamiento, 
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

            List<PeliculaxSucursal> listaPeliculaxSucursal = new List<PeliculaxSucursal>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PeliculaxSucursal peliculaxSucursal = new PeliculaxSucursal
                    {
                        Sucursal = new Sucursal
                        {
                            IdSucursal = reader.GetInt32(reader.GetOrdinal("IdSucursal")),
                            Nombre = reader.GetString(reader.GetOrdinal("NombreSucursal")),
                            Direccion = reader.GetString(reader.GetOrdinal("Direccion")),
                            Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                            Activo = reader.GetBoolean(reader.GetOrdinal("SucursalActiva")),
                            Encargado = new Encargado
                            {
                                IdEncargado = reader.GetInt32(reader.GetOrdinal("IdEncargado"))
                            }
                        },
                        Pelicula = new Pelicula
                        {
                            IdPelicula = reader.GetInt32(reader.GetOrdinal("IdPelicula")),
                            Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                            AnoLanzamiento = reader.GetInt32(reader.GetOrdinal("AnoLanzamiento")),
                            Idioma = reader.GetString(reader.GetOrdinal("Idioma")),
                            Nombre = reader.GetString(reader.GetOrdinal("CategoriaPelicula"))
                        },
                        Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad"))
                    };
                    listaPeliculaxSucursal.Add(peliculaxSucursal);
                }
                reader.Close();
            }

            return listaPeliculaxSucursal;
        }
    }
}

