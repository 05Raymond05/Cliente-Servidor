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
    public class EncargadoAD
    {
        private string cadenaConexion;
        public EncargadoAD()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        public bool AgregarEncargado(Encargado pencargado)
        {
            AgregarPersona(pencargado);
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	Encargado (IdEncargado,	Identificacion,	FechaIngreso)" +
                        " Values (@param1,	@param2,	@param3)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", pencargado.IdEncargado);
            comando.Parameters.AddWithValue("@param2", pencargado.Identificacion);
            comando.Parameters.AddWithValue("@param3", pencargado.FechaIngreso);

            conexion.Open();

            int result = comando.ExecuteNonQuery();

            conexion.Close();

            return result > 0;
        }

        private void AgregarPersona(Encargado pencargado)
        {

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	Persona (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento)" +
                        " Values (@param1, @param2, @param3, @param4, @param5)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@param1", pencargado.Identificacion);
            comando.Parameters.AddWithValue("@param2", pencargado.Nombre);
            comando.Parameters.AddWithValue("@param3", pencargado.PrimerApellido);
            comando.Parameters.AddWithValue("@param4", pencargado.SegundoApellido);
            comando.Parameters.AddWithValue("@param5", pencargado.FechaNacimiento);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }

    }
}
