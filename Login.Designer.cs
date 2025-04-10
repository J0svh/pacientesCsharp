using pacientesCsharp.bbdd;
using pacientesCsharp.Vistas;
using System.Windows.Forms;

namespace pacientesCsharp
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Formulario = new System.Windows.Forms.GroupBox();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pacientesCsharp.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(433, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 23);
            this.panel1.TabIndex = 1;
            // 
            // Formulario
            // 
            this.Formulario.BackColor = System.Drawing.Color.Transparent;
            this.Formulario.Controls.Add(this.botonAcceder);
            this.Formulario.Controls.Add(this.campoPass);
            this.Formulario.Controls.Add(this.campoUsuario);
            this.Formulario.Controls.Add(this.label2);
            this.Formulario.Controls.Add(this.label1);
            this.Formulario.Location = new System.Drawing.Point(65, 57);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(397, 266);
            this.Formulario.TabIndex = 1;
            this.Formulario.TabStop = false;
            this.Formulario.Text = "LOGIN";
            // 
            // botonAcceder
            // 
            this.botonAcceder.BackColor = System.Drawing.Color.SeaGreen;
            this.botonAcceder.Location = new System.Drawing.Point(131, 230);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(160, 30);
            this.botonAcceder.TabIndex = 3;
            this.botonAcceder.Text = "Acceder";
            this.botonAcceder.UseVisualStyleBackColor = false;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(210, 152);
            this.campoPass.Name = "campoPass";
            this.campoPass.PasswordChar = '*';
            this.campoPass.Size = new System.Drawing.Size(154, 20);
            this.campoPass.TabIndex = 2;
            this.campoPass.UseSystemPasswordChar = true;
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(210, 67);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(154, 20);
            this.campoUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Formulario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonAcceder;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUsuario;

        public void acceder()
        {
            string usuarios;
            string pass;

            usuarios = campoUsuario.Text;
            pass = Utilidades.Encriptado.Encriptar(campoPass.Text);

            if (bbdd.Conexion.Acceder(usuarios, pass))
            {
                Principal p = new Principal();
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario Y contraseñas Erroneos");
                campoUsuario.Text = "";
                campoPass.Text = "";
            }
        }
    }
}

