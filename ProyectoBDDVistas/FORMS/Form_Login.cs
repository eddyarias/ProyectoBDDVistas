using ProyectoBDDVistas.METODOS_SQL_CONEXION;

namespace ProyectoBDDVistas
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2); ;
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            String usuario= TBUsername.Text;
            String contraseña = TBPassword.Text;
            Conexion conexion = new Conexion("DESKTOP-85782JV","TallerReparacionG",usuario,contraseña);
            bool continuar = conexion.AbrirConexion(true);

            if(continuar )
            {
                
                FORMS.Form_Menu form_menu = new FORMS.Form_Menu(conexion.ObtenerConexion());
                form_menu.Show();
                this.Hide();
            }
            
        }
    }
}
