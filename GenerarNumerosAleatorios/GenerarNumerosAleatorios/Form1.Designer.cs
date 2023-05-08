namespace GenerarNumerosAleatorios
{
    partial class GenerarNumeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarNumeros));
            this.btn_Generar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Generar
            // 
            this.btn_Generar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Generar.Location = new System.Drawing.Point(108, 59);
            this.btn_Generar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Generar.Name = "btn_Generar";
            this.btn_Generar.Size = new System.Drawing.Size(112, 39);
            this.btn_Generar.TabIndex = 2;
            this.btn_Generar.Text = "Generar";
            this.btn_Generar.UseVisualStyleBackColor = false;
            this.btn_Generar.Click += new System.EventHandler(this.btn_Generar_Click);
            // 
            // GenerarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(338, 164);
            this.Controls.Add(this.btn_Generar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GenerarNumeros";
            this.Text = "Generar Numeros Aleatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Generar;
    }
}

