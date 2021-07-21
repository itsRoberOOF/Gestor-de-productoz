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
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos(DataTable data)
        {
            InitializeComponent();
            dgvLProdus.DataSource = data;
        }

        void BuscarProducto()
        {
            DataTable datos;
            datos = ControllerProductos.BuscarProducto_Controller(txtBuscar.Text);
            dgvLProdus.DataSource= datos;
        }

        private void BtnCargarProducto_Click(object sender, EventArgs e)
        {
            dgvLProdus.DataSource = ControllerProductos.CargarProductos_Controller();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmProducto volver = new FrmProducto();
            volver.Show();
            this.Hide();
        } 
        
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa?",
             "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            dgvLProdus.DataSource = ControllerProductos.CargarProductos_Controller();
        }
    }
}
