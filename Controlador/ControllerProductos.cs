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
    }
}
