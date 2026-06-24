using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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
                this.Text = $"  —  {_usuario.NombreCompleto}  |  Perfil: {_usuario.Perfil}";

            CargarProvincias(); 
            cargarContactos();

            cmbRedes.Items.Clear();
            cmbRedes.Items.AddRange(new[] {
                "Facebook","Instagram","Twitter/X","LinkedIn","WhatsApp","TikTok","YouTube"
            });
            cmbRedes.SelectedIndex = -1;

            new clsConexion().AsegurarColumnaActivo();
            new clsConexion().AsegurarTablasContacto();

            // Configurar grilla de auditoría
            ConfigurarGrillaAuditoria();

            // Llenar filtro de acciones
            cmbFiltroAccion.Items.Clear();
            cmbFiltroAccion.Items.Add("(Todas)");
            cmbFiltroAccion.Items.Add("Inicio de sesión");
            cmbFiltroAccion.Items.Add("Ingreso a Personal");
            cmbFiltroAccion.Items.Add("Ingreso a Auditoría");
            cmbFiltroAccion.SelectedIndex = 0;
            //Limpiar componentes
            txtApellido.Clear();
            txtdni.Clear();
            txtNombre.Clear();

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
            cmbContacto.Enabled = false;
        }
        //Cargar contactos del personal
        private void cargarContactos()
        { clsConexion conexion = new clsConexion();
            List<string> DNI = conexion.ObtenerDNI();
            cmbContacto.Items.Clear();
            foreach (string d in DNI)
                cmbContacto.Items.Add(d);
            if(cmbContacto.Items.Count > 0)
                cmbContacto.SelectedIndex = 0;
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
            
            txtNombre.Enabled = true;
            lblNombre.Enabled = true;
            txtApellido.Enabled = true;
            lblApellido.Enabled = true; 
            lblDNI.Enabled = true;
            txtdni.Enabled = true;
            tcDatos.Enabled = true;
            btnEliminar.Visible = false;

            txtdni.Clear(); txtNombre.Clear(); txtApellido.Clear();
            cmbProv.SelectedIndex = -1; cmbLoc.Items.Clear();
            txtDireccion.Clear(); txtGeo.Clear();
            txtMail.Clear(); txtTelefono.Clear();
            cmbRedes.SelectedIndex = -1;
           
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
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(cmbProv.Text)||
                string.IsNullOrWhiteSpace(cmbLoc.Text)||
                string.IsNullOrWhiteSpace(cmbTipo.Text)||
                string.IsNullOrWhiteSpace(cmbTipo.Text)||
                string.IsNullOrWhiteSpace(txtDireccion.Text)||
                string.IsNullOrWhiteSpace(txtGeo.Text))
            {
                MessageBox.Show("DNI, Nombre, Apellido y Domicilio completo son obligatorios.",
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
                cmbRedes.SelectedItem?.ToString() ?? ""
             );

            if (resultado)
            {
                string dni = txtdni.Text.Trim();
                cx.GuardarDomicilios(dni, RecolectarDomicilios());
                cx.GuardarRedes(dni, RecolectarRedes());

                MessageBox.Show("Personal guardado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmbContacto.Enabled = true;
            txtNombre.Enabled = false;
            lblNombre.Enabled = false;
            txtApellido.Enabled = false;
            lblApellido.Enabled = false;
            lblDNI.Enabled = false;
            txtdni.Enabled = false;
            tcDatos.Enabled = false;
            btnEliminar.Visible = false;
            cmbContacto.Enabled = false;
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
                Width = 155
            });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Width = 80
            });

            dgvAuditoria.CellFormatting += dgvAuditoria_CellFormatting;
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

            var inactivos = new clsConexion().ObtenerUsuariosInactivos();
            foreach (var item in lista)
                item.Estado = inactivos.Contains(item.Usuario) ? "Inactivo" : "Activo";

            dgvAuditoria.DataSource = null;
            dgvAuditoria.DataSource = lista;

            lblTotalRegistros.Text = $"Registros: {lista.Count}";
        }

        private void dgvAuditoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvAuditoria.Rows[e.RowIndex];
            var item = row.DataBoundItem as AuditoriaInfo;
            if (item == null) return;

            if (item.Estado == "Inactivo")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(153, 27, 27);
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(252, 165, 165);
                row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(127, 29, 29);
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.Empty;
                row.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
                row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 99, 235);
                row.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvAuditoria.CurrentRow == null) return;

            var item = dgvAuditoria.CurrentRow.DataBoundItem as AuditoriaInfo;
            if (item == null) return;

            if (item.Estado == "Inactivo")
            {
                MessageBox.Show($"El usuario «{item.Usuario}» ya está inactivo.",
                    "Usuario inactivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var resp = MessageBox.Show(
                $"¿Desea desactivar al usuario «{item.Usuario}»?\n\nEl usuario no podrá iniciar sesión.",
                "Confirmar desactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (resp != DialogResult.Yes) return;

            if (new clsConexion().DesactivarUsuario(item.Usuario))
            {
                if (_usuario != null)
                    new clsAuditoria().RegistrarEvento(
                        _usuario.NombreCompleto,
                        _usuario.Perfil,
                        _usuario.NombreCompleto,
                        $"Desactivó usuario: {item.Usuario}");

                CargarAuditoria();
            }
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
            if (tcRedes.SelectedTab == tpplus)
                BeginInvoke(new Action(AgregarTabRed));
        }
        private void AgregarTabRed()
        {
            CrearTabRed();
        }
        private TabPage CrearTabRed()
        {
            _contadorRedes++;

            var bgDark   = Color.FromArgb(248, 249, 250);
            var bgInput  = Color.White;
            var textPri  = Color.FromArgb(30, 41, 59);
            var textSec  = Color.FromArgb(100, 116, 139);
            var danger   = Color.FromArgb(220, 38, 38);
            var dangerBg = Color.FromArgb(254, 226, 226);
            var font     = new Font("Segoe UI", 8.5F);
            var fontIn   = new Font("Segoe UI", 9.5F);

            TabPage nuevaTab = new TabPage($"Red {_contadorRedes}") { BackColor = bgDark };

            Label lblRed = new Label { Text = "Red:", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(12, 14) };
            ComboBox cmb = new ComboBox { Location = new Point(60, 10), Size = new Size(170, 26), Name = $"cmbRedes_{_contadorRedes}", DropDownStyle = ComboBoxStyle.DropDownList, BackColor = bgInput, ForeColor = textPri, FlatStyle = FlatStyle.Flat, Font = fontIn };
            CargarCmbRedes(cmb);

            Label lblUsr = new Label { Text = "Usuario:", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(250, 14) };
            TextBox txtUsr = new TextBox { Location = new Point(316, 10), Size = new Size(200, 26), Name = $"txtUsuarioRed_{_contadorRedes}", BackColor = bgInput, ForeColor = textPri, BorderStyle = BorderStyle.FixedSingle, Font = fontIn };

            Label lblUrl = new Label { Text = "URL:", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(12, 54) };
            TextBox txtUrl = new TextBox { Location = new Point(60, 50), Size = new Size(456, 26), Name = $"txtUrl_{_contadorRedes}", BackColor = bgInput, ForeColor = textPri, BorderStyle = BorderStyle.FixedSingle, Font = fontIn };

            Button btnElim = new Button
            {
                Text = "Eliminar red",
                Location = new Point(8, 84),
                Size = new Size(110, 28),
                Tag = nuevaTab,
                BackColor = dangerBg,
                ForeColor = danger,
                FlatStyle = FlatStyle.Flat,
                Font = font,
                UseVisualStyleBackColor = false
            };
            btnElim.FlatAppearance.BorderSize = 0;
            btnElim.Click += btnEliminarR_Click;

            nuevaTab.Controls.AddRange(new Control[] { lblRed, cmb, lblUsr, txtUsr, lblUrl, txtUrl, btnElim });

            int posPlus = tcRedes.TabPages.IndexOf(tpplus);
            tcRedes.TabPages.Insert(posPlus, nuevaTab);
            tcRedes.SelectedTab = nuevaTab;
            return nuevaTab;
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
                BeginInvoke(new Action(AgregarTabDom));
        }

        private void AgregarTabDom()
        {
            CrearTabDom();
        }
        private TabPage CrearTabDom()
        {
            _contadorDoms++;

            var bgDark   = Color.FromArgb(248, 249, 250);
            var bgInput  = Color.White;
            var textPri  = Color.FromArgb(30, 41, 59);
            var textSec  = Color.FromArgb(100, 116, 139);
            var danger   = Color.FromArgb(220, 38, 38);
            var dangerBg = Color.FromArgb(254, 226, 226);
            var font     = new Font("Segoe UI", 8.5F);
            var fontIn   = new Font("Segoe UI", 9.5F);

            TabPage nuevaTab = new TabPage($"Dom {_contadorDoms}") { BackColor = bgDark };

            Label lblProv = new Label { Text = "Provincia:", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(16, 24) };
            ComboBox cmbProv2 = new ComboBox { Location = new Point(16, 44), Size = new Size(180, 26), Name = $"cmbProv_{_contadorDoms}", DropDownStyle = ComboBoxStyle.DropDownList, BackColor = bgInput, ForeColor = textPri, FlatStyle = FlatStyle.Flat, Font = fontIn };
            try { clsConexion cx = new clsConexion(); foreach (string p in cx.ObtenerProvincias()) cmbProv2.Items.Add(p); } catch { }

            Label lblLoc = new Label { Text = "Localidad:", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(210, 24) };
            ComboBox cmbLoc2 = new ComboBox { Location = new Point(210, 44), Size = new Size(180, 26), Name = $"cmbLoc_{_contadorDoms}", DropDownStyle = ComboBoxStyle.DropDownList, BackColor = bgInput, ForeColor = textPri, FlatStyle = FlatStyle.Flat, Font = fontIn };
            cmbProv2.SelectedIndexChanged += (s, ev) =>
            {
                cmbLoc2.Items.Clear();
                if (cmbProv2.SelectedItem?.ToString() == "Córdoba")
                {
                    try
                    {
                        clsConexion cx2 = new clsConexion();
                        foreach (string l in cx2.ObtenerLocalidades(""))
                            cmbLoc2.Items.Add(l);
                        if (cmbLoc2.Items.Count > 0) cmbLoc2.SelectedIndex = 0;
                    }
                    catch { }
                }
            };

            Label lblDir = new Label { Text = "Dirección:", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(16, 86) };
            TextBox txtDir = new TextBox { Location = new Point(16, 106), Size = new Size(374, 26), Name = $"txtDir_{_contadorDoms}", BackColor = bgInput, ForeColor = textPri, BorderStyle = BorderStyle.FixedSingle, Font = fontIn };

            Label lblGeo2 = new Label { Text = "Coordenadas (Geo):", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(16, 148) };
            TextBox txtGeo2 = new TextBox { Location = new Point(16, 168), Size = new Size(374, 26), Name = $"txtGeo_{_contadorDoms}", BackColor = bgInput, ForeColor = textPri, BorderStyle = BorderStyle.FixedSingle, Font = fontIn };

            Label lblTipo2 = new Label { Text = "Tipo:", AutoSize = true, Font = font, ForeColor = textSec, Location = new Point(410, 24) };
            ComboBox cmbTipo2 = new ComboBox { Location = new Point(410, 44), Size = new Size(160, 26), Name = $"cmbTipo_{_contadorDoms}", DropDownStyle = ComboBoxStyle.DropDownList, BackColor = bgInput, ForeColor = textPri, FlatStyle = FlatStyle.Flat, Font = fontIn };
            cmbTipo2.Items.AddRange(new object[] { "Pricipal", "Laboral", "Alternatibo", "Fiscal" });

            Button btnElim = new Button
            {
                Text = "Eliminar dom.",
                Location = new Point(8, 210),
                Size = new Size(120, 28),
                Tag = nuevaTab,
                BackColor = dangerBg,
                ForeColor = danger,
                FlatStyle = FlatStyle.Flat,
                Font = font,
                UseVisualStyleBackColor = false
            };
            btnElim.FlatAppearance.BorderSize = 0;
            btnElim.Click += btnEliminarD_Click;

            nuevaTab.Controls.AddRange(new Control[] {
                lblProv, cmbProv2, lblLoc, cmbLoc2,
                lblDir, txtDir, lblGeo2, txtGeo2,
                lblTipo2, cmbTipo2, btnElim
            });

            int posPlus = tpDomicilio.TabPages.IndexOf(tpdpus);
            tpDomicilio.TabPages.Insert(posPlus, nuevaTab);
            tpDomicilio.SelectedTab = nuevaTab;
            return nuevaTab;
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

        // ── Tab drawing helpers (light theme) ───────────────────────────────
        private static readonly Color _tabBg       = Color.FromArgb(241, 245, 249);
        private static readonly Color _tabSelected = Color.White;
        private static readonly Color _tabAccent   = Color.FromArgb(37, 99, 235);
        private static readonly Color _tabText     = Color.FromArgb(30, 41, 59);
        private static readonly Color _tabTextDim  = Color.FromArgb(100, 116, 139);

        private void DrawDarkTab(DrawItemEventArgs e, TabControl tc)
        {
            if (e.Index < 0 || e.Index >= tc.TabPages.Count) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            using (var bgBrush = new SolidBrush(selected ? _tabSelected : _tabBg))
                e.Graphics.FillRectangle(bgBrush, e.Bounds);

            if (selected)
            {
                using (var accentPen = new Pen(_tabAccent, 2))
                    e.Graphics.DrawLine(accentPen, e.Bounds.Left, e.Bounds.Bottom - 1,
                        e.Bounds.Right, e.Bounds.Bottom - 1);
            }

            string text = tc.TabPages[e.Index].Text;
            var textColor = selected ? _tabText : _tabTextDim;
            var font = selected
                ? new Font("Segoe UI", 9F, FontStyle.Bold)
                : new Font("Segoe UI", 9F);
            using (font)
            using (var textBrush = new SolidBrush(textColor))
            {
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(text, font, textBrush, e.Bounds, sf);
            }
        }

        private void tbcADM_DrawItem(object sender, DrawItemEventArgs e)
            => DrawDarkTab(e, (TabControl)sender);

        private void tcDatos_DrawItem(object sender, DrawItemEventArgs e)
            => DrawDarkTab(e, (TabControl)sender);

        private void tpDomicilio_DrawItem(object sender, DrawItemEventArgs e)
            => DrawDarkTab(e, (TabControl)sender);

        private void tcRedes_DrawItem(object sender, DrawItemEventArgs e)
            => DrawDarkTab(e, (TabControl)sender);

        private void cmbContacto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            string dni = cmbContacto.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(dni)) return;

            clsConexion cx = new clsConexion();
            PersonalInfo p = cx.ObtenerPersonalPorDNI(dni);
            if (p == null) return;

            // Datos básicos
            txtdni.Text = p.DNI;
            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;

            // Provincia
            int idxProv = cmbProv.Items.IndexOf(p.Provincia);
            if (idxProv >= 0)
                cmbProv.SelectedIndex = idxProv;
            else
            {
                cmbProv.SelectedIndex = -1;
                // Si la provincia no estaba en la lista, forzar carga de localidad igual
                cmbLoc.Items.Clear();
            }

            // Localidad (puede que cmbProv_SelectedIndexChanged ya la haya cargado si es Córdoba)
            int idxLoc = cmbLoc.Items.IndexOf(p.Localidad);
            if (idxLoc >= 0)
                cmbLoc.SelectedIndex = idxLoc;
            else
                cmbLoc.SelectedIndex = -1;

            // Resto de campos
            txtDireccion.Text = p.Direccion;
            txtGeo.Text = p.Geo;
            txtMail.Text = p.Mail;
            txtTelefono.Text = p.Telefono;

            // Red social
            int idxRed = cmbRedes.Items.IndexOf(p.Redes);
            cmbRedes.SelectedIndex = idxRed >= 0 ? idxRed : -1;

            // Navegar al tab de Datos Personales para que el usuario vea todo
            tcDatos.SelectedTab = tpDatosPersonales;

            // Cargar TODOS los domicilios y redes guardados (si existen)
            var domicilios = cx.ObtenerDomicilios(dni);
            if (domicilios.Count > 0) CargarDomiciliosUI(domicilios);

            var redes = cx.ObtenerRedes(dni);
            if (redes.Count > 0) CargarRedesUI(redes);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cmbContacto.Enabled = true;
            btnEliminar.Visible = true;
            txtNombre.Enabled = true;
            lblNombre.Enabled = true;
            txtApellido.Enabled = true;
            lblApellido.Enabled = true;
            lblDNI.Enabled = true;
            txtdni.Enabled = true;
            tcDatos.Enabled = true;
        }
        private Control BuscarPorPrefijo(Control contenedor, string prefijo)
        {
            return contenedor.Controls.Cast<Control>()
                .FirstOrDefault(c => c.Name != null && c.Name.StartsWith(prefijo));
        }

        private void SetComboValor(ComboBox cmb, string valor)
        {
            if (cmb == null) return;
            if (string.IsNullOrEmpty(valor)) { cmb.SelectedIndex = -1; return; }
            int idx = cmb.Items.IndexOf(valor);
            if (idx < 0) { cmb.Items.Add(valor); idx = cmb.Items.IndexOf(valor); }
            cmb.SelectedIndex = idx;
        }

        private string ComboVal(ComboBox cmb)
            => cmb?.SelectedItem?.ToString() ?? cmb?.Text?.Trim() ?? "";

        private List<DomicilioInfo> RecolectarDomicilios()
        {
            var lista = new List<DomicilioInfo>();

            lista.Add(new DomicilioInfo
            {
                Provincia = ComboVal(cmbProv),
                Localidad = ComboVal(cmbLoc),
                Direccion = txtDireccion.Text.Trim(),
                Geo = txtGeo.Text.Trim(),
                Tipo = ComboVal(cmbTipo)
            });

            foreach (TabPage tp in tpDomicilio.TabPages)
            {
                if (tp == tpDom1 || tp == tpdpus) continue;

                var prov = BuscarPorPrefijo(tp, "cmbProv_") as ComboBox;
                var loc = BuscarPorPrefijo(tp, "cmbLoc_") as ComboBox;
                var dir = BuscarPorPrefijo(tp, "txtDir_") as TextBox;
                var geo = BuscarPorPrefijo(tp, "txtGeo_") as TextBox;
                var tipo = BuscarPorPrefijo(tp, "cmbTipo_") as ComboBox;

                var d = new DomicilioInfo
                {
                    Provincia = ComboVal(prov),
                    Localidad = ComboVal(loc),
                    Direccion = dir?.Text.Trim() ?? "",
                    Geo = geo?.Text.Trim() ?? "",
                    Tipo = ComboVal(tipo)
                };

                if (string.IsNullOrWhiteSpace(d.Provincia) &&
                    string.IsNullOrWhiteSpace(d.Direccion)) continue;

                lista.Add(d);
            }
            return lista;
        }

        private List<RedInfo> RecolectarRedes()
        {
            var lista = new List<RedInfo>();

            string redPri = ComboVal(cmbRedes);
            string usrPri = textBox1.Text.Trim();
            string urlPri = txturl.Text.Trim();
            if (!string.IsNullOrWhiteSpace(redPri) ||
                !string.IsNullOrWhiteSpace(usrPri) ||
                !string.IsNullOrWhiteSpace(urlPri))
            {
                lista.Add(new RedInfo { Red = redPri, Usuario = usrPri, Url = urlPri });
            }

            foreach (TabPage tp in tcRedes.TabPages)
            {
                if (tp == tpRed1 || tp == tpplus) continue;

                var red = BuscarPorPrefijo(tp, "cmbRedes_") as ComboBox;
                var usr = BuscarPorPrefijo(tp, "txtUsuarioRed_") as TextBox;
                var url = BuscarPorPrefijo(tp, "txtUrl_") as TextBox;

                var r = new RedInfo
                {
                    Red = ComboVal(red),
                    Usuario = usr?.Text.Trim() ?? "",
                    Url = url?.Text.Trim() ?? ""
                };

                if (string.IsNullOrWhiteSpace(r.Red) &&
                    string.IsNullOrWhiteSpace(r.Usuario) &&
                    string.IsNullOrWhiteSpace(r.Url)) continue;

                lista.Add(r);
            }
            return lista;
        }

        private void CargarDomiciliosUI(List<DomicilioInfo> domicilios)
        {
            var aEliminar = new List<TabPage>();
            foreach (TabPage tp in tpDomicilio.TabPages)
                if (tp != tpDom1 && tp != tpdpus) aEliminar.Add(tp);
            foreach (TabPage tp in aEliminar) tpDomicilio.TabPages.Remove(tp);
            _contadorDoms = 1;

            if (domicilios == null || domicilios.Count == 0) return;

            var d0 = domicilios[0];
            SetComboValor(cmbProv, d0.Provincia);
            SetComboValor(cmbLoc, d0.Localidad);
            txtDireccion.Text = d0.Direccion;
            txtGeo.Text = d0.Geo;
            SetComboValor(cmbTipo, d0.Tipo);

            for (int i = 1; i < domicilios.Count; i++)
            {
                var d = domicilios[i];
                TabPage t = CrearTabDom();

                var prov = BuscarPorPrefijo(t, "cmbProv_") as ComboBox;
                var loc = BuscarPorPrefijo(t, "cmbLoc_") as ComboBox;
                var dir = BuscarPorPrefijo(t, "txtDir_") as TextBox;
                var geo = BuscarPorPrefijo(t, "txtGeo_") as TextBox;
                var tipo = BuscarPorPrefijo(t, "cmbTipo_") as ComboBox;

                SetComboValor(prov, d.Provincia);
                SetComboValor(loc, d.Localidad);
                if (dir != null) dir.Text = d.Direccion;
                if (geo != null) geo.Text = d.Geo;
                SetComboValor(tipo, d.Tipo);
            }

            tpDomicilio.SelectedTab = tpDom1;
        }

        private void CargarRedesUI(List<RedInfo> redes)
        {
            var aEliminar = new List<TabPage>();
            foreach (TabPage tp in tcRedes.TabPages)
                if (tp != tpRed1 && tp != tpplus) aEliminar.Add(tp);
            foreach (TabPage tp in aEliminar) tcRedes.TabPages.Remove(tp);
            _contadorRedes = 1;

            if (redes == null || redes.Count == 0) return;

            var r0 = redes[0];
            SetComboValor(cmbRedes, r0.Red);
            textBox1.Text = r0.Usuario;
            txturl.Text = r0.Url;

            for (int i = 1; i < redes.Count; i++)
            {
                var r = redes[i];
                TabPage t = CrearTabRed();

                var red = BuscarPorPrefijo(t, "cmbRedes_") as ComboBox;
                var usr = BuscarPorPrefijo(t, "txtUsuarioRed_") as TextBox;
                var url = BuscarPorPrefijo(t, "txtUrl_") as TextBox;

                SetComboValor(red, r.Red);
                if (usr != null) usr.Text = r.Usuario;
                if (url != null) url.Text = r.Url;
            }

            tcRedes.SelectedTab = tpRed1;
        }
    }
}

