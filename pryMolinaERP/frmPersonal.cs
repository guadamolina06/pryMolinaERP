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
    public partial class frmPersonal : Form
    {
        public frmPersonal(UsuarioInfo usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
        private readonly UsuarioInfo _usuario;

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            if (_usuario != null)
                this.Text = $"Recursos Humanos  —  {_usuario.NombreCompleto}  |  Perfil: {_usuario.Perfil}";
            CargarProvincias();
            cmbRedes.Items.Clear();
            cmbRedes.Items.Add("Facebook");
            cmbRedes.Items.Add("Instagram");
            cmbRedes.Items.Add("Twitter/X");
            cmbRedes.Items.Add("LinkedIn");
            cmbRedes.Items.Add("WhatsApp");
            cmbRedes.Items.Add("TikTok");
            cmbRedes.Items.Add("YouTube");
            cmbRedes.SelectedIndex = -1;
        }
        private void CargarProvincias()
        {
            clsConexion conexion = new clsConexion();
            List<string> provincias = conexion.ObtenerProvincias();

            cmbProv.Items.Clear();
            foreach (string p in provincias)
                cmbProv.Items.Add(p);

            if (cmbProv.Items.Count > 0)
                cmbProv.SelectedIndex = 0;
        }

        private void cmbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProv.SelectedItem == null) return;

            string provinciaSeleccionada = cmbProv.SelectedItem.ToString();

            // Solo carga localidades si seleccionó Córdoba
            if (provinciaSeleccionada == "Córdoba")
            {
                clsConexion conexion = new clsConexion();
                List<string> localidades = conexion.ObtenerLocalidades("");

                cmbLoc.Items.Clear();
                foreach (string l in localidades)
                    cmbLoc.Items.Add(l);

                if (cmbLoc.Items.Count > 0)
                    cmbLoc.SelectedIndex = 0;
            }
            else
            {
                cmbLoc.Items.Clear();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtdni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cmbProv.SelectedIndex = -1;
            cmbLoc.Items.Clear();
            txtDireccion.Clear();
            txtGeo.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            cmbRedes.SelectedIndex = -1;
            chkActivo.Checked = false;
            txtdni.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdni.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("DNI, Nombre y Apellido son obligatorios.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsConexion cx = new clsConexion();
            bool resultado = cx.GuardarPersonal(
                txtdni.Text.Trim(),
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                cmbProv.SelectedItem?.ToString() ?? "",
                cmbLoc.SelectedItem?.ToString() ?? "",
                txtDireccion.Text.Trim(),
                txtGeo.Text.Trim(),
                txtMail.Text.Trim(),
                txtTelefono.Text.Trim(),
                cmbRedes.SelectedItem?.ToString() ?? "",
                chkActivo.Checked
            );

            if (resultado)
                MessageBox.Show("Personal guardado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdni.Text))
            {
                MessageBox.Show("Ingrese el DNI del personal a eliminar.",
                    "DNI requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar el personal con DNI {txtdni.Text}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                clsConexion cx = new clsConexion();
                bool resultado = cx.EliminarPersonal(txtdni.Text.Trim());

                if (resultado)
                {
                    MessageBox.Show("Personal eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNuevo_Click(sender, e);
                }
            }
        }
    }    
}
