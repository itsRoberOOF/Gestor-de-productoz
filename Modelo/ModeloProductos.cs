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


    }
}
