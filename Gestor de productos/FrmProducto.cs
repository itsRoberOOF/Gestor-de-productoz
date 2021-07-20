using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Windows.Forms;

namespace Gestor_de_productos
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
            LlenarEstadoP();
            LlenarLote();
            LlenarProovedor();
            LlenarTipoP();
        }

        #region Llenar cmb form
        void LlenarEstadoP()
        {
            try
            {
                cmbEstadoP.DataSource = ControllerProductos.CargarEstadoP_Controller();
                cmbEstadoP.DisplayMember = "nombre_estadoprodu";
                cmbEstadoP.ValueMember = "idestadoprodu";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, verifique su conexión a internet o que el cable de red esta conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LlenarLote()
        {
            try
            {
                cmbLote.DataSource = ControllerProductos.CargarLote_Controller();
                cmbLote.DisplayMember = "numlote";
                cmbLote.ValueMember = "idlote";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, verifique su conexión a internet o que el cable de red esta conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LlenarProovedor()
        {
            try
            {
                cmbProveedor.DataSource = ControllerProductos.CargarProveedor_Controller();
                cmbProveedor.DisplayMember = "nombres_prv";
                cmbProveedor.ValueMember = "idproveedor";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, verifique su conexión a internet o que el cable de red esta conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LlenarTipoP()
        {
            try
            {
                cmbTipoP.DataSource = ControllerProductos.CargarTipoP_Controller();
                cmbTipoP.DisplayMember = "nombre_tipoproducto";
                cmbTipoP.ValueMember = "idtipoproducto";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos, verifique su conexión a internet o que el cable de red esta conectado.", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea volver al menu?",
            "Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmMenu fmr = new FrmMenu();
                fmr.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa?",
                "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
