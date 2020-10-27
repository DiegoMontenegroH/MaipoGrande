﻿namespace Presentancion
{
    partial class ListarTrasportista
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
            this.BtnClienteExterno = new FontAwesome.Sharp.IconButton();
            this.BtnInformes = new FontAwesome.Sharp.IconButton();
            this.BtnTrasportista = new FontAwesome.Sharp.IconButton();
            this.BtnSolicitud = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTras.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTras
            // 
            this.panelTras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.panelTras.Controls.Add(this.BtnClienteExterno);
            this.panelTras.Controls.Add(this.BtnInformes);
            this.panelTras.Controls.Add(this.BtnTrasportista);
            this.panelTras.Controls.Add(this.BtnSolicitud);
            this.panelTras.Controls.Add(this.panelLogo);
            this.panelTras.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTras.Location = new System.Drawing.Point(0, 0);
            this.panelTras.Name = "panelTras";
            this.panelTras.Size = new System.Drawing.Size(220, 450);
            this.panelTras.TabIndex = 0;
            // 
            // BtnClienteExterno
            // 
            this.BtnClienteExterno.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClienteExterno.FlatAppearance.BorderSize = 0;
            this.BtnClienteExterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClienteExterno.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClienteExterno.ForeColor = System.Drawing.Color.White;
            this.BtnClienteExterno.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClienteExterno.IconColor = System.Drawing.Color.White;
            this.BtnClienteExterno.IconSize = 40;
            this.BtnClienteExterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClienteExterno.Location = new System.Drawing.Point(0, 300);
            this.BtnClienteExterno.Name = "BtnClienteExterno";
            this.BtnClienteExterno.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnClienteExterno.Rotation = 0D;
            this.BtnClienteExterno.Size = new System.Drawing.Size(220, 60);
            this.BtnClienteExterno.TabIndex = 4;
            this.BtnClienteExterno.Text = "BtnClienteExterno";
            this.BtnClienteExterno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClienteExterno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClienteExterno.UseVisualStyleBackColor = true;
            this.BtnClienteExterno.Click += new System.EventHandler(this.BtnClienteExterno_Click);
            // 
            // BtnInformes
            // 
            this.BtnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInformes.FlatAppearance.BorderSize = 0;
            this.BtnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInformes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnInformes.ForeColor = System.Drawing.Color.White;
            this.BtnInformes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.BtnInformes.IconColor = System.Drawing.Color.White;
            this.BtnInformes.IconSize = 40;
            this.BtnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInformes.Location = new System.Drawing.Point(0, 240);
            this.BtnInformes.Name = "BtnInformes";
            this.BtnInformes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnInformes.Rotation = 0D;
            this.BtnInformes.Size = new System.Drawing.Size(220, 60);
            this.BtnInformes.TabIndex = 3;
            this.BtnInformes.Text = "BtnInforme";
            this.BtnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInformes.UseVisualStyleBackColor = true;
            this.BtnInformes.Click += new System.EventHandler(this.BtnInforme_Click);
            // 
            // BtnTrasportista
            // 
            this.BtnTrasportista.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTrasportista.FlatAppearance.BorderSize = 0;
            this.BtnTrasportista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrasportista.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnTrasportista.ForeColor = System.Drawing.Color.White;
            this.BtnTrasportista.IconChar = FontAwesome.Sharp.IconChar.TruckPickup;
            this.BtnTrasportista.IconColor = System.Drawing.Color.White;
            this.BtnTrasportista.IconSize = 40;
            this.BtnTrasportista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrasportista.Location = new System.Drawing.Point(0, 180);
            this.BtnTrasportista.Name = "BtnTrasportista";
            this.BtnTrasportista.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnTrasportista.Rotation = 0D;
            this.BtnTrasportista.Size = new System.Drawing.Size(220, 60);
            this.BtnTrasportista.TabIndex = 2;
            this.BtnTrasportista.Text = "BtnTrasportista";
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
            this.BtnSolicitud.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSolicitud.ForeColor = System.Drawing.Color.White;
            this.BtnSolicitud.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.BtnSolicitud.IconColor = System.Drawing.Color.White;
            this.BtnSolicitud.IconSize = 40;
            this.BtnSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSolicitud.Location = new System.Drawing.Point(0, 120);
            this.BtnSolicitud.Name = "BtnSolicitud";
            this.BtnSolicitud.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnSolicitud.Rotation = 0D;
            this.BtnSolicitud.Size = new System.Drawing.Size(220, 60);
            this.BtnSolicitud.TabIndex = 1;
            this.BtnSolicitud.Text = "BtnSolicitudes";
            this.BtnSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSolicitud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSolicitud.UseVisualStyleBackColor = true;
            this.BtnSolicitud.Click += new System.EventHandler(this.BtnSolicitudes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.PicLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::Presentancion.Properties.Resources.Logo_FrutOnline;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(220, 120);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            this.PicLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ListarTrasportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTras);
            this.Name = "ListarTrasportista";
            this.Text = "Form1";
            this.panelTras.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTras;
        private FontAwesome.Sharp.IconButton BtnSolicitud;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton BtnInformes;
        private FontAwesome.Sharp.IconButton BtnTrasportista;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PicLogo;
        private FontAwesome.Sharp.IconButton BtnClienteExterno;
    }
}
