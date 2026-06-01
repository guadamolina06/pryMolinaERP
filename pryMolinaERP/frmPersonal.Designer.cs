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
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbcDatos = new System.Windows.Forms.TabControl();
            this.tbpDomicilio = new System.Windows.Forms.TabPage();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtGeo = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGeo = new System.Windows.Forms.Label();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.tbpContacto = new System.Windows.Forms.TabPage();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.lblredes = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbcADM = new System.Windows.Forms.TabControl();
            this.tbpUsuario = new System.Windows.Forms.TabPage();
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
            this.tbcDatos.SuspendLayout();
            this.tbpDomicilio.SuspendLayout();
            this.tbpContacto.SuspendLayout();
            this.tbcADM.SuspendLayout();
            this.tbpUsuario.SuspendLayout();
            this.tbpAuditoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(114, 154);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(51, 25);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(114, 221);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(88, 25);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(114, 185);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tbpDomicilio);
            this.tbcDatos.Controls.Add(this.tbpContacto);
            this.tbcDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDatos.Location = new System.Drawing.Point(576, 58);
            this.tbcDatos.Margin = new System.Windows.Forms.Padding(4);
            this.tbcDatos.Name = "tbcDatos";
            this.tbcDatos.SelectedIndex = 0;
            this.tbcDatos.Size = new System.Drawing.Size(309, 304);
            this.tbcDatos.TabIndex = 3;
            // 
            // tbpDomicilio
            // 
            this.tbpDomicilio.Controls.Add(this.cmbLoc);
            this.tbpDomicilio.Controls.Add(this.cmbProv);
            this.tbpDomicilio.Controls.Add(this.txtDireccion);
            this.tbpDomicilio.Controls.Add(this.txtGeo);
            this.tbpDomicilio.Controls.Add(this.lblDireccion);
            this.tbpDomicilio.Controls.Add(this.lblGeo);
            this.tbpDomicilio.Controls.Add(this.lbllocalidad);
            this.tbpDomicilio.Controls.Add(this.lblProv);
            this.tbpDomicilio.Location = new System.Drawing.Point(4, 31);
            this.tbpDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDomicilio.Name = "tbpDomicilio";
            this.tbpDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDomicilio.Size = new System.Drawing.Size(301, 269);
            this.tbpDomicilio.TabIndex = 0;
            this.tbpDomicilio.Text = "Domicilio";
            this.tbpDomicilio.UseVisualStyleBackColor = true;
            // 
            // cmbLoc
            // 
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(152, 84);
            this.cmbLoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(132, 30);
            this.cmbLoc.TabIndex = 7;
            // 
            // cmbProv
            // 
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(152, 33);
            this.cmbProv.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(132, 30);
            this.cmbProv.TabIndex = 6;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(152, 140);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 28);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(152, 196);
            this.txtGeo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(132, 28);
            this.txtGeo.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 144);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 22);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Location = new System.Drawing.Point(21, 199);
            this.lblGeo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(155, 22);
            this.lblGeo.TabIndex = 2;
            this.lblGeo.Text = "Geo(cordenadas):";
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Location = new System.Drawing.Point(21, 87);
            this.lbllocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(92, 22);
            this.lbllocalidad.TabIndex = 1;
            this.lbllocalidad.Text = "Localidad:";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(21, 33);
            this.lblProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(89, 22);
            this.lblProv.TabIndex = 0;
            this.lblProv.Text = "Provincia:";
            // 
            // tbpContacto
            // 
            this.tbpContacto.Controls.Add(this.chkActivo);
            this.tbpContacto.Controls.Add(this.txtMail);
            this.tbpContacto.Controls.Add(this.txtTelefono);
            this.tbpContacto.Controls.Add(this.cmbRedes);
            this.tbpContacto.Controls.Add(this.lblredes);
            this.tbpContacto.Controls.Add(this.lblTelefono);
            this.tbpContacto.Controls.Add(this.lblMail);
            this.tbpContacto.Location = new System.Drawing.Point(4, 25);
            this.tbpContacto.Margin = new System.Windows.Forms.Padding(4);
            this.tbpContacto.Name = "tbpContacto";
            this.tbpContacto.Padding = new System.Windows.Forms.Padding(4);
            this.tbpContacto.Size = new System.Drawing.Size(301, 275);
            this.tbpContacto.TabIndex = 1;
            this.tbpContacto.Text = "Contacto";
            this.tbpContacto.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(29, 203);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(81, 26);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(101, 44);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(172, 28);
            this.txtMail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 92);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 28);
            this.txtTelefono.TabIndex = 4;
            // 
            // cmbRedes
            // 
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Location = new System.Drawing.Point(137, 143);
            this.cmbRedes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(136, 30);
            this.cmbRedes.TabIndex = 3;
            // 
            // lblredes
            // 
            this.lblredes.AutoSize = true;
            this.lblredes.Location = new System.Drawing.Point(25, 146);
            this.lblredes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblredes.Name = "lblredes";
            this.lblredes.Size = new System.Drawing.Size(67, 22);
            this.lblredes.TabIndex = 2;
            this.lblredes.Text = "Redes:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 96);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(86, 22);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(29, 44);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 22);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.Location = new System.Drawing.Point(202, 151);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(132, 30);
            this.txtdni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(202, 181);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 30);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(202, 213);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 30);
            this.txtApellido.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(20, 453);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.Location = new System.Drawing.Point(179, 453);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 26);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(259, 453);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 26);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbcADM
            // 
            this.tbcADM.Controls.Add(this.tbpUsuario);
            this.tbcADM.Controls.Add(this.tbpAuditoria);
            this.tbcADM.Location = new System.Drawing.Point(16, 5);
            this.tbcADM.Margin = new System.Windows.Forms.Padding(4);
            this.tbcADM.Name = "tbcADM";
            this.tbcADM.SelectedIndex = 0;
            this.tbcADM.Size = new System.Drawing.Size(994, 443);
            this.tbcADM.TabIndex = 10;
            this.tbcADM.SelectedIndexChanged += new System.EventHandler(this.tbcADM_SelectedIndexChanged_1);
            // 
            // tbpUsuario
            // 
            this.tbpUsuario.Controls.Add(this.txtdni);
            this.tbpUsuario.Controls.Add(this.btnGuardar);
            this.tbpUsuario.Controls.Add(this.lblDNI);
            this.tbpUsuario.Controls.Add(this.btnNuevo);
            this.tbpUsuario.Controls.Add(this.lblApellido);
            this.tbpUsuario.Controls.Add(this.btnEliminar);
            this.tbpUsuario.Controls.Add(this.lblNombre);
            this.tbpUsuario.Controls.Add(this.txtApellido);
            this.tbpUsuario.Controls.Add(this.tbcDatos);
            this.tbpUsuario.Controls.Add(this.txtNombre);
            this.tbpUsuario.Location = new System.Drawing.Point(4, 25);
            this.tbpUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbpUsuario.Name = "tbpUsuario";
            this.tbpUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.tbpUsuario.Size = new System.Drawing.Size(986, 414);
            this.tbpUsuario.TabIndex = 0;
            this.tbpUsuario.Text = "Usuario";
            this.tbpUsuario.UseVisualStyleBackColor = true;
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
            this.tbpAuditoria.Size = new System.Drawing.Size(986, 414);
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
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.RowTemplate.Height = 24;
            this.dgvAuditoria.Size = new System.Drawing.Size(966, 304);
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
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(966, 60);
            this.pnlFiltros.TabIndex = 0;
            // 
            // cmbFiltroAccion
            // 
            this.cmbFiltroAccion.FormattingEnabled = true;
            this.cmbFiltroAccion.Location = new System.Drawing.Point(246, 20);
            this.cmbFiltroAccion.Name = "cmbFiltroAccion";
            this.cmbFiltroAccion.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltroAccion.TabIndex = 11;
            // 
            // btnFlitrar
            // 
            this.btnFlitrar.Location = new System.Drawing.Point(879, 21);
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
            this.lblHasta.Location = new System.Drawing.Point(665, 24);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(457, 24);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(728, 21);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(124, 22);
            this.dtpHasta.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(519, 21);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(124, 22);
            this.dtpDesde.TabIndex = 5;
            // 
            // chkFiltroFecha
            // 
            this.chkFiltroFecha.AutoSize = true;
            this.chkFiltroFecha.Location = new System.Drawing.Point(381, 22);
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
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtFiltroUsuario.TabIndex = 2;
            // 
            // lblFiltroAccion
            // 
            this.lblFiltroAccion.AutoSize = true;
            this.lblFiltroAccion.Location = new System.Drawing.Point(189, 24);
            this.lblFiltroAccion.Name = "lblFiltroAccion";
            this.lblFiltroAccion.Size = new System.Drawing.Size(51, 16);
            this.lblFiltroAccion.TabIndex = 1;
            this.lblFiltroAccion.Text = "Acción:";
            // 
            // lblFiltroUsuario
            // 
            this.lblFiltroUsuario.AutoSize = true;
            this.lblFiltroUsuario.Location = new System.Drawing.Point(9, 24);
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
            this.ClientSize = new System.Drawing.Size(1025, 463);
            this.Controls.Add(this.tbcADM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonal";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.tbcDatos.ResumeLayout(false);
            this.tbpDomicilio.ResumeLayout(false);
            this.tbpDomicilio.PerformLayout();
            this.tbpContacto.ResumeLayout(false);
            this.tbpContacto.PerformLayout();
            this.tbcADM.ResumeLayout(false);
            this.tbpUsuario.ResumeLayout(false);
            this.tbpUsuario.PerformLayout();
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
        private System.Windows.Forms.TabControl tbcDatos;
        private System.Windows.Forms.TabPage tbpDomicilio;
        private System.Windows.Forms.TabPage tbpContacto;
        private System.Windows.Forms.Label lblGeo;
        private System.Windows.Forms.Label lbllocalidad;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtGeo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblredes;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbRedes;
        private System.Windows.Forms.CheckBox chkActivo;
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
    }
}