namespace WindowsLab_Loop
{
    partial class FrmCaso2
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
            this.btnIngresoPrecios = new System.Windows.Forms.Button();
            this.lstPrecios = new System.Windows.Forms.ListBox();
            this.lstSumaPrecios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIngresoPrecios
            // 
            this.btnIngresoPrecios.Location = new System.Drawing.Point(98, 76);
            this.btnIngresoPrecios.Name = "btnIngresoPrecios";
            this.btnIngresoPrecios.Size = new System.Drawing.Size(125, 49);
            this.btnIngresoPrecios.TabIndex = 0;
            this.btnIngresoPrecios.Text = "Ingresar precios";
            this.btnIngresoPrecios.UseVisualStyleBackColor = true;
            this.btnIngresoPrecios.Click += new System.EventHandler(this.btnIngresoPrecios_Click);
            // 
            // lstPrecios
            // 
            this.lstPrecios.FormattingEnabled = true;
            this.lstPrecios.Location = new System.Drawing.Point(253, 76);
            this.lstPrecios.Name = "lstPrecios";
            this.lstPrecios.Size = new System.Drawing.Size(120, 95);
            this.lstPrecios.TabIndex = 1;
            // 
            // lstSumaPrecios
            // 
            this.lstSumaPrecios.FormattingEnabled = true;
            this.lstSumaPrecios.Location = new System.Drawing.Point(407, 76);
            this.lstSumaPrecios.Name = "lstSumaPrecios";
            this.lstSumaPrecios.Size = new System.Drawing.Size(123, 30);
            this.lstSumaPrecios.TabIndex = 2;
            // 
            // FrmCaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSumaPrecios);
            this.Controls.Add(this.lstPrecios);
            this.Controls.Add(this.btnIngresoPrecios);
            this.Name = "FrmCaso2";
            this.Text = "FrmCaso2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoPrecios;
        private System.Windows.Forms.ListBox lstPrecios;
        private System.Windows.Forms.ListBox lstSumaPrecios;
    }
}