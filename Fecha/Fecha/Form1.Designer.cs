namespace Fecha
{
    partial class EFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EFecha));
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.sacarMeses = new System.Windows.Forms.Button();
            this.ListFecha = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elije Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fecha
            // 
            this.Fecha.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(156, 91);
            this.Fecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(127, 26);
            this.Fecha.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sacarMeses
            // 
            this.sacarMeses.Location = new System.Drawing.Point(156, 176);
            this.sacarMeses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sacarMeses.Name = "sacarMeses";
            this.sacarMeses.Size = new System.Drawing.Size(210, 39);
            this.sacarMeses.TabIndex = 3;
            this.sacarMeses.Text = "Sacar Meses";
            this.sacarMeses.UseVisualStyleBackColor = true;
            this.sacarMeses.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListFecha
            // 
            this.ListFecha.FormattingEnabled = true;
            this.ListFecha.ItemHeight = 22;
            this.ListFecha.Location = new System.Drawing.Point(474, 80);
            this.ListFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListFecha.Name = "ListFecha";
            this.ListFecha.Size = new System.Drawing.Size(350, 158);
            this.ListFecha.TabIndex = 4;
            // 
            // EFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 418);
            this.Controls.Add(this.ListFecha);
            this.Controls.Add(this.sacarMeses);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EFecha";
            this.Text = "eleccion de fecha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sacarMeses;
        private System.Windows.Forms.ListBox ListFecha;
    }
}

