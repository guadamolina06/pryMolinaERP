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
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            frmInicio frmPerfil = new frmInicio();
            frmPerfil.Show();
            this.Hide();
        }
        private int _IntentosRestantes = 3;
        private void btnIngrasar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico y contraseña.", "Campos vacíos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsConexion conexion = new clsConexion();
            UsuarioInfo info = conexion.ValidarUsuario(nombre, contrasenia);


            if (info != null)
            {
                Form1 frmInicio = new Form1(info);
                frmInicio.Show();
                this.Hide();
            }
            else 
            {
                _IntentosRestantes--;
                
                if(_IntentosRestantes <= 0)
                {
                    MessageBox.Show("Ha superado el número máximo de intentos.\nEl sistema se cerrará.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                    return;

                }
                MessageBox.Show(
                    "$Usuario o contraseña incorrectos.\nIntentos restantes: {_intentosRestantes}",
                    "Acceso inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtContrasenia.Clear();
                txtContrasenia.Focus();
                ActualizarEtiquetaIntentos();

            }
     
        }
        private void ActualizarEtiquetaIntentos()
        {
            lblIntentos.Text = $"Intentos restantes: {_IntentosRestantes}";
            lblIntentos.ForeColor = _IntentosRestantes == 1
                ? System.Drawing.Color.Red
                : System.Drawing.Color.DarkSlateGray;
        }

        
    }
}
