namespace Semana_13_DemoPatronProductorConsumidor
{
    partial class Form1
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
            panel1 = new Panel();
            btnRegistrar = new Button();
            txtCorreoElectronico = new TextBox();
            txtNombres = new TextBox();
            lblCorreo = new Label();
            lblNombres = new Label();
            btnSalir = new Button();
            panel2 = new Panel();
            btnProcesar = new Button();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            CorreoElectronico = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtCorreoElectronico);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblNombres);
            panel1.Location = new Point(6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(517, 173);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(192, 255, 255);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(413, 31);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 29);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(19, 124);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(366, 23);
            txtCorreoElectronico.TabIndex = 3;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(19, 37);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(366, 23);
            txtNombres.TabIndex = 2;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(19, 91);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(108, 15);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo Electronico:";
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(19, 19);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(59, 15);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 255, 255);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(413, 221);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnProcesar);
            panel2.Controls.Add(dgvUsuarios);
            panel2.Location = new Point(6, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(517, 264);
            panel2.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(192, 255, 255);
            btnProcesar.FlatStyle = FlatStyle.Flat;
            btnProcesar.Location = new Point(413, 37);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(82, 29);
            btnProcesar.TabIndex = 6;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, CorreoElectronico, Fecha });
            dgvUsuarios.Location = new Point(6, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.Size = new Size(379, 258);
            dgvUsuarios.TabIndex = 0;
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
            // CorreoElectronico
            // 
            CorreoElectronico.HeaderText = "Correo";
            CorreoElectronico.Name = "CorreoElectronico";
            CorreoElectronico.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(539, 472);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostración patron Productor - Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txtCorreoElectronico;
        private TextBox txtNombres;
        private Label lblCorreo;
        private Label lblNombres;
        private Button btnSalir;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn CorreoElectronico;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnProcesar;
    }
}
