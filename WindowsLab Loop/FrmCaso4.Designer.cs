namespace WindowsLab_Loop
{
    partial class FrmCaso4
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
            this.btnCargaDatos = new System.Windows.Forms.Button();
            this.btnMostarMayores = new System.Windows.Forms.Button();
            this.lstMayoresEdad = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCargaDatos
            // 
            this.btnCargaDatos.Location = new System.Drawing.Point(34, 166);
            this.btnCargaDatos.Name = "btnCargaDatos";
            this.btnCargaDatos.Size = new System.Drawing.Size(183, 46);
            this.btnCargaDatos.TabIndex = 0;
            this.btnCargaDatos.Text = "Ingresar personas y edad";
            this.btnCargaDatos.UseVisualStyleBackColor = true;
            this.btnCargaDatos.Click += new System.EventHandler(this.btnCargaDatos_Click);
            // 
            // btnMostarMayores
            // 
            this.btnMostarMayores.Location = new System.Drawing.Point(270, 34);
            this.btnMostarMayores.Name = "btnMostarMayores";
            this.btnMostarMayores.Size = new System.Drawing.Size(145, 45);
            this.btnMostarMayores.TabIndex = 1;
            this.btnMostarMayores.Text = "Mostrar Mayores de Edad (+18)";
            this.btnMostarMayores.UseVisualStyleBackColor = true;
            this.btnMostarMayores.Click += new System.EventHandler(this.btnMostarMayores_Click);
            // 
            // lstMayoresEdad
            // 
            this.lstMayoresEdad.FormattingEnabled = true;
            this.lstMayoresEdad.Location = new System.Drawing.Point(270, 106);
            this.lstMayoresEdad.Name = "lstMayoresEdad";
            this.lstMayoresEdad.Size = new System.Drawing.Size(145, 160);
            this.lstMayoresEdad.TabIndex = 2;
            // 
            // FrmCaso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMayoresEdad);
            this.Controls.Add(this.btnMostarMayores);
            this.Controls.Add(this.btnCargaDatos);
            this.Name = "FrmCaso4";
            this.Text = "FrmCaso4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaDatos;
        private System.Windows.Forms.Button btnMostarMayores;
        private System.Windows.Forms.ListBox lstMayoresEdad;
    }
}