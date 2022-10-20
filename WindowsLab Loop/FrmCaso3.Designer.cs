namespace WindowsLab_Loop
{
    partial class FrmCaso3
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
            this.btnCargaOperarios = new System.Windows.Forms.Button();
            this.btnMuestraOperarios = new System.Windows.Forms.Button();
            this.listOperarios = new System.Windows.Forms.ListBox();
            this.btnCargaSueldos = new System.Windows.Forms.Button();
            this.listTotalOperario = new System.Windows.Forms.ListBox();
            this.btnMuestraTotal = new System.Windows.Forms.Button();
            this.btnMejorPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargaOperarios
            // 
            this.btnCargaOperarios.Location = new System.Drawing.Point(92, 91);
            this.btnCargaOperarios.Name = "btnCargaOperarios";
            this.btnCargaOperarios.Size = new System.Drawing.Size(128, 23);
            this.btnCargaOperarios.TabIndex = 0;
            this.btnCargaOperarios.Text = "Cargar Operarios";
            this.btnCargaOperarios.UseVisualStyleBackColor = true;
            this.btnCargaOperarios.Click += new System.EventHandler(this.btnCargaOperarios_Click);
            // 
            // btnMuestraOperarios
            // 
            this.btnMuestraOperarios.Location = new System.Drawing.Point(92, 138);
            this.btnMuestraOperarios.Name = "btnMuestraOperarios";
            this.btnMuestraOperarios.Size = new System.Drawing.Size(128, 26);
            this.btnMuestraOperarios.TabIndex = 1;
            this.btnMuestraOperarios.Text = "Mostrar operarios";
            this.btnMuestraOperarios.UseVisualStyleBackColor = true;
            this.btnMuestraOperarios.Click += new System.EventHandler(this.btnMuestraOperarios_Click);
            // 
            // listOperarios
            // 
            this.listOperarios.FormattingEnabled = true;
            this.listOperarios.Location = new System.Drawing.Point(92, 180);
            this.listOperarios.Name = "listOperarios";
            this.listOperarios.Size = new System.Drawing.Size(128, 173);
            this.listOperarios.TabIndex = 2;
            // 
            // btnCargaSueldos
            // 
            this.btnCargaSueldos.Location = new System.Drawing.Point(264, 91);
            this.btnCargaSueldos.Name = "btnCargaSueldos";
            this.btnCargaSueldos.Size = new System.Drawing.Size(186, 23);
            this.btnCargaSueldos.TabIndex = 3;
            this.btnCargaSueldos.Text = "Cargar ultimos 3 sueldos";
            this.btnCargaSueldos.UseVisualStyleBackColor = true;
            this.btnCargaSueldos.Click += new System.EventHandler(this.btnCargaSueldos_Click);
            // 
            // listTotalOperario
            // 
            this.listTotalOperario.FormattingEnabled = true;
            this.listTotalOperario.Location = new System.Drawing.Point(293, 180);
            this.listTotalOperario.Name = "listTotalOperario";
            this.listTotalOperario.Size = new System.Drawing.Size(131, 173);
            this.listTotalOperario.TabIndex = 4;
            // 
            // btnMuestraTotal
            // 
            this.btnMuestraTotal.Location = new System.Drawing.Point(264, 138);
            this.btnMuestraTotal.Name = "btnMuestraTotal";
            this.btnMuestraTotal.Size = new System.Drawing.Size(186, 26);
            this.btnMuestraTotal.TabIndex = 5;
            this.btnMuestraTotal.Text = "Mostrar total por operario";
            this.btnMuestraTotal.UseVisualStyleBackColor = true;
            this.btnMuestraTotal.Click += new System.EventHandler(this.btnMuestraTotal_Click);
            // 
            // btnMejorPago
            // 
            this.btnMejorPago.Location = new System.Drawing.Point(500, 260);
            this.btnMejorPago.Name = "btnMejorPago";
            this.btnMejorPago.Size = new System.Drawing.Size(197, 26);
            this.btnMejorPago.TabIndex = 6;
            this.btnMejorPago.Text = "Mostrar Operario Mejor Pago";
            this.btnMejorPago.UseVisualStyleBackColor = true;
            this.btnMejorPago.Click += new System.EventHandler(this.btnMejorPago_Click);
            // 
            // FrmCaso3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMejorPago);
            this.Controls.Add(this.btnMuestraTotal);
            this.Controls.Add(this.listTotalOperario);
            this.Controls.Add(this.btnCargaSueldos);
            this.Controls.Add(this.listOperarios);
            this.Controls.Add(this.btnMuestraOperarios);
            this.Controls.Add(this.btnCargaOperarios);
            this.Name = "FrmCaso3";
            this.Text = "FrmCaso3";
            this.Load += new System.EventHandler(this.FrmCaso3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargaOperarios;
        private System.Windows.Forms.Button btnMuestraOperarios;
        private System.Windows.Forms.ListBox listOperarios;
        private System.Windows.Forms.Button btnCargaSueldos;
        private System.Windows.Forms.ListBox listTotalOperario;
        private System.Windows.Forms.Button btnMuestraTotal;
        private System.Windows.Forms.Button btnMejorPago;
    }
}