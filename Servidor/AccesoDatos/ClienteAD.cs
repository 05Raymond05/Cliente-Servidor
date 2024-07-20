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
    public class ClienteAD
    {
        private string cadenaConexion;
        public ClienteAD()
        {
            //Se obtiene la cadena de conexión del app config del proyecto de interfaz
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexionBiblioteca"].ConnectionString;
        }

        private void AgregarPersona(Cliente pcliente)
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
            comando.Parameters.AddWithValue("@param1", pcliente.Identificacion);
            comando.Parameters.AddWithValue("@param2", pcliente.Nombre);
            comando.Parameters.AddWithValue("@param3", pcliente.PrimerApellido);
            comando.Parameters.AddWithValue("@param4", pcliente.SegundoApellido);
            comando.Parameters.AddWithValue("@param5", pcliente.FechaNacimiento);

            conexion.Open();

            comando.ExecuteNonQuery();

            conexion.Close();
        }


        public bool AgregarCliente(Cliente pcliente)
        {
            AgregarPersona(pcliente);

            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;

            conexion = new SqlConnection(cadenaConexion);
            sentencia = " Insert	Into	Cliente (IdCliente,	Identificacion,	FechaRegistro, Activo)" +
                        " Values (@IdCliente,	@Identificacion,	@FechaRegistro,		@Activo)";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@IdCliente", pcliente.IdCliente);
            comando.Parameters.AddWithValue("@Identificacion", pcliente.Identificacion);
            comando.Parameters.AddWithValue("@FechaRegistro", pcliente.FechaRegistro);
            comando.Parameters.AddWithValue("@Activo", pcliente.Activo);

            conexion.Open();

            int result = comando.ExecuteNonQuery();

            conexion.Close();

            return result > 0;
        }

        
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadenaConexion);

            sentencia = " Select	IdCliente,    Identificacion,	    FechaRegistro,     Activo" +
                        " From	    Cliente";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaClientes.Add(new Cliente
                    {
                        IdCliente = reader.GetInt32(0),
                        Identificacion = reader.GetString(1),
                        FechaRegistro = reader.GetDateTime(2),
                        Activo = reader.GetBoolean(3) //Si es nulo asigna string.Empty 
                    });
                }
            }

            conexion.Close();

            return listaClientes;
        }

    }
}
