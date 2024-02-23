namespace ProyectoBDDVistas.FORMS
{
    partial class Form_Factura
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
            DGWFacturas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGWFacturas).BeginInit();
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
            label1.Text = "FACTURA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // DGWFacturas
            // 
            DGWFacturas.BackgroundColor = Color.White;
            DGWFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGWFacturas.Location = new Point(26, 153);
            DGWFacturas.Margin = new Padding(3, 4, 3, 4);
            DGWFacturas.Name = "DGWFacturas";
            DGWFacturas.RowHeadersWidth = 51;
            DGWFacturas.RowTemplate.Height = 24;
            DGWFacturas.Size = new Size(410, 313);
            DGWFacturas.TabIndex = 44;
            DGWFacturas.DataBindingComplete += DGWFacturas_DataBindingComplete;
            // 
            // Form_Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            Controls.Add(DGWFacturas);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Factura";
            Text = "Form_Factura";
            ((System.ComponentModel.ISupportInitialize)DGWFacturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView DGWFactura;
        private DataGridView DGWFacturas;
    }
}