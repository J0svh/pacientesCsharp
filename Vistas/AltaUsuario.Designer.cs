namespace pacientesCsharp.Vistas
{
    partial class AltaUsuario
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
            this.Formulario = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.campoNombreCOmpleto = new System.Windows.Forms.TextBox();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 23);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::pacientesCsharp.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(519, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Formulario
            // 
            this.Formulario.BackColor = System.Drawing.Color.Transparent;
            this.Formulario.Controls.Add(this.label3);
            this.Formulario.Controls.Add(this.botonAcceder);
            this.Formulario.Controls.Add(this.campoPass);
            this.Formulario.Controls.Add(this.campoNombreCOmpleto);
            this.Formulario.Controls.Add(this.campoUsuario);
            this.Formulario.Controls.Add(this.label2);
            this.Formulario.Controls.Add(this.label1);
            this.Formulario.Location = new System.Drawing.Point(70, 54);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(452, 306);
            this.Formulario.TabIndex = 7;
            this.Formulario.TabStop = false;
            this.Formulario.Text = "REGISTRO USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOMBRE COMPLETO";
            // 
            // botonAcceder
            // 
            this.botonAcceder.BackColor = System.Drawing.Color.SeaGreen;
            this.botonAcceder.Location = new System.Drawing.Point(152, 242);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(160, 30);
            this.botonAcceder.TabIndex = 4;
            this.botonAcceder.Text = "Acceder";
            this.botonAcceder.UseVisualStyleBackColor = false;
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(239, 167);
            this.campoPass.Name = "campoPass";
            this.campoPass.PasswordChar = '*';
            this.campoPass.Size = new System.Drawing.Size(154, 20);
            this.campoPass.TabIndex = 3;
            this.campoPass.Tag = "Contraseña";
            this.campoPass.UseSystemPasswordChar = true;
            // 
            // campoNombreCOmpleto
            // 
            this.campoNombreCOmpleto.Location = new System.Drawing.Point(239, 44);
            this.campoNombreCOmpleto.Name = "campoNombreCOmpleto";
            this.campoNombreCOmpleto.Size = new System.Drawing.Size(192, 20);
            this.campoNombreCOmpleto.TabIndex = 1;
            this.campoNombreCOmpleto.Tag = "Nombre Completo";
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(239, 102);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(109, 20);
            this.campoUsuario.TabIndex = 2;
            this.campoUsuario.Tag = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Formulario;
        private System.Windows.Forms.Button botonAcceder;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoNombreCOmpleto;
    }
}