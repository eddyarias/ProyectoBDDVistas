using Microsoft.Data.SqlClient;
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
        public Form_Empleado(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            mse = new metodos_Sql_Empleado();
            mse.DesplegarDatosEmpleados(conexion, DGWEmpleado);
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
    }
}
