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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal));
            this.tbcADM = new System.Windows.Forms.TabControl();
            this.tbpUsuario = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tcDatos = new System.Windows.Forms.TabControl();
            this.tpDom = new System.Windows.Forms.TabPage();
            this.tpDomicilio = new System.Windows.Forms.TabControl();
            this.tpDom1 = new System.Windows.Forms.TabPage();
            this.lblProv = new System.Windows.Forms.Label();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblGeo = new System.Windows.Forms.Label();
            this.txtGeo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tpdpus = new System.Windows.Forms.TabPage();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.gpbContacto = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.gpbRedSocial = new System.Windows.Forms.GroupBox();
            this.tcRedes = new System.Windows.Forms.TabControl();
            this.tpRed1 = new System.Windows.Forms.TabPage();
            this.lblred = new System.Windows.Forms.Label();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuarioR = new System.Windows.Forms.TextBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.tpplus = new System.Windows.Forms.TabPage();
            this.btnEliminarR = new System.Windows.Forms.Button();
            this.pnlIdentidad = new System.Windows.Forms.Panel();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblContactoLbl = new System.Windows.Forms.Label();
            this.cmbContacto = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoBD = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbpAuditoria = new System.Windows.Forms.TabPage();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.btnDesactivarUsuario = new System.Windows.Forms.Button();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.lblFiltroUsuario = new System.Windows.Forms.Label();
            this.txtFiltroUsuario = new System.Windows.Forms.TextBox();
            this.lblFiltroAccion = new System.Windows.Forms.Label();
            this.cmbFiltroAccion = new System.Windows.Forms.ComboBox();
            this.chkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFlitrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.tbcADM.SuspendLayout();
            this.tbpUsuario.SuspendLayout();
            this.tcDatos.SuspendLayout();
            this.tpDom.SuspendLayout();
            this.tpDomicilio.SuspendLayout();
            this.tpDom1.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            this.gpbContacto.SuspendLayout();
            this.gpbRedSocial.SuspendLayout();
            this.tcRedes.SuspendLayout();
            this.tpRed1.SuspendLayout();
            this.pnlIdentidad.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tbpAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcADM
            // 
            this.tbcADM.Controls.Add(this.tbpUsuario);
            this.tbcADM.Controls.Add(this.tbpAuditoria);
            this.tbcADM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcADM.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbcADM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbcADM.ItemSize = new System.Drawing.Size(120, 32);
            this.tbcADM.Location = new System.Drawing.Point(0, 0);
            this.tbcADM.Name = "tbcADM";
            this.tbcADM.SelectedIndex = 0;
            this.tbcADM.Size = new System.Drawing.Size(860, 627);
            this.tbcADM.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcADM.TabIndex = 10;
            this.tbcADM.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tbcADM_DrawItem);
            this.tbcADM.SelectedIndexChanged += new System.EventHandler(this.tbcADM_SelectedIndexChanged_1);
            // 
            // tbpUsuario
            // 
            this.tbpUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tbpUsuario.Controls.Add(this.btnGuardar);
            this.tbpUsuario.Controls.Add(this.tcDatos);
            this.tbpUsuario.Controls.Add(this.pnlIdentidad);
            this.tbpUsuario.Controls.Add(this.pnlToolbar);
            this.tbpUsuario.Controls.Add(this.statusStrip1);
            this.tbpUsuario.Location = new System.Drawing.Point(4, 36);
            this.tbpUsuario.Name = "tbpUsuario";
            this.tbpUsuario.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.tbpUsuario.Size = new System.Drawing.Size(852, 569);
            this.tbpUsuario.TabIndex = 0;
            this.tbpUsuario.Text = "Personal";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(688, 512);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tcDatos
            // 
            this.tcDatos.Controls.Add(this.tpDom);
            this.tcDatos.Controls.Add(this.tpDatosPersonales);
            this.tcDatos.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcDatos.Enabled = false;
            this.tcDatos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tcDatos.ItemSize = new System.Drawing.Size(150, 28);
            this.tcDatos.Location = new System.Drawing.Point(12, 144);
            this.tcDatos.Name = "tcDatos";
            this.tcDatos.SelectedIndex = 0;
            this.tcDatos.Size = new System.Drawing.Size(816, 360);
            this.tcDatos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcDatos.TabIndex = 10;
            this.tcDatos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcDatos_DrawItem);
            // 
            // tpDom
            // 
            this.tpDom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tpDom.Controls.Add(this.tpDomicilio);
            this.tpDom.Location = new System.Drawing.Point(4, 32);
            this.tpDom.Name = "tpDom";
            this.tpDom.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tpDom.Size = new System.Drawing.Size(808, 324);
            this.tpDom.TabIndex = 1;
            this.tpDom.Text = "Domicilio";
            // 
            // tpDomicilio
            // 
            this.tpDomicilio.Controls.Add(this.tpDom1);
            this.tpDomicilio.Controls.Add(this.tpdpus);
            this.tpDomicilio.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tpDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpDomicilio.ItemSize = new System.Drawing.Size(100, 26);
            this.tpDomicilio.Location = new System.Drawing.Point(8, 8);
            this.tpDomicilio.Name = "tpDomicilio";
            this.tpDomicilio.SelectedIndex = 0;
            this.tpDomicilio.Size = new System.Drawing.Size(790, 308);
            this.tpDomicilio.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tpDomicilio.TabIndex = 22;
            this.tpDomicilio.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tpDomicilio_DrawItem);
            this.tpDomicilio.SelectedIndexChanged += new System.EventHandler(this.tpDomicilio_SelectedIndexChanged);
            // 
            // tpDom1
            // 
            this.tpDom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
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
            this.tpDom1.Location = new System.Drawing.Point(4, 30);
            this.tpDom1.Name = "tpDom1";
            this.tpDom1.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.tpDom1.Size = new System.Drawing.Size(782, 274);
            this.tpDom1.TabIndex = 0;
            this.tpDom1.Text = "Dom 1";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblProv.Location = new System.Drawing.Point(16, 24);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(71, 15);
            this.lblProv.TabIndex = 0;
            this.lblProv.Text = "PROVINCIA";
            // 
            // cmbProv
            // 
            this.cmbProv.BackColor = System.Drawing.Color.White;
            this.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProv.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(16, 44);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(180, 25);
            this.cmbProv.TabIndex = 20;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbllocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbllocalidad.Location = new System.Drawing.Point(210, 24);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(73, 15);
            this.lbllocalidad.TabIndex = 21;
            this.lbllocalidad.Text = "LOCALIDAD";
            // 
            // cmbLoc
            // 
            this.cmbLoc.BackColor = System.Drawing.Color.White;
            this.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(210, 44);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(180, 25);
            this.cmbLoc.TabIndex = 21;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDireccion.Location = new System.Drawing.Point(16, 86);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(70, 15);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtDireccion.Location = new System.Drawing.Point(16, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(374, 24);
            this.txtDireccion.TabIndex = 19;
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblGeo.Location = new System.Drawing.Point(16, 148);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(131, 15);
            this.lblGeo.TabIndex = 23;
            this.lblGeo.Text = "COORDENADAS (GEO)";
            // 
            // txtGeo
            // 
            this.txtGeo.BackColor = System.Drawing.Color.White;
            this.txtGeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGeo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtGeo.Location = new System.Drawing.Point(16, 168);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(374, 24);
            this.txtGeo.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTipo.Location = new System.Drawing.Point(410, 24);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(118, 15);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "TIPO DE DOMICILIO";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.White;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Pricipal",
            "Laboral",
            "Alternatibo",
            "Fiscal"});
            this.cmbTipo.Location = new System.Drawing.Point(410, 44);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(160, 25);
            this.cmbTipo.TabIndex = 23;
            // 
            // tpdpus
            // 
            this.tpdpus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tpdpus.Location = new System.Drawing.Point(4, 30);
            this.tpdpus.Name = "tpdpus";
            this.tpdpus.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpdpus.Size = new System.Drawing.Size(782, 274);
            this.tpdpus.TabIndex = 1;
            this.tpdpus.Text = "+";
            // 
            // tpDatosPersonales
            // 
            this.tpDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tpDatosPersonales.Controls.Add(this.gpbContacto);
            this.tpDatosPersonales.Controls.Add(this.gpbRedSocial);
            this.tpDatosPersonales.Location = new System.Drawing.Point(4, 32);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tpDatosPersonales.Size = new System.Drawing.Size(808, 324);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Contacto";
            // 
            // gpbContacto
            // 
            this.gpbContacto.BackColor = System.Drawing.Color.White;
            this.gpbContacto.Controls.Add(this.lblMail);
            this.gpbContacto.Controls.Add(this.txtMail);
            this.gpbContacto.Controls.Add(this.lblTelefono);
            this.gpbContacto.Controls.Add(this.txtTelefono);
            this.gpbContacto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gpbContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.gpbContacto.Location = new System.Drawing.Point(12, 12);
            this.gpbContacto.Name = "gpbContacto";
            this.gpbContacto.Size = new System.Drawing.Size(760, 80);
            this.gpbContacto.TabIndex = 0;
            this.gpbContacto.TabStop = false;
            this.gpbContacto.Text = "Contacto";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMail.Location = new System.Drawing.Point(16, 22);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(42, 15);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "EMAIL";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.White;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtMail.Location = new System.Drawing.Point(16, 40);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 24);
            this.txtMail.TabIndex = 5;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTelefono.Location = new System.Drawing.Point(320, 22);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(65, 15);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "TELÉFONO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtTelefono.Location = new System.Drawing.Point(320, 40);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 24);
            this.txtTelefono.TabIndex = 4;
            // 
            // gpbRedSocial
            // 
            this.gpbRedSocial.BackColor = System.Drawing.Color.White;
            this.gpbRedSocial.Controls.Add(this.tcRedes);
            this.gpbRedSocial.Controls.Add(this.btnEliminarR);
            this.gpbRedSocial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gpbRedSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.gpbRedSocial.Location = new System.Drawing.Point(12, 104);
            this.gpbRedSocial.Name = "gpbRedSocial";
            this.gpbRedSocial.Size = new System.Drawing.Size(760, 210);
            this.gpbRedSocial.TabIndex = 1;
            this.gpbRedSocial.TabStop = false;
            this.gpbRedSocial.Text = "Redes Sociales";
            // 
            // tcRedes
            // 
            this.tcRedes.Controls.Add(this.tpRed1);
            this.tcRedes.Controls.Add(this.tpplus);
            this.tcRedes.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcRedes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tcRedes.ItemSize = new System.Drawing.Size(80, 24);
            this.tcRedes.Location = new System.Drawing.Point(8, 22);
            this.tcRedes.Name = "tcRedes";
            this.tcRedes.SelectedIndex = 0;
            this.tcRedes.Size = new System.Drawing.Size(744, 148);
            this.tcRedes.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcRedes.TabIndex = 0;
            this.tcRedes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcRedes_DrawItem);
            this.tcRedes.SelectedIndexChanged += new System.EventHandler(this.tcRedes_SelectedIndexChanged);
            // 
            // tpRed1
            // 
            this.tpRed1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tpRed1.Controls.Add(this.lblred);
            this.tpRed1.Controls.Add(this.cmbRedes);
            this.tpRed1.Controls.Add(this.lblUsuario);
            this.tpRed1.Controls.Add(this.txtUsuarioR);
            this.tpRed1.Controls.Add(this.lblurl);
            this.tpRed1.Controls.Add(this.txturl);
            this.tpRed1.Location = new System.Drawing.Point(4, 28);
            this.tpRed1.Name = "tpRed1";
            this.tpRed1.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.tpRed1.Size = new System.Drawing.Size(736, 116);
            this.tpRed1.TabIndex = 0;
            this.tpRed1.Text = "Red 1";
            // 
            // lblred
            // 
            this.lblred.AutoSize = true;
            this.lblred.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblred.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblred.Location = new System.Drawing.Point(12, 14);
            this.lblred.Name = "lblred";
            this.lblred.Size = new System.Drawing.Size(30, 15);
            this.lblred.TabIndex = 0;
            this.lblred.Text = "RED";
            // 
            // cmbRedes
            // 
            this.cmbRedes.BackColor = System.Drawing.Color.White;
            this.cmbRedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRedes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbRedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Location = new System.Drawing.Point(60, 10);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(170, 25);
            this.cmbRedes.TabIndex = 3;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUsuario.Location = new System.Drawing.Point(250, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 15);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "USUARIO";
            // 
            // txtUsuarioR
            // 
            this.txtUsuarioR.BackColor = System.Drawing.Color.White;
            this.txtUsuarioR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioR.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtUsuarioR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtUsuarioR.Location = new System.Drawing.Point(316, 10);
            this.txtUsuarioR.Name = "txtUsuarioR";
            this.txtUsuarioR.Size = new System.Drawing.Size(200, 24);
            this.txtUsuarioR.TabIndex = 5;
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblurl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblurl.Location = new System.Drawing.Point(12, 54);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(30, 15);
            this.lblurl.TabIndex = 6;
            this.lblurl.Text = "URL";
            // 
            // txturl
            // 
            this.txturl.BackColor = System.Drawing.Color.White;
            this.txturl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txturl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txturl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txturl.Location = new System.Drawing.Point(60, 50);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(456, 24);
            this.txturl.TabIndex = 7;
            // 
            // tpplus
            // 
            this.tpplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tpplus.Location = new System.Drawing.Point(4, 28);
            this.tpplus.Name = "tpplus";
            this.tpplus.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpplus.Size = new System.Drawing.Size(736, 116);
            this.tpplus.TabIndex = 1;
            this.tpplus.Text = "+";
            // 
            // btnEliminarR
            // 
            this.btnEliminarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnEliminarR.FlatAppearance.BorderSize = 0;
            this.btnEliminarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarR.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnEliminarR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminarR.Location = new System.Drawing.Point(8, 174);
            this.btnEliminarR.Name = "btnEliminarR";
            this.btnEliminarR.Size = new System.Drawing.Size(110, 28);
            this.btnEliminarR.TabIndex = 1;
            this.btnEliminarR.Text = "Eliminar red";
            this.btnEliminarR.UseVisualStyleBackColor = false;
            this.btnEliminarR.Click += new System.EventHandler(this.btnEliminarR_Click);
            // 
            // pnlIdentidad
            // 
            this.pnlIdentidad.BackColor = System.Drawing.Color.White;
            this.pnlIdentidad.Controls.Add(this.lblDNI);
            this.pnlIdentidad.Controls.Add(this.txtdni);
            this.pnlIdentidad.Controls.Add(this.lblNombre);
            this.pnlIdentidad.Controls.Add(this.txtNombre);
            this.pnlIdentidad.Controls.Add(this.lblApellido);
            this.pnlIdentidad.Controls.Add(this.txtApellido);
            this.pnlIdentidad.Location = new System.Drawing.Point(12, 76);
            this.pnlIdentidad.Name = "pnlIdentidad";
            this.pnlIdentidad.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlIdentidad.Size = new System.Drawing.Size(816, 60);
            this.pnlIdentidad.TabIndex = 11;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Enabled = false;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDNI.Location = new System.Drawing.Point(12, 10);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 15);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.White;
            this.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdni.Enabled = false;
            this.txtdni.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtdni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtdni.Location = new System.Drawing.Point(12, 26);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(140, 24);
            this.txtdni.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNombre.Location = new System.Drawing.Point(170, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtNombre.Location = new System.Drawing.Point(170, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 24);
            this.txtNombre.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Enabled = false;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblApellido.Location = new System.Drawing.Point(408, 10);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 15);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtApellido.Location = new System.Drawing.Point(408, 26);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 24);
            this.txtApellido.TabIndex = 6;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.btnNuevo);
            this.pnlToolbar.Controls.Add(this.btnEditar);
            this.pnlToolbar.Controls.Add(this.btnEliminar);
            this.pnlToolbar.Controls.Add(this.lblContactoLbl);
            this.pnlToolbar.Controls.Add(this.cmbContacto);
            this.pnlToolbar.Location = new System.Drawing.Point(12, 12);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnlToolbar.Size = new System.Drawing.Size(816, 56);
            this.pnlToolbar.TabIndex = 12;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(8, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 34);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "+ Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnEditar.Location = new System.Drawing.Point(136, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 34);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar contacto";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.Location = new System.Drawing.Point(264, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblContactoLbl
            // 
            this.lblContactoLbl.AutoSize = true;
            this.lblContactoLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblContactoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblContactoLbl.Location = new System.Drawing.Point(520, 18);
            this.lblContactoLbl.Name = "lblContactoLbl";
            this.lblContactoLbl.Size = new System.Drawing.Size(89, 15);
            this.lblContactoLbl.TabIndex = 13;
            this.lblContactoLbl.Text = "Buscar por DNI:";
            // 
            // cmbContacto
            // 
            this.cmbContacto.BackColor = System.Drawing.Color.White;
            this.cmbContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbContacto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.Location = new System.Drawing.Point(630, 13);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.Size = new System.Drawing.Size(174, 25);
            this.cmbContacto.TabIndex = 13;
            this.cmbContacto.SelectedIndexChanged += new System.EventHandler(this.cmbContacto_SelectedIndexChanged_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoBD});
            this.statusStrip1.Location = new System.Drawing.Point(12, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(828, 22);
            this.statusStrip1.TabIndex = 11;
            // 
            // lblEstadoBD
            // 
            this.lblEstadoBD.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEstadoBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblEstadoBD.Name = "lblEstadoBD";
            this.lblEstadoBD.Size = new System.Drawing.Size(145, 17);
            this.lblEstadoBD.Text = "  ●  Verificando conexión...";
            // 
            // tbpAuditoria
            // 
            this.tbpAuditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tbpAuditoria.Controls.Add(this.lblTotalRegistros);
            this.tbpAuditoria.Controls.Add(this.btnDesactivarUsuario);
            this.tbpAuditoria.Controls.Add(this.dgvAuditoria);
            this.tbpAuditoria.Controls.Add(this.pnlFiltros);
            this.tbpAuditoria.Location = new System.Drawing.Point(4, 36);
            this.tbpAuditoria.Name = "tbpAuditoria";
            this.tbpAuditoria.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.tbpAuditoria.Size = new System.Drawing.Size(852, 587);
            this.tbpAuditoria.TabIndex = 1;
            this.tbpAuditoria.Text = "Auditoría";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalRegistros.Location = new System.Drawing.Point(10, 558);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(73, 15);
            this.lblTotalRegistros.TabIndex = 0;
            this.lblTotalRegistros.Text = "Registros: —";
            // 
            // btnDesactivarUsuario
            // 
            this.btnDesactivarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnDesactivarUsuario.FlatAppearance.BorderSize = 0;
            this.btnDesactivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnDesactivarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDesactivarUsuario.Location = new System.Drawing.Point(631, 551);
            this.btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            this.btnDesactivarUsuario.Size = new System.Drawing.Size(208, 28);
            this.btnDesactivarUsuario.TabIndex = 100;
            this.btnDesactivarUsuario.Text = "Desactivar usuario seleccionado";
            this.btnDesactivarUsuario.UseVisualStyleBackColor = false;
            this.btnDesactivarUsuario.Click += new System.EventHandler(this.btnDesactivarUsuario_Click);
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvAuditoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dgvAuditoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuditoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.dgvAuditoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuditoria.ColumnHeadersHeight = 34;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuditoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuditoria.EnableHeadersVisualStyles = false;
            this.dgvAuditoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvAuditoria.Location = new System.Drawing.Point(10, 70);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.ReadOnly = true;
            this.dgvAuditoria.RowHeadersVisible = false;
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.RowTemplate.Height = 28;
            this.dgvAuditoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditoria.Size = new System.Drawing.Size(820, 475);
            this.dgvAuditoria.TabIndex = 1;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.White;
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
            this.pnlFiltros.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlFiltros.Size = new System.Drawing.Size(820, 52);
            this.pnlFiltros.TabIndex = 101;
            // 
            // lblFiltroUsuario
            // 
            this.lblFiltroUsuario.AutoSize = true;
            this.lblFiltroUsuario.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFiltroUsuario.Location = new System.Drawing.Point(10, 14);
            this.lblFiltroUsuario.Name = "lblFiltroUsuario";
            this.lblFiltroUsuario.Size = new System.Drawing.Size(52, 15);
            this.lblFiltroUsuario.TabIndex = 0;
            this.lblFiltroUsuario.Text = "Usuario:";
            // 
            // txtFiltroUsuario
            // 
            this.txtFiltroUsuario.BackColor = System.Drawing.Color.White;
            this.txtFiltroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtFiltroUsuario.Location = new System.Drawing.Point(70, 11);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(100, 23);
            this.txtFiltroUsuario.TabIndex = 2;
            // 
            // lblFiltroAccion
            // 
            this.lblFiltroAccion.AutoSize = true;
            this.lblFiltroAccion.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFiltroAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblFiltroAccion.Location = new System.Drawing.Point(182, 14);
            this.lblFiltroAccion.Name = "lblFiltroAccion";
            this.lblFiltroAccion.Size = new System.Drawing.Size(47, 15);
            this.lblFiltroAccion.TabIndex = 3;
            this.lblFiltroAccion.Text = "Acción:";
            // 
            // cmbFiltroAccion
            // 
            this.cmbFiltroAccion.BackColor = System.Drawing.Color.White;
            this.cmbFiltroAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroAccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFiltroAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmbFiltroAccion.FormattingEnabled = true;
            this.cmbFiltroAccion.Location = new System.Drawing.Point(234, 11);
            this.cmbFiltroAccion.Name = "cmbFiltroAccion";
            this.cmbFiltroAccion.Size = new System.Drawing.Size(140, 23);
            this.cmbFiltroAccion.TabIndex = 11;
            // 
            // chkFiltroFecha
            // 
            this.chkFiltroFecha.AutoSize = true;
            this.chkFiltroFecha.BackColor = System.Drawing.Color.White;
            this.chkFiltroFecha.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.chkFiltroFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.chkFiltroFecha.Location = new System.Drawing.Point(388, 14);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(61, 19);
            this.chkFiltroFecha.TabIndex = 12;
            this.chkFiltroFecha.Text = "Fecha:";
            this.chkFiltroFecha.UseVisualStyleBackColor = false;
            this.chkFiltroFecha.TextChanged += new System.EventHandler(this.chkFiltroFecha_TextChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDesde.Location = new System.Drawing.Point(450, 14);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(45, 15);
            this.lblDesde.TabIndex = 13;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(500, 11);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(94, 23);
            this.dtpDesde.TabIndex = 5;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHasta.Location = new System.Drawing.Point(602, 14);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 15);
            this.lblHasta.TabIndex = 14;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(648, 11);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(94, 23);
            this.dtpHasta.TabIndex = 6;
            // 
            // btnFlitrar
            // 
            this.btnFlitrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnFlitrar.FlatAppearance.BorderSize = 0;
            this.btnFlitrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlitrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFlitrar.ForeColor = System.Drawing.Color.White;
            this.btnFlitrar.Location = new System.Drawing.Point(752, 10);
            this.btnFlitrar.Name = "btnFlitrar";
            this.btnFlitrar.Size = new System.Drawing.Size(30, 24);
            this.btnFlitrar.TabIndex = 9;
            this.btnFlitrar.Text = "▶";
            this.btnFlitrar.UseVisualStyleBackColor = false;
            this.btnFlitrar.Click += new System.EventHandler(this.btnFlitrar_Click);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnLimpiarFiltro.FlatAppearance.BorderSize = 0;
            this.btnLimpiarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltro.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnLimpiarFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(784, 10);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(30, 24);
            this.btnLimpiarFiltro.TabIndex = 99;
            this.btnLimpiarFiltro.Text = "✕";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(860, 627);
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
            this.tbpUsuario.PerformLayout();
            this.tcDatos.ResumeLayout(false);
            this.tpDom.ResumeLayout(false);
            this.tpDomicilio.ResumeLayout(false);
            this.tpDom1.ResumeLayout(false);
            this.tpDom1.PerformLayout();
            this.tpDatosPersonales.ResumeLayout(false);
            this.gpbContacto.ResumeLayout(false);
            this.gpbContacto.PerformLayout();
            this.gpbRedSocial.ResumeLayout(false);
            this.tcRedes.ResumeLayout(false);
            this.tpRed1.ResumeLayout(false);
            this.tpRed1.PerformLayout();
            this.pnlIdentidad.ResumeLayout(false);
            this.pnlIdentidad.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbpAuditoria.ResumeLayout(false);
            this.tbpAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
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
        private System.Windows.Forms.TextBox txtUsuarioR;
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
