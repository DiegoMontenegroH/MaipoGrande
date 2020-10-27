namespace LOGIN
{
    partial class FormNegro
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
            this.panelBlanco = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.raya1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.raya2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_acceder = new System.Windows.Forms.Button();
            this.linkpass = new System.Windows.Forms.LinkLabel();
            this.link_cerrar = new System.Windows.Forms.LinkLabel();
            this.link_minimizar = new System.Windows.Forms.LinkLabel();
            this.panelBlanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBlanco
            // 
            this.panelBlanco.BackColor = System.Drawing.Color.White;
            this.panelBlanco.Controls.Add(this.pictureBox1);
            this.panelBlanco.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBlanco.Location = new System.Drawing.Point(0, 0);
            this.panelBlanco.Name = "panelBlanco";
            this.panelBlanco.Size = new System.Drawing.Size(250, 330);
            this.panelBlanco.TabIndex = 0;
            this.panelBlanco.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBlanco_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // raya1
            // 
            this.raya1.AutoSize = true;
            this.raya1.Enabled = false;
            this.raya1.ForeColor = System.Drawing.Color.White;
            this.raya1.Location = new System.Drawing.Point(314, 72);
            this.raya1.Name = "raya1";
            this.raya1.Size = new System.Drawing.Size(403, 13);
            this.raya1.TabIndex = 1;
            this.raya1.Text = "__________________________________________________________________";
            this.raya1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raya1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.Location = new System.Drawing.Point(317, 58);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(400, 20);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.Text = "USUARIO";
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // raya2
            // 
            this.raya2.AutoSize = true;
            this.raya2.Enabled = false;
            this.raya2.ForeColor = System.Drawing.Color.White;
            this.raya2.Location = new System.Drawing.Point(314, 186);
            this.raya2.Name = "raya2";
            this.raya2.Size = new System.Drawing.Size(403, 13);
            this.raya2.TabIndex = 4;
            this.raya2.Text = "__________________________________________________________________";
            this.raya2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(317, 172);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(400, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "CONTRASEÑA";
            this.txtpass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(479, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(90, 30);
            this.lbl_login.TabIndex = 6;
            this.lbl_login.Text = "LOGIN";
            // 
            // btn_acceder
            // 
            this.btn_acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acceder.ForeColor = System.Drawing.Color.White;
            this.btn_acceder.Location = new System.Drawing.Point(317, 246);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(400, 40);
            this.btn_acceder.TabIndex = 3;
            this.btn_acceder.Text = "ACCEDER";
            this.btn_acceder.UseVisualStyleBackColor = false;
            this.btn_acceder.Click += new System.EventHandler(this.btn_acceder_Click);
            // 
            // linkpass
            // 
            this.linkpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkpass.AutoSize = true;
            this.linkpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkpass.LinkColor = System.Drawing.Color.LightGray;
            this.linkpass.Location = new System.Drawing.Point(423, 304);
            this.linkpass.Name = "linkpass";
            this.linkpass.Size = new System.Drawing.Size(188, 17);
            this.linkpass.TabIndex = 0;
            this.linkpass.TabStop = true;
            this.linkpass.Text = "¿has olvidado tu contraseña ?";
            // 
            // link_cerrar
            // 
            this.link_cerrar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.link_cerrar.AutoSize = true;
            this.link_cerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_cerrar.LinkColor = System.Drawing.Color.LightGray;
            this.link_cerrar.Location = new System.Drawing.Point(757, 15);
            this.link_cerrar.Name = "link_cerrar";
            this.link_cerrar.Size = new System.Drawing.Size(16, 17);
            this.link_cerrar.TabIndex = 9;
            this.link_cerrar.TabStop = true;
            this.link_cerrar.Text = "X";
            this.link_cerrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // link_minimizar
            // 
            this.link_minimizar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.link_minimizar.AutoSize = true;
            this.link_minimizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_minimizar.LinkColor = System.Drawing.Color.LightGray;
            this.link_minimizar.Location = new System.Drawing.Point(736, 15);
            this.link_minimizar.Name = "link_minimizar";
            this.link_minimizar.Size = new System.Drawing.Size(15, 17);
            this.link_minimizar.TabIndex = 11;
            this.link_minimizar.TabStop = true;
            this.link_minimizar.Text = "_";
            this.link_minimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.link_minimizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_minimizar_LinkClicked);
            // 
            // FormNegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.link_minimizar);
            this.Controls.Add(this.link_cerrar);
            this.Controls.Add(this.linkpass);
            this.Controls.Add(this.btn_acceder);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.raya2);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.raya1);
            this.Controls.Add(this.panelBlanco);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNegro";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormNegro_MouseDown);
            this.panelBlanco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBlanco;
        private System.Windows.Forms.Label raya1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label raya2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_acceder;
        private System.Windows.Forms.LinkLabel linkpass;
        private System.Windows.Forms.LinkLabel link_cerrar;
        private System.Windows.Forms.LinkLabel link_minimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

