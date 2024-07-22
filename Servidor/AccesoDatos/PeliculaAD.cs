using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.NetworkInformation;
using Entidades;

namespace AccesoDatos
{
    public class PeliculaAD
    {

        private string cadenaConexion;

        public PeliculaAD()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }
        public bool AgregarPelicula(Pelicula ppelicula)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;



            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	Pelicula (IdPelicula, IdCategoria, Titulo, AnioLanzamiento, Idioma)" +
                        " Values (@param1,	@param2, @param3, @param4, @param5)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", ppelicula.IdPelicula);
            comando.Parameters.AddWithValue("@param2", ppelicula.IdCategoria);
            comando.Parameters.AddWithValue("@param3", ppelicula.Titulo);
            comando.Parameters.AddWithValue("@param4", ppelicula.AnoLanzamiento);
            comando.Parameters.AddWithValue("@param5", ppelicula.Idioma);

            conexion.Open();

            int result = comando.ExecuteNonQuery();

            conexion.Close();

            return result > 0;
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            string query = @"
        SELECT 
            Pelicula.IdPelicula, 
            Pelicula.Titulo, 
            Pelicula.AnioLanzamiento, 
            Pelicula.Idioma, 
            CategoriaPelicula.NombreCategoria AS CategoriaPelicula
        FROM 
            Pelicula
        INNER JOIN 
            CategoriaPelicula ON Pelicula.IdCategoria = CategoriaPelicula.IdCategoria
        ORDER BY 
            Pelicula.IdPelicula;";

            List<Pelicula> listaPeliculas = new List<Pelicula>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pelicula pelicula = new Pelicula
                            {
                                IdPelicula = reader.GetInt32(reader.GetOrdinal("IdPelicula")),
                                Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                AnoLanzamiento = reader.GetInt32(reader.GetOrdinal("AnioLanzamiento")),
                                Idioma = reader.GetString(reader.GetOrdinal("Idioma")),
                                Nombre = reader.GetString(reader.GetOrdinal("CategoriaPelicula"))
                            };
                            listaPeliculas.Add(pelicula);
                        }
                    }
                }
            }
            return listaPeliculas;
        }

        }
}

