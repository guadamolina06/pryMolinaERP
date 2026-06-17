namespace pryMolinaERP
{
    partial class frmPerfil
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
            this.lblCargo   = new System.Windows.Forms.Label();
            this.txtCargo   = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnsalir   = new System.Windows.Forms.Button();
            this.pnlHeader  = new System.Windows.Forms.Panel();
            this.lblTitle   = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            var BG_PAGE   = System.Drawing.Color.FromArgb(248, 249, 250);
            var BG_WHITE  = System.Drawing.Color.White;
            var ACCENT    = System.Drawing.Color.FromArgb(37, 99, 235);
            var TEXT_PRI  = System.Drawing.Color.FromArgb(30, 41, 59);
            var TEXT_SEC  = System.Drawing.Color.FromArgb(100, 116, 139);
            var BTN_GHOST = System.Drawing.Color.FromArgb(226, 232, 240);

            // ── pnlHeader ───────────────────────────────────────────────────
            this.pnlHeader.BackColor = ACCENT;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 56;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Gestión de Perfiles";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblCargo ────────────────────────────────────────────────────
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCargo.ForeColor = TEXT_SEC;
            this.lblCargo.Location = new System.Drawing.Point(40, 74);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Text = "NOMBRE DEL PERFIL";

            // ── txtCargo ────────────────────────────────────────────────────
            this.txtCargo.BackColor = BG_WHITE;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCargo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCargo.ForeColor = TEXT_PRI;
            this.txtCargo.Location = new System.Drawing.Point(40, 96);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(320, 30);
            this.txtCargo.TabIndex = 1;

            // ── btnGuardar ──────────────────────────────────────────────────
            this.btnGuardar.BackColor = ACCENT;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(220, 148);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 34);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ── btnsalir ────────────────────────────────────────────────────
            this.btnsalir.BackColor = BTN_GHOST;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnsalir.ForeColor = TEXT_SEC;
            this.btnsalir.Location = new System.Drawing.Point(40, 148);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(140, 34);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);

            // ── frmPerfil ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = BG_PAGE;
            this.ClientSize = new System.Drawing.Size(400, 202);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Perfiles";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
    }
}
