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
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lblHoraR = new System.Windows.Forms.Label();
            this.lblFechaR = new System.Windows.Forms.Label();
            this.lblSesion = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.lblPerf = new System.Windows.Forms.Label();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.tbcDatos.SuspendLayout();
            this.tbpDomicilio.SuspendLayout();
            this.tbpContacto.SuspendLayout();
            this.tbcADM.SuspendLayout();
            this.tbpUsuario.SuspendLayout();
            this.tbpAuditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(27, 19);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 73);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tbpDomicilio);
            this.tbcDatos.Controls.Add(this.tbpContacto);
            this.tbcDatos.Location = new System.Drawing.Point(15, 103);
            this.tbcDatos.Name = "tbcDatos";
            this.tbcDatos.SelectedIndex = 0;
            this.tbcDatos.Size = new System.Drawing.Size(232, 247);
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
            this.tbpDomicilio.Location = new System.Drawing.Point(4, 22);
            this.tbpDomicilio.Name = "tbpDomicilio";
            this.tbpDomicilio.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpDomicilio.Size = new System.Drawing.Size(224, 221);
            this.tbpDomicilio.TabIndex = 0;
            this.tbpDomicilio.Text = "Domicilio";
            this.tbpDomicilio.UseVisualStyleBackColor = true;
            // 
            // cmbLoc
            // 
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(114, 68);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(100, 21);
            this.cmbLoc.TabIndex = 7;
            // 
            // cmbProv
            // 
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(114, 27);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(100, 21);
            this.cmbProv.TabIndex = 6;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 114);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(114, 159);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(100, 20);
            this.txtGeo.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Location = new System.Drawing.Point(16, 162);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(92, 13);
            this.lblGeo.TabIndex = 2;
            this.lblGeo.Text = "Geo(cordenadas):";
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Location = new System.Drawing.Point(16, 71);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(56, 13);
            this.lbllocalidad.TabIndex = 1;
            this.lbllocalidad.Text = "Localidad:";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(16, 27);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(54, 13);
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
            this.tbpContacto.Location = new System.Drawing.Point(4, 22);
            this.tbpContacto.Name = "tbpContacto";
            this.tbpContacto.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpContacto.Size = new System.Drawing.Size(224, 221);
            this.tbpContacto.TabIndex = 1;
            this.tbpContacto.Text = "Contacto";
            this.tbpContacto.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(22, 165);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(76, 36);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(130, 20);
            this.txtMail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(103, 75);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(103, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // cmbRedes
            // 
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Location = new System.Drawing.Point(103, 116);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(103, 21);
            this.cmbRedes.TabIndex = 3;
            // 
            // lblredes
            // 
            this.lblredes.AutoSize = true;
            this.lblredes.Location = new System.Drawing.Point(19, 119);
            this.lblredes.Name = "lblredes";
            this.lblredes.Size = new System.Drawing.Size(41, 13);
            this.lblredes.TabIndex = 2;
            this.lblredes.Text = "Redes:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 78);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(22, 36);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(93, 16);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(15, 368);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 21);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.Location = new System.Drawing.Point(134, 368);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 21);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(194, 368);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 21);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbcADM
            // 
            this.tbcADM.Controls.Add(this.tbpUsuario);
            this.tbcADM.Controls.Add(this.tbpAuditoria);
            this.tbcADM.Location = new System.Drawing.Point(12, 4);
            this.tbcADM.Name = "tbcADM";
            this.tbcADM.SelectedIndex = 0;
            this.tbcADM.Size = new System.Drawing.Size(274, 431);
            this.tbcADM.TabIndex = 10;
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
            this.tbpUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbpUsuario.Name = "tbpUsuario";
            this.tbpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsuario.Size = new System.Drawing.Size(266, 405);
            this.tbpUsuario.TabIndex = 0;
            this.tbpUsuario.Text = "Usuario";
            this.tbpUsuario.UseVisualStyleBackColor = true;
            // 
            // tbpAuditoria
            // 
            this.tbpAuditoria.Controls.Add(this.lblPerfil);
            this.tbpAuditoria.Controls.Add(this.lblUsuario);
            this.tbpAuditoria.Controls.Add(this.lblNombreR);
            this.tbpAuditoria.Controls.Add(this.lblPerf);
            this.tbpAuditoria.Controls.Add(this.lblUsu);
            this.tbpAuditoria.Controls.Add(this.lblNom);
            this.tbpAuditoria.Controls.Add(this.lblSesion);
            this.tbpAuditoria.Controls.Add(this.lblFechaR);
            this.tbpAuditoria.Controls.Add(this.lblHoraR);
            this.tbpAuditoria.Controls.Add(this.lblInicioSesion);
            this.tbpAuditoria.Controls.Add(this.lblFecha);
            this.tbpAuditoria.Controls.Add(this.lblHora);
            this.tbpAuditoria.Location = new System.Drawing.Point(4, 22);
            this.tbpAuditoria.Name = "tbpAuditoria";
            this.tbpAuditoria.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAuditoria.Size = new System.Drawing.Size(266, 405);
            this.tbpAuditoria.TabIndex = 1;
            this.tbpAuditoria.Text = "Auditoria";
            this.tbpAuditoria.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(26, 30);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 23);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(26, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioSesion.Location = new System.Drawing.Point(26, 101);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(85, 23);
            this.lblInicioSesion.TabIndex = 2;
            this.lblInicioSesion.Text = "Inicio Sesion:";
            // 
            // lblHoraR
            // 
            this.lblHoraR.AutoSize = true;
            this.lblHoraR.Location = new System.Drawing.Point(134, 30);
            this.lblHoraR.Name = "lblHoraR";
            this.lblHoraR.Size = new System.Drawing.Size(0, 13);
            this.lblHoraR.TabIndex = 3;
            // 
            // lblFechaR
            // 
            this.lblFechaR.AutoSize = true;
            this.lblFechaR.Location = new System.Drawing.Point(134, 67);
            this.lblFechaR.Name = "lblFechaR";
            this.lblFechaR.Size = new System.Drawing.Size(0, 13);
            this.lblFechaR.TabIndex = 4;
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Location = new System.Drawing.Point(134, 101);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(0, 13);
            this.lblSesion.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(27, 142);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(66, 23);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nombre: ";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.Location = new System.Drawing.Point(27, 182);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(58, 23);
            this.lblUsu.TabIndex = 7;
            this.lblUsu.Text = "Usuario:";
            // 
            // lblPerf
            // 
            this.lblPerf.AutoSize = true;
            this.lblPerf.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerf.Location = new System.Drawing.Point(27, 224);
            this.lblPerf.Name = "lblPerf";
            this.lblPerf.Size = new System.Drawing.Size(42, 23);
            this.lblPerf.TabIndex = 8;
            this.lblPerf.Text = "Perfil:";
            // 
            // lblNombreR
            // 
            this.lblNombreR.AutoSize = true;
            this.lblNombreR.Location = new System.Drawing.Point(134, 144);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(0, 13);
            this.lblNombreR.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(134, 184);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblUsuario.TabIndex = 10;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(134, 224);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(0, 13);
            this.lblPerfil.TabIndex = 11;
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(304, 447);
            this.Controls.Add(this.tbcADM);
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
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.Label lblFechaR;
        private System.Windows.Forms.Label lblHoraR;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPerf;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombreR;
    }
}