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
    public partial class Form_Factura : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Factura msf;
        public Form_Factura(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msf = new metodos_Sql_Factura();
            msf.DesplegarDatosFacturas(conexion, DGWFactura);
        }

        private void DGWFactura_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWFactura.AutoResizeColumns();
            DGWFactura.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWFactura.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWFactura.RowHeadersWidth + 3;
            int height = DGWFactura.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWFactura.ColumnHeadersHeight + 3;

            DGWFactura.ClientSize = new Size(width, height);
        }
    }
}
