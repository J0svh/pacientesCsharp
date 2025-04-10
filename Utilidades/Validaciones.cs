using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacientesCsharp.Utilidades

{
    class Validaciones
    {

        public static Boolean ValidaFormulario (GroupBox g)
        {
            foreach (Control c in g.Controls)
            {
                if (c is TextBox micampo && micampo.Text.Trim()=="")
                {
                        MessageBox.Show("El campo " + c.Tag + " es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return false;
                    
                } 
                if (c is ComboBox combobox && combobox.SelectedItem ==null)
                {
                    MessageBox.Show("Debe seleccionar " + c.Tag, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
                
            }
            return true;

        }

        public static void LimpiarFormulario (GroupBox g)
        {
            foreach (Control c in g.Controls)
            {
                if (c is TextBox micampo)
                {
                    micampo.Clear();
                }
                if (c is ComboBox combobox)
                {
                    combobox.SelectedItem = null;
                }
            }
        }
    }
}
