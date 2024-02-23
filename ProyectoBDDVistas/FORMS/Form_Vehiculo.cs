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
    public partial class Form_Vehiculo : Form
    {
        public SqlConnection Conexion;
        public metodos_Sql_Vehiculo msv;
        public Form_Vehiculo(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion = conexion;
            msv = new metodos_Sql_Vehiculo();
            msv.DesplegarDatosVehiculos(conexion, DGWVEHICULO);
        }
        //DGWVEHICULO
        private void DGWVEHICULO_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGWVEHICULO.AutoResizeColumns();
            DGWVEHICULO.AutoResizeRows();

            // Ajustar el tamaño del DataGridView al de sus columnas y filas
            int width = DGWVEHICULO.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + DGWVEHICULO.RowHeadersWidth + 3;
            int height = DGWVEHICULO.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DGWVEHICULO.ColumnHeadersHeight + 3;

            DGWVEHICULO.ClientSize = new Size(width, height);
        }
    }
}
