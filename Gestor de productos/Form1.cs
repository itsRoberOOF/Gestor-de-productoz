using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using MySql.Data.MySqlClient;

namespace Gestor_de_productos
{
    public partial class FrmMenu : Form
    {
        void verificarConexion()
        {
            MySqlConnection retorno = ControllerConexion.ConnectController();
            if (retorno != null)
            {
                MessageBox.Show("Conexión establecida con exito",
                                "Conexión completada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al establecer conexión con el servidor, verifique su conexión a internet o consulte a su adminsitrador.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public FrmMenu()
        {
            InitializeComponent();
            verificarConexion();
        }


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa?",
                "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProveedores fmr = new FrmProveedores();
            fmr.Show();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpleados fmr = new FrmEmpleados();
            fmr.Show();
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProducto fmr = new FrmProducto();
            fmr.Show();
        }

        private void btnbodega_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBodega fmr = new FrmBodega();
            fmr.Show();
        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKardex fmr = new FrmKardex();
            fmr.Show();
        }
    }
}
