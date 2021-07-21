using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModeloProductos
    {
        #region Llenar cmb
        public static DataTable CargarEstadoP()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM estadoproducto";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarLote()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM lote";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarProveedor()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM proveedor";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarTipoP()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tipoproducto";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarDetalleMarcaP()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM ";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        #endregion

        #region Ingresar 
        public static DataTable CargarProductos()
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM producto";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static bool RegistrarProducto(string pnombre, string pdescripcion, string pfelaboracion, string pfcaducidad, string pcodbarras, double pprecio, double ppeso, int pidproveedor, int pidlote, int pidestadoproducto, int pidtipoproducto)
        {
            bool retorno;
            try
            {
                //INSERCIÓN DE DATOS
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO producto(nombre_pr, descripcion_pr, fecha_de_elb_pr, fecha_de_exp_pr, precio_pr, peso_pr, codigo_de_barra_pr, idlote, idproveedor, idtipoproducto, idestadoprodu) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', '{9}', '{10}')", pnombre, pdescripcion, pfelaboracion, pfcaducidad, pcodbarras, pprecio, ppeso, pidproveedor, pidlote, pidestadoproducto, pidtipoproducto), ModelConexion.getConnect());
                //VERIFACIÓN DE DATOS
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                //RETORNAR RESPUESTA
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        #endregion

        #region Actualizar Datos
        public static DataTable CargarLoteInnerJoin(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM lote WHERE idlote = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarProveedorInnerJoin(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM proveedor WHERE idproveedor = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarTipoProduInnerJoin(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tipoproducto WHERE idtipoproducto = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        public static DataTable CargarEstadoProduInnerJoin(int id)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM estadoproducto WHERE idestadoprodu = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", id));
                MySqlDataAdapter asda = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                asda.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static bool ActualizarProducto(int idproducto, string pnombre, string pdescripcion, string pfelaboracion, string pfcaducidad, string pcodbarras, double pprecio, double ppeso, int pidproveedor, int pidlote, int pidestadoproducto, int pidtipoproducto)
        {
            bool retorno;
            try
            {
                string query = "UPDATE producto SET nombre_pr = '" + pnombre + "', descripcion_pr = '" + pdescripcion + "', fecha_de_elb_pr = '" + pfelaboracion + "', fecha_de_exp_pr = '" + pfcaducidad + "', precio_pr = '" + pprecio + "', peso_pr = '" + ppeso + "', codigo_de_barra_pr = '" + pcodbarras + "', idlote = '" + pidlote + "', idproveedor = '" + pidproveedor + "', idtipoproducto = '" + pidtipoproducto + "', idestadoprodu = '" + pidestadoproducto + "' WHERE idproducto = '" + idproducto + "'";
                MySqlCommand cmdupdate = new MySqlCommand(string.Format(query), ModelConexion.getConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }
        #endregion
    }
}
