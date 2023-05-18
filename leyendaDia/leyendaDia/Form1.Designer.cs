namespace leyendaDia
{
    partial class LeyendaFecha
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.GENERARLEYENDA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(86, 40);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 0;
            // 
            // GENERARLEYENDA
            // 
            this.GENERARLEYENDA.Location = new System.Drawing.Point(143, 82);
            this.GENERARLEYENDA.Name = "GENERARLEYENDA";
            this.GENERARLEYENDA.Size = new System.Drawing.Size(75, 23);
            this.GENERARLEYENDA.TabIndex = 1;
            this.GENERARLEYENDA.Text = "GENERAR";
            this.GENERARLEYENDA.UseVisualStyleBackColor = true;
            this.GENERARLEYENDA.Click += new System.EventHandler(this.button1_Click);
            // 
            // LeyendaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 194);
            this.Controls.Add(this.GENERARLEYENDA);
            this.Controls.Add(this.fecha);
            this.Name = "LeyendaFecha";
            this.Text = "Fecha Leyenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button GENERARLEYENDA;
    }
}

