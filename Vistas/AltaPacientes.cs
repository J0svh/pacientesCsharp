using pacientesCsharp.bbdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacientesCsharp.Vistas
{
    public partial class AltaPacientes: Form
    {
        public AltaPacientes()
        {
            InitializeComponent();
            Conexion.CargarCOmboCIudades(comboCiudad);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            registrar();
        }
    }
}
