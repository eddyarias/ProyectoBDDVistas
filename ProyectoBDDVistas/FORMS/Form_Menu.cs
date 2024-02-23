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
        private Form_Login form_Login;
        private Form_Vehiculo form_Vehiculo;
        private Form_Factura form_Factura;

        public Form_Menu()
        {
            InitializeComponent();
            form_Cliente = new Form_Cliente();
            form_Empleado = new Form_Empleado();
            form_Reparacion = new Form_Reparacion();
            form_Login = new Form_Login();
            form_Vehiculo = new Form_Vehiculo();
            form_Factura = new Form_Factura();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

        }

        private void HideAllForms()
        {

            form_Cliente.Hide();
            form_Empleado.Hide();
            form_Reparacion.Hide();
            form_Login.Hide();
            form_Vehiculo.Hide();
            form_Factura.Hide();
        }

        private Form PrepararForm(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.ControlBox = false;// Desactiva el cuadro de control que contiene los botones minimizar, maximizar y cerrar
            form.FormBorderStyle = FormBorderStyle.None;// Elimina todos los bordes del formulario


            return form;
        }

        private void bttClienteMenu_Click(object sender, EventArgs e)
        {
            HideAllForms();
            PrepararForm(form_Cliente);
            form_Cliente.Show();
        }

        private void bttVehiculoMenu_Click(object sender, EventArgs e)
        {
            HideAllForms();
            PrepararForm(form_Vehiculo);
            form_Vehiculo.Show();
        }

        private void bttReparacionMenu_Click(object sender, EventArgs e)
        {
            HideAllForms();
            PrepararForm(form_Reparacion);
            form_Reparacion.Show();
        }

        private void bttEmpleadoMenu_Click(object sender, EventArgs e)
        {
            HideAllForms();
            PrepararForm(form_Empleado);
            form_Empleado.Show();
        }

        private void bttFacturacionMenu_Click(object sender, EventArgs e)
        {
            HideAllForms();
            PrepararForm(form_Factura);
            form_Factura.Show();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
