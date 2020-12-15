namespace Presentancion
{
    partial class PanelMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTras = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PanelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.iconFormHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.BtnReportes = new FontAwesome.Sharp.IconButton();
            this.BtnContrato = new FontAwesome.Sharp.IconButton();
            this.BtnTransporte = new FontAwesome.Sharp.IconButton();
            this.BtnInformes = new FontAwesome.Sharp.IconButton();
            this.BtnTrasportista = new FontAwesome.Sharp.IconButton();
            this.BtnSolicitud = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTras.SuspendLayout();
            this.PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoActual)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTras
            // 
            this.panelTras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panelTras.Controls.Add(this.BtnReportes);
            this.panelTras.Controls.Add(this.BtnContrato);
            this.panelTras.Controls.Add(this.BtnTransporte);
            this.panelTras.Controls.Add(this.BtnInformes);
            this.panelTras.Controls.Add(this.BtnTrasportista);
            this.panelTras.Controls.Add(this.BtnSolicitud);
            this.panelTras.Controls.Add(this.panelLogo);
            this.panelTras.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTras.Location = new System.Drawing.Point(0, 0);
            this.panelTras.Name = "panelTras";
            this.panelTras.Size = new System.Drawing.Size(220, 561);
            this.panelTras.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PanelTitleBar
            // 
            this.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.PanelTitleBar.Controls.Add(this.btnCerrar);
            this.PanelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.PanelTitleBar.Controls.Add(this.iconFormHijoActual);
            this.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.PanelTitleBar.Name = "PanelTitleBar";
            this.PanelTitleBar.Size = new System.Drawing.Size(864, 108);
            this.PanelTitleBar.TabIndex = 1;
            this.PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(69, 52);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.Click += new System.EventHandler(this.lblTitleChildForm_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 108);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(864, 12);
            this.panelShadow.TabIndex = 2;
            this.panelShadow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShadow_Paint);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelDesktop.BackgroundImage = global::Presentancion.Properties.Resources.mercabarna_fruta;
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktop.Location = new System.Drawing.Point(220, 120);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(864, 441);
            this.panelDesktop.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 16;
            this.btnCerrar.Location = new System.Drawing.Point(786, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // iconFormHijoActual
            // 
            this.iconFormHijoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.iconFormHijoActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormHijoActual.IconColor = System.Drawing.Color.White;
            this.iconFormHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormHijoActual.IconSize = 42;
            this.iconFormHijoActual.Location = new System.Drawing.Point(19, 39);
            this.iconFormHijoActual.Name = "iconFormHijoActual";
            this.iconFormHijoActual.Size = new System.Drawing.Size(44, 42);
            this.iconFormHijoActual.TabIndex = 0;
            this.iconFormHijoActual.TabStop = false;
            this.iconFormHijoActual.Click += new System.EventHandler(this.iconFormHijoActual_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnReportes.IconColor = System.Drawing.Color.White;
            this.BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnReportes.IconSize = 40;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 420);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnReportes.Size = new System.Drawing.Size(220, 60);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnContrato
            // 
            this.BtnContrato.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnContrato.FlatAppearance.BorderSize = 0;
            this.BtnContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContrato.ForeColor = System.Drawing.Color.White;
            this.BtnContrato.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.BtnContrato.IconColor = System.Drawing.Color.White;
            this.BtnContrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnContrato.IconSize = 40;
            this.BtnContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContrato.Location = new System.Drawing.Point(0, 360);
            this.BtnContrato.Name = "BtnContrato";
            this.BtnContrato.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnContrato.Size = new System.Drawing.Size(220, 60);
            this.BtnContrato.TabIndex = 6;
            this.BtnContrato.Text = "Contrato";
            this.BtnContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContrato.UseVisualStyleBackColor = true;
            this.BtnContrato.Click += new System.EventHandler(this.BtnContrato_Click);
            // 
            // BtnTransporte
            // 
            this.BtnTransporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransporte.FlatAppearance.BorderSize = 0;
            this.BtnTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransporte.ForeColor = System.Drawing.Color.White;
            this.BtnTransporte.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.BtnTransporte.IconColor = System.Drawing.Color.White;
            this.BtnTransporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTransporte.IconSize = 40;
            this.BtnTransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransporte.Location = new System.Drawing.Point(0, 300);
            this.BtnTransporte.Name = "BtnTransporte";
            this.BtnTransporte.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnTransporte.Size = new System.Drawing.Size(220, 60);
            this.BtnTransporte.TabIndex = 5;
            this.BtnTransporte.Text = "Transporte";
            this.BtnTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTransporte.UseVisualStyleBackColor = true;
            this.BtnTransporte.Click += new System.EventHandler(this.BtnTransporte_Click);
            // 
            // BtnInformes
            // 
            this.BtnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInformes.FlatAppearance.BorderSize = 0;
            this.BtnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInformes.ForeColor = System.Drawing.Color.White;
            this.BtnInformes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.BtnInformes.IconColor = System.Drawing.Color.White;
            this.BtnInformes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInformes.IconSize = 40;
            this.BtnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInformes.Location = new System.Drawing.Point(0, 240);
            this.BtnInformes.Name = "BtnInformes";
            this.BtnInformes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnInformes.Size = new System.Drawing.Size(220, 60);
            this.BtnInformes.TabIndex = 3;
            this.BtnInformes.Text = "Informe";
            this.BtnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInformes.UseVisualStyleBackColor = true;
            this.BtnInformes.Visible = false;
            this.BtnInformes.Click += new System.EventHandler(this.BtnInforme_Click);
            // 
            // BtnTrasportista
            // 
            this.BtnTrasportista.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTrasportista.FlatAppearance.BorderSize = 0;
            this.BtnTrasportista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrasportista.ForeColor = System.Drawing.Color.White;
            this.BtnTrasportista.IconChar = FontAwesome.Sharp.IconChar.TruckPickup;
            this.BtnTrasportista.IconColor = System.Drawing.Color.White;
            this.BtnTrasportista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnTrasportista.IconSize = 40;
            this.BtnTrasportista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrasportista.Location = new System.Drawing.Point(0, 180);
            this.BtnTrasportista.Name = "BtnTrasportista";
            this.BtnTrasportista.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnTrasportista.Size = new System.Drawing.Size(220, 60);
            this.BtnTrasportista.TabIndex = 2;
            this.BtnTrasportista.Text = "Trasportista";
            this.BtnTrasportista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrasportista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTrasportista.UseVisualStyleBackColor = true;
            this.BtnTrasportista.Click += new System.EventHandler(this.BtnTrasportistas_Click);
            // 
            // BtnSolicitud
            // 
            this.BtnSolicitud.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSolicitud.FlatAppearance.BorderSize = 0;
            this.BtnSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSolicitud.ForeColor = System.Drawing.Color.White;
            this.BtnSolicitud.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.BtnSolicitud.IconColor = System.Drawing.Color.White;
            this.BtnSolicitud.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSolicitud.IconSize = 40;
            this.BtnSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSolicitud.Location = new System.Drawing.Point(0, 120);
            this.BtnSolicitud.Name = "BtnSolicitud";
            this.BtnSolicitud.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnSolicitud.Size = new System.Drawing.Size(220, 60);
            this.BtnSolicitud.TabIndex = 1;
            this.BtnSolicitud.Text = "Solicitudes";
            this.BtnSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSolicitud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSolicitud.UseVisualStyleBackColor = true;
            this.BtnSolicitud.Click += new System.EventHandler(this.BtnSolicitudes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panelLogo.BackgroundImage = global::Presentancion.Properties.Resources.Logo_FrutOnline_SIN_F1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // PanelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.PanelTitleBar);
            this.Controls.Add(this.panelTras);
            this.Name = "PanelMenu";
            this.Text = "Form1";
            this.panelTras.ResumeLayout(false);
            this.PanelTitleBar.ResumeLayout(false);
            this.PanelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormHijoActual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTras;
        private FontAwesome.Sharp.IconButton BtnSolicitud;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton BtnInformes;
        private FontAwesome.Sharp.IconButton BtnTrasportista;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel PanelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconFormHijoActual;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton BtnTransporte;
        private FontAwesome.Sharp.IconButton BtnContrato;
        private FontAwesome.Sharp.IconButton BtnReportes;
    }
}

