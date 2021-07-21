using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;

namespace Controlador
{
    public class ControllerProductos
    {
        #region Llenar cmbs controller
        public static DataTable CargarEstadoP_Controller()
        {
            DataTable datos = ModeloProductos.CargarEstadoP();
            return datos;
        }
        public static DataTable CargarLote_Controller()
        {
            DataTable datos = ModeloProductos.CargarLote();
            return datos;
        }
        public static DataTable CargarProveedor_Controller()
        {
            DataTable datos = ModeloProductos.CargarProveedor();
            return datos;
        }
        public static DataTable CargarTipoP_Controller()
        {
            DataTable datos = ModeloProductos.CargarTipoP();
            return datos;
        }
        public static DataTable CargarDetallePMarca_Controller()
        {
            DataTable datos = ModeloProductos.CargarTipoP();
            return datos;
        }
        #endregion

        #region Constructor
        //ATRIBUTOS
        public static int idproducto { get; set; }
        public string nombreP { get; set; }
        public string descripcionP { get; set; }
        public string FElaboracionP { get; set; }
        public string FCaducidadP { get; set; }
        public string CodBarrasP { get; set; }
        public double precioP { get; set; }
        public double pesoP { get; set; }
        public int idproveedor { get; set; }
        public int idlote { get; set; }
        public int idestadoproducto { get; set; }
        public int idtipoproducto { get; set; }

        public ControllerProductos(string pnombre, string pdescripcion, string pfelaboracion, string pfcaducidad, string pcodbarras, double pprecio, double ppeso, int pidproveedor, int pidlote, int pidestadoproducto, int pidtipoproducto)
        {
            //ATRIBUTO = PARAMETRO
            nombreP = pnombre;
            descripcionP = pdescripcion;
            FElaboracionP = pfelaboracion;
            FCaducidadP = pfcaducidad;
            CodBarrasP = pcodbarras;
            precioP = pprecio;
            pesoP = ppeso;
            idproveedor = pidproveedor;
            idlote = pidlote;
            idestadoproducto = pidestadoproducto;
            idtipoproducto = pidtipoproducto;
        }

        public bool EnviarDatos_Controller()
        {
            return ModeloProductos.RegistrarProducto(nombreP, descripcionP, FElaboracionP, FCaducidadP, CodBarrasP, precioP, pesoP, idproveedor, idlote, idestadoproducto ,idtipoproducto);
        }

        public static DataTable CargarProductos_Controller()
        {
            DataTable datos = ModeloProductos.CargarProductos();
            return datos;
        }
        #endregion

        #region Actualizar Datos
        public static DataTable CargarLoteInner_Controller(int id)
        {
            return ModeloProductos.CargarLoteInnerJoin(id);
        }
        public static DataTable CargarProveedorInner_Controller(int id)
        {
            return ModeloProductos.CargarProveedorInnerJoin(id);
        }
        public static DataTable CargarTipoProduInner_Controller(int id)
        {
            return ModeloProductos.CargarTipoProduInnerJoin(id);
        }
        public static DataTable CargarEstadoProduInner_Controller(int id)
        {
            return ModeloProductos.CargarEstadoProduInnerJoin(id);
        }

        public bool ActualizarDatos_Controller()
        {
            return ModeloProductos.ActualizarProducto(idproducto, nombreP, descripcionP, FElaboracionP, FCaducidadP, CodBarrasP, precioP, pesoP, idproveedor, idlote, idestadoproducto, idtipoproducto);
        }
        #endregion
    }
}
