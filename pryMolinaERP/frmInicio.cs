using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryMolinaERP;

namespace pryMolinaERP
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            txtContrasenia.PasswordChar = '*';
            ActualizarEtiquetaIntentos();
            CargarPerfiles();
        }
        private void CargarPerfiles()
        {
            clsConexion conexion = new clsConexion();
            List<string> perfiles = conexion.ObtenerPerfiles();

            cmbPerfil.Items.Clear();
            foreach (string p in perfiles)
                cmbPerfil.Items.Add(p);

            if (cmbPerfil.Items.Count > 0)
                cmbPerfil.SelectedIndex = 0;
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmPerfil frm = new frmPerfil();
            frm.ShowDialog();          // ShowDialog para esperar a que cierre
            CargarPerfiles();          // Recargar en caso de que se haya agregado uno nuevo
        }
        private int _IntentosRestantes = 3;
        private void btnIngrasar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            string perfil = cmbPerfil.SelectedItem?.ToString() ?? "";

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(perfil))
            {
                MessageBox.Show("Seleccione un perfil para continuar.",
                    "Perfil requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que sea perfil Administrador
            if (!perfil.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Solo los usuarios Administradores pueden ingresar al sistema.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Validar usuario + contraseña + perfil contra la BD
            clsConexion conexion = new clsConexion();
            UsuarioInfo info = conexion.ValidarUsuario(usuario, contrasenia, perfil);

            if (info != null)
            {
                frmPersonal frmPrincipal = new frmPersonal(info);
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                _IntentosRestantes--;

                if (_IntentosRestantes <= 0)
                {
                    MessageBox.Show("Ha superado el número máximo de intentos.\nEl sistema se cerrará.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                    return;
                }

                MessageBox.Show(
                    $"Usuario, contraseña o perfil incorrectos.\nIntentos restantes: {_IntentosRestantes}",
                    "Acceso inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtContrasenia.Clear();
                txtContrasenia.Focus();
                ActualizarEtiquetaIntentos();
            }
            if (info != null)
            {
                // Registrar en tabla Auditoria y guardar el IdSesion
                clsAuditoria aud = new clsAuditoria();
                info.IdSesion = aud.IniciarSesion(usuario);  // graba Usuario, Hora, Fecha

                frmPersonal frmPrincipal = new frmPersonal(info);
                frmPrincipal.Show();
                this.Hide();
            }

        }

        private void ActualizarEtiquetaIntentos()
        {
            lblIntentos.Text = $"Intentos restantes: {_IntentosRestantes}";
            lblIntentos.ForeColor = _IntentosRestantes == 1
                ? System.Drawing.Color.Red
                : System.Drawing.Color.DarkSlateGray;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
