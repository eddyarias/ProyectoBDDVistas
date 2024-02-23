using System;
using Microsoft.Data.SqlClient;

namespace ProyectoBDDVistas.METODOS_SQL_CONEXION
{
    internal class Conexion
    {
        private SqlConnection conexion;

        public Conexion(string servidor, string nombreBaseDatos, string usuario, string contraseña)
        {
            // Construye la cadena de conexión usando los parámetros
            string connectionString = $"Data Source={servidor};Initial Catalog={nombreBaseDatos};User ID={usuario};Password={contraseña};TrustServerCertificate=true;";
            conexion = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión con un parámetro opcional para mostrar el mensaje
        public bool AbrirConexion(bool mostrarMensajeExito)
        {
            bool bandera = false;
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                    if (mostrarMensajeExito)
                    {
                       /*Descomentar cuando el proyecto este funcionando al 100% */
                      //  MessageBox.Show("Conexión a la base de datos establecida con éxito.", "Conexión Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    bandera = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bandera = false;
            }
            return bandera;
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión a la base de datos: " + ex.Message);
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
