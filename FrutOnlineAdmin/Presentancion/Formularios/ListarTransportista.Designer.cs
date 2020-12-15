namespace Presentancion.Formularios
{
    partial class ListarTransportista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.LblRut = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 125);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(600, 183);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(87, 50);
            this.BtnCargar.TabIndex = 1;
            this.BtnCargar.Text = "Cargar Transportistas";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(214, 223);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(140, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(214, 260);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(140, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(214, 185);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(140, 20);
            this.txtRut.TabIndex = 4;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsertar.Location = new System.Drawing.Point(418, 185);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(102, 48);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Agregar Transportista";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(214, 295);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(140, 20);
            this.TxtTelefono.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(214, 332);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(214, 370);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // LblRut
            // 
            this.LblRut.AutoSize = true;
            this.LblRut.BackColor = System.Drawing.Color.Transparent;
            this.LblRut.Location = new System.Drawing.Point(38, 185);
            this.LblRut.Name = "LblRut";
            this.LblRut.Size = new System.Drawing.Size(24, 13);
            this.LblRut.TabIndex = 9;
            this.LblRut.Text = "Rut";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Location = new System.Drawing.Point(38, 226);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 10;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.BackColor = System.Drawing.Color.Transparent;
            this.LblApellido.Location = new System.Drawing.Point(38, 267);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(44, 13);
            this.LblApellido.TabIndex = 11;
            this.LblApellido.Text = "Apellido";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.LblTelefono.Location = new System.Drawing.Point(38, 302);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 12;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Location = new System.Drawing.Point(38, 335);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 13;
            this.LblEmail.Text = "Email";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.BackColor = System.Drawing.Color.Transparent;
            this.LblUserName.Location = new System.Drawing.Point(38, 373);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(98, 13);
            this.LblUserName.TabIndex = 14;
            this.LblUserName.Text = "Nombre de Usuario";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Location = new System.Drawing.Point(418, 267);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 44);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar Transportista";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEliminar.Location = new System.Drawing.Point(418, 346);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(103, 44);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar Transportista";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ListarTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentancion.Properties.Resources.trans_bl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblRut);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListarTransportista";
            this.Text = "ListarTransportista";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label LblRut;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}