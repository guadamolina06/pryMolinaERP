using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            this.AcceptButton = btnIngrasar;
     
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
            frm.ShowDialog();
            CargarPerfiles();
        }

        private int _IntentosRestantes = 3;

        private void btnIngrasar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            string perfil = cmbPerfil.SelectedItem?.ToString() ?? "";

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

            bool perfilPermitido =
            perfil.Equals("Administrador", StringComparison.OrdinalIgnoreCase) ||
            perfil.Equals("Empleado", StringComparison.OrdinalIgnoreCase);

            if (!perfilPermitido)
            {
                MessageBox.Show("Solo los perfiles Administrador y Empleado pueden ingresar al sistema.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            clsConexion conexion = new clsConexion();
            UsuarioInfo info = conexion.ValidarUsuario(usuario, contrasenia, perfil);

            if (info != null)
            {
                if (!new clsConexion().EsUsuarioActivo(usuario))
                {
                    MessageBox.Show(
                        $"El usuario «{usuario}» está desactivado y no puede iniciar sesión.\nContacte al administrador.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtContrasenia.Clear();
                    txtContrasenia.Focus();
                    return;
                }

                clsAuditoria aud = new clsAuditoria();
                info.IdSesion = aud.RegistrarEvento(
                    usuario,
                    info.Perfil,
                    info.NombreCompleto,
                    "Inicio de sesión");

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
        }
        private void chkMostrarContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasenia.PasswordChar = chkMostrarContrasenia.Checked ? '\0' : '*';
        }

        private void ActualizarEtiquetaIntentos()
        {
            lblInt.Text = "";
            lblIntentos.Text = $"Intentos restantes: {_IntentosRestantes}";
            lblIntentos.ForeColor = _IntentosRestantes == 1
                ? System.Drawing.Color.FromArgb(220, 38, 38)
                : System.Drawing.Color.FromArgb(100, 116, 139);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
