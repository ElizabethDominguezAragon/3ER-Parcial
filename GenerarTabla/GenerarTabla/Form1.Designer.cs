namespace GenerarTabla
{
    partial class GENERARTABLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GENERARTABLE));
            this.GTabla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GTabla
            // 
            this.GTabla.Location = new System.Drawing.Point(181, 76);
            this.GTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GTabla.Name = "GTabla";
            this.GTabla.Size = new System.Drawing.Size(108, 88);
            this.GTabla.TabIndex = 0;
            this.GTabla.Text = "Generar Tabla";
            this.GTabla.UseVisualStyleBackColor = true;
            this.GTabla.Click += new System.EventHandler(this.GTabla_Click);
            // 
            // GENERARTABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 245);
            this.Controls.Add(this.GTabla);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GENERARTABLE";
            this.Text = "Generar Tabla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GTabla;
    }
}

