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
    public partial class Form_Menu : Form
    {
        private Form_Cliente form_Cliente;
        private Form_Empleado form_Empleado;
        private Form_Reparacion form_Reparacion;
       // private Form_Login form_Login;
        private Form_Vehiculo form_Vehiculo;
        private Form_Factura form_Factura;
        private Form_NumeroTelefono form_NumeroTelefono;
        SqlConnection Conexion;
        public Form_Menu(SqlConnection conexion)
        {
            InitializeComponent();
            Conexion= conexion;

            /*Inicializar formularios*/
            form_Cliente = new Form_Cliente(Conexion);
            form_Empleado = new Form_Empleado(Conexion);
            form_Reparacion = new Form_Reparacion(Conexion);
            //form_Login = new Form_Login();
            form_Vehiculo = new Form_Vehiculo(Conexion);
            form_Factura = new Form_Factura(Conexion);
            form_NumeroTelefono = new Form_NumeroTelefono(Conexion);

            /*Este forulario es el contenedor*/
            this.IsMdiContainer = true;

            /*Maximizar este formulario*/
            this.WindowState = FormWindowState.Maximized;

            /*Preparar formularios*/
            form_Cliente = (Form_Cliente)PrepararForm(form_Cliente);
            form_Empleado = (Form_Empleado)PrepararForm(form_Empleado);
            form_Reparacion = (Form_Reparacion)PrepararForm(form_Reparacion);
            form_Vehiculo = (Form_Vehiculo)PrepararForm(form_Vehiculo);
            form_Factura = (Form_Factura)PrepararForm(form_Factura);
            form_NumeroTelefono = (Form_NumeroTelefono)PrepararForm(form_NumeroTelefono);
        }

        private void OcultarFormularios()
        {
            form_Cliente.Hide();
            form_Empleado.Hide();
            form_Reparacion.Hide();
            //form_Login.Hide();
            form_Vehiculo.Hide();
            form_Factura.Hide();
            form_NumeroTelefono.Hide();
        }

        private Form PrepararForm(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.ControlBox = false;  // Asegúrate de añadir esta línea
            return form;
        }

        private void bttClienteMenu_Click(object sender, EventArgs e)
        {
            OcultarFormularios();
            form_Cliente.Show();
        }

        private void bttVehiculoMenu_Click(object sender, EventArgs e)
        {
            OcultarFormularios();
            form_Vehiculo.Show();
        }

        private void bttReparacionMenu_Click(object sender, EventArgs e)
        {
            OcultarFormularios();
            form_Reparacion.Show();
        }

        private void bttEmpleadoMenu_Click(object sender, EventArgs e)
        {
            OcultarFormularios();
            form_Empleado.Show();
        }

        private void bttFacturacionMenu_Click(object sender, EventArgs e)
        {
            OcultarFormularios();
            form_Factura.Show();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttNumeroTelefono_Click(object sender, EventArgs e)
        {
            OcultarFormularios();
            form_NumeroTelefono.Show();
        }
    }
}
