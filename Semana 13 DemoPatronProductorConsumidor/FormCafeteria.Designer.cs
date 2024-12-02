namespace Semana_13_DemoPatronProductorConsumidor
{
    partial class FormCafeteria
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
            dgvBarra = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            HoraPreparacion = new DataGridViewTextBoxColumn();
            btnRecoger = new Button();
            panel1 = new Panel();
            btnPreparar = new Button();
            txtProducto = new TextBox();
            lblNombres = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBarra).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBarra);
            panel2.Location = new Point(12, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 264);
            panel2.TabIndex = 3;
            // 
            // dgvBarra
            // 
            dgvBarra.AllowUserToAddRows = false;
            dgvBarra.AllowUserToDeleteRows = false;
            dgvBarra.BackgroundColor = Color.White;
            dgvBarra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarra.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, HoraPreparacion });
            dgvBarra.Location = new Point(6, 3);
            dgvBarra.Name = "dgvBarra";
            dgvBarra.ReadOnly = true;
            dgvBarra.Size = new Size(280, 258);
            dgvBarra.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // HoraPreparacion
            // 
            HoraPreparacion.HeaderText = "Hora Preparacion";
            HoraPreparacion.Name = "HoraPreparacion";
            HoraPreparacion.ReadOnly = true;
            // 
            // btnRecoger
            // 
            btnRecoger.BackColor = Color.FromArgb(192, 255, 255);
            btnRecoger.FlatStyle = FlatStyle.Flat;
            btnRecoger.Location = new Point(160, 98);
            btnRecoger.Name = "btnRecoger";
            btnRecoger.Size = new Size(82, 29);
            btnRecoger.TabIndex = 6;
            btnRecoger.Text = "Recoger";
            btnRecoger.UseVisualStyleBackColor = false;
            btnRecoger.Click += btnRecoger_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPreparar);
            panel1.Controls.Add(btnRecoger);
            panel1.Controls.Add(txtProducto);
            panel1.Controls.Add(lblNombres);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 145);
            panel1.TabIndex = 2;
            // 
            // btnPreparar
            // 
            btnPreparar.BackColor = Color.FromArgb(192, 255, 255);
            btnPreparar.FlatStyle = FlatStyle.Flat;
            btnPreparar.Location = new Point(38, 98);
            btnPreparar.Name = "btnPreparar";
            btnPreparar.Size = new Size(82, 29);
            btnPreparar.TabIndex = 4;
            btnPreparar.Text = "Preparar";
            btnPreparar.UseVisualStyleBackColor = false;
            btnPreparar.Click += btnPreparar_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(19, 37);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(267, 23);
            txtProducto.TabIndex = 2;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(19, 19);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(59, 15);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Producto:";
            // 
            // FormCafeteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 469);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCafeteria";
            Text = "FormCafeteria";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBarra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnRecoger;
        private DataGridView dgvBarra;
        private Panel panel1;
        private Button btnPreparar;
        private TextBox txtProducto;
        private Label lblNombres;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn HoraPreparacion;
    }
}