namespace pryMolinaERP
{
    partial class frmPersonal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal));

            this.tbcADM            = new System.Windows.Forms.TabControl();
            this.tbpUsuario        = new System.Windows.Forms.TabPage();
            this.tbpAuditoria      = new System.Windows.Forms.TabPage();
            this.pnlToolbar        = new System.Windows.Forms.Panel();
            this.btnNuevo          = new System.Windows.Forms.Button();
            this.btnEditar         = new System.Windows.Forms.Button();
            this.btnEliminar       = new System.Windows.Forms.Button();
            this.lblContactoLbl    = new System.Windows.Forms.Label();
            this.cmbContacto       = new System.Windows.Forms.ComboBox();
            this.pnlIdentidad      = new System.Windows.Forms.Panel();
            this.lblDNI            = new System.Windows.Forms.Label();
            this.txtdni            = new System.Windows.Forms.TextBox();
            this.lblNombre         = new System.Windows.Forms.Label();
            this.txtNombre         = new System.Windows.Forms.TextBox();
            this.lblApellido       = new System.Windows.Forms.Label();
            this.txtApellido       = new System.Windows.Forms.TextBox();
            this.tcDatos           = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.tpDom             = new System.Windows.Forms.TabPage();
            this.gpbContacto       = new System.Windows.Forms.GroupBox();
            this.lblMail           = new System.Windows.Forms.Label();
            this.txtMail           = new System.Windows.Forms.TextBox();
            this.lblTelefono       = new System.Windows.Forms.Label();
            this.txtTelefono       = new System.Windows.Forms.TextBox();
            this.gpbRedSocial      = new System.Windows.Forms.GroupBox();
            this.tcRedes           = new System.Windows.Forms.TabControl();
            this.tpRed1            = new System.Windows.Forms.TabPage();
            this.lblred            = new System.Windows.Forms.Label();
            this.cmbRedes          = new System.Windows.Forms.ComboBox();
            this.lblUsuario        = new System.Windows.Forms.Label();
            this.textBox1          = new System.Windows.Forms.TextBox();
            this.lblurl            = new System.Windows.Forms.Label();
            this.txturl            = new System.Windows.Forms.TextBox();
            this.tpplus            = new System.Windows.Forms.TabPage();
            this.btnEliminarR      = new System.Windows.Forms.Button();
            this.tpDomicilio       = new System.Windows.Forms.TabControl();
            this.tpDom1            = new System.Windows.Forms.TabPage();
            this.lblProv           = new System.Windows.Forms.Label();
            this.cmbProv           = new System.Windows.Forms.ComboBox();
            this.lbllocalidad      = new System.Windows.Forms.Label();
            this.cmbLoc            = new System.Windows.Forms.ComboBox();
            this.lblDireccion      = new System.Windows.Forms.Label();
            this.txtDireccion      = new System.Windows.Forms.TextBox();
            this.lblGeo            = new System.Windows.Forms.Label();
            this.txtGeo            = new System.Windows.Forms.TextBox();
            this.lblTipo           = new System.Windows.Forms.Label();
            this.cmbTipo           = new System.Windows.Forms.ComboBox();
            this.tpdpus            = new System.Windows.Forms.TabPage();
            this.btnGuardar        = new System.Windows.Forms.Button();
            this.statusStrip1      = new System.Windows.Forms.StatusStrip();
            this.lblEstadoBD       = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlFiltros        = new System.Windows.Forms.Panel();
            this.lblFiltroUsuario  = new System.Windows.Forms.Label();
            this.txtFiltroUsuario  = new System.Windows.Forms.TextBox();
            this.lblFiltroAccion   = new System.Windows.Forms.Label();
            this.cmbFiltroAccion   = new System.Windows.Forms.ComboBox();
            this.chkFiltroFecha    = new System.Windows.Forms.CheckBox();
            this.lblDesde          = new System.Windows.Forms.Label();
            this.dtpDesde          = new System.Windows.Forms.DateTimePicker();
            this.lblHasta          = new System.Windows.Forms.Label();
            this.dtpHasta          = new System.Windows.Forms.DateTimePicker();
            this.btnFlitrar           = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro     = new System.Windows.Forms.Button();
            this.dgvAuditoria         = new System.Windows.Forms.DataGridView();
            this.lblTotalRegistros    = new System.Windows.Forms.Label();
            this.btnDesactivarUsuario = new System.Windows.Forms.Button();

            this.tbcADM.SuspendLayout();
            this.tbpUsuario.SuspendLayout();
            this.tbpAuditoria.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.pnlIdentidad.SuspendLayout();
            this.tcDatos.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            this.tpDom.SuspendLayout();
            this.gpbContacto.SuspendLayout();
            this.gpbRedSocial.SuspendLayout();
            this.tcRedes.SuspendLayout();
            this.tpRed1.SuspendLayout();
            this.tpDomicilio.SuspendLayout();
            this.tpDom1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();

            // ── Paleta light ─────────────────────────────────────────────────
            var BG_PAGE    = System.Drawing.Color.FromArgb(248, 249, 250);
            var BG_WHITE   = System.Drawing.Color.White;
            var BG_PANEL   = System.Drawing.Color.FromArgb(241, 245, 249);
            var BG_HEADER  = System.Drawing.Color.FromArgb(37, 99, 235);
            var ACCENT     = System.Drawing.Color.FromArgb(37, 99, 235);
            var ACCENT_LT  = System.Drawing.Color.FromArgb(219, 234, 254);
            var TEXT_PRI   = System.Drawing.Color.FromArgb(30, 41, 59);
            var TEXT_SEC   = System.Drawing.Color.FromArgb(100, 116, 139);
            var DANGER     = System.Drawing.Color.FromArgb(220, 38, 38);
            var DANGER_LT  = System.Drawing.Color.FromArgb(254, 226, 226);
            var BTN_GHOST  = System.Drawing.Color.FromArgb(226, 232, 240);
            var BORDER     = System.Drawing.Color.FromArgb(203, 213, 225);
            var BTN_NEW    = System.Drawing.Color.FromArgb(239, 246, 255);
            var SUCCESS    = System.Drawing.Color.FromArgb(5, 150, 105);
            var ROW_ALT    = System.Drawing.Color.FromArgb(241, 245, 249);

            var fontBase  = new System.Drawing.Font("Segoe UI", 9F);
            var fontBold  = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            var fontSmall = new System.Drawing.Font("Segoe UI", 8.5F);
            var fontSmallBold = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            var fontInput = new System.Drawing.Font("Segoe UI", 9.5F);

            // ════════════════════════════════════════════════════════════════
            // TAB CONTROL PRINCIPAL
            // ════════════════════════════════════════════════════════════════
            this.tbcADM.Controls.Add(this.tbpUsuario);
            this.tbcADM.Controls.Add(this.tbpAuditoria);
            this.tbcADM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcADM.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbcADM.Font = fontBase;
            this.tbcADM.ItemSize = new System.Drawing.Size(120, 32);
            this.tbcADM.Name = "tbcADM";
            this.tbcADM.SelectedIndex = 0;
            this.tbcADM.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcADM.TabIndex = 10;
            this.tbcADM.SelectedIndexChanged += new System.EventHandler(this.tbcADM_SelectedIndexChanged_1);
            this.tbcADM.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbcADM_DrawItem);

            // ── tbpUsuario ───────────────────────────────────────────────────
            this.tbpUsuario.BackColor = BG_PAGE;
            this.tbpUsuario.Controls.Add(this.btnGuardar);
            this.tbpUsuario.Controls.Add(this.tcDatos);
            this.tbpUsuario.Controls.Add(this.pnlIdentidad);
            this.tbpUsuario.Controls.Add(this.pnlToolbar);
            this.tbpUsuario.Controls.Add(this.statusStrip1);
            this.tbpUsuario.Name = "tbpUsuario";
            this.tbpUsuario.Padding = new System.Windows.Forms.Padding(12);
            this.tbpUsuario.TabIndex = 0;
            this.tbpUsuario.Text = "Personal";

            // ── Toolbar ──────────────────────────────────────────────────────
            this.pnlToolbar.BackColor = BG_WHITE;
            this.pnlToolbar.Controls.Add(this.btnNuevo);
            this.pnlToolbar.Controls.Add(this.btnEditar);
            this.pnlToolbar.Controls.Add(this.btnEliminar);
            this.pnlToolbar.Controls.Add(this.lblContactoLbl);
            this.pnlToolbar.Controls.Add(this.cmbContacto);
            this.pnlToolbar.Location = new System.Drawing.Point(12, 12);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(816, 56);
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);

            this.btnNuevo.BackColor = ACCENT;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = fontBold;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(8, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 34);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "+ Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            this.btnEditar.BackColor = BTN_GHOST;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = fontBase;
            this.btnEditar.ForeColor = TEXT_PRI;
            this.btnEditar.Location = new System.Drawing.Point(136, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 34);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar contacto";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnEliminar.BackColor = DANGER_LT;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = fontBase;
            this.btnEliminar.ForeColor = DANGER;
            this.btnEliminar.Location = new System.Drawing.Point(264, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.lblContactoLbl.AutoSize = true;
            this.lblContactoLbl.Font = fontSmall;
            this.lblContactoLbl.ForeColor = TEXT_SEC;
            this.lblContactoLbl.Location = new System.Drawing.Point(520, 18);
            this.lblContactoLbl.Name = "lblContactoLbl";
            this.lblContactoLbl.Text = "Buscar por DNI:";

            this.cmbContacto.BackColor = BG_WHITE;
            this.cmbContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbContacto.Font = fontInput;
            this.cmbContacto.ForeColor = TEXT_PRI;
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.Location = new System.Drawing.Point(630, 13);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.Size = new System.Drawing.Size(174, 26);
            this.cmbContacto.TabIndex = 13;
            this.cmbContacto.SelectedIndexChanged += new System.EventHandler(this.cmbContacto_SelectedIndexChanged_1);

            // ── Identidad ────────────────────────────────────────────────────
            this.pnlIdentidad.BackColor = BG_WHITE;
            this.pnlIdentidad.Controls.Add(this.lblDNI);
            this.pnlIdentidad.Controls.Add(this.txtdni);
            this.pnlIdentidad.Controls.Add(this.lblNombre);
            this.pnlIdentidad.Controls.Add(this.txtNombre);
            this.pnlIdentidad.Controls.Add(this.lblApellido);
            this.pnlIdentidad.Controls.Add(this.txtApellido);
            this.pnlIdentidad.Location = new System.Drawing.Point(12, 76);
            this.pnlIdentidad.Name = "pnlIdentidad";
            this.pnlIdentidad.Size = new System.Drawing.Size(816, 60);
            this.pnlIdentidad.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            this.lblDNI.AutoSize = true;
            this.lblDNI.Enabled = false;
            this.lblDNI.Font = fontSmallBold;
            this.lblDNI.ForeColor = TEXT_SEC;
            this.lblDNI.Location = new System.Drawing.Point(12, 10);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Text = "DNI";

            this.txtdni.BackColor = BG_WHITE;
            this.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdni.Enabled = false;
            this.txtdni.Font = fontInput;
            this.txtdni.ForeColor = TEXT_PRI;
            this.txtdni.Location = new System.Drawing.Point(12, 26);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(140, 26);
            this.txtdni.TabIndex = 4;

            this.lblNombre.AutoSize = true;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = fontSmallBold;
            this.lblNombre.ForeColor = TEXT_SEC;
            this.lblNombre.Location = new System.Drawing.Point(170, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Text = "NOMBRE";

            this.txtNombre.BackColor = BG_WHITE;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = fontInput;
            this.txtNombre.ForeColor = TEXT_PRI;
            this.txtNombre.Location = new System.Drawing.Point(170, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 26);
            this.txtNombre.TabIndex = 5;

            this.lblApellido.AutoSize = true;
            this.lblApellido.Enabled = false;
            this.lblApellido.Font = fontSmallBold;
            this.lblApellido.ForeColor = TEXT_SEC;
            this.lblApellido.Location = new System.Drawing.Point(408, 10);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Text = "APELLIDO";

            this.txtApellido.BackColor = BG_WHITE;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = fontInput;
            this.txtApellido.ForeColor = TEXT_PRI;
            this.txtApellido.Location = new System.Drawing.Point(408, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 26);
            this.txtApellido.TabIndex = 6;

            // ── tcDatos ───────────────────────────────────────────────────────
            this.tcDatos.Controls.Add(this.tpDom);
            this.tcDatos.Controls.Add(this.tpDatosPersonales);
            this.tcDatos.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcDatos.Enabled = false;
            this.tcDatos.Font = fontBase;
            this.tcDatos.ItemSize = new System.Drawing.Size(150, 28);
            this.tcDatos.Location = new System.Drawing.Point(12, 144);
            this.tcDatos.Name = "tcDatos";
            this.tcDatos.SelectedIndex = 0;
            this.tcDatos.Size = new System.Drawing.Size(816, 360);
            this.tcDatos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcDatos.TabIndex = 10;
            this.tcDatos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcDatos_DrawItem);

            // ── tpDom ─────────────────────────────────────────────────────────
            this.tpDom.BackColor = BG_PAGE;
            this.tpDom.Controls.Add(this.tpDomicilio);
            this.tpDom.Name = "tpDom";
            this.tpDom.Padding = new System.Windows.Forms.Padding(8);
            this.tpDom.TabIndex = 1;
            this.tpDom.Text = "Domicilio";

            this.tpDomicilio.Controls.Add(this.tpDom1);
            this.tpDomicilio.Controls.Add(this.tpdpus);
            this.tpDomicilio.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tpDomicilio.Font = fontBase;
            this.tpDomicilio.ItemSize = new System.Drawing.Size(100, 26);
            this.tpDomicilio.Location = new System.Drawing.Point(8, 8);
            this.tpDomicilio.Name = "tpDomicilio";
            this.tpDomicilio.SelectedIndex = 0;
            this.tpDomicilio.Size = new System.Drawing.Size(790, 308);
            this.tpDomicilio.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tpDomicilio.TabIndex = 22;
            this.tpDomicilio.SelectedIndexChanged += new System.EventHandler(this.tpDomicilio_SelectedIndexChanged);
            this.tpDomicilio.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tpDomicilio_DrawItem);

            this.tpDom1.BackColor = BG_PAGE;
            this.tpDom1.Controls.Add(this.lblProv);
            this.tpDom1.Controls.Add(this.cmbProv);
            this.tpDom1.Controls.Add(this.lbllocalidad);
            this.tpDom1.Controls.Add(this.cmbLoc);
            this.tpDom1.Controls.Add(this.lblDireccion);
            this.tpDom1.Controls.Add(this.txtDireccion);
            this.tpDom1.Controls.Add(this.lblGeo);
            this.tpDom1.Controls.Add(this.txtGeo);
            this.tpDom1.Controls.Add(this.lblTipo);
            this.tpDom1.Controls.Add(this.cmbTipo);
            this.tpDom1.Name = "tpDom1";
            this.tpDom1.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.tpDom1.TabIndex = 0;
            this.tpDom1.Text = "Dom 1";

            this.lblProv.AutoSize = true;
            this.lblProv.Font = fontSmallBold;
            this.lblProv.ForeColor = TEXT_SEC;
            this.lblProv.Location = new System.Drawing.Point(16, 24);
            this.lblProv.Name = "lblProv";
            this.lblProv.Text = "PROVINCIA";

            this.cmbProv.BackColor = BG_WHITE;
            this.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProv.Font = fontInput;
            this.cmbProv.ForeColor = TEXT_PRI;
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(16, 44);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(180, 26);
            this.cmbProv.TabIndex = 20;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);

            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Font = fontSmallBold;
            this.lbllocalidad.ForeColor = TEXT_SEC;
            this.lbllocalidad.Location = new System.Drawing.Point(210, 24);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Text = "LOCALIDAD";

            this.cmbLoc.BackColor = BG_WHITE;
            this.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoc.Font = fontInput;
            this.cmbLoc.ForeColor = TEXT_PRI;
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(210, 44);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(180, 26);
            this.cmbLoc.TabIndex = 21;

            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = fontSmallBold;
            this.lblDireccion.ForeColor = TEXT_SEC;
            this.lblDireccion.Location = new System.Drawing.Point(16, 86);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Text = "DIRECCIÓN";

            this.txtDireccion.BackColor = BG_WHITE;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = fontInput;
            this.txtDireccion.ForeColor = TEXT_PRI;
            this.txtDireccion.Location = new System.Drawing.Point(16, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(374, 26);
            this.txtDireccion.TabIndex = 19;

            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = fontSmallBold;
            this.lblGeo.ForeColor = TEXT_SEC;
            this.lblGeo.Location = new System.Drawing.Point(16, 148);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Text = "COORDENADAS (GEO)";

            this.txtGeo.BackColor = BG_WHITE;
            this.txtGeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeo.Font = fontInput;
            this.txtGeo.ForeColor = TEXT_PRI;
            this.txtGeo.Location = new System.Drawing.Point(16, 168);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(374, 26);
            this.txtGeo.TabIndex = 18;

            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = fontSmallBold;
            this.lblTipo.ForeColor = TEXT_SEC;
            this.lblTipo.Location = new System.Drawing.Point(410, 24);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Text = "TIPO DE DOMICILIO";

            this.cmbTipo.BackColor = BG_WHITE;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = fontInput;
            this.cmbTipo.ForeColor = TEXT_PRI;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] { "Pricipal", "Laboral", "Alternatibo", "Fiscal" });
            this.cmbTipo.Location = new System.Drawing.Point(410, 44);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(160, 26);
            this.cmbTipo.TabIndex = 23;

            this.tpdpus.BackColor = BG_PAGE;
            this.tpdpus.Name = "tpdpus";
            this.tpdpus.Padding = new System.Windows.Forms.Padding(3);
            this.tpdpus.TabIndex = 1;
            this.tpdpus.Text = "+";

            // ── tpDatosPersonales ─────────────────────────────────────────────
            this.tpDatosPersonales.BackColor = BG_PAGE;
            this.tpDatosPersonales.Controls.Add(this.gpbContacto);
            this.tpDatosPersonales.Controls.Add(this.gpbRedSocial);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(8);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Contacto";

            this.gpbContacto.BackColor = BG_WHITE;
            this.gpbContacto.Controls.Add(this.lblMail);
            this.gpbContacto.Controls.Add(this.txtMail);
            this.gpbContacto.Controls.Add(this.lblTelefono);
            this.gpbContacto.Controls.Add(this.txtTelefono);
            this.gpbContacto.Font = fontBold;
            this.gpbContacto.ForeColor = TEXT_SEC;
            this.gpbContacto.Location = new System.Drawing.Point(12, 12);
            this.gpbContacto.Name = "gpbContacto";
            this.gpbContacto.Size = new System.Drawing.Size(760, 80);
            this.gpbContacto.TabStop = false;
            this.gpbContacto.Text = "Contacto";

            this.lblMail.AutoSize = true;
            this.lblMail.Font = fontSmallBold;
            this.lblMail.ForeColor = TEXT_SEC;
            this.lblMail.Location = new System.Drawing.Point(16, 22);
            this.lblMail.Name = "lblMail";
            this.lblMail.Text = "EMAIL";

            this.txtMail.BackColor = BG_WHITE;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = fontInput;
            this.txtMail.ForeColor = TEXT_PRI;
            this.txtMail.Location = new System.Drawing.Point(16, 40);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 26);
            this.txtMail.TabIndex = 5;

            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = fontSmallBold;
            this.lblTelefono.ForeColor = TEXT_SEC;
            this.lblTelefono.Location = new System.Drawing.Point(320, 22);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Text = "TELÉFONO";

            this.txtTelefono.BackColor = BG_WHITE;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = fontInput;
            this.txtTelefono.ForeColor = TEXT_PRI;
            this.txtTelefono.Location = new System.Drawing.Point(320, 40);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 26);
            this.txtTelefono.TabIndex = 4;

            this.gpbRedSocial.BackColor = BG_WHITE;
            this.gpbRedSocial.Controls.Add(this.tcRedes);
            this.gpbRedSocial.Controls.Add(this.btnEliminarR);
            this.gpbRedSocial.Font = fontBold;
            this.gpbRedSocial.ForeColor = TEXT_SEC;
            this.gpbRedSocial.Location = new System.Drawing.Point(12, 104);
            this.gpbRedSocial.Name = "gpbRedSocial";
            this.gpbRedSocial.Size = new System.Drawing.Size(760, 210);
            this.gpbRedSocial.TabStop = false;
            this.gpbRedSocial.Text = "Redes Sociales";

            this.tcRedes.Controls.Add(this.tpRed1);
            this.tcRedes.Controls.Add(this.tpplus);
            this.tcRedes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcRedes.Font = fontBase;
            this.tcRedes.ItemSize = new System.Drawing.Size(80, 24);
            this.tcRedes.Location = new System.Drawing.Point(8, 22);
            this.tcRedes.Name = "tcRedes";
            this.tcRedes.SelectedIndex = 0;
            this.tcRedes.Size = new System.Drawing.Size(744, 148);
            this.tcRedes.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcRedes.TabIndex = 0;
            this.tcRedes.SelectedIndexChanged += new System.EventHandler(this.tcRedes_SelectedIndexChanged);
            this.tcRedes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcRedes_DrawItem);

            this.tpRed1.BackColor = BG_PAGE;
            this.tpRed1.Controls.Add(this.lblred);
            this.tpRed1.Controls.Add(this.cmbRedes);
            this.tpRed1.Controls.Add(this.lblUsuario);
            this.tpRed1.Controls.Add(this.textBox1);
            this.tpRed1.Controls.Add(this.lblurl);
            this.tpRed1.Controls.Add(this.txturl);
            this.tpRed1.Name = "tpRed1";
            this.tpRed1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.tpRed1.TabIndex = 0;
            this.tpRed1.Text = "Red 1";

            this.lblred.AutoSize = true;
            this.lblred.Font = fontSmallBold;
            this.lblred.ForeColor = TEXT_SEC;
            this.lblred.Location = new System.Drawing.Point(12, 14);
            this.lblred.Name = "lblred";
            this.lblred.Text = "RED";

            this.cmbRedes.BackColor = BG_WHITE;
            this.cmbRedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRedes.Font = fontInput;
            this.cmbRedes.ForeColor = TEXT_PRI;
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Location = new System.Drawing.Point(60, 10);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(170, 26);
            this.cmbRedes.TabIndex = 3;

            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = fontSmallBold;
            this.lblUsuario.ForeColor = TEXT_SEC;
            this.lblUsuario.Location = new System.Drawing.Point(250, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Text = "USUARIO";

            this.textBox1.BackColor = BG_WHITE;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = fontInput;
            this.textBox1.ForeColor = TEXT_PRI;
            this.textBox1.Location = new System.Drawing.Point(316, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 5;

            this.lblurl.AutoSize = true;
            this.lblurl.Font = fontSmallBold;
            this.lblurl.ForeColor = TEXT_SEC;
            this.lblurl.Location = new System.Drawing.Point(12, 54);
            this.lblurl.Name = "lblurl";
            this.lblurl.Text = "URL";

            this.txturl.BackColor = BG_WHITE;
            this.txturl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txturl.Font = fontInput;
            this.txturl.ForeColor = TEXT_PRI;
            this.txturl.Location = new System.Drawing.Point(60, 50);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(456, 26);
            this.txturl.TabIndex = 7;

            this.tpplus.BackColor = BG_PAGE;
            this.tpplus.Name = "tpplus";
            this.tpplus.Padding = new System.Windows.Forms.Padding(3);
            this.tpplus.TabIndex = 1;
            this.tpplus.Text = "+";

            this.btnEliminarR.BackColor = DANGER_LT;
            this.btnEliminarR.FlatAppearance.BorderSize = 0;
            this.btnEliminarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarR.Font = fontSmall;
            this.btnEliminarR.ForeColor = DANGER;
            this.btnEliminarR.Location = new System.Drawing.Point(8, 174);
            this.btnEliminarR.Name = "btnEliminarR";
            this.btnEliminarR.Size = new System.Drawing.Size(110, 28);
            this.btnEliminarR.TabIndex = 1;
            this.btnEliminarR.Text = "Eliminar red";
            this.btnEliminarR.UseVisualStyleBackColor = false;
            this.btnEliminarR.Click += new System.EventHandler(this.btnEliminarR_Click);

            // ── btnGuardar ───────────────────────────────────────────────────
            this.btnGuardar.BackColor = ACCENT;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = fontBold;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(688, 512);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ── statusStrip1 ──────────────────────────────────────────────────
            this.statusStrip1.BackColor = BG_WHITE;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblEstadoBD });
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(840, 24);
            this.statusStrip1.TabIndex = 11;

            this.lblEstadoBD.Font = fontSmall;
            this.lblEstadoBD.ForeColor = TEXT_SEC;
            this.lblEstadoBD.Name = "lblEstadoBD";
            this.lblEstadoBD.Text = "  ●  Verificando conexión...";

            // ════════════════════════════════════════════════════════════════
            // TAB AUDITORÍA
            // ════════════════════════════════════════════════════════════════
            this.tbpAuditoria.BackColor = BG_PAGE;
            this.tbpAuditoria.Controls.Add(this.lblTotalRegistros);
            this.tbpAuditoria.Controls.Add(this.btnDesactivarUsuario);
            this.tbpAuditoria.Controls.Add(this.dgvAuditoria);
            this.tbpAuditoria.Controls.Add(this.pnlFiltros);
            this.tbpAuditoria.Name = "tbpAuditoria";
            this.tbpAuditoria.Padding = new System.Windows.Forms.Padding(10);
            this.tbpAuditoria.TabIndex = 1;
            this.tbpAuditoria.Text = "Auditoría";

            this.pnlFiltros.BackColor = BG_WHITE;
            this.pnlFiltros.Controls.Add(this.lblFiltroUsuario);
            this.pnlFiltros.Controls.Add(this.txtFiltroUsuario);
            this.pnlFiltros.Controls.Add(this.lblFiltroAccion);
            this.pnlFiltros.Controls.Add(this.cmbFiltroAccion);
            this.pnlFiltros.Controls.Add(this.chkFiltroFecha);
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.btnFlitrar);
            this.pnlFiltros.Controls.Add(this.btnLimpiarFiltro);
            this.pnlFiltros.Location = new System.Drawing.Point(10, 10);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(820, 52);
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);

            this.lblFiltroUsuario.AutoSize = true;
            this.lblFiltroUsuario.Font = fontSmallBold;
            this.lblFiltroUsuario.ForeColor = TEXT_SEC;
            this.lblFiltroUsuario.Location = new System.Drawing.Point(10, 14);
            this.lblFiltroUsuario.Name = "lblFiltroUsuario";
            this.lblFiltroUsuario.Text = "Usuario:";

            this.txtFiltroUsuario.BackColor = BG_WHITE;
            this.txtFiltroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroUsuario.Font = fontBase;
            this.txtFiltroUsuario.ForeColor = TEXT_PRI;
            this.txtFiltroUsuario.Location = new System.Drawing.Point(70, 11);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtFiltroUsuario.TabIndex = 2;

            this.lblFiltroAccion.AutoSize = true;
            this.lblFiltroAccion.Font = fontSmallBold;
            this.lblFiltroAccion.ForeColor = TEXT_SEC;
            this.lblFiltroAccion.Location = new System.Drawing.Point(182, 14);
            this.lblFiltroAccion.Name = "lblFiltroAccion";
            this.lblFiltroAccion.Text = "Acción:";

            this.cmbFiltroAccion.BackColor = BG_WHITE;
            this.cmbFiltroAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroAccion.Font = fontBase;
            this.cmbFiltroAccion.ForeColor = TEXT_PRI;
            this.cmbFiltroAccion.FormattingEnabled = true;
            this.cmbFiltroAccion.Location = new System.Drawing.Point(234, 11);
            this.cmbFiltroAccion.Name = "cmbFiltroAccion";
            this.cmbFiltroAccion.Size = new System.Drawing.Size(140, 22);
            this.cmbFiltroAccion.TabIndex = 11;

            this.chkFiltroFecha.AutoSize = true;
            this.chkFiltroFecha.BackColor = BG_WHITE;
            this.chkFiltroFecha.Font = fontSmallBold;
            this.chkFiltroFecha.ForeColor = TEXT_SEC;
            this.chkFiltroFecha.Location = new System.Drawing.Point(388, 14);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Text = "Fecha:";
            this.chkFiltroFecha.UseVisualStyleBackColor = false;
            this.chkFiltroFecha.TextChanged += new System.EventHandler(this.chkFiltroFecha_TextChanged);

            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = fontSmallBold;
            this.lblDesde.ForeColor = TEXT_SEC;
            this.lblDesde.Location = new System.Drawing.Point(450, 14);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Text = "Desde:";

            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(500, 11);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(94, 22);
            this.dtpDesde.TabIndex = 5;

            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = fontSmallBold;
            this.lblHasta.ForeColor = TEXT_SEC;
            this.lblHasta.Location = new System.Drawing.Point(602, 14);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Text = "Hasta:";

            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(648, 11);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(94, 22);
            this.dtpHasta.TabIndex = 6;

            this.btnFlitrar.BackColor = ACCENT;
            this.btnFlitrar.FlatAppearance.BorderSize = 0;
            this.btnFlitrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlitrar.Font = fontBold;
            this.btnFlitrar.ForeColor = System.Drawing.Color.White;
            this.btnFlitrar.Location = new System.Drawing.Point(752, 10);
            this.btnFlitrar.Name = "btnFlitrar";
            this.btnFlitrar.Size = new System.Drawing.Size(30, 24);
            this.btnFlitrar.TabIndex = 9;
            this.btnFlitrar.Text = "▶";
            this.btnFlitrar.UseVisualStyleBackColor = false;
            this.btnFlitrar.Click += new System.EventHandler(this.btnFlitrar_Click);

            this.btnLimpiarFiltro.BackColor = BTN_GHOST;
            this.btnLimpiarFiltro.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = fontSmall;
            this.btnLimpiarFiltro.ForeColor = TEXT_SEC;
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(784, 10);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(30, 24);
            this.btnLimpiarFiltro.TabIndex = 99;
            this.btnLimpiarFiltro.Text = "✕";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);

            // ── dgvAuditoria ──────────────────────────────────────────────────
            this.dgvAuditoria.BackgroundColor = BG_PAGE;
            this.dgvAuditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuditoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            var hdrStyle = new System.Windows.Forms.DataGridViewCellStyle();
            hdrStyle.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            hdrStyle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            hdrStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            hdrStyle.SelectionBackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            hdrStyle.SelectionForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.dgvAuditoria.ColumnHeadersDefaultCellStyle = hdrStyle;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAuditoria.ColumnHeadersHeight = 34;

            var cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvAuditoria.DefaultCellStyle = cellStyle;

            var altStyle = new System.Windows.Forms.DataGridViewCellStyle();
            altStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            altStyle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            altStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            altStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvAuditoria.AlternatingRowsDefaultCellStyle = altStyle;

            this.dgvAuditoria.AutoGenerateColumns = false;
            this.dgvAuditoria.ReadOnly = true;
            this.dgvAuditoria.AllowUserToAddRows = false;
            this.dgvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditoria.RowHeadersVisible = false;
            this.dgvAuditoria.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvAuditoria.EnableHeadersVisualStyles = false;
            this.dgvAuditoria.Location = new System.Drawing.Point(10, 70);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowTemplate.Height = 28;
            this.dgvAuditoria.Size = new System.Drawing.Size(820, 480);
            this.dgvAuditoria.TabIndex = 1;

            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Font = fontSmall;
            this.lblTotalRegistros.ForeColor = TEXT_SEC;
            this.lblTotalRegistros.Location = new System.Drawing.Point(10, 558);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Text = "Registros: —";

            this.btnDesactivarUsuario.BackColor = DANGER_LT;
            this.btnDesactivarUsuario.FlatAppearance.BorderSize = 0;
            this.btnDesactivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarUsuario.Font = fontSmallBold;
            this.btnDesactivarUsuario.ForeColor = DANGER;
            this.btnDesactivarUsuario.Location = new System.Drawing.Point(622, 553);
            this.btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            this.btnDesactivarUsuario.Size = new System.Drawing.Size(208, 28);
            this.btnDesactivarUsuario.TabIndex = 100;
            this.btnDesactivarUsuario.Text = "Desactivar usuario seleccionado";
            this.btnDesactivarUsuario.UseVisualStyleBackColor = false;
            this.btnDesactivarUsuario.Click += new System.EventHandler(this.btnDesactivarUsuario_Click);

            // ── frmPersonal ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = BG_PAGE;
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(this.tbcADM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Molina ERP — Administración";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonal_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonal_Load);

            this.tbcADM.ResumeLayout(false);
            this.tbpUsuario.ResumeLayout(false);
            this.tbpAuditoria.ResumeLayout(false);
            this.tbpAuditoria.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlIdentidad.ResumeLayout(false);
            this.pnlIdentidad.PerformLayout();
            this.tcDatos.ResumeLayout(false);
            this.tpDatosPersonales.ResumeLayout(false);
            this.tpDom.ResumeLayout(false);
            this.gpbContacto.ResumeLayout(false);
            this.gpbContacto.PerformLayout();
            this.gpbRedSocial.ResumeLayout(false);
            this.tcRedes.ResumeLayout(false);
            this.tpRed1.ResumeLayout(false);
            this.tpRed1.PerformLayout();
            this.tpDomicilio.ResumeLayout(false);
            this.tpDom1.ResumeLayout(false);
            this.tpDom1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tbcADM;
        private System.Windows.Forms.TabPage tbpUsuario;
        private System.Windows.Forms.TabPage tbpAuditoria;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblContactoLbl;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbContacto;
        private System.Windows.Forms.Panel pnlIdentidad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TabControl tcDatos;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.TabPage tpDom;
        private System.Windows.Forms.GroupBox gpbContacto;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox gpbRedSocial;
        private System.Windows.Forms.TabControl tcRedes;
        private System.Windows.Forms.TabPage tpRed1;
        private System.Windows.Forms.Label lblred;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TabPage tpplus;
        private System.Windows.Forms.Button btnEliminarR;
        private System.Windows.Forms.TabControl tpDomicilio;
        private System.Windows.Forms.TabPage tpDom1;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.Label lbllocalidad;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblGeo;
        private System.Windows.Forms.TextBox txtGeo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TabPage tpdpus;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoBD;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblFiltroUsuario;
        private System.Windows.Forms.TextBox txtFiltroUsuario;
        private System.Windows.Forms.Label lblFiltroAccion;
        private System.Windows.Forms.ComboBox cmbFiltroAccion;
        private System.Windows.Forms.CheckBox chkFiltroFecha;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFlitrar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Button btnDesactivarUsuario;
    }
}
