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

                string rutaBase = System.IO.Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,  // bin\Debug\
                    "..", "..",                              // sube a pryMolinaERP\
                    "BaseDeDatos", "Molina.accdb");

                rutaBase = System.IO.Path.GetFullPath(rutaBase);

                ConectorBaseDatos.ConnectionString =
                    $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaBase}";
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
        public UsuarioInfo ValidarUsuario(string nombre, string contrasenia, string perfil)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                // Paso 1: validar usuario y contraseña, obtener su ID
                string sql1 = "SELECT IdUsuario, Nombre, Apellido FROM Usuario " +
                              "WHERE Nombre = ? AND Contrasenia = ?";
                ComandoBaseDatos = new OleDbCommand(sql1, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = nombre;
                ComandoBaseDatos.Parameters.Add("p2", OleDbType.VarWChar).Value = contrasenia;

                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();
                if (!lector.Read())
                {
                    lector.Close();
                    ConectorBaseDatos.Close();
                    return null; // usuario o contraseña incorrectos
                }

                string idUsuario = lector["IdUsuario"].ToString();
                string nombreCompleto = lector["Nombre"].ToString() + " " + lector["Apellido"].ToString();
                lector.Close();

                // Paso 2: buscar el IDPerfil que corresponde al nombre de perfil
                string sql2 = "SELECT IdPerfil FROM Perfil WHERE Nombre = ?";
                ComandoBaseDatos = new OleDbCommand(sql2, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = perfil;

                lector = ComandoBaseDatos.ExecuteReader();
                if (!lector.Read())
                {
                    lector.Close();
                    ConectorBaseDatos.Close();
                    return null; // perfil no existe
                }

                string idPerfil = lector["IdPerfil"].ToString();
                lector.Close();

                // Paso 3: verificar que exista la relacion usuario-perfil
                string sql3 = "SELECT Id FROM [Relacion/P-U] WHERE IdUsuario = ? AND IDPerfil = ?";
                ComandoBaseDatos = new OleDbCommand(sql3, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = idUsuario;
                ComandoBaseDatos.Parameters.Add("p2", OleDbType.VarWChar).Value = idPerfil;

                lector = ComandoBaseDatos.ExecuteReader();
                bool tieneRelacion = lector.Read();
                lector.Close();
                ConectorBaseDatos.Close();

                if (tieneRelacion)
                {
                    return new UsuarioInfo
                    {
                        NombreCompleto = nombreCompleto,
                        Perfil = perfil,
                        FechaIngreso = DateTime.Now
                    };
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al validar usuario: " + error.Message);
            }
            return null;
        }
        public List<string> ObtenerPerfiles()
        {
            List<string> perfiles = new List<string>();
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "SELECT Nombre FROM Perfil ORDER BY Nombre";
                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();

                while (lector.Read())
                    perfiles.Add(lector["Nombre"].ToString());

                lector.Close();
                ConectorBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener perfiles: " + error.Message);
            }
            return perfiles;
        }
        // ── Guardar un perfil nuevo (evita duplicados)
        public bool GuardarPerfil(string nombrePerfil)
        {
            if (string.IsNullOrWhiteSpace(nombrePerfil)) return false;
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                // Verificar si ya existe
                string sqlCheck = "SELECT COUNT(*) FROM Perfil WHERE Nombre = ?";
                OleDbCommand cmdCheck = new OleDbCommand(sqlCheck, ConectorBaseDatos);
                cmdCheck.Parameters.Add("p1", OleDbType.VarWChar, 50).Value = nombrePerfil.Trim();
                int existe = (int)cmdCheck.ExecuteScalar();

                if (existe > 0)
                {
                    ConectorBaseDatos.Close();
                    MessageBox.Show($"El perfil '{nombrePerfil}' ya existe.",
                        "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string sqlInsert = "INSERT INTO Perfil (Nombre) VALUES (?)";
                OleDbCommand cmdInsert = new OleDbCommand(sqlInsert, ConectorBaseDatos);
                cmdInsert.Parameters.Add("p1", OleDbType.VarWChar, 50).Value = nombrePerfil.Trim();
                cmdInsert.ExecuteNonQuery();

                ConectorBaseDatos.Close();
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar perfil: " + error.Message);
                return false;
            }
        }
        //Cargar provincias desde la tabla Provincia 
        public List<string> ObtenerProvincias()
        {
            List<string> provincias = new List<string>();
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "SELECT Provincia FROM Provincia ORDER BY Provincia";
                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();

                while (lector.Read())
                    provincias.Add(lector["Provincia"].ToString());

                lector.Close();
                ConectorBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener provincias: " + error.Message);
            }
            return provincias;

        }
        
        public List<string> ObtenerLocalidades(string provincia)
        {
            List<string> localidades = new List<string>();
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "SELECT Localidad FROM Localidad ORDER BY Localidad";
                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();

                while (lector.Read())
                    localidades.Add(lector["Localidad"].ToString());

                lector.Close();
                ConectorBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener localidades: " + error.Message);
            }
            return localidades;
        }
       
        public void MostrarColumnasPersonal()
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "SELECT * FROM Personal";
                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();
                string cols = "";
                for (int i = 0; i < lector.FieldCount; i++)
                    cols += lector.GetName(i) + " → " + lector.GetFieldType(i).Name + "\n";
                lector.Close();
                MessageBox.Show("Columnas de Personal:\n" + cols);

                ConectorBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
        public void CrearTablaPersonal()
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = @"CREATE TABLE Personal (
            IdPersonal AUTOINCREMENT PRIMARY KEY,
            DNI TEXT(20),
            Nombre TEXT(50),
            Apellido TEXT(50),
            Provincia TEXT(50),
            Localidad TEXT(50),
            Direccion TEXT(100),
            Geo TEXT(50),
            Mail TEXT(100),
            Telefono TEXT(20),
            Redes TEXT(50)";

                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                ComandoBaseDatos.ExecuteNonQuery();
                ConectorBaseDatos.Close();

                MessageBox.Show("Tabla Personal creada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al crear tabla: " + error.Message);
            }
        }
        public bool GuardarPersonal(string dni, string nombre, string apellido,
        string provincia, string localidad, string direccion, string geo,
        string mail, string telefono, string redes)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                // Verificar si ya existe por DNI
                string sqlCheck = "SELECT COUNT(*) FROM Personal WHERE DNI = ?";
                OleDbCommand cmdCheck = new OleDbCommand(sqlCheck, ConectorBaseDatos);
                cmdCheck.Parameters.Add("p1", OleDbType.VarWChar).Value = dni;
                int existe = (int)cmdCheck.ExecuteScalar();

                string sql;
                if (existe > 0)
                {
                    // Actualizar
                    sql = "UPDATE Personal SET Nombre=?, Apellido=?, Provincia=?, " +
                          "Localidad=?, Direccion=?, Geo=?, Mail=?, Telefono=?, " +
                          "Redes=? WHERE DNI=?";
                }
                else
                {
                    // Insertar
                    sql = "INSERT INTO Personal (Nombre, Apellido, Provincia, Localidad, " +
                          "Direccion, Geo, Mail, Telefono, Redes, DNI) " +
                          "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                }

                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = nombre;
                ComandoBaseDatos.Parameters.Add("p2", OleDbType.VarWChar).Value = apellido;
                ComandoBaseDatos.Parameters.Add("p3", OleDbType.VarWChar).Value = provincia;
                ComandoBaseDatos.Parameters.Add("p4", OleDbType.VarWChar).Value = localidad;
                ComandoBaseDatos.Parameters.Add("p5", OleDbType.VarWChar).Value = direccion;
                ComandoBaseDatos.Parameters.Add("p6", OleDbType.VarWChar).Value = geo;
                ComandoBaseDatos.Parameters.Add("p7", OleDbType.VarWChar).Value = mail;
                ComandoBaseDatos.Parameters.Add("p8", OleDbType.VarWChar).Value = telefono;
                ComandoBaseDatos.Parameters.Add("p9", OleDbType.VarWChar).Value = redes;
                ComandoBaseDatos.Parameters.Add("p10", OleDbType.VarWChar).Value = dni;

                ComandoBaseDatos.ExecuteNonQuery();
                ConectorBaseDatos.Close();
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar personal: " + error.Message);
                return false;
            }
        }

        public bool EliminarPersonal(string dni)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "DELETE FROM Personal WHERE DNI = ?";
                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = dni;
                ComandoBaseDatos.ExecuteNonQuery();

                ConectorBaseDatos.Close();
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar personal: " + error.Message);
                return false;
            }
        }
        public List<string> ObtenerDNI()
        {
            List<string> dnis = new List<string>();
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "SELECT DNI FROM Personal WHERE DNI IS NOT NULL ORDER BY DNI";
                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();

                while (lector.Read())
                    dnis.Add(lector["DNI"].ToString());

                lector.Close();
                ConectorBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener DNIs: " + error.Message);
            }
            return dnis;
        }
        // ── Gestión de estado activo/inactivo de usuarios ────────────────────
        public void AsegurarColumnaActivo()
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();
                new OleDbCommand("ALTER TABLE Usuario ADD COLUMN Activo BIT", ConectorBaseDatos).ExecuteNonQuery();
                new OleDbCommand("UPDATE Usuario SET Activo = TRUE", ConectorBaseDatos).ExecuteNonQuery();
                ConectorBaseDatos.Close();
            }
            catch
            {
                try { if (ConectorBaseDatos != null) ConectorBaseDatos.Close(); } catch { }
            }
        }

        public bool EsUsuarioActivo(string nombre)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();
                ComandoBaseDatos = new OleDbCommand(
                    "SELECT Activo FROM Usuario WHERE Nombre = ?", ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = nombre;
                object resultado = ComandoBaseDatos.ExecuteScalar();
                ConectorBaseDatos.Close();
                if (resultado == null || resultado == DBNull.Value) return true;
                return Convert.ToBoolean(resultado);
            }
            catch
            {
                try { if (ConectorBaseDatos != null) ConectorBaseDatos.Close(); } catch { }
                return true; // si no existe la columna aún, se permite acceso
            }
        }

        public System.Collections.Generic.HashSet<string> ObtenerUsuariosInactivos()
        {
            var inactivos = new System.Collections.Generic.HashSet<string>(
                System.StringComparer.OrdinalIgnoreCase);
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();
                ComandoBaseDatos = new OleDbCommand(
                    "SELECT Nombre FROM Usuario WHERE Activo = FALSE", ConectorBaseDatos);
                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();
                while (lector.Read())
                    inactivos.Add(lector["Nombre"].ToString());
                lector.Close();
                ConectorBaseDatos.Close();
            }
            catch
            {
                try { if (ConectorBaseDatos != null) ConectorBaseDatos.Close(); } catch { }
            }
            return inactivos;
        }

        public bool DesactivarUsuario(string nombre)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();
                ComandoBaseDatos = new OleDbCommand(
                    "UPDATE Usuario SET Activo = FALSE WHERE Nombre = ?", ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = nombre;
                ComandoBaseDatos.ExecuteNonQuery();
                ConectorBaseDatos.Close();
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al desactivar usuario: " + error.Message);
                try { if (ConectorBaseDatos != null) ConectorBaseDatos.Close(); } catch { }
                return false;
            }
        }

        public PersonalInfo ObtenerPersonalPorDNI(string dni)
        {
            try
            {
                ConectarBaseDatos();
                ConectorBaseDatos.Open();

                string sql = "SELECT * FROM Personal WHERE DNI = ?";
                ComandoBaseDatos = new OleDbCommand(sql, ConectorBaseDatos);
                ComandoBaseDatos.Parameters.Add("p1", OleDbType.VarWChar).Value = dni;

                OleDbDataReader lector = ComandoBaseDatos.ExecuteReader();
                if (lector.Read())
                {
                    var p = new PersonalInfo
                    {
                        DNI = lector["DNI"].ToString(),
                        Nombre = lector["Nombre"].ToString(),
                        Apellido = lector["Apellido"].ToString(),
                        Provincia = lector["Provincia"].ToString(),
                        Localidad = lector["Localidad"].ToString(),
                        Direccion = lector["Direccion"].ToString(),
                        Geo = lector["Geo"].ToString(),
                        Mail = lector["Mail"].ToString(),
                        Telefono = lector["Telefono"].ToString(),
                        Redes = lector["Redes"].ToString()
                    };
                    lector.Close();
                    ConectorBaseDatos.Close();
                    return p;
                }
                lector.Close();
                ConectorBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener personal: " + error.Message);
            }
            return null;
        }
    }
    public class PersonalInfo
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Geo { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Redes { get; set; }
    }

    public class UsuarioInfo
    {
        public string NombreCompleto { get; set; }
        public string Perfil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdSesion { get; set; }
    }

}
