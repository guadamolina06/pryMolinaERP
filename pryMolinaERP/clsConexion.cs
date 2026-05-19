using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryMolinaERP
{
    internal class clsConexion
    {
        OleDbConnection ConectorBaseDatos;
        OleDbCommand ComandoBaseDatos;

        public string Estadoconexion;

        public void ConectarBaseDatos()
        {
            try
            {
                ConectorBaseDatos = new OleDbConnection();
                ConectorBaseDatos.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\MolinaERP.accdb";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + error.Message);
            }
        }
    }
}
