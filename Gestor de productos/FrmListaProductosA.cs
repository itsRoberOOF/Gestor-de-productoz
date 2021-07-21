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

namespace Gestor_de_productos
{
    public partial class FrmListaProductosA : Form
    {
        public FrmListaProductosA()
        {
            InitializeComponent();
            dgvLProdus.DataSource = ControllerProductos.CargarProductosAgotados_Controller();
        }

        void BuscarProducto()
        {
            DataTable datos;
            datos = ControllerProductos.BuscarProducto_Controller(txtBuscar.Text);
            dgvLProdus.DataSource = datos;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvLProdus.DataSource = ControllerProductos.CargarProductosAgotados_Controller();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa?",
             "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmProducto volver = new FrmProducto();
            volver.Show();
            this.Hide();
        }
    }
}
