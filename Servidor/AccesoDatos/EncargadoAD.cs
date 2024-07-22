using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class EncargadoAD
    {
        private string cadenaConexion;

        public EncargadoAD()
        {
            // Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        public bool AgregarEncargado(Encargado pencargado)
        {
            AgregarPersona(pencargado);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "Insert Into Encargado (IdEncargado, Identificacion, FechaIngreso)" +
                        " Values (@param1, @param2, @param3)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", pencargado.IdEncargado);
            comando.Parameters.AddWithValue("@param2", pencargado.Identificacion);
            comando.Parameters.AddWithValue("@param3", pencargado.FechaIngreso);

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
                    Console.WriteLine("Error: El IdEncargado ya existe en la base de datos.");
                }
                else
                {
                    Console.WriteLine("Error al agregar el encargado: " + ex.Message);
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar el encargado: " + ex.Message);
                return false;
            }
        }

        private void AgregarPersona(Encargado pencargado)
        {
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "Insert Into Persona (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento)" +
                        " Values (@param1, @param2, @param3, @param4, @param5)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", pencargado.Identificacion);
            comando.Parameters.AddWithValue("@param2", pencargado.Nombre);
            comando.Parameters.AddWithValue("@param3", pencargado.PrimerApellido);
            comando.Parameters.AddWithValue("@param4", pencargado.SegundoApellido);
            comando.Parameters.AddWithValue("@param5", pencargado.FechaNacimiento);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la persona: " + ex.Message);
            }
        }

        public List<Encargado> ObtenerEncargados()
        {
            List<Encargado> listaEncargados = new List<Encargado>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = "Select IdEncargado, Identificacion, FechaIngreso From Encargado";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listaEncargados.Add(new Encargado
                        {
                            IdEncargado = reader.GetInt32(0),
                            Identificacion = reader.GetString(1),
                            FechaIngreso = reader.GetDateTime(2)
                        });
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los encargados: " + ex.Message);
            }

            return listaEncargados;
        }
    }
}
