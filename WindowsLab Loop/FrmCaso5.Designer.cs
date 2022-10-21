namespace WindowsLab_Loop
{
    partial class FrmCaso5
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
            this.btnIngresarProvincias = new System.Windows.Forms.Button();
            this.btnTemperaturasMedias = new System.Windows.Forms.Button();
            this.btnMostrarMesesxTemp = new System.Windows.Forms.Button();
            this.lstMesesxTemp = new System.Windows.Forms.ListBox();
            this.btnCalcularMediaTrimestral = new System.Windows.Forms.Button();
            this.btnMuestraMediasTrim = new System.Windows.Forms.Button();
            this.lstMediasTrimestrales = new System.Windows.Forms.ListBox();
            this.btnMostrarMayorProvinciaTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarProvincias
            // 
            this.btnIngresarProvincias.Location = new System.Drawing.Point(58, 48);
            this.btnIngresarProvincias.Name = "btnIngresarProvincias";
            this.btnIngresarProvincias.Size = new System.Drawing.Size(153, 45);
            this.btnIngresarProvincias.TabIndex = 0;
            this.btnIngresarProvincias.Text = "Ingresar Provincias";
            this.btnIngresarProvincias.UseVisualStyleBackColor = true;
            this.btnIngresarProvincias.Click += new System.EventHandler(this.btnIngresarProvincias_Click);
            // 
            // btnTemperaturasMedias
            // 
            this.btnTemperaturasMedias.Location = new System.Drawing.Point(58, 123);
            this.btnTemperaturasMedias.Name = "btnTemperaturasMedias";
            this.btnTemperaturasMedias.Size = new System.Drawing.Size(153, 54);
            this.btnTemperaturasMedias.TabIndex = 1;
            this.btnTemperaturasMedias.Text = "Ingresar temperaturas mensuales p/ provincia";
            this.btnTemperaturasMedias.UseVisualStyleBackColor = true;
            this.btnTemperaturasMedias.Click += new System.EventHandler(this.btnTemperaturasMedias_Click);
            // 
            // btnMostrarMesesxTemp
            // 
            this.btnMostrarMesesxTemp.Location = new System.Drawing.Point(260, 48);
            this.btnMostrarMesesxTemp.Name = "btnMostrarMesesxTemp";
            this.btnMostrarMesesxTemp.Size = new System.Drawing.Size(226, 45);
            this.btnMostrarMesesxTemp.TabIndex = 2;
            this.btnMostrarMesesxTemp.Text = "Mostrar provincias con sus medias mensuales";
            this.btnMostrarMesesxTemp.UseVisualStyleBackColor = true;
            this.btnMostrarMesesxTemp.Click += new System.EventHandler(this.btnMostrarMesesxTemp_Click);
            // 
            // lstMesesxTemp
            // 
            this.lstMesesxTemp.FormattingEnabled = true;
            this.lstMesesxTemp.Location = new System.Drawing.Point(260, 123);
            this.lstMesesxTemp.Name = "lstMesesxTemp";
            this.lstMesesxTemp.Size = new System.Drawing.Size(226, 290);
            this.lstMesesxTemp.TabIndex = 3;
            // 
            // btnCalcularMediaTrimestral
            // 
            this.btnCalcularMediaTrimestral.Location = new System.Drawing.Point(58, 205);
            this.btnCalcularMediaTrimestral.Name = "btnCalcularMediaTrimestral";
            this.btnCalcularMediaTrimestral.Size = new System.Drawing.Size(153, 54);
            this.btnCalcularMediaTrimestral.TabIndex = 4;
            this.btnCalcularMediaTrimestral.Text = "Calcular media Trimestral";
            this.btnCalcularMediaTrimestral.UseVisualStyleBackColor = true;
            this.btnCalcularMediaTrimestral.Click += new System.EventHandler(this.btnCalcularMediaTrimestral_Click);
            // 
            // btnMuestraMediasTrim
            // 
            this.btnMuestraMediasTrim.Location = new System.Drawing.Point(524, 48);
            this.btnMuestraMediasTrim.Name = "btnMuestraMediasTrim";
            this.btnMuestraMediasTrim.Size = new System.Drawing.Size(185, 45);
            this.btnMuestraMediasTrim.TabIndex = 5;
            this.btnMuestraMediasTrim.Text = "Mostrar Medias Trimestrales";
            this.btnMuestraMediasTrim.UseVisualStyleBackColor = true;
            this.btnMuestraMediasTrim.Click += new System.EventHandler(this.btnMuestraMediasTrim_Click);
            // 
            // lstMediasTrimestrales
            // 
            this.lstMediasTrimestrales.FormattingEnabled = true;
            this.lstMediasTrimestrales.Location = new System.Drawing.Point(524, 123);
            this.lstMediasTrimestrales.Name = "lstMediasTrimestrales";
            this.lstMediasTrimestrales.Size = new System.Drawing.Size(185, 290);
            this.lstMediasTrimestrales.TabIndex = 6;
            // 
            // btnMostrarMayorProvinciaTemp
            // 
            this.btnMostrarMayorProvinciaTemp.Location = new System.Drawing.Point(58, 297);
            this.btnMostrarMayorProvinciaTemp.Name = "btnMostrarMayorProvinciaTemp";
            this.btnMostrarMayorProvinciaTemp.Size = new System.Drawing.Size(153, 60);
            this.btnMostrarMayorProvinciaTemp.TabIndex = 7;
            this.btnMostrarMayorProvinciaTemp.Text = "Mostrar provincia con mayor temperatura promedio trimestral";
            this.btnMostrarMayorProvinciaTemp.UseVisualStyleBackColor = true;
            this.btnMostrarMayorProvinciaTemp.Click += new System.EventHandler(this.btnMostrarMayorProvinciaTemp_Click);
            // 
            // FrmCaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarMayorProvinciaTemp);
            this.Controls.Add(this.lstMediasTrimestrales);
            this.Controls.Add(this.btnMuestraMediasTrim);
            this.Controls.Add(this.btnCalcularMediaTrimestral);
            this.Controls.Add(this.lstMesesxTemp);
            this.Controls.Add(this.btnMostrarMesesxTemp);
            this.Controls.Add(this.btnTemperaturasMedias);
            this.Controls.Add(this.btnIngresarProvincias);
            this.Name = "FrmCaso5";
            this.Text = "FrmCaso5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarProvincias;
        private System.Windows.Forms.Button btnTemperaturasMedias;
        private System.Windows.Forms.Button btnMostrarMesesxTemp;
        private System.Windows.Forms.ListBox lstMesesxTemp;
        private System.Windows.Forms.Button btnCalcularMediaTrimestral;
        private System.Windows.Forms.Button btnMuestraMediasTrim;
        private System.Windows.Forms.ListBox lstMediasTrimestrales;
        private System.Windows.Forms.Button btnMostrarMayorProvinciaTemp;
    }
}