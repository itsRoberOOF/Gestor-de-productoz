using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_productos
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu fmr = new FrmMenu();
            fmr.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
