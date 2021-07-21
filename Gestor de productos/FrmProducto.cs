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
        public DataTable datos;
        string nombreP, descripcionP, FElaboracionP, CodBarrasP, FCaducidadP;
        double precioP, pesoP;
        int idproveedor, idlote, idestadoproducto, idtipoproducto;
        ControllerProductos agregar;

        public FrmProducto()
        {
            InitializeComponent();
            LLenarListas();
            CargarGridDatos();
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
        void LLenarListas()
        {
            LlenarEstadoP();
            LlenarLote();
            LlenarProovedor();
            LlenarTipoP();
        }
        #endregion

        void Datos()
        {
            nombreP = txtNombreP.Text;
            descripcionP = txtDescripcionP.Text;
            precioP = Convert.ToDouble(txtPrecioP.Text);
            FElaboracionP = dtFElaboracion.Text;
            CodBarrasP = txtCodBarrasP.Text;
            pesoP = Convert.ToDouble(txtPesoP.Text);
            FCaducidadP = dtVencimientoP.Text;
            idproveedor = Convert.ToInt16(cmbProveedor.SelectedValue);
            idlote = Convert.ToInt16(cmbLote.SelectedValue);
            idestadoproducto = Convert.ToInt16(cmbEstadoP.SelectedValue);
            idtipoproducto = Convert.ToInt16(cmbTipoP.SelectedValue);
        }

        #region Envio Datos + Validaciones
        void EnvioDatos()
        {
            //VALIDAR QUE NO EXISTAN CAMPOS VACÍOS.
            if (txtNombreP.Text.Trim() == "" ||
                txtDescripcionP.Text.Trim() == "" ||
                txtPrecioP.Text.Trim() == "" ||
                txtPesoP.Text.Trim() == "")
            {
                MessageBox.Show("No puede dejar campos vacíos, por favor complete todos los espacios requeridos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Convert.ToDouble(txtPesoP.Text.Trim()) < 0 && Convert.ToDouble(txtPrecioP.Text.Trim()) < 0)
            {
                MessageBox.Show("Precio y peso no pueden ser menor a 0, por favor revise la información ingresada.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Datos();
                agregar = new ControllerProductos(nombreP, descripcionP, FElaboracionP, FCaducidadP, CodBarrasP, precioP, pesoP, idproveedor, idlote, idestadoproducto, idtipoproducto);
                bool respuesta = agregar.EnviarDatos_Controller();
                if (respuesta == true)
                {
                    MessageBox.Show("Producto agregado exitosamente.",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no pudo ser agregado.",
                                    "Proceso fallido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        void CargarGridDatos()
        {
            datos = ControllerProductos.CargarProductos_Controller();
            dgvProductos.DataSource = datos;
        }

        #endregion

        #region Actualizar Datos

        private void cmbLote_Click(object sender, EventArgs e)
        {
            LlenarLote();
        }

        private void cmbEstadoP_Click(object sender, EventArgs e)
        {
            LlenarEstadoP();
        }

        private void cmbTipoP_Click(object sender, EventArgs e)
        {
            LlenarTipoP();
        }

        private void cmbProveedor_Click(object sender, EventArgs e)
        {
            LlenarProovedor();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvProductos.CurrentRow.Index;

            txtId.Text = dgvProductos[0, posicion].Value.ToString();
            txtNombreP.Text = dgvProductos[1, posicion].Value.ToString();
            txtDescripcionP.Text = dgvProductos[2, posicion].Value.ToString();
            dtFElaboracion.Text = dgvProductos[3, posicion].Value.ToString();
            dtVencimientoP.Text = dgvProductos[4, posicion].Value.ToString();
            txtPrecioP.Text = dgvProductos[5, posicion].Value.ToString();
            txtPesoP.Text = dgvProductos[6, posicion].Value.ToString();
            txtCodBarrasP.Text = dgvProductos[7, posicion].Value.ToString();

            int idlote = Convert.ToInt16(dgvProductos[8, posicion].Value.ToString());
            int idproveedor = Convert.ToInt16(dgvProductos[8, posicion].Value.ToString());
            int idtipoprodu = Convert.ToInt16(dgvProductos[9, posicion].Value.ToString());
            int idestadoprodu = Convert.ToInt16(dgvProductos[10, posicion].Value.ToString());

            cmbLote.DataSource = ControllerProductos.CargarLoteInner_Controller(idlote);
            cmbLote.DisplayMember = "numlote";
            cmbLote.ValueMember = "idlote";

            cmbProveedor.DataSource = ControllerProductos.CargarProveedorInner_Controller(idproveedor);
            cmbProveedor.DisplayMember = "nombres_prv";
            cmbProveedor.ValueMember = "idproveedor";

            cmbTipoP.DataSource = ControllerProductos.CargarTipoProduInner_Controller(idtipoprodu);
            cmbTipoP.DisplayMember = "nombre_tipoproducto";
            cmbTipoP.ValueMember = "idtipoproducto";

            cmbEstadoP.DataSource = ControllerProductos.CargarEstadoProduInner_Controller(idestadoprodu);
            cmbEstadoP.DisplayMember = "nombre_estadoprodu";
            cmbEstadoP.ValueMember = "idestadoprodu";
        }

        void ActualizarDatos()
        {
            ControllerProductos.idproducto = Convert.ToInt16(txtId.Text);
            nombreP = txtNombreP.Text;
            descripcionP = txtDescripcionP.Text;
            precioP = Convert.ToDouble(txtPrecioP.Text);
            FElaboracionP = dtFElaboracion.Text;
            CodBarrasP = txtCodBarrasP.Text;
            pesoP = Convert.ToDouble(txtPesoP.Text);
            FCaducidadP = dtVencimientoP.Text;
            idproveedor = Convert.ToInt16(cmbProveedor.SelectedValue);
            idlote = Convert.ToInt16(cmbLote.SelectedValue);
            idestadoproducto = Convert.ToInt16(cmbEstadoP.SelectedValue);
            idtipoproducto = Convert.ToInt16(cmbTipoP.SelectedValue);

            agregar = new ControllerProductos(nombreP, descripcionP, FElaboracionP, FCaducidadP, CodBarrasP, precioP, pesoP, idproveedor, idlote, idestadoproducto, idtipoproducto);
            bool respuesta = agregar.ActualizarDatos_Controller();
            if (respuesta == true)
            {
                MessageBox.Show("Producto actualizado correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El producto no pudo ser actualizado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarGridDatos();
        }
        #endregion

        private void txtPrecioP_KeyPress(object sender, KeyPressEventArgs a)
        {
            Validaciones.SoloNumeros(a);
            if (txtPrecioP.Text.Contains('.') && a.KeyChar == '.')
            {
                a.Handled = true;
            }
            if (txtPrecioP.Text.Trim() == "" && a.KeyChar == '.')
            {
                a.Handled = true;
            }
        }

        private void txtPesoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
            if (txtPesoP.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            if (txtPesoP.Text.Trim() == "" && e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

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

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                EnvioDatos();
                CargarGridDatos();
            }
    }
} 
