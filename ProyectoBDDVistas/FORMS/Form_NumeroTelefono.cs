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
    public partial class Form_NumeroTelefono : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_NumeroTelefono msnt;
        public Form_NumeroTelefono(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msnt = new metodos_Sql_NumeroTelefono();
            msnt.DesplegarDatosNumeroTelefono(conexion, DGWFNumeroTelefono);

        }

        private void DGWFNumeroTelefono_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWFNumeroTelefono.AutoResizeColumns();
            DGWFNumeroTelefono.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWFNumeroTelefono.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWFNumeroTelefono.RowHeadersWidth + 3;
            int height = DGWFNumeroTelefono.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWFNumeroTelefono.ColumnHeadersHeight + 3;

            DGWFNumeroTelefono.ClientSize = new Size(width, height);
        }
    }
}
