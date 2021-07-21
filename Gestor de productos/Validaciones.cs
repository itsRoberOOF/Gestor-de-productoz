using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_productos
{
    class Validaciones
    {
        public static void SoloNumeros(KeyPressEventArgs r)
        {
            if (char.IsNumber(r.KeyChar))
            {
                r.Handled = false;
            }
            else if (char.IsControl(r.KeyChar))
            {
                r.Handled = false;
            }
            else if (r.KeyChar == '.')
            {
                r.Handled = false;
            }
            else
            {
                r.Handled = true;
            }
        }
    }
}
