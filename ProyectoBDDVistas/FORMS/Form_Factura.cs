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
            msf.DesplegarDatosFacturas(conexion, DGWFacturas);
        }

        private void DGWFacturas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWFacturas.AutoResizeColumns();
            DGWFacturas.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWFacturas.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWFacturas.RowHeadersWidth + 3-950;
            int height = DGWFacturas.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWFacturas.ColumnHeadersHeight + 3;

            DGWFacturas.ClientSize = new Size(width, height);
            DGWFacturas.Columns[0].Width = 100;
        }
    }
}
