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
            this.tbcDatos.SuspendLayout();
            this.tbpDomicilio.SuspendLayout();
            this.tbpContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(31, 23);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(31, 90);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(31, 54);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tbpDomicilio);
            this.tbcDatos.Controls.Add(this.tbpContacto);
            this.tbcDatos.Location = new System.Drawing.Point(15, 127);
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
            this.tbpDomicilio.Location = new System.Drawing.Point(4, 25);
            this.tbpDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDomicilio.Name = "tbpDomicilio";
            this.tbpDomicilio.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDomicilio.Size = new System.Drawing.Size(301, 275);
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
            this.cmbLoc.Size = new System.Drawing.Size(132, 24);
            this.cmbLoc.TabIndex = 7;
            // 
            // cmbProv
            // 
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(152, 33);
            this.cmbProv.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(132, 24);
            this.cmbProv.TabIndex = 6;
            this.cmbProv.SelectedIndexChanged += new System.EventHandler(this.cmbProv_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(152, 140);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtGeo
            // 
            this.txtGeo.Location = new System.Drawing.Point(152, 196);
            this.txtGeo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeo.Name = "txtGeo";
            this.txtGeo.Size = new System.Drawing.Size(132, 22);
            this.txtGeo.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(23, 144);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblGeo
            // 
            this.lblGeo.AutoSize = true;
            this.lblGeo.Location = new System.Drawing.Point(21, 199);
            this.lblGeo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeo.Name = "lblGeo";
            this.lblGeo.Size = new System.Drawing.Size(117, 16);
            this.lblGeo.TabIndex = 2;
            this.lblGeo.Text = "Geo(cordenadas):";
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Location = new System.Drawing.Point(21, 87);
            this.lbllocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(70, 16);
            this.lbllocalidad.TabIndex = 1;
            this.lbllocalidad.Text = "Localidad:";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Location = new System.Drawing.Point(21, 33);
            this.lblProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(66, 16);
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
            this.chkActivo.Size = new System.Drawing.Size(66, 20);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(101, 44);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(172, 22);
            this.txtMail.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 92);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(136, 22);
            this.txtTelefono.TabIndex = 4;
            // 
            // cmbRedes
            // 
            this.cmbRedes.FormattingEnabled = true;
            this.cmbRedes.Location = new System.Drawing.Point(137, 143);
            this.cmbRedes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRedes.Name = "cmbRedes";
            this.cmbRedes.Size = new System.Drawing.Size(136, 24);
            this.cmbRedes.TabIndex = 3;
            // 
            // lblredes
            // 
            this.lblredes.AutoSize = true;
            this.lblredes.Location = new System.Drawing.Point(25, 146);
            this.lblredes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblredes.Name = "lblredes";
            this.lblredes.Size = new System.Drawing.Size(51, 16);
            this.lblredes.TabIndex = 2;
            this.lblredes.Text = "Redes:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 96);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(29, 44);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 16);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(119, 20);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(132, 22);
            this.txtdni.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(119, 82);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(15, 453);
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
            this.btnNuevo.Location = new System.Drawing.Point(173, 453);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 26);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(254, 453);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 26);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(341, 491);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.tbcDatos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDNI);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonal";
            this.Text = "Recursos Humanos";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
    }
}