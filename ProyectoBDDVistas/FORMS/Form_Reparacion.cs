using Microsoft.Data.SqlClient;
using ProyectoBDDVistas.METODOS_SQL_CONEXION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDDVistas.FORMS
{
    public partial class Form_Reparacion : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Reparacion msr;
        public Form_Reparacion(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msr = new metodos_Sql_Reparacion();
            msr.DesplegarDatosReparacion(conexion, DGWReparacion);
        }

        private void DGWReparacion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWReparacion.AutoResizeColumns();
            DGWReparacion.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWReparacion.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWReparacion.RowHeadersWidth + 3;
            int height = DGWReparacion.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWReparacion.ColumnHeadersHeight + 3;

            DGWReparacion.ClientSize = new Size(width, height);
        }
    }
}
