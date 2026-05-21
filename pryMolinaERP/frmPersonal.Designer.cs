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
            this.tbpContacto = new System.Windows.Forms.TabPage();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblProv = new System.Windows.Forms.Label();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.lblGeo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtGeo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblredes = new System.Windows.Forms.Label();
            this.cmbRedes = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.tbcDatos.SuspendLayout();
            this.tbpDomicilio.SuspendLayout();
            this.tbpContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(23, 19);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 73);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tbpDomicilio);
            this.tbcDatos.Controls.Add(this.tbpContacto);
            this.tbcDatos.Location = new System.Drawing.Point(12, 103);
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
            this.tbpDomicilio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDomicilio.Size = new System.Drawing.Size(224, 221);
            this.tbpDomicilio.TabIndex = 0;
            this.tbpDomicilio.Text = "Domicilio";
            this.tbpDomicilio.UseVisualStyleBackColor = true;
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
            this.tbpContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContacto.Size = new System.Drawing.Size(224, 221);
            this.tbpContacto.TabIndex = 1;
            this.tbpContacto.Text = "Contacto";
            this.tbpContacto.UseVisualStyleBackColor = true;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(89, 16);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(89, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
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
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Location = new System.Drawing.Point(16, 71);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(56, 13);
            this.lbllocalidad.TabIndex = 1;
            this.lbllocalidad.Text = "Localidad:";
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
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(114, 159);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(100, 20);
            this.txtGeo.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(114, 114);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // cmbProv
            // 
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(114, 27);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(100, 21);
            this.cmbProv.TabIndex = 6;
            // 
            // cmbLoc
            // 
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Location = new System.Drawing.Point(114, 68);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(100, 21);
            this.cmbLoc.TabIndex = 7;
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
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(19, 78);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono:";
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
            // cmbRedes
            // 
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Location = new System.Drawing.Point(103, 116);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(103, 21);
            this.cmbRedes.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(103, 75);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(103, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(76, 36);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(130, 20);
            this.txtMail.TabIndex = 5;
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
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(256, 362);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.tbcDatos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDNI);
            this.Name = "frmPersonal";
            this.Text = "Recursos Humanos";
            this.tbcDatos.ResumeLayout(false);
            this.tbpDomicilio.ResumeLayout(false);
            this.tbpDomicilio.PerformLayout();
            this.tbpContacto.ResumeLayout(false);
            this.tbpContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}