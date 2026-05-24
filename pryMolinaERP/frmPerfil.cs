using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolinaERP
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            txtCargo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtCargo.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese un nombre para el perfil.",
                    "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCargo.Focus();
                return;
            }

            clsConexion conexion = new clsConexion();
            bool guardado = conexion.GuardarPerfil(nombre);

            if (guardado)
            {
                MessageBox.Show($"Perfil '{nombre}' guardado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Clear();
                txtCargo.Focus();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
