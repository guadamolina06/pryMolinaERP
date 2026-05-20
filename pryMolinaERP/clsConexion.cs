using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryMolinaERP
{
    public class clsConexion
    {
        OleDbConnection ConectorBaseDatos;
        OleDbCommand ComandoBaseDatos;

        public string Estadoconexion;

        public void ConectarBaseDatos()
        {
            try
            {
                ConectorBaseDatos = new OleDbConnection();
                ConectorBaseDatos.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Molina.accdb";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + error.Message);
            }
        }
        public bool ProbarConexion() 
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();
                Estadoconexion = "Conexión exitosa";
                ConectorBaseDatos.Close();
                return true;    
            }
            catch 
            {
                Estadoconexion = "Sin Conexion";
                return false;
            }
        }
        public UsuarioInfo ValidarUsuario(string nombre, string contrasenia)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "SELECT Nombre, Apellido FROM Usuario " +
                             "WHERE Nombre = ? AND Contrasenia = ?";

                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar, 50).Value = nombre;
                ComandoBaseDatos.Parameters.Add("p2", OleDbType.VarWChar, 50).Value = contrasenia;

                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();

                if (lector.Read())
                {
                    UsuarioInfo info = new UsuarioInfo
                    {
                        NombreCompleto = lector["Nombre"].ToString() + " " + lector["Apellido"].ToString(),
                        Perfil = "Usuario",
                        FechaIngreso = DateTime.Now
                    };
                    lector.Close();
                    ConectorBaseDatos.Close();
                    return info;
                }

                lector.Close();
                ConectorBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al validar usuario: " + error.Message);
            }

            return null;
        }
    }
    public class UsuarioInfo
    {
        public string NombreCompleto { get; set; }
        public string Perfil { get; set; }
        public DateTime FechaIngreso { get; set; }
    }

}
