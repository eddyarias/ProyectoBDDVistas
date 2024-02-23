namespace ProyectoBDDVistas.FORMS
{
    partial class Form_NumeroTelefono
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
            DGWFNumeroTelefono = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGWFNumeroTelefono).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1482, 40);
            label1.TabIndex = 1;
            label1.Text = "NUMERO TELEFONO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // DGWFNumeroTelefono
            // 
            DGWFNumeroTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGWFNumeroTelefono.BackgroundColor = Color.White;
            DGWFNumeroTelefono.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWFNumeroTelefono.Location = new Point(918, 140);
            DGWFNumeroTelefono.Margin = new Padding(3, 4, 3, 4);
            DGWFNumeroTelefono.Name = "DGWFNumeroTelefono";
            DGWFNumeroTelefono.RowHeadersWidth = 51;
            DGWFNumeroTelefono.RowTemplate.Height = 24;
            DGWFNumeroTelefono.Size = new Size(265, 244);
            DGWFNumeroTelefono.TabIndex = 85;
            DGWFNumeroTelefono.DataBindingComplete += DGWFNumeroTelefono_DataBindingComplete;
            // 
            // Form_NumeroTelefono
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            Controls.Add(DGWFNumeroTelefono);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_NumeroTelefono";
            Text = "Form_NumeroTelefono";
            ((System.ComponentModel.ISupportInitialize)DGWFNumeroTelefono).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView DGWFNumeroTelefono;
    }
}