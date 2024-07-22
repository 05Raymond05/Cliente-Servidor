using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CategoriaAD
    {
        private string cadenaConexion;

        public CategoriaAD()
        {
            // Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        public bool AgregarCategoria(Categoria pcategoria)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "Insert Into CategoriaPelicula (IdCategoria, NombreCategoria, Descripcion)" +
                        " Values (@param1, @param2, @param3)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", pcategoria.IdCategoria);
            comando.Parameters.AddWithValue("@param2", pcategoria.Nombre);
            comando.Parameters.AddWithValue("@param3", pcategoria.Descripcion);

            try
            {
                conexion.Open();
                int result = comando.ExecuteNonQuery();
                conexion.Close();

                return result > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    Console.WriteLine("Error: El IdCategoria ya existe en la base de datos.");
                }
                else
                {
                    Console.WriteLine("Error al agregar la categoría: " + ex.Message);
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la categoría: " + ex.Message);
                return false;
            }
        }

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);

            sentencia = "Select IdCategoria, NombreCategoria, Descripcion From CategoriaPelicula";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaCategorias.Add(new Categoria
                    {
                        IdCategoria = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2)
                    });
                }
            }

            conexion.Close();
            return listaCategorias;
        }
    }
}
