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
        }
    }
}
