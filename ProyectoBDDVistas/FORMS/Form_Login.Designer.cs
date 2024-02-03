namespace ProyectoBDDVistas
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            panel1 = new Panel();
            BLogin = new Button();
            TBUsername = new TextBox();
            TBPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BLogin);
            panel1.Controls.Add(TBUsername);
            panel1.Controls.Add(TBPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(94, 79);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 247);
            panel1.TabIndex = 7;
            // 
            // BLogin
            // 
            BLogin.BackColor = SystemColors.ButtonFace;
            BLogin.Image = (Image)resources.GetObject("BLogin.Image");
            BLogin.Location = new Point(157, 143);
            BLogin.Margin = new Padding(3, 4, 3, 4);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(190, 69);
            BLogin.TabIndex = 4;
            BLogin.UseVisualStyleBackColor = false;
            BLogin.Click += BLogin_Click;
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(198, 51);
            TBUsername.Margin = new Padding(3, 4, 3, 4);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(159, 27);
            TBUsername.TabIndex = 2;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(198, 99);
            TBPassword.Margin = new Padding(3, 4, 3, 4);
            TBPassword.Name = "TBPassword";
            TBPassword.PasswordChar = '*';
            TBPassword.Size = new Size(159, 27);
            TBPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 59);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 106);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 389);
            Controls.Add(panel1);
            Name = "Form_Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TBUsername;
        private Button BLogin;
        private TextBox TBPassword;
        private Label label1;
        private Label label2;
    }
}
