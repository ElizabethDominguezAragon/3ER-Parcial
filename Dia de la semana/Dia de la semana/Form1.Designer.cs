namespace Dia_de_la_semana
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.EncontrarDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(145, 56);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(140, 26);
            this.Fecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // EncontrarDia
            // 
            this.EncontrarDia.Location = new System.Drawing.Point(89, 110);
            this.EncontrarDia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncontrarDia.Name = "EncontrarDia";
            this.EncontrarDia.Size = new System.Drawing.Size(196, 39);
            this.EncontrarDia.TabIndex = 2;
            this.EncontrarDia.Text = "Dia de la semana";
            this.EncontrarDia.UseVisualStyleBackColor = true;
            this.EncontrarDia.Click += new System.EventHandler(this.EncontrarDia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 214);
            this.Controls.Add(this.EncontrarDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Enconterar dia de la semana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EncontrarDia;
    }
}

