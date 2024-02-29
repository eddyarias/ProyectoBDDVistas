namespace ProyectoBDDVistas.FORMS
{
    partial class Form_Empleado
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
            label3 = new Label();
            panel1 = new Panel();
            BBuscar = new Button();
            label24 = new Label();
            label23 = new Label();
            comboBox3 = new ComboBox();
            textBox20 = new TextBox();
            DGWEmpleado = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtBidEmpleadoRegistrar = new TextBox();
            label9 = new Label();
            txtBapeEmpleadoRegistrar = new TextBox();
            txtBsalEmpleadoRegistrar = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtBfecEmpleadoRegistrar = new TextBox();
            label25 = new Label();
            txtBnomEmpleadoRegistrar = new TextBox();
            txtBcedEmpleadoRegistrar = new TextBox();
            BAgregar = new Button();
            tabPage2 = new TabPage();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBidEmpleadoAct = new TextBox();
            label8 = new Label();
            txtBapeEmpleadoAct = new TextBox();
            txtBsalEmpleadoAct = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtBfecEmpleadoAct = new TextBox();
            label27 = new Label();
            txtBnomEmpleadoAct = new TextBox();
            txtBcedEmpleadoAct = new TextBox();
            button1 = new Button();
            label21 = new Label();
            label22 = new Label();
            tabPage7 = new TabPage();
            label14 = new Label();
            button2 = new Button();
            label15 = new Label();
            label16 = new Label();
            txtBcedEmpleadoEli = new TextBox();
            txtBidEmpleadoEli = new TextBox();
            txtBnomEmpleadoEli = new TextBox();
            label17 = new Label();
            label20 = new Label();
            txtBapeEmpleadoEli = new TextBox();
            txtBfecEmpleadoEli = new TextBox();
            txtBsalEmpleadoEli = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label26 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGWEmpleado).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(677, 110);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 86;
            label3.Text = "Consulta";
            // 
            // panel1
            // 
            panel1.Controls.Add(BBuscar);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(textBox20);
            panel1.Location = new Point(706, 134);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 148);
            panel1.TabIndex = 87;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(118, 89);
            BBuscar.Margin = new Padding(3, 4, 3, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(131, 37);
            BBuscar.TabIndex = 77;
            BBuscar.Text = "Consultar";
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(65, 37);
            label24.Name = "label24";
            label24.Size = new Size(0, 20);
            label24.TabIndex = 81;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(94, 24);
            label23.Name = "label23";
            label23.Size = new Size(0, 20);
            label23.TabIndex = 78;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Nombre", "Apellido", "Salario", "Fecha inicio contrato", "cedula", "id_empleado" });
            comboBox3.Location = new Point(22, 31);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(172, 28);
            comboBox3.TabIndex = 80;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(201, 32);
            textBox20.Margin = new Padding(3, 4, 3, 4);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(162, 27);
            textBox20.TabIndex = 79;
            // 
            // DGWEmpleado
            // 
            DGWEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGWEmpleado.BackgroundColor = Color.White;
            DGWEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWEmpleado.Location = new Point(89, 490);
            DGWEmpleado.Margin = new Padding(3, 4, 3, 4);
            DGWEmpleado.Name = "DGWEmpleado";
            DGWEmpleado.RowHeadersWidth = 51;
            DGWEmpleado.RowTemplate.Height = 24;
            DGWEmpleado.Size = new Size(1181, 244);
            DGWEmpleado.TabIndex = 83;
            DGWEmpleado.CellClick += DGWEmpleado_CellClick;
            DGWEmpleado.DataBindingComplete += DGWEmpleado_DataBindingComplete;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Location = new Point(44, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(549, 374);
            tabControl1.TabIndex = 85;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtBidEmpleadoRegistrar);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(txtBapeEmpleadoRegistrar);
            tabPage1.Controls.Add(txtBsalEmpleadoRegistrar);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(txtBfecEmpleadoRegistrar);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(txtBnomEmpleadoRegistrar);
            tabPage1.Controls.Add(txtBcedEmpleadoRegistrar);
            tabPage1.Controls.Add(BAgregar);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(541, 341);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registrar empleado";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 252);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 95;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 50);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 96;
            label2.Text = "id_empleado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 120);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 97;
            label4.Text = "Nombre:";
            // 
            // txtBidEmpleadoRegistrar
            // 
            txtBidEmpleadoRegistrar.Location = new Point(197, 47);
            txtBidEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBidEmpleadoRegistrar.Name = "txtBidEmpleadoRegistrar";
            txtBidEmpleadoRegistrar.Size = new Size(255, 27);
            txtBidEmpleadoRegistrar.TabIndex = 100;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(118, 154);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 98;
            label9.Text = "Apellido:";
            // 
            // txtBapeEmpleadoRegistrar
            // 
            txtBapeEmpleadoRegistrar.Location = new Point(197, 151);
            txtBapeEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBapeEmpleadoRegistrar.Name = "txtBapeEmpleadoRegistrar";
            txtBapeEmpleadoRegistrar.Size = new Size(255, 27);
            txtBapeEmpleadoRegistrar.TabIndex = 104;
            // 
            // txtBsalEmpleadoRegistrar
            // 
            txtBsalEmpleadoRegistrar.Location = new Point(197, 187);
            txtBsalEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBsalEmpleadoRegistrar.Name = "txtBsalEmpleadoRegistrar";
            txtBsalEmpleadoRegistrar.Size = new Size(255, 27);
            txtBsalEmpleadoRegistrar.TabIndex = 107;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 229);
            label10.Name = "label10";
            label10.Size = new Size(150, 20);
            label10.TabIndex = 103;
            label10.Text = "Fecha inicio contrato:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(133, 86);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 99;
            label11.Text = "Cedula:";
            // 
            // txtBfecEmpleadoRegistrar
            // 
            txtBfecEmpleadoRegistrar.Location = new Point(197, 226);
            txtBfecEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBfecEmpleadoRegistrar.Name = "txtBfecEmpleadoRegistrar";
            txtBfecEmpleadoRegistrar.Size = new Size(255, 27);
            txtBfecEmpleadoRegistrar.TabIndex = 105;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(133, 190);
            label25.Name = "label25";
            label25.Size = new Size(58, 20);
            label25.TabIndex = 106;
            label25.Text = "Salario:";
            // 
            // txtBnomEmpleadoRegistrar
            // 
            txtBnomEmpleadoRegistrar.Location = new Point(197, 117);
            txtBnomEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBnomEmpleadoRegistrar.Name = "txtBnomEmpleadoRegistrar";
            txtBnomEmpleadoRegistrar.Size = new Size(255, 27);
            txtBnomEmpleadoRegistrar.TabIndex = 102;
            // 
            // txtBcedEmpleadoRegistrar
            // 
            txtBcedEmpleadoRegistrar.Location = new Point(197, 83);
            txtBcedEmpleadoRegistrar.Margin = new Padding(3, 4, 3, 4);
            txtBcedEmpleadoRegistrar.Name = "txtBcedEmpleadoRegistrar";
            txtBcedEmpleadoRegistrar.Size = new Size(255, 27);
            txtBcedEmpleadoRegistrar.TabIndex = 101;
            // 
            // BAgregar
            // 
            BAgregar.Location = new Point(197, 277);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(94, 37);
            BAgregar.TabIndex = 75;
            BAgregar.Text = "Registrar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtBidEmpleadoAct);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtBapeEmpleadoAct);
            tabPage2.Controls.Add(txtBsalEmpleadoAct);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txtBfecEmpleadoAct);
            tabPage2.Controls.Add(label27);
            tabPage2.Controls.Add(txtBnomEmpleadoAct);
            tabPage2.Controls.Add(txtBcedEmpleadoAct);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label22);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(541, 341);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Actualizar empleado";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 263);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 108;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 56);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 109;
            label6.Text = "id_empleado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 126);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 110;
            label7.Text = "Nombre:";
            // 
            // txtBidEmpleadoAct
            // 
            txtBidEmpleadoAct.Location = new Point(184, 53);
            txtBidEmpleadoAct.Margin = new Padding(3, 4, 3, 4);
            txtBidEmpleadoAct.Name = "txtBidEmpleadoAct";
            txtBidEmpleadoAct.ReadOnly = true;
            txtBidEmpleadoAct.Size = new Size(255, 27);
            txtBidEmpleadoAct.TabIndex = 113;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 160);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 111;
            label8.Text = "Apellido:";
            // 
            // txtBapeEmpleadoAct
            // 
            txtBapeEmpleadoAct.Location = new Point(184, 157);
            txtBapeEmpleadoAct.Margin = new Padding(3, 4, 3, 4);
            txtBapeEmpleadoAct.Name = "txtBapeEmpleadoAct";
            txtBapeEmpleadoAct.Size = new Size(255, 27);
            txtBapeEmpleadoAct.TabIndex = 117;
            // 
            // txtBsalEmpleadoAct
            // 
            txtBsalEmpleadoAct.Location = new Point(184, 193);
            txtBsalEmpleadoAct.Margin = new Padding(3, 4, 3, 4);
            txtBsalEmpleadoAct.Name = "txtBsalEmpleadoAct";
            txtBsalEmpleadoAct.Size = new Size(255, 27);
            txtBsalEmpleadoAct.TabIndex = 120;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(28, 235);
            label12.Name = "label12";
            label12.Size = new Size(150, 20);
            label12.TabIndex = 116;
            label12.Text = "Fecha inicio contrato:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(120, 92);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 112;
            label13.Text = "Cedula:";
            // 
            // txtBfecEmpleadoAct
            // 
            txtBfecEmpleadoAct.Location = new Point(184, 232);
            txtBfecEmpleadoAct.Margin = new Padding(3, 4, 3, 4);
            txtBfecEmpleadoAct.Name = "txtBfecEmpleadoAct";
            txtBfecEmpleadoAct.Size = new Size(255, 27);
            txtBfecEmpleadoAct.TabIndex = 118;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(120, 196);
            label27.Name = "label27";
            label27.Size = new Size(58, 20);
            label27.TabIndex = 119;
            label27.Text = "Salario:";
            // 
            // txtBnomEmpleadoAct
            // 
            txtBnomEmpleadoAct.Location = new Point(184, 123);
            txtBnomEmpleadoAct.Margin = new Padding(3, 4, 3, 4);
            txtBnomEmpleadoAct.Name = "txtBnomEmpleadoAct";
            txtBnomEmpleadoAct.Size = new Size(255, 27);
            txtBnomEmpleadoAct.TabIndex = 115;
            // 
            // txtBcedEmpleadoAct
            // 
            txtBcedEmpleadoAct.Location = new Point(184, 89);
            txtBcedEmpleadoAct.Margin = new Padding(3, 4, 3, 4);
            txtBcedEmpleadoAct.Name = "txtBcedEmpleadoAct";
            txtBcedEmpleadoAct.Size = new Size(255, 27);
            txtBcedEmpleadoAct.TabIndex = 114;
            // 
            // button1
            // 
            button1.Location = new Point(211, 286);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 95;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(189, 266);
            label21.Name = "label21";
            label21.Size = new Size(0, 20);
            label21.TabIndex = 64;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(184, 274);
            label22.Name = "label22";
            label22.Size = new Size(0, 20);
            label22.TabIndex = 63;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(label14);
            tabPage7.Controls.Add(button2);
            tabPage7.Controls.Add(label15);
            tabPage7.Controls.Add(label16);
            tabPage7.Controls.Add(txtBcedEmpleadoEli);
            tabPage7.Controls.Add(txtBidEmpleadoEli);
            tabPage7.Controls.Add(txtBnomEmpleadoEli);
            tabPage7.Controls.Add(label17);
            tabPage7.Controls.Add(label20);
            tabPage7.Controls.Add(txtBapeEmpleadoEli);
            tabPage7.Controls.Add(txtBfecEmpleadoEli);
            tabPage7.Controls.Add(txtBsalEmpleadoEli);
            tabPage7.Controls.Add(label19);
            tabPage7.Controls.Add(label18);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(541, 341);
            tabPage7.TabIndex = 3;
            tabPage7.Text = "Eliminar empleado";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(189, 252);
            label14.Name = "label14";
            label14.Size = new Size(0, 20);
            label14.TabIndex = 108;
            // 
            // button2
            // 
            button2.Location = new Point(203, 275);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 110;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(81, 50);
            label15.Name = "label15";
            label15.Size = new Size(99, 20);
            label15.TabIndex = 109;
            label15.Text = "id_empleado:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(113, 120);
            label16.Name = "label16";
            label16.Size = new Size(67, 20);
            label16.TabIndex = 110;
            label16.Text = "Nombre:";
            // 
            // txtBcedEmpleadoEli
            // 
            txtBcedEmpleadoEli.Location = new Point(186, 83);
            txtBcedEmpleadoEli.Margin = new Padding(3, 4, 3, 4);
            txtBcedEmpleadoEli.Name = "txtBcedEmpleadoEli";
            txtBcedEmpleadoEli.ReadOnly = true;
            txtBcedEmpleadoEli.Size = new Size(255, 27);
            txtBcedEmpleadoEli.TabIndex = 114;
            // 
            // txtBidEmpleadoEli
            // 
            txtBidEmpleadoEli.Location = new Point(186, 47);
            txtBidEmpleadoEli.Margin = new Padding(3, 4, 3, 4);
            txtBidEmpleadoEli.Name = "txtBidEmpleadoEli";
            txtBidEmpleadoEli.ReadOnly = true;
            txtBidEmpleadoEli.Size = new Size(255, 27);
            txtBidEmpleadoEli.TabIndex = 113;
            // 
            // txtBnomEmpleadoEli
            // 
            txtBnomEmpleadoEli.Location = new Point(186, 117);
            txtBnomEmpleadoEli.Margin = new Padding(3, 4, 3, 4);
            txtBnomEmpleadoEli.Name = "txtBnomEmpleadoEli";
            txtBnomEmpleadoEli.ReadOnly = true;
            txtBnomEmpleadoEli.Size = new Size(255, 27);
            txtBnomEmpleadoEli.TabIndex = 115;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(107, 154);
            label17.Name = "label17";
            label17.Size = new Size(69, 20);
            label17.TabIndex = 111;
            label17.Text = "Apellido:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(122, 190);
            label20.Name = "label20";
            label20.Size = new Size(58, 20);
            label20.TabIndex = 119;
            label20.Text = "Salario:";
            // 
            // txtBapeEmpleadoEli
            // 
            txtBapeEmpleadoEli.Location = new Point(186, 151);
            txtBapeEmpleadoEli.Margin = new Padding(3, 4, 3, 4);
            txtBapeEmpleadoEli.Name = "txtBapeEmpleadoEli";
            txtBapeEmpleadoEli.ReadOnly = true;
            txtBapeEmpleadoEli.Size = new Size(255, 27);
            txtBapeEmpleadoEli.TabIndex = 117;
            // 
            // txtBfecEmpleadoEli
            // 
            txtBfecEmpleadoEli.Location = new Point(186, 226);
            txtBfecEmpleadoEli.Margin = new Padding(3, 4, 3, 4);
            txtBfecEmpleadoEli.Name = "txtBfecEmpleadoEli";
            txtBfecEmpleadoEli.ReadOnly = true;
            txtBfecEmpleadoEli.Size = new Size(255, 27);
            txtBfecEmpleadoEli.TabIndex = 118;
            // 
            // txtBsalEmpleadoEli
            // 
            txtBsalEmpleadoEli.Location = new Point(186, 187);
            txtBsalEmpleadoEli.Margin = new Padding(3, 4, 3, 4);
            txtBsalEmpleadoEli.Name = "txtBsalEmpleadoEli";
            txtBsalEmpleadoEli.ReadOnly = true;
            txtBsalEmpleadoEli.Size = new Size(255, 27);
            txtBsalEmpleadoEli.TabIndex = 120;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(122, 86);
            label19.Name = "label19";
            label19.Size = new Size(58, 20);
            label19.TabIndex = 112;
            label19.Text = "Cedula:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(30, 229);
            label18.Name = "label18";
            label18.Size = new Size(150, 20);
            label18.TabIndex = 116;
            label18.Text = "Fecha inicio contrato:";
            // 
            // label26
            // 
            label26.Dock = DockStyle.Top;
            label26.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(0, 0);
            label26.Name = "label26";
            label26.Size = new Size(1482, 40);
            label26.TabIndex = 88;
            label26.Text = "EMPLEADO";
            label26.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form_Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            ControlBox = false;
            Controls.Add(label26);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(DGWEmpleado);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Empleado";
            Text = "FormEmpleado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGWEmpleado).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Panel panel1;
        private Button BBuscar;
        private Label label24;
        private Label label23;
        private ComboBox comboBox3;
        private TextBox textBox20;
        private DataGridView DGWEmpleado;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button BAgregar;
        private TabPage tabPage2;
        private Button button1;
        private Label label21;
        private Label label22;
        private TabPage tabPage7;
        private Button button2;
        private Label label26;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtBidEmpleadoRegistrar;
        private Label label9;
        private TextBox txtBapeEmpleadoRegistrar;
        private TextBox txtBsalEmpleadoRegistrar;
        private Label label10;
        private Label label11;
        private TextBox txtBfecEmpleadoRegistrar;
        private Label label25;
        private TextBox txtBnomEmpleadoRegistrar;
        private TextBox txtBcedEmpleadoRegistrar;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBidEmpleadoAct;
        private Label label8;
        private TextBox txtBapeEmpleadoAct;
        private TextBox txtBsalEmpleadoAct;
        private Label label12;
        private Label label13;
        private TextBox txtBfecEmpleadoAct;
        private Label label27;
        private TextBox txtBnomEmpleadoAct;
        private TextBox txtBcedEmpleadoAct;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtBcedEmpleadoEli;
        private TextBox txtBidEmpleadoEli;
        private TextBox txtBnomEmpleadoEli;
        private Label label17;
        private Label label20;
        private TextBox txtBapeEmpleadoEli;
        private TextBox txtBfecEmpleadoEli;
        private TextBox txtBsalEmpleadoEli;
        private Label label19;
        private Label label18;
    }
}