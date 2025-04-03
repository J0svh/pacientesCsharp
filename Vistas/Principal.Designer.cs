namespace pacientesCsharp.Vistas
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonPaciente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonTabla = new System.Windows.Forms.Button();
            this.botonUsuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 23);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pacientesCsharp.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(783, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // botonPaciente
            // 
            this.botonPaciente.BackColor = System.Drawing.Color.Transparent;
            this.botonPaciente.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonPaciente.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.botonPaciente.FlatAppearance.BorderSize = 3;
            this.botonPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPaciente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPaciente.ForeColor = System.Drawing.Color.SeaGreen;
            this.botonPaciente.Location = new System.Drawing.Point(0, 0);
            this.botonPaciente.Name = "botonPaciente";
            this.botonPaciente.Size = new System.Drawing.Size(179, 97);
            this.botonPaciente.TabIndex = 1;
            this.botonPaciente.Text = "Alta Nuevo Paciente";
            this.botonPaciente.UseVisualStyleBackColor = false;
            this.botonPaciente.Click += new System.EventHandler(this.botonPaciente_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonTabla);
            this.panel2.Controls.Add(this.botonUsuarios);
            this.panel2.Controls.Add(this.botonPaciente);
            this.panel2.Location = new System.Drawing.Point(49, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 97);
            this.panel2.TabIndex = 6;
            // 
            // botonTabla
            // 
            this.botonTabla.BackColor = System.Drawing.Color.Transparent;
            this.botonTabla.Dock = System.Windows.Forms.DockStyle.Right;
            this.botonTabla.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.botonTabla.FlatAppearance.BorderSize = 3;
            this.botonTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonTabla.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonTabla.ForeColor = System.Drawing.Color.SeaGreen;
            this.botonTabla.Location = new System.Drawing.Point(608, 0);
            this.botonTabla.Name = "botonTabla";
            this.botonTabla.Size = new System.Drawing.Size(179, 97);
            this.botonTabla.TabIndex = 3;
            this.botonTabla.Text = "Tabla pacientes";
            this.botonTabla.UseVisualStyleBackColor = false;
            this.botonTabla.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonUsuarios
            // 
            this.botonUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.botonUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.botonUsuarios.FlatAppearance.BorderSize = 3;
            this.botonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonUsuarios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonUsuarios.ForeColor = System.Drawing.Color.SeaGreen;
            this.botonUsuarios.Location = new System.Drawing.Point(304, 0);
            this.botonUsuarios.Name = "botonUsuarios";
            this.botonUsuarios.Size = new System.Drawing.Size(179, 97);
            this.botonUsuarios.TabIndex = 2;
            this.botonUsuarios.Text = "Registro de usuarios";
            this.botonUsuarios.UseVisualStyleBackColor = false;
            this.botonUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonPaciente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonTabla;
        private System.Windows.Forms.Button botonUsuarios;
    }
}