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
    public class metodos_Sql_Empleado
    {
        public string tabla = "EMPLEADO_02";
        public string idTaller = "TALL002";

        public void DesplegarDatosEmpleados(SqlConnection conexion, DataGridView dataGridView)
        {
            try
            {
                // Asegúrate de que la conexión esté abierta
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                // Crear un adaptador SQL para cargar los datos
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tabla + "", conexion);
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

        public void InsertarDatosEmpleado(SqlConnection conexion, Empleado empleado)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la inserción de datos
                SqlCommand cmd = new SqlCommand($"INSERT INTO {tabla} (ID_EMPLEADO, ID_TALLER, NUMCED_EMPLEADO, NOMBRE_EMPLEADO, APELLIDO_EMPLEADO, SALARIO_EMPLEADO, FECHAINICIOCONTRATO_EMPLEADO) VALUES (@IdEmpleado, @IdTaller, @NumCedEmpleado, @NombreEmpleado, @ApellidoEmpleado, @SalarioEmpleado, @FechaInicioContratoEmpleado)", conexion);

                // Asignar valores a los parámetros utilizando el objeto Empleado
                cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdTaller", empleado.IdTaller);
                cmd.Parameters.AddWithValue("@NumCedEmpleado", empleado.NumCedulaEmpleado);
                cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                cmd.Parameters.AddWithValue("@ApellidoEmpleado", empleado.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@SalarioEmpleado", empleado.SalarioEmpleado);
                cmd.Parameters.AddWithValue("@FechaInicioContratoEmpleado", empleado.FechaInicioContratoEmpleado);

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

        public void ActualizarDatosEmpleado(SqlConnection conexion, Empleado empleado)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la actualización de datos
                SqlCommand cmd = new SqlCommand($"UPDATE {tabla} SET NUMCED_EMPLEADO = @NumCedEmpleado, NOMBRE_EMPLEADO = @NombreEmpleado, APELLIDO_EMPLEADO = @ApellidoEmpleado, SALARIO_EMPLEADO = @SalarioEmpleado, FECHAINICIOCONTRATO_EMPLEADO = @FechaInicioContratoEmpleado WHERE ID_EMPLEADO = @IdEmpleado AND ID_TALLER = @IdTaller", conexion);

                // Asignar valores a los parámetros utilizando el objeto Empleado
                cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdTaller", empleado.IdTaller);
                cmd.Parameters.AddWithValue("@NumCedEmpleado", empleado.NumCedulaEmpleado);
                cmd.Parameters.AddWithValue("@NombreEmpleado", empleado.NombreEmpleado);
                cmd.Parameters.AddWithValue("@ApellidoEmpleado", empleado.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@SalarioEmpleado", empleado.SalarioEmpleado);
                cmd.Parameters.AddWithValue("@FechaInicioContratoEmpleado", empleado.FechaInicioContratoEmpleado);

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

        /// <summary>
        /// Es necesario recibir el idEmpleado e idTaller??
        /// </summary>
        /// <param name="conexion"></param>
        /// <param name="idEmpleado"></param>
        /// <param name="idTaller"></param>
        public void EliminarDatosEmpleado(SqlConnection conexion, string idEmpleado, string idTaller)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                // Crear el comando SQL para la eliminación de datos
                SqlCommand cmd = new SqlCommand($"DELETE FROM {tabla} WHERE ID_EMPLEADO = @IdEmpleado AND ID_TALLER = @IdTaller", conexion);

                // Asignar valores a los parámetros utilizando el ID_EMPLEADO y ID_TALLER
                cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
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
