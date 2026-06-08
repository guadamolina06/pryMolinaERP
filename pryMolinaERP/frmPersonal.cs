using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace pryMolinaERP
{
    public partial class frmPersonal : Form
    {
        private readonly UsuarioInfo _usuario;
        private int _contadorRedes = 1;
        private int _contadorDoms = 1;

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
            try
            {
                clsConexion cx = new clsConexion();
                cx.ObtenerProvincias(); // prueba real de conexión
                lblEstadoBD.Text = "  ●  Conectado a la base de datos";
                lblEstadoBD.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                lblEstadoBD.Text = "  ●  Sin conexión a la base de datos";
                lblEstadoBD.ForeColor = System.Drawing.Color.Red;
            }
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

            cmbLoc.Items.Clear();

            if (cmbProv.SelectedItem.ToString() == "Córdoba")
            {
                clsConexion conexion = new clsConexion();
                List<string> localidades = conexion.ObtenerLocalidades("");
                foreach (string l in localidades)
                    cmbLoc.Items.Add(l);

                if (cmbLoc.Items.Count > 0)
                    cmbLoc.SelectedIndex = 0;
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
            List<TabPage> aEliminar = new List<TabPage>();
            foreach (TabPage tp in tcRedes.TabPages)
                if (tp != tpRed1 && tp != tpplus)
                    aEliminar.Add(tp);
            foreach (TabPage tp in aEliminar)
                tcRedes.TabPages.Remove(tp);
            _contadorRedes = 1;
            List<TabPage> domAEliminar = new List<TabPage>();
            foreach (TabPage tp in tpDomicilio.TabPages)
                if (tp != tpDom1 && tp != tpdpus)
                    domAEliminar.Add(tp);
            foreach (TabPage tp in domAEliminar)
                tpDomicilio.TabPages.Remove(tp);
            _contadorDoms = 1;
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
            DateTime? desde = chkFiltroFecha.Checked ? (DateTime?)dtpDesde.Value.Date : null;
            DateTime? hasta = chkFiltroFecha.Checked ? (DateTime?)dtpHasta.Value.Date : null;

            List<AuditoriaInfo> lista = aud.ObtenerRegistros(usuario, accion, desde, hasta);

            dgvAuditoria.DataSource = null;
            dgvAuditoria.DataSource = lista;

            lblTotalRegistros.Text = $"Registros: {lista.Count}";
        }



        private void btnFlitrar_Click(object sender, EventArgs e)
        {
            CargarAuditoria();
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
        private void CargarCmbRedes(ComboBox cmb)
        {
            cmb.Items.Clear();
            cmb.Items.AddRange(new[] {
                "Facebook","Instagram","Twitter/X","LinkedIn","WhatsApp","TikTok","YouTube"
            });
            cmb.SelectedIndex = -1;
        }
        private void tcRedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el usuario seleccionó el tab "+"
            if (tcRedes.SelectedTab == tpplus)
            {
                AgregarTabRed();
            }
        }
        private void AgregarTabRed()
        {
            _contadorRedes++;

            // Crear nueva TabPage
            TabPage nuevaTab = new TabPage($"Red {_contadorRedes}");

            // ── Controles internos ──
            Label lblRed = new Label { Text = "Red:", AutoSize = true, Location = new System.Drawing.Point(47, 23) };
            ComboBox cmb = new ComboBox { Location = new System.Drawing.Point(95, 20), Size = new System.Drawing.Size(179, 24), Name = $"cmbRedes_{_contadorRedes}" };
            CargarCmbRedes(cmb);

            Label lblUsr = new Label { Text = "Usuario:", AutoSize = true, Location = new System.Drawing.Point(316, 26) };
            TextBox txtUsr = new TextBox { Location = new System.Drawing.Point(385, 23), Size = new System.Drawing.Size(195, 22), Name = $"txtUsuarioRed_{_contadorRedes}" };

            Label lblUrl = new Label { Text = "URL:", AutoSize = true, Location = new System.Drawing.Point(43, 73) };
            TextBox txtUrl = new TextBox { Location = new System.Drawing.Point(95, 69), Size = new System.Drawing.Size(179, 22), Name = $"txtUrl_{_contadorRedes}" };

            // Botón eliminar esta pestaña
            Button btnElim = new Button
            {
                Text = "Eliminar red",
                Location = new System.Drawing.Point(385, 65),
                Size = new System.Drawing.Size(100, 28),
                Tag = nuevaTab
            };
            btnElim.Click += btnEliminarR_Click;

            nuevaTab.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblRed, cmb, lblUsr, txtUsr, lblUrl, txtUrl, btnElim
            });

            // Insertar antes del tab "+"
            int posPlus = tcRedes.TabPages.IndexOf(tpplus);
            tcRedes.TabPages.Insert(posPlus, nuevaTab);

            // Seleccionar la nueva pestaña
            tcRedes.SelectedTab = nuevaTab;
        }

        private void btnEliminarR_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            TabPage tabAEliminar = btn.Tag as TabPage;
            if (tabAEliminar == null) return;

            if (tcRedes.TabPages.Count <= 2) // solo queda Red 1 y +
            {
                MessageBox.Show("Debe haber al menos una red social.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tcRedes.TabPages.Remove(tabAEliminar);

            // Renumerar las pestañas
            int numero = 1;
            foreach (TabPage tp in tcRedes.TabPages)
            {
                if (tp == tpplus) continue;
                tp.Text = $"Red {numero}";
                numero++;
            }
            _contadorRedes = numero - 1;
        }

        private void tpDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tpDomicilio.SelectedTab == tpdpus)
                AgregarTabDom();
        }
        private void AgregarTabDom()
        {
            _contadorDoms++;

            TabPage nuevaTab = new TabPage($"Dom {_contadorDoms}");

            Label lblProv = new Label { Text = "Provincia:", AutoSize = true, Location = new System.Drawing.Point(24, 25) };
            ComboBox cmbProv2 = new ComboBox { Location = new System.Drawing.Point(177, 25), Size = new System.Drawing.Size(132, 24), Name = $"cmbProv_{_contadorDoms}" };
            try { clsConexion cx = new clsConexion(); foreach (string p in cx.ObtenerProvincias()) cmbProv2.Items.Add(p); } catch { }

            Label lblLoc = new Label { Text = "Localidad:", AutoSize = true, Location = new System.Drawing.Point(24, 65) };
            ComboBox cmbLoc2 = new ComboBox { Location = new System.Drawing.Point(177, 58), Size = new System.Drawing.Size(132, 24), Name = $"cmbLoc_{_contadorDoms}" };

            Label lblDir = new Label { Text = "Dirección:", AutoSize = true, Location = new System.Drawing.Point(373, 20) };
            TextBox txtDir = new TextBox { Location = new System.Drawing.Point(460, 20), Size = new System.Drawing.Size(132, 22), Name = $"txtDir_{_contadorDoms}" };

            Label lblGeo2 = new Label { Text = "Geo(cordenadas):", AutoSize = true, Location = new System.Drawing.Point(373, 66) };
            TextBox txtGeo2 = new TextBox { Location = new System.Drawing.Point(488, 62), Size = new System.Drawing.Size(132, 22), Name = $"txtGeo_{_contadorDoms}" };

            Label lblTipo2 = new Label { Text = "Tipo:", AutoSize = true, Location = new System.Drawing.Point(24, 103) };
            ComboBox cmbTipo2 = new ComboBox { Location = new System.Drawing.Point(177, 94), Size = new System.Drawing.Size(132, 24), Name = $"cmbTipo_{_contadorDoms}" };
            cmbTipo2.Items.AddRange(new object[] { "Pricipal", "Laboral", "Alternatibo", "Fiscal" });

            Button btnElim = new Button
            {
                Text = "Eliminar dom.",
                Location = new System.Drawing.Point(24, 130),
                Size = new System.Drawing.Size(100, 26),
                Tag = nuevaTab
            };
            btnElim.Click += btnEliminarD_Click;

            nuevaTab.Controls.AddRange(new System.Windows.Forms.Control[] {
               lblProv, cmbProv2, lblLoc, cmbLoc2,
              lblDir, txtDir, lblGeo2, txtGeo2,
               lblTipo2, cmbTipo2, btnElim
            });

            int posPlus = tpDomicilio.TabPages.IndexOf(tpdpus);
            tpDomicilio.TabPages.Insert(posPlus, nuevaTab);
            tpDomicilio.SelectedTab = nuevaTab;
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            TabPage tabAEliminar = btn.Tag as TabPage;
            if (tabAEliminar == null) return;

            if (tpDomicilio.TabPages.Count <= 2)
            {
                MessageBox.Show("Debe haber al menos un domicilio.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tpDomicilio.TabPages.Remove(tabAEliminar);

            int numero = 1;
            foreach (TabPage tp in tpDomicilio.TabPages)
            {
                if (tp == tpdpus) continue;
                tp.Text = $"Dom {numero}";
                numero++;
            }
            _contadorDoms = numero - 1;
        }
        private void frmPersonal_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

