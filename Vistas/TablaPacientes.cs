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
    public partial class TablaPacientes: Form
    {
        public TablaPacientes()
        {
            InitializeComponent();
            tabla.DataSource = Conexion.CargarPacientes();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
