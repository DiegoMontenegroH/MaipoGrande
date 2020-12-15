namespace Presentancion.Formularios
{
    partial class Reportes
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnReporteInterno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(106, 121);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(225, 187);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Reporte Ventas Externas";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnReporteInterno
            // 
            this.btnReporteInterno.Location = new System.Drawing.Point(452, 121);
            this.btnReporteInterno.Name = "btnReporteInterno";
            this.btnReporteInterno.Size = new System.Drawing.Size(231, 187);
            this.btnReporteInterno.TabIndex = 1;
            this.btnReporteInterno.Text = "Generar Reporte Ventas Internas";
            this.btnReporteInterno.UseVisualStyleBackColor = true;
            this.btnReporteInterno.Click += new System.EventHandler(this.btnReporteInterno_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentancion.Properties.Resources._1b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporteInterno);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnReporteInterno;
    }
}