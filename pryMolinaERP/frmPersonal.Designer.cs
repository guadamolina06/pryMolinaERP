namespace pryMolinaERP
{
    partial class frmPersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonal));
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbcADM = new System.Windows.Forms.TabControl();
            this.tbpUsuario = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoBD = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcDatos = new System.Windows.Forms.TabControl();
            this.tpDatosPersonales = new System.Windows.Forms.TabPage();
            this.gpbRedSocial = new System.Windows.Forms.GroupBox();
            this.btnEliminarR = new System.Windows.Forms.Button();
            this.tcRedes = new System.Windows.Forms.TabControl();
            this.tpRed1 = new System.Windows.Forms.TabPage();
            this.txturl = new System.Windows.Forms.TextBox();
            this.lblurl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.lblred = new System.Windows.Forms.Label();
            this.tpplus = new System.Windows.Forms.TabPage();
            this.gpbContacto = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tpDom = new System.Windows.Forms.TabPage();
            this.tpDomicilio = new System.Windows.Forms.TabControl();
            this.tpDom1 = new System.Windows.Forms.TabPage();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.txtGeo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.lblGeo = new System.Windows.Forms.Label();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.tpdpus = new System.Windows.Forms.TabPage();
            this.tbpAuditoria = new System.Windows.Forms.TabPage();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.cmbFiltroAccion = new System.Windows.Forms.ComboBox();
            this.btnFlitrar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.chkFiltroFecha = new System.Windows.Forms.CheckBox();
            this.txtFiltroUsuario = new System.Windows.Forms.TextBox();
            this.lblFiltroAccion = new System.Windows.Forms.Label();
            this.lblFiltroUsuario = new System.Windows.Forms.Label();
            this.tbcADM.SuspendLayout();
            this.tbpUsuario.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tcDatos.SuspendLayout();
            this.tpDatosPersonales.SuspendLayout();
            this.gpbRedSocial.SuspendLayout();
            this.tcRedes.SuspendLayout();
            this.tpRed1.SuspendLayout();
            this.gpbContacto.SuspendLayout();
            this.tpDom.SuspendLayout();
            this.tpDomicilio.SuspendLayout();
            this.tpDom1.SuspendLayout();
            this.tbpAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(13, 30);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(13, 105);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 69);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(84, 23);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(132, 23);
            this.txtdni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(84, 65);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(84, 101);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 23);
            this.txtApellido.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(35, 325);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 47);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.Location = new System.Drawing.Point(35, 249);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(183, 50);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(35, 194);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 49);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbcADM
            // 
            this.tbcADM.Controls.Add(this.tbpUsuario);
            this.tbcADM.Controls.Add(this.tbpAuditoria);
            this.tbcADM.Location = new System.Drawing.Point(16, 15);
            this.tbcADM.Margin = new System.Windows.Forms.Padding(4);
            this.tbcADM.Name = "tbcADM";
            this.tbcADM.SelectedIndex = 0;
            this.tbcADM.Size = new System.Drawing.Size(1111, 475);
            this.tbcADM.TabIndex = 10;
            this.tbcADM.SelectedIndexChanged += new System.EventHandler(this.tbcADM_SelectedIndexChanged_1);
            // 
            // tbpUsuario
            // 
            this.tbpUsuario.Controls.Add(this.statusStrip1);
            this.tbpUsuario.Controls.Add(this.tcDatos);
            this.tbpUsuario.Controls.Add(this.txtdni);
            this.tbpUsuario.Controls.Add(this.btnGuardar);
            this.tbpUsuario.Controls.Add(this.lblDNI);
            this.tbpUsuario.Controls.Add(this.btnNuevo);
            this.tbpUsuario.Controls.Add(this.lblApellido);
            this.tbpUsuario.Controls.Add(this.btnEliminar);
            this.tbpUsuario.Controls.Add(this.lblNombre);
            this.tbpUsuario.Controls.Add(this.txtApellido);
            this.tbpUsuario.Controls.Add(this.txtNombre);
            this.tbpUsuario.Location = new System.Drawing.Point(4, 25);
            this.tbpUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbpUsuario.Name = "tbpUsuario";
            this.tbpUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.tbpUsuario.Size = new System.Drawing.Size(1103, 446);
            this.tbpUsuario.TabIndex = 0;
            this.tbpUsuario.Text = "Usuario";
            this.tbpUsuario.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoBD});
            this.statusStrip1.Location = new System.Drawing.Point(4, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoBD
            // 
            this.lblEstadoBD.Name = "lblEstadoBD";
            this.lblEstadoBD.Size = new System.Drawing.Size(0, 18);
            // 
            // tcDatos
            // 
            this.tcDatos.Controls.Add(this.tpDatosPersonales);
            this.tcDatos.Controls.Add(this.tpDom);
            this.tcDatos.Location = new System.Drawing.Point(253, 7);
            this.tcDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tcDatos.Name = "tcDatos";
            this.tcDatos.SelectedIndex = 0;
            this.tcDatos.Size = new System.Drawing.Size(842, 400);
            this.tcDatos.TabIndex = 10;
            // 
            // tpDatosPersonales
            // 
            this.tpDatosPersonales.Controls.Add(this.gpbRedSocial);
            this.tpDatosPersonales.Controls.Add(this.gpbContacto);
            this.tpDatosPersonales.Location = new System.Drawing.Point(4, 25);
            this.tpDatosPersonales.Margin = new System.Windows.Forms.Padding(4);
            this.tpDatosPersonales.Name = "tpDatosPersonales";
            this.tpDatosPersonales.Padding = new System.Windows.Forms.Padding(4);
            this.tpDatosPersonales.Size = new System.Drawing.Size(794, 371);
            this.tpDatosPersonales.TabIndex = 0;
            this.tpDatosPersonales.Text = "Datos Personales";
            this.tpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // gpbRedSocial
            // 
            this.gpbRedSocial.Controls.Add(this.btnEliminarR);
            this.gpbRedSocial.Controls.Add(this.tcRedes);
            this.gpbRedSocial.Location = new System.Drawing.Point(20, 116);
            this.gpbRedSocial.Margin = new System.Windows.Forms.Padding(4);
            this.gpbRedSocial.Name = "gpbRedSocial";
            this.gpbRedSocial.Padding = new System.Windows.Forms.Padding(4);
            this.gpbRedSocial.Size = new System.Drawing.Size(766, 224);
            this.gpbRedSocial.TabIndex = 24;
            this.gpbRedSocial.TabStop = false;
            this.gpbRedSocial.Text = "Redes Sociales";
            // 
            // btnEliminarR
            // 
            this.btnEliminarR.Location = new System.Drawing.Point(12, 186);
            this.btnEliminarR.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarR.Name = "btnEliminarR";
            this.btnEliminarR.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarR.TabIndex = 1;
            this.btnEliminarR.Text = "Eliminar";
            this.btnEliminarR.UseVisualStyleBackColor = true;
            this.btnEliminarR.Click += new System.EventHandler(this.btnEliminarR_Click);
            // 
            // tcRedes
            // 
            this.tcRedes.Controls.Add(this.tpRed1);
            this.tcRedes.Controls.Add(this.tpplus);
            this.tcRedes.Location = new System.Drawing.Point(8, 23);
            this.tcRedes.Margin = new System.Windows.Forms.Padding(4);
            this.tcRedes.Name = "tcRedes";
            this.tcRedes.SelectedIndex = 0;
            this.tcRedes.Size = new System.Drawing.Size(750, 155);
            this.tcRedes.TabIndex = 0;
            this.tcRedes.SelectedIndexChanged += new System.EventHandler(this.tcRedes_SelectedIndexChanged);
            // 
            // tpRed1
            // 
            this.tpRed1.Controls.Add(this.txturl);
            this.tpRed1.Controls.Add(this.lblurl);
            this.tpRed1.Controls.Add(this.textBox1);
            this.tpRed1.Controls.Add(this.lblUsuario);
            this.tpRed1.Controls.Add(this.cmbRedes);
            this.tpRed1.Controls.Add(this.lblred);
            this.tpRed1.Location = new System.Drawing.Point(4, 25);
            this.tpRed1.Margin = new System.Windows.Forms.Padding(4);
            this.tpRed1.Name = "tpRed1";
            this.tpRed1.Padding = new System.Windows.Forms.Padding(4);
            this.tpRed1.Size = new System.Drawing.Size(742, 126);
            this.tpRed1.TabIndex = 0;
            this.tpRed1.Text = "Red 1";
            this.tpRed1.UseVisualStyleBackColor = true;
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(95, 69);
            this.txturl.Margin = new System.Windows.Forms.Padding(4);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(179, 22);
            this.txturl.TabIndex = 7;
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Location = new System.Drawing.Point(43, 73);
            this.lblurl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(37, 16);
            this.lblurl.TabIndex = 6;
            this.lblurl.Text = "URL:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(316, 26);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cmbRedes
            // 
            this.cmbRedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Location = new System.Drawing.Point(95, 20);
            this.cmbRedes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(179, 24);
            this.cmbRedes.TabIndex = 3;
            // 
            // lblred
            // 
            this.lblred.AutoSize = true;
            this.lblred.Location = new System.Drawing.Point(47, 23);
            this.lblred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblred.Name = "lblred";
            this.lblred.Size = new System.Drawing.Size(36, 16);
            this.lblred.TabIndex = 2;
            this.lblred.Text = "Red:";
            // 
            // tpplus
            // 
            this.tpplus.Location = new System.Drawing.Point(4, 25);
            this.tpplus.Margin = new System.Windows.Forms.Padding(4);
            this.tpplus.Name = "tpplus";
            this.tpplus.Padding = new System.Windows.Forms.Padding(4);
            this.tpplus.Size = new System.Drawing.Size(742, 126);
            this.tpplus.TabIndex = 1;
            this.tpplus.Text = "+";
            this.tpplus.UseVisualStyleBackColor = true;
            // 
            // gpbContacto
            // 
            this.gpbContacto.Controls.Add(this.txtMail);
            this.gpbContacto.Controls.Add(this.lblMail);
            this.gpbContacto.Controls.Add(this.txtTelefono);
            this.gpbContacto.Controls.Add(this.lblTelefono);
            this.gpbContacto.Location = new System.Drawing.Point(20, 31);
            this.gpbContacto.Margin = new System.Windows.Forms.Padding(4);
            this.gpbContacto.Name = "gpbContacto";
            this.gpbContacto.Padding = new System.Windows.Forms.Padding(4);
            this.gpbContacto.Size = new System.Drawing.Size(665, 78);
            this.gpbContacto.TabIndex = 23;
            this.gpbContacto.TabStop = false;
            this.gpbContacto.Text = "Contacto";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(139, 23);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(172, 22);
            this.txtMail.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(56, 27);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 16);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(457, 23);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 22);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(355, 27);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // tpDom
            // 
            this.tpDom.Controls.Add(this.tpDomicilio);
            this.tpDom.Location = new System.Drawing.Point(4, 25);
            this.tpDom.Margin = new System.Windows.Forms.Padding(4);
            this.tpDom.Name = "tpDom";
            this.tpDom.Padding = new System.Windows.Forms.Padding(4);
            this.tpDom.Size = new System.Drawing.Size(834, 371);
            this.tpDom.TabIndex = 1;
            this.tpDom.Text = "Domicilio";
            this.tpDom.UseVisualStyleBackColor = true;
            // 
            // tpDomicilio
            // 
            this.tpDomicilio.Controls.Add(this.tpDom1);
            this.tpDomicilio.Controls.Add(this.tpdpus);
            this.tpDomicilio.Location = new System.Drawing.Point(19, 14);
            this.tpDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.tpDomicilio.Name = "tpDomicilio";
            this.tpDomicilio.SelectedIndex = 0;
            this.tpDomicilio.Size = new System.Drawing.Size(807, 253);
            this.tpDomicilio.TabIndex = 22;
            this.tpDomicilio.SelectedIndexChanged += new System.EventHandler(this.tpDomicilio_SelectedIndexChanged);
            // 
            // tpDom1
            // 
            this.tpDom1.Controls.Add(this.cmbTipo);
            this.tpDom1.Controls.Add(this.lblTipo);
            this.tpDom1.Controls.Add(this.cmbLoc);
            this.tpDom1.Controls.Add(this.txtGeo);
            this.tpDom1.Controls.Add(this.txtDireccion);
            this.tpDom1.Controls.Add(this.cmbProv);
            this.tpDom1.Controls.Add(this.lblGeo);
            this.tpDom1.Controls.Add(this.lbllocalidad);
            this.tpDom1.Controls.Add(this.lblDireccion);
            this.tpDom1.Controls.Add(this.lblProv);
            this.tpDom1.Location = new System.Drawing.Point(4, 25);
            this.tpDom1.Margin = new System.Windows.Forms.Padding(4);
            this.tpDom1.Name = "tpDom1";
            this.tpDom1.Padding = new System.Windows.Forms.Padding(4);
            this.tpDom1.Size = new System.Drawing.Size(799, 224);
            this.tpDom1.TabIndex = 0;
            this.tpDom1.Text = "Dom 1";
            this.tpDom1.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Pricipal",
            "Laboral",
            "Alternatibo",
            "Fiscal"});
            this.cmbTipo.Location = new System.Drawing.Point(177, 94);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(132, 24);
            this.cmbTipo.TabIndex = 23;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(24, 103);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 16);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbLoc
            // 
            this.cmbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(177, 58);
            this.cmbLoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(132, 24);
            this.cmbLoc.TabIndex = 21;
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(488, 62);
            this.txtGeo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(132, 22);
            this.txtGeo.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(460, 20);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 22);
            this.txtDireccion.TabIndex = 19;
            // 
            // cmbProv
            // 
            this.cmbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(177, 25);
            this.cmbProv.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(132, 24);
            this.cmbProv.TabIndex = 20;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Location = new System.Drawing.Point(373, 66);
            this.lblGeo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(117, 16);
            this.lblGeo.TabIndex = 16;
            this.lblGeo.Text = "Geo(cordenadas):";
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Location = new System.Drawing.Point(24, 65);
            this.lbllocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(70, 16);
            this.lbllocalidad.TabIndex = 15;
            this.lbllocalidad.Text = "Localidad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(373, 20);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(24, 25);
            this.lblProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(66, 16);
            this.lblProv.TabIndex = 14;
            this.lblProv.Text = "Provincia:";
            // 
            // tpdpus
            // 
            this.tpdpus.Location = new System.Drawing.Point(4, 25);
            this.tpdpus.Margin = new System.Windows.Forms.Padding(4);
            this.tpdpus.Name = "tpdpus";
            this.tpdpus.Padding = new System.Windows.Forms.Padding(4);
            this.tpdpus.Size = new System.Drawing.Size(759, 224);
            this.tpdpus.TabIndex = 1;
            this.tpdpus.Text = "+";
            this.tpdpus.UseVisualStyleBackColor = true;
            // 
            // tbpAuditoria
            // 
            this.tbpAuditoria.Controls.Add(this.lblTotalRegistros);
            this.tbpAuditoria.Controls.Add(this.dgvAuditoria);
            this.tbpAuditoria.Controls.Add(this.pnlFiltros);
            this.tbpAuditoria.Location = new System.Drawing.Point(4, 25);
            this.tbpAuditoria.Margin = new System.Windows.Forms.Padding(4);
            this.tbpAuditoria.Name = "tbpAuditoria";
            this.tbpAuditoria.Padding = new System.Windows.Forms.Padding(4);
            this.tbpAuditoria.Size = new System.Drawing.Size(1063, 446);
            this.tbpAuditoria.TabIndex = 1;
            this.tbpAuditoria.Text = "Auditoria";
            this.tbpAuditoria.UseVisualStyleBackColor = true;
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(7, 386);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(64, 16);
            this.lblTotalRegistros.TabIndex = 2;
            this.lblTotalRegistros.Text = "Registro: ";
            this.lblTotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(7, 79);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.RowTemplate.Height = 24;
            this.dgvAuditoria.Size = new System.Drawing.Size(965, 304);
            this.dgvAuditoria.TabIndex = 1;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.cmbFiltroAccion);
            this.pnlFiltros.Controls.Add(this.btnFlitrar);
            this.pnlFiltros.Controls.Add(this.lblHasta);
            this.pnlFiltros.Controls.Add(this.lblDesde);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.chkFiltroFecha);
            this.pnlFiltros.Controls.Add(this.txtFiltroUsuario);
            this.pnlFiltros.Controls.Add(this.lblFiltroAccion);
            this.pnlFiltros.Controls.Add(this.lblFiltroUsuario);
            this.pnlFiltros.Location = new System.Drawing.Point(7, 7);
            this.pnlFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(965, 60);
            this.pnlFiltros.TabIndex = 0;
            // 
            // cmbFiltroAccion
            // 
            this.cmbFiltroAccion.FormattingEnabled = true;
            this.cmbFiltroAccion.Location = new System.Drawing.Point(245, 20);
            this.cmbFiltroAccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroAccion.Name = "cmbFiltroAccion";
            this.cmbFiltroAccion.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltroAccion.TabIndex = 11;
            // 
            // btnFlitrar
            // 
            this.btnFlitrar.Location = new System.Drawing.Point(879, 21);
            this.btnFlitrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlitrar.Name = "btnFlitrar";
            this.btnFlitrar.Size = new System.Drawing.Size(75, 23);
            this.btnFlitrar.TabIndex = 9;
            this.btnFlitrar.Text = "Filtrar";
            this.btnFlitrar.UseVisualStyleBackColor = true;
            this.btnFlitrar.Click += new System.EventHandler(this.btnFlitrar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(665, 25);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(457, 25);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(728, 21);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(124, 22);
            this.dtpHasta.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(519, 21);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(124, 22);
            this.dtpDesde.TabIndex = 5;
            // 
            // chkFiltroFecha
            // 
            this.chkFiltroFecha.AutoSize = true;
            this.chkFiltroFecha.Location = new System.Drawing.Point(381, 22);
            this.chkFiltroFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFiltroFecha.Name = "chkFiltroFecha";
            this.chkFiltroFecha.Size = new System.Drawing.Size(70, 20);
            this.chkFiltroFecha.TabIndex = 4;
            this.chkFiltroFecha.Text = "Fecha:";
            this.chkFiltroFecha.UseVisualStyleBackColor = true;
            this.chkFiltroFecha.TextChanged += new System.EventHandler(this.chkFiltroFecha_TextChanged);
            // 
            // txtFiltroUsuario
            // 
            this.txtFiltroUsuario.Location = new System.Drawing.Point(72, 21);
            this.txtFiltroUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtFiltroUsuario.TabIndex = 2;
            // 
            // lblFiltroAccion
            // 
            this.lblFiltroAccion.AutoSize = true;
            this.lblFiltroAccion.Location = new System.Drawing.Point(189, 25);
            this.lblFiltroAccion.Name = "lblFiltroAccion";
            this.lblFiltroAccion.Size = new System.Drawing.Size(51, 16);
            this.lblFiltroAccion.TabIndex = 1;
            this.lblFiltroAccion.Text = "Acción:";
            // 
            // lblFiltroUsuario
            // 
            this.lblFiltroUsuario.AutoSize = true;
            this.lblFiltroUsuario.Location = new System.Drawing.Point(9, 25);
            this.lblFiltroUsuario.Name = "lblFiltroUsuario";
            this.lblFiltroUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblFiltroUsuario.TabIndex = 0;
            this.lblFiltroUsuario.Text = "Usuario:";
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1140, 494);
            this.Controls.Add(this.tbcADM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonal";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonal_FormClosing);
            this.tbcADM.ResumeLayout(false);
            this.tbpUsuario.ResumeLayout(false);
            this.tbpUsuario.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tcDatos.ResumeLayout(false);
            this.tpDatosPersonales.ResumeLayout(false);
            this.gpbRedSocial.ResumeLayout(false);
            this.tcRedes.ResumeLayout(false);
            this.tpRed1.ResumeLayout(false);
            this.tpRed1.PerformLayout();
            this.gpbContacto.ResumeLayout(false);
            this.gpbContacto.PerformLayout();
            this.tpDom.ResumeLayout(false);
            this.tpDomicilio.ResumeLayout(false);
            this.tpDom1.ResumeLayout(false);
            this.tpDom1.PerformLayout();
            this.tbpAuditoria.ResumeLayout(false);
            this.tbpAuditoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabControl tbcADM;
        private System.Windows.Forms.TabPage tbpUsuario;
        private System.Windows.Forms.TabPage tbpAuditoria;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label lblFiltroAccion;
        private System.Windows.Forms.Label lblFiltroUsuario;
        private System.Windows.Forms.CheckBox chkFiltroFecha;
        private System.Windows.Forms.TextBox txtFiltroUsuario;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnFlitrar;
        private System.Windows.Forms.ComboBox cmbFiltroAccion;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.TabControl tcDatos;
        private System.Windows.Forms.TabPage tpDatosPersonales;
        private System.Windows.Forms.GroupBox gpbRedSocial;
        private System.Windows.Forms.TabControl tcRedes;
        private System.Windows.Forms.TabPage tpRed1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.Label lblred;
        private System.Windows.Forms.TabPage tpplus;
        private System.Windows.Forms.GroupBox gpbContacto;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtGeo;
        private System.Windows.Forms.TabPage tpDom;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lbllocalidad;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblGeo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Label lblurl;
        private System.Windows.Forms.Button btnEliminarR;
        private System.Windows.Forms.TabControl tpDomicilio;
        private System.Windows.Forms.TabPage tpDom1;
        private System.Windows.Forms.TabPage tpdpus;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoBD;
    }
}