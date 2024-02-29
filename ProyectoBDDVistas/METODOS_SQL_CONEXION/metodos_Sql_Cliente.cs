using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.CLASES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.METODOS_SQL_CONEXION
{
    public class metodos_Sql_Cliente
    {
        public string tabla = "VISTA_CLIENTE";

        public void DesplegarDatosClientes(SqlConnection conexion, DataGridView dataGridView)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM "+ tabla + "", conexion);
                // Crear un DataTable para contener los datos
                DataTable dataTable = new DataTable();
                // Llenar el DataTable con los datos del adaptador
                sqlDataAdapter.Fill(dataTable);
                // Asignar el DataTable como DataSource del DataGridView
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción aquí
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        public void InsertarDatosCliente(SqlConnection conexion, Cliente cliente)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (NOMBRE_CLIENTE, APELLIDO_CLIENTE, ID_TALLER, NUMCEDULA_CLIENTE, DIRECCION_CLIENTE) VALUES (@NombreCliente, @ApellidoCliente, @IdTaller, @NumCedulaCliente, @DireccionCliente)", conexion);

                // Asignar valores a los parámetros utilizando el objeto Cliente
                cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                cmd.Parameters.AddWithValue("@ApellidoCliente", cliente.ApellidoCliente);
                cmd.Parameters.AddWithValue("@IdTaller", cliente.IdTaller);
                cmd.Parameters.AddWithValue("@NumCedulaCliente", cliente.NumCedulaCliente);
                cmd.Parameters.AddWithValue("@DireccionCliente", cliente.DireccionCliente);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void ActualizarDatosCliente(SqlConnection conexion, Cliente cliente)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la actualización de datos
                SqlCommand cmd = new SqlCommand($"UPDATE {tabla} SET NUMCEDULA_CLIENTE = @NumCedulaCliente, DIRECCION_CLIENTE = @DireccionCliente WHERE NOMBRE_CLIENTE = @NombreCliente AND APELLIDO_CLIENTE = @ApellidoCliente AND ID_TALLER = @IdTaller", conexion);

                // Asignar valores a los parámetros utilizando el objeto Cliente
                cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                cmd.Parameters.AddWithValue("@ApellidoCliente", cliente.ApellidoCliente);
                cmd.Parameters.AddWithValue("@IdTaller", cliente.IdTaller);
                cmd.Parameters.AddWithValue("@NumCedulaCliente", cliente.NumCedulaCliente);
                cmd.Parameters.AddWithValue("@DireccionCliente", cliente.DireccionCliente);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void EliminarDatosCliente(SqlConnection conexion, string idTaller)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la eliminación de datos
                SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE ID_TALLER = @IdTaller", conexion);

                // Asignar valor al parámetro utilizando el ID_TALLER
                cmd.Parameters.AddWithValue("@IdTaller", idTaller);

                // Ejecutar la consulta
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

    }
}
