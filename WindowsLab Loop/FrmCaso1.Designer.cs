namespace WindowsLab_Loop
{
    partial class FrmCaso1
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
            this.btnIngresoAlumnos = new System.Windows.Forms.Button();
            this.lstVector = new System.Windows.Forms.ListBox();
            this.vectorPromedio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIngresoAlumnos
            // 
            this.btnIngresoAlumnos.Location = new System.Drawing.Point(107, 111);
            this.btnIngresoAlumnos.Name = "btnIngresoAlumnos";
            this.btnIngresoAlumnos.Size = new System.Drawing.Size(155, 54);
            this.btnIngresoAlumnos.TabIndex = 0;
            this.btnIngresoAlumnos.Text = "Cargar alumnos + notas";
            this.btnIngresoAlumnos.UseVisualStyleBackColor = true;
            this.btnIngresoAlumnos.Click += new System.EventHandler(this.btnIngresoAlumnos_Click);
            // 
            // lstVector
            // 
            this.lstVector.FormattingEnabled = true;
            this.lstVector.Location = new System.Drawing.Point(307, 111);
            this.lstVector.Name = "lstVector";
            this.lstVector.Size = new System.Drawing.Size(174, 173);
            this.lstVector.TabIndex = 2;
            // 
            // vectorPromedio
            // 
            this.vectorPromedio.FormattingEnabled = true;
            this.vectorPromedio.Location = new System.Drawing.Point(516, 111);
            this.vectorPromedio.Name = "vectorPromedio";
            this.vectorPromedio.Size = new System.Drawing.Size(174, 173);
            this.vectorPromedio.TabIndex = 3;
            // 
            // FrmCaso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vectorPromedio);
            this.Controls.Add(this.lstVector);
            this.Controls.Add(this.btnIngresoAlumnos);
            this.Name = "FrmCaso1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoAlumnos;
        private System.Windows.Forms.ListBox lstVector;
        private System.Windows.Forms.ListBox vectorPromedio;
    }
}

