using pacientesCsharp.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacientesCsharp
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            acceder();
        }
    }
}
