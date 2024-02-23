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

    public partial class Form_Cliente : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Cliente msc;
        public Form_Cliente(SqlConnection conexion)
        {
            InitializeComponent();
            msc = new metodos_Sql_Cliente();
            Conexion = conexion;
        }

        private void Form_Cliente_Load(object sender, EventArgs e)
        {
            msc.DesplegarDatosClientes(Conexion, DGWClientes);
        }

        private void DGWClientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWClientes.AutoResizeColumns();
            DGWClientes.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWClientes.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWClientes.RowHeadersWidth + 3;
            int height = DGWClientes.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWClientes.ColumnHeadersHeight + 3;

            DGWClientes.ClientSize = new Size(width, height);
        }
    }
}
