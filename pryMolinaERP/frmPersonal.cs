using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace pryMolinaERP
{
    public partial class frmPersonal : Form
    {
        private readonly UsuarioInfo _usuario;

        public frmPersonal(UsuarioInfo usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        // ── Carga inicial ────────────────────────────────────────────────────
        private void frmPersonal_Load(object sender, EventArgs e)
        {
            if (_usuario != null)
                this.Text = $"Recursos Humanos  —  {_usuario.NombreCompleto}  |  Perfil: {_usuario.Perfil}";

            CargarProvincias();

            cmbRedes.Items.Clear();
            cmbRedes.Items.AddRange(new[] {
                "Facebook","Instagram","Twitter/X","LinkedIn","WhatsApp","TikTok","YouTube"
            });
            cmbRedes.SelectedIndex = -1;

            // Configurar grilla de auditoría
            ConfigurarGrillaAuditoria();

            // Llenar filtro de acciones
            cmbFiltroAccion.Items.Clear();
            cmbFiltroAccion.Items.Add("(Todas)");
            cmbFiltroAccion.Items.Add("Inicio de sesión");
            cmbFiltroAccion.Items.Add("Ingreso a Personal");
            cmbFiltroAccion.Items.Add("Ingreso a Auditoría");
            cmbFiltroAccion.SelectedIndex = 0;

            // Fecha por defecto: último mes
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;
        }

        // ── Tab Personal ─────────────────────────────────────────────────────
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

            if (cmbProv.SelectedItem.ToString() == "Córdoba")
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
            txtdni.Clear(); txtNombre.Clear(); txtApellido.Clear();
            cmbProv.SelectedIndex = -1; cmbLoc.Items.Clear();
            txtDireccion.Clear(); txtGeo.Clear();
            txtMail.Clear(); txtTelefono.Clear();
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
                txtdni.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(),
                cmbProv.SelectedItem?.ToString() ?? "",
                cmbLoc.SelectedItem?.ToString() ?? "",
                txtDireccion.Text.Trim(), txtGeo.Text.Trim(),
                txtMail.Text.Trim(), txtTelefono.Text.Trim(),
                cmbRedes.SelectedItem?.ToString() ?? "",
                chkActivo.Checked);

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

            if (MessageBox.Show(
                    $"¿Está seguro que desea eliminar el personal con DNI {txtdni.Text}?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                clsConexion cx = new clsConexion();
                if (cx.EliminarPersonal(txtdni.Text.Trim()))
                {
                    MessageBox.Show("Personal eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNuevo_Click(sender, e);
                }
            }
        }

        // ── Tab Auditoría ────────────────────────────────────────────────────
        private void ConfigurarGrillaAuditoria()
        {
            dgvAuditoria.AutoGenerateColumns = false;
            dgvAuditoria.ReadOnly = true;
            dgvAuditoria.AllowUserToAddRows = false;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.RowHeadersVisible = false;
            dgvAuditoria.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dgvAuditoria.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(230, 240, 255);

            dgvAuditoria.Columns.Clear();
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdSesion",
                HeaderText = "ID",
                Width = 40
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Fecha",
                HeaderText = "Fecha",
                Width = 85,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Hora",
                HeaderText = "Hora",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "HH:mm:ss" }
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Usuario",
                HeaderText = "Usuario",
                Width = 90
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre completo",
                Width = 130
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Perfil",
                HeaderText = "Perfil",
                Width = 90
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Accion",
                HeaderText = "Acción",
                Width = 160
            });
        }

        private void CargarAuditoria()
        {
            clsAuditoria aud = new clsAuditoria();

            string usuario = txtFiltroUsuario.Text.Trim();
            string accion = cmbFiltroAccion.SelectedIndex > 0
                             ? cmbFiltroAccion.SelectedItem.ToString() : "";
            DateTime? desde = chkFiltroFecha.Checked ? (DateTime?)dtpDesde.Value : null;
            DateTime? hasta = chkFiltroFecha.Checked ? (DateTime?)dtpHasta.Value : null;

            List<AuditoriaInfo> lista = aud.ObtenerRegistros(usuario, accion, desde, hasta);

            dgvAuditoria.DataSource = null;
            dgvAuditoria.DataSource = lista;

            lblTotalRegistros.Text = $"Registros: {lista.Count}";
        }
       
      

        private void btnFlitrar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarAuditoria();
                MessageBox.Show($"Registros cargados: {dgvAuditoria.Rows.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\n" + ex.StackTrace);
            }
        }

       

        private void chkFiltroFecha_TextChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFiltroFecha.Checked;
            dtpHasta.Enabled = chkFiltroFecha.Checked;
        }
        // Registrar acceso al tab y cargar datos al seleccionarlo
        private void tbcADM_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tbcADM.SelectedTab == tbpAuditoria)
            {
                // Registrar en auditoría el ingreso a esta sección
                if (_usuario != null)
                {
                    clsAuditoria aud = new clsAuditoria();
                    aud.RegistrarEvento(
                        _usuario.NombreCompleto,
                        _usuario.Perfil,
                        _usuario.NombreCompleto,
                        "Ingreso a Auditoría");
                }
                CargarAuditoria();
            }
            else if (tbcADM.SelectedTab == tbpUsuario)
            {
                if (_usuario != null)
                {
                    clsAuditoria aud = new clsAuditoria();
                    aud.RegistrarEvento(
                        _usuario.NombreCompleto,
                        _usuario.Perfil,
                        _usuario.NombreCompleto,
                        "Ingreso a Personal");
                }
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            // Limpiar filtros
            txtFiltroUsuario.Clear();
            if (cmbFiltroAccion.Items.Count > 0)
                cmbFiltroAccion.SelectedIndex = 0;

            // Desactivar filtro de fecha (disparará el CheckedChanged y deshabilitará los dtp)
            chkFiltroFecha.Checked = false;

            // Restaurar fechas por defecto
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;

            // Recargar auditoría con filtros por defecto
            CargarAuditoria();
        }
    }
}

