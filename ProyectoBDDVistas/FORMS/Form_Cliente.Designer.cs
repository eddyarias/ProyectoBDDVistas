namespace ProyectoBDDVistas.FORMS
{
    partial class Form_Cliente
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
            label1 = new Label();
            tabCRUDClientes = new TabControl();
            tabPage1 = new TabPage();
            BAgregar = new Button();
            label10 = new Label();
            label9 = new Label();
            txtBDirClienteRegistrar = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtBCedClienteRegistrar = new TextBox();
            txtBNomClienteRegistrar = new TextBox();
            txtBApeClienteRegistrar = new TextBox();
            tabPage2 = new TabPage();
            label5 = new Label();
            txtdirAct = new TextBox();
            txtcedAct = new TextBox();
            label8 = new Label();
            bttActClientes = new Button();
            txtapeAct = new TextBox();
            label6 = new Label();
            txtnomAct = new TextBox();
            label7 = new Label();
            tabPage7 = new TabPage();
            txtdirEli = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            bttEliClientes = new Button();
            txtnomEli = new TextBox();
            label15 = new Label();
            txtapeEli = new TextBox();
            txtcedEli = new TextBox();
            DGWClientes = new DataGridView();
            tabCRUDClientes.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGWClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1482, 40);
            label1.TabIndex = 0;
            label1.Text = "CLIENTES";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabCRUDClientes
            // 
            tabCRUDClientes.Controls.Add(tabPage1);
            tabCRUDClientes.Controls.Add(tabPage2);
            tabCRUDClientes.Controls.Add(tabPage7);
            tabCRUDClientes.Location = new Point(60, 100);
            tabCRUDClientes.Name = "tabCRUDClientes";
            tabCRUDClientes.SelectedIndex = 0;
            tabCRUDClientes.Size = new Size(455, 455);
            tabCRUDClientes.TabIndex = 86;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BAgregar);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtBDirClienteRegistrar);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtBCedClienteRegistrar);
            tabPage1.Controls.Add(txtBNomClienteRegistrar);
            tabPage1.Controls.Add(txtBApeClienteRegistrar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(447, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(172, 339);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(94, 37);
            BAgregar.TabIndex = 75;
            BAgregar.Text = "Registrar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 131);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 51;
            label10.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 163);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 52;
            label9.Text = "Apellido:";
            // 
            // txtBDirClienteRegistrar
            // 
            txtBDirClienteRegistrar.Location = new Point(119, 199);
            txtBDirClienteRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBDirClienteRegistrar.Name = "txtBDirClienteRegistrar";
            txtBDirClienteRegistrar.Size = new Size(257, 27);
            txtBDirClienteRegistrar.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 102);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 53;
            label4.Text = "Cedula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 199);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 68;
            label2.Text = "Dirección:";
            // 
            // txtBCedClienteRegistrar
            // 
            txtBCedClienteRegistrar.Location = new Point(119, 95);
            txtBCedClienteRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBCedClienteRegistrar.Name = "txtBCedClienteRegistrar";
            txtBCedClienteRegistrar.Size = new Size(257, 27);
            txtBCedClienteRegistrar.TabIndex = 55;
            // 
            // txtBNomClienteRegistrar
            // 
            txtBNomClienteRegistrar.Location = new Point(119, 128);
            txtBNomClienteRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBNomClienteRegistrar.Name = "txtBNomClienteRegistrar";
            txtBNomClienteRegistrar.Size = new Size(257, 27);
            txtBNomClienteRegistrar.TabIndex = 56;
            // 
            // txtBApeClienteRegistrar
            // 
            txtBApeClienteRegistrar.Location = new Point(119, 163);
            txtBApeClienteRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBApeClienteRegistrar.Name = "txtBApeClienteRegistrar";
            txtBApeClienteRegistrar.Size = new Size(257, 27);
            txtBApeClienteRegistrar.TabIndex = 63;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtdirAct);
            tabPage2.Controls.Add(txtcedAct);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(bttActClientes);
            tabPage2.Controls.Add(txtapeAct);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txtnomAct);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(447, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Actualizar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 103);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 87;
            label5.Text = "Cedula:";
            // 
            // txtdirAct
            // 
            txtdirAct.Location = new Point(129, 213);
            txtdirAct.Margin = new Padding(3, 4, 3, 4);
            txtdirAct.Multiline = true;
            txtdirAct.Name = "txtdirAct";
            txtdirAct.Size = new Size(285, 29);
            txtdirAct.TabIndex = 94;
            // 
            // txtcedAct
            // 
            txtcedAct.Location = new Point(129, 94);
            txtcedAct.Margin = new Padding(3, 4, 3, 4);
            txtcedAct.Multiline = true;
            txtcedAct.Name = "txtcedAct";
            txtcedAct.Size = new Size(285, 29);
            txtcedAct.TabIndex = 88;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 216);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 91;
            label8.Text = "Dirección:";
            // 
            // bttActClientes
            // 
            bttActClientes.Location = new Point(169, 292);
            bttActClientes.Margin = new Padding(3, 4, 3, 4);
            bttActClientes.Name = "bttActClientes";
            bttActClientes.Size = new Size(114, 37);
            bttActClientes.TabIndex = 95;
            bttActClientes.Text = "Actualizar";
            bttActClientes.UseVisualStyleBackColor = true;
            bttActClientes.Click += button1_Click;
            // 
            // txtapeAct
            // 
            txtapeAct.Location = new Point(129, 173);
            txtapeAct.Margin = new Padding(3, 4, 3, 4);
            txtapeAct.Multiline = true;
            txtapeAct.Name = "txtapeAct";
            txtapeAct.ReadOnly = true;
            txtapeAct.Size = new Size(285, 29);
            txtapeAct.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 136);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 89;
            label6.Text = "Nombres:";
            // 
            // txtnomAct
            // 
            txtnomAct.Location = new Point(129, 133);
            txtnomAct.Margin = new Padding(3, 4, 3, 4);
            txtnomAct.Multiline = true;
            txtnomAct.Name = "txtnomAct";
            txtnomAct.ReadOnly = true;
            txtnomAct.Size = new Size(285, 29);
            txtnomAct.TabIndex = 92;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 176);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 90;
            label7.Text = "Apellidos:";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(txtdirEli);
            tabPage7.Controls.Add(label14);
            tabPage7.Controls.Add(label12);
            tabPage7.Controls.Add(label13);
            tabPage7.Controls.Add(bttEliClientes);
            tabPage7.Controls.Add(txtnomEli);
            tabPage7.Controls.Add(label15);
            tabPage7.Controls.Add(txtapeEli);
            tabPage7.Controls.Add(txtcedEli);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(447, 422);
            tabPage7.TabIndex = 3;
            tabPage7.Text = "Eliminar";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // txtdirEli
            // 
            txtdirEli.Location = new Point(133, 199);
            txtdirEli.Margin = new Padding(3, 4, 3, 4);
            txtdirEli.Multiline = true;
            txtdirEli.Name = "txtdirEli";
            txtdirEli.ReadOnly = true;
            txtdirEli.Size = new Size(285, 29);
            txtdirEli.TabIndex = 96;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 208);
            label14.Name = "label14";
            label14.Size = new Size(75, 20);
            label14.TabIndex = 95;
            label14.Text = "Dirección:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(45, 79);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 90;
            label12.Text = "Nombres:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 119);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 91;
            label13.Text = "Apellidos:";
            // 
            // bttEliClientes
            // 
            bttEliClientes.Location = new Point(178, 283);
            bttEliClientes.Margin = new Padding(3, 4, 3, 4);
            bttEliClientes.Name = "bttEliClientes";
            bttEliClientes.Size = new Size(114, 40);
            bttEliClientes.TabIndex = 87;
            bttEliClientes.Text = "Eliminar";
            bttEliClientes.UseVisualStyleBackColor = true;
            bttEliClientes.Click += bttEliClientes_Click;
            // 
            // txtnomEli
            // 
            txtnomEli.Location = new Point(133, 74);
            txtnomEli.Margin = new Padding(3, 4, 3, 4);
            txtnomEli.Multiline = true;
            txtnomEli.Name = "txtnomEli";
            txtnomEli.ReadOnly = true;
            txtnomEli.Size = new Size(285, 29);
            txtnomEli.TabIndex = 92;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(87, 165);
            label15.Name = "label15";
            label15.Size = new Size(25, 20);
            label15.TabIndex = 88;
            label15.Text = "CI:";
            // 
            // txtapeEli
            // 
            txtapeEli.Location = new Point(133, 114);
            txtapeEli.Margin = new Padding(3, 4, 3, 4);
            txtapeEli.Multiline = true;
            txtapeEli.Name = "txtapeEli";
            txtapeEli.ReadOnly = true;
            txtapeEli.Size = new Size(285, 29);
            txtapeEli.TabIndex = 93;
            // 
            // txtcedEli
            // 
            txtcedEli.Location = new Point(133, 154);
            txtcedEli.Margin = new Padding(3, 4, 3, 4);
            txtcedEli.Multiline = true;
            txtcedEli.Name = "txtcedEli";
            txtcedEli.ReadOnly = true;
            txtcedEli.Size = new Size(285, 29);
            txtcedEli.TabIndex = 94;
            // 
            // DGWClientes
            // 
            DGWClientes.AllowUserToAddRows = false;
            DGWClientes.AllowUserToDeleteRows = false;
            DGWClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWClientes.Location = new Point(618, 126);
            DGWClientes.Name = "DGWClientes";
            DGWClientes.ReadOnly = true;
            DGWClientes.RowHeadersWidth = 51;
            DGWClientes.Size = new Size(554, 426);
            DGWClientes.TabIndex = 87;
            DGWClientes.CellClick += DGWClientes_CellClick;
            DGWClientes.DataBindingComplete += DGWClientes_DataBindingComplete;
            // 
            // Form_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            ControlBox = false;
            Controls.Add(DGWClientes);
            Controls.Add(tabCRUDClientes);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Cliente";
            Text = "Form_Cliente";
            Load += Form_Cliente_Load;
            tabCRUDClientes.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGWClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tabCRUDClientes;
        private TabPage tabPage1;
        private Button BAgregar;
        private Label label10;
        private Label label9;
        private TextBox txtBDirClienteRegistrar;
        private Label label4;
        private Label label2;
        private TextBox txtBCedClienteRegistrar;
        private TextBox txtBNomClienteRegistrar;
        private TextBox txtBApeClienteRegistrar;
        private TabPage tabPage2;
        private TabPage tabPage7;
        private Label label5;
        private TextBox txtdirAct;
        private TextBox txtcedAct;
        private Label label8;
        private Button bttActClientes;
        private TextBox txtapeAct;
        private Label label6;
        private TextBox txtnomAct;
        private Label label7;
        private Label label12;
        private Label label13;
        private Button bttEliClientes;
        private TextBox txtnomEli;
        private Label label15;
        private TextBox txtapeEli;
        private TextBox txtcedEli;
        private DataGridView DGWClientes;
        private TextBox txtdirEli;
        private Label label14;
    }
}