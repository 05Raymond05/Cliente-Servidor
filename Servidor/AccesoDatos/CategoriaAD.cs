using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoDatos
{
    //Clase que no requiere de constructor por ser static
    public class CategoriaAD
    {
        private string cadenaConexion;
        public CategoriaAD()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        public bool AgregarCategoria(Categoria pcategoria)
        {

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	CategoriaPelicula (IdCategoria, NombreCategoria, Descripcion)" +
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
                // Manejo de errores específicos de SQL
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    // Error de violación de clave primaria
                    Console.WriteLine("Error: El IdCategoria ya existe en la base de datos.");
                }
                else
                {
                    // Otros errores de SQL
                    Console.WriteLine("Error al agregar la categoría: " + ex.Message);
                }
                return false;

            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error al agregar la categoria: " + ex.Message);
                return false;
            }
        }
    }
}