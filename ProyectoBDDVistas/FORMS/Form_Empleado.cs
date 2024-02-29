using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.CLASES;
using ProyectoBDDVistas.METODOS_SQL_CONEXION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDDVistas.FORMS
{
    public partial class Form_Empleado : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Empleado mse;
        public Empleado empleado;
        public string idEmpleadoActEli;
        public Empleado EmpleadoSeccionadoActual;

        public Form_Empleado(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            mse = new metodos_Sql_Empleado();
            mse.DesplegarDatosEmpleados(Conexion, DGWEmpleado);
        }

        private void DGWEmpleado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWEmpleado.AutoResizeColumns();
            DGWEmpleado.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWEmpleado.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWEmpleado.RowHeadersWidth + 3;
            int height = DGWEmpleado.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWEmpleado.ColumnHeadersHeight + 3;

            DGWEmpleado.ClientSize = new Size(width, height);
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            empleado = new Empleado(txtBidEmpleadoRegistrar.Text, mse.idTaller,
            txtBcedEmpleadoRegistrar.Text, txtBnomEmpleadoRegistrar.Text,
            txtBapeEmpleadoRegistrar.Text, decimal.Parse(txtBsalEmpleadoRegistrar.Text),
            DateTime.Parse(txtBfecEmpleadoRegistrar.Text));

            mse.InsertarDatosEmpleado(Conexion, empleado);

            //actualizar la tabla 
            mse.DesplegarDatosEmpleados(Conexion, DGWEmpleado);

        }

        //boton actualizar
        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleadoActualizar = new Empleado(txtBidEmpleadoAct.Text, mse.idTaller,
            txtBcedEmpleadoAct.Text, txtBnomEmpleadoAct.Text,
            txtBapeEmpleadoAct.Text, decimal.Parse(txtBsalEmpleadoAct.Text),
             DateTime.Parse(txtBfecEmpleadoAct.Text));

            mse.ActualizarDatosEmpleado(Conexion, empleadoActualizar);
            //actualizar la tabla 
            mse.DesplegarDatosEmpleados(Conexion, DGWEmpleado);
        }

        private void DGWEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Obtenemos el valor de la celda en la columna deseada
                idEmpleadoActEli = DGWEmpleado.Rows[e.RowIndex].Cells[0].Value.ToString();

            }

            EmpleadoSeccionadoActual = mse.BuscarEmpleadoPorId(Conexion, idEmpleadoActEli);

            desplegarEmpleadoActualizarEliminar();
        }

        private void desplegarEmpleadoActualizarEliminar()
        {
            if (EmpleadoSeccionadoActual != null)
            {
                txtBidEmpleadoAct.Text = EmpleadoSeccionadoActual.IdEmpleado.Trim();
                txtBcedEmpleadoAct.Text = EmpleadoSeccionadoActual.NumCedulaEmpleado.Trim();
                txtBnomEmpleadoAct.Text = EmpleadoSeccionadoActual.NombreEmpleado.Trim();
                txtBapeEmpleadoAct.Text = EmpleadoSeccionadoActual.ApellidoEmpleado.Trim();
                txtBsalEmpleadoAct.Text = EmpleadoSeccionadoActual.SalarioEmpleado + "".Trim();
                txtBfecEmpleadoAct.Text = EmpleadoSeccionadoActual.FechaInicioContratoEmpleado + "".Trim();

                txtBidEmpleadoEli.Text = EmpleadoSeccionadoActual.IdEmpleado.Trim();
                txtBcedEmpleadoEli.Text = EmpleadoSeccionadoActual.NumCedulaEmpleado.Trim();
                txtBnomEmpleadoEli.Text = EmpleadoSeccionadoActual.NombreEmpleado.Trim();
                txtBapeEmpleadoEli.Text = EmpleadoSeccionadoActual.ApellidoEmpleado.Trim();
                txtBsalEmpleadoEli.Text = EmpleadoSeccionadoActual.SalarioEmpleado + "".Trim();
                txtBfecEmpleadoEli.Text = EmpleadoSeccionadoActual.FechaInicioContratoEmpleado + "".Trim();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mse.EliminarDatosEmpleado(Conexion, txtBidEmpleadoEli.Text.Trim());
            //actualizar la tabla 
            mse.DesplegarDatosEmpleados(Conexion, DGWEmpleado);
        }
    }
}
