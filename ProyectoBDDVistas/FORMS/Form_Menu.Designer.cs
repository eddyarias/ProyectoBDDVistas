namespace ProyectoBDDVistas.FORMS
{
    partial class Form_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            bttSalir = new Button();
            bttEmpleadoMenu = new Button();
            bttFacturacionMenu = new Button();
            bttReparacionMenu = new Button();
            bttVehiculoMenu = new Button();
            bttClienteMenu = new Button();
            label2 = new Label();
            label1 = new Label();
            bttNumeroTelefono = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(bttNumeroTelefono);
            panel2.Controls.Add(bttSalir);
            panel2.Controls.Add(bttEmpleadoMenu);
            panel2.Controls.Add(bttFacturacionMenu);
            panel2.Controls.Add(bttReparacionMenu);
            panel2.Controls.Add(bttVehiculoMenu);
            panel2.Controls.Add(bttClienteMenu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 1033);
            panel2.TabIndex = 27;
            // 
            // bttSalir
            // 
            bttSalir.Dock = DockStyle.Bottom;
            bttSalir.FlatAppearance.BorderSize = 0;
            bttSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            bttSalir.FlatStyle = FlatStyle.Flat;
            bttSalir.Font = new Font("Segoe UI", 14.25F);
            bttSalir.ForeColor = SystemColors.ControlLightLight;
            bttSalir.Location = new Point(0, 935);
            bttSalir.Margin = new Padding(3, 4, 3, 4);
            bttSalir.Name = "bttSalir";
            bttSalir.Size = new Size(229, 98);
            bttSalir.TabIndex = 22;
            bttSalir.Text = "Salir";
            bttSalir.UseVisualStyleBackColor = true;
            bttSalir.Click += button1_Click;
            // 
            // bttEmpleadoMenu
            // 
            bttEmpleadoMenu.Dock = DockStyle.Top;
            bttEmpleadoMenu.FlatAppearance.BorderSize = 0;
            bttEmpleadoMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            bttEmpleadoMenu.FlatStyle = FlatStyle.Flat;
            bttEmpleadoMenu.Font = new Font("Segoe UI", 14.25F);
            bttEmpleadoMenu.ForeColor = SystemColors.ControlLightLight;
            bttEmpleadoMenu.Location = new Point(0, 392);
            bttEmpleadoMenu.Margin = new Padding(3, 4, 3, 4);
            bttEmpleadoMenu.Name = "bttEmpleadoMenu";
            bttEmpleadoMenu.Size = new Size(229, 98);
            bttEmpleadoMenu.TabIndex = 17;
            bttEmpleadoMenu.Text = "Empleado";
            bttEmpleadoMenu.UseVisualStyleBackColor = true;
            bttEmpleadoMenu.Click += bttEmpleadoMenu_Click;
            // 
            // bttFacturacionMenu
            // 
            bttFacturacionMenu.Dock = DockStyle.Top;
            bttFacturacionMenu.FlatAppearance.BorderSize = 0;
            bttFacturacionMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            bttFacturacionMenu.FlatStyle = FlatStyle.Flat;
            bttFacturacionMenu.Font = new Font("Segoe UI", 14.25F);
            bttFacturacionMenu.ForeColor = SystemColors.Control;
            bttFacturacionMenu.Location = new Point(0, 294);
            bttFacturacionMenu.Margin = new Padding(3, 4, 3, 4);
            bttFacturacionMenu.Name = "bttFacturacionMenu";
            bttFacturacionMenu.Size = new Size(229, 98);
            bttFacturacionMenu.TabIndex = 18;
            bttFacturacionMenu.Text = "Facturacion";
            bttFacturacionMenu.UseVisualStyleBackColor = true;
            bttFacturacionMenu.Click += bttFacturacionMenu_Click;
            // 
            // bttReparacionMenu
            // 
            bttReparacionMenu.Dock = DockStyle.Top;
            bttReparacionMenu.FlatAppearance.BorderSize = 0;
            bttReparacionMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            bttReparacionMenu.FlatStyle = FlatStyle.Flat;
            bttReparacionMenu.Font = new Font("Segoe UI", 14.25F);
            bttReparacionMenu.ForeColor = SystemColors.Control;
            bttReparacionMenu.Location = new Point(0, 196);
            bttReparacionMenu.Margin = new Padding(3, 4, 3, 4);
            bttReparacionMenu.Name = "bttReparacionMenu";
            bttReparacionMenu.Size = new Size(229, 98);
            bttReparacionMenu.TabIndex = 20;
            bttReparacionMenu.Text = "Reparacion";
            bttReparacionMenu.UseVisualStyleBackColor = true;
            bttReparacionMenu.Click += bttReparacionMenu_Click;
            // 
            // bttVehiculoMenu
            // 
            bttVehiculoMenu.Dock = DockStyle.Top;
            bttVehiculoMenu.FlatAppearance.BorderSize = 0;
            bttVehiculoMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            bttVehiculoMenu.FlatStyle = FlatStyle.Flat;
            bttVehiculoMenu.Font = new Font("Segoe UI", 14.25F);
            bttVehiculoMenu.ForeColor = SystemColors.Control;
            bttVehiculoMenu.Location = new Point(0, 98);
            bttVehiculoMenu.Margin = new Padding(3, 4, 3, 4);
            bttVehiculoMenu.Name = "bttVehiculoMenu";
            bttVehiculoMenu.Size = new Size(229, 98);
            bttVehiculoMenu.TabIndex = 21;
            bttVehiculoMenu.Text = "Vehiculo";
            bttVehiculoMenu.UseVisualStyleBackColor = true;
            bttVehiculoMenu.Click += bttVehiculoMenu_Click;
            // 
            // bttClienteMenu
            // 
            bttClienteMenu.Dock = DockStyle.Top;
            bttClienteMenu.FlatAppearance.BorderSize = 0;
            bttClienteMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            bttClienteMenu.FlatStyle = FlatStyle.Flat;
            bttClienteMenu.Font = new Font("Segoe UI", 14.25F);
            bttClienteMenu.ForeColor = SystemColors.Control;
            bttClienteMenu.Location = new Point(0, 0);
            bttClienteMenu.Margin = new Padding(3, 4, 3, 4);
            bttClienteMenu.Name = "bttClienteMenu";
            bttClienteMenu.Size = new Size(229, 98);
            bttClienteMenu.TabIndex = 19;
            bttClienteMenu.Text = "Cliente";
            bttClienteMenu.UseVisualStyleBackColor = true;
            bttClienteMenu.Click += bttClienteMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 34.8F);
            label2.Location = new Point(154, 117);
            label2.Name = "label2";
            label2.Size = new Size(0, 67);
            label2.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(-128, 117);
            label1.Name = "label1";
            label1.Size = new Size(0, 39);
            label1.TabIndex = 24;
            // 
            // bttNumeroTelefono
            // 
            bttNumeroTelefono.Dock = DockStyle.Top;
            bttNumeroTelefono.FlatAppearance.BorderSize = 0;
            bttNumeroTelefono.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            bttNumeroTelefono.FlatStyle = FlatStyle.Flat;
            bttNumeroTelefono.Font = new Font("Segoe UI", 14.25F);
            bttNumeroTelefono.ForeColor = SystemColors.ControlLightLight;
            bttNumeroTelefono.Location = new Point(0, 490);
            bttNumeroTelefono.Margin = new Padding(3, 4, 3, 4);
            bttNumeroTelefono.Name = "bttNumeroTelefono";
            bttNumeroTelefono.Size = new Size(229, 98);
            bttNumeroTelefono.TabIndex = 23;
            bttNumeroTelefono.Text = "NumeroTelefono";
            bttNumeroTelefono.UseVisualStyleBackColor = true;
            bttNumeroTelefono.Click += bttNumeroTelefono_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 40, 60);
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Menu";
            Text = "Menú";
            Load += Form_Menu_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button bttEmpleadoMenu;
        private Button bttFacturacionMenu;
        private Button bttReparacionMenu;
        private Button bttVehiculoMenu;
        private Button bttClienteMenu;
        private Label label2;
        private Label label1;
        private Button bttSalir;
        private Button bttNumeroTelefono;
    }
}