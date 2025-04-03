using pacientesCsharp.Utilidades;
using System.Windows.Forms;

namespace pacientesCsharp.Vistas
{
    partial class AltaPacientes
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
            this.Formulario = new System.Windows.Forms.GroupBox();
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.campoDIreccion = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 23);
            this.panel1.TabIndex = 3;
            // 
            // Formulario
            // 
            this.Formulario.BackColor = System.Drawing.Color.Transparent;
            this.Formulario.Controls.Add(this.comboCiudad);
            this.Formulario.Controls.Add(this.campoDIreccion);
            this.Formulario.Controls.Add(this.campoApellidos);
            this.Formulario.Controls.Add(this.label4);
            this.Formulario.Controls.Add(this.label3);
            this.Formulario.Controls.Add(this.botonRegistrar);
            this.Formulario.Controls.Add(this.campoNombre);
            this.Formulario.Controls.Add(this.label2);
            this.Formulario.Controls.Add(this.label1);
            this.Formulario.Location = new System.Drawing.Point(61, 43);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(452, 306);
            this.Formulario.TabIndex = 6;
            this.Formulario.TabStop = false;
            this.Formulario.Text = "REGISTRO PACIENTE";
            // 
            // comboCiudad
            // 
            this.comboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.Items.AddRange(new object[] {
            "Seleccione:"});
            this.comboCiudad.Location = new System.Drawing.Point(210, 216);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(104, 21);
            this.comboCiudad.TabIndex = 4;
            this.comboCiudad.Tag = "CIUDAD";
            // 
            // campoDIreccion
            // 
            this.campoDIreccion.Location = new System.Drawing.Point(210, 163);
            this.campoDIreccion.Name = "campoDIreccion";
            this.campoDIreccion.Size = new System.Drawing.Size(154, 20);
            this.campoDIreccion.TabIndex = 3;
            this.campoDIreccion.Tag = "DIRECCION";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(210, 117);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(124, 20);
            this.campoApellidos.TabIndex = 2;
            this.campoApellidos.Tag = "APELLIDOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CIUDAD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRECCION";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.SeaGreen;
            this.botonRegistrar.Location = new System.Drawing.Point(154, 270);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(160, 30);
            this.botonRegistrar.TabIndex = 5;
            this.botonRegistrar.Text = "Acceder";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(210, 67);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(104, 20);
            this.campoNombre.TabIndex = 1;
            this.campoNombre.Tag = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::pacientesCsharp.Properties.Resources.salud;
            this.pictureBox1.Location = new System.Drawing.Point(519, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AltaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.Formulario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AltaPacientes";
            this.Text = "AltaPacientes";
            this.Formulario.ResumeLayout(false);
            this.Formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Formulario;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoDIreccion;
        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonRegistrar;




        public void registrar ()

        {
            string nombre = campoNombre.Text;
            string apellidos = campoApellidos.Text;
            string direccion = campoDIreccion.Text;
            string ciudad = comboCiudad.Text;

            if (Validaciones.ValidaFormulario(Formulario))

            {
                MessageBox.Show("Registro exitoso");
                Validaciones.LimpiarFormulario(Formulario);
            }

        }

    }
}