namespace NumerosImpares
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
            this.label1 = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.TextBox();
            this.final = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarImpares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(122, 49);
            this.Inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(148, 26);
            this.Inicio.TabIndex = 1;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(428, 46);
            this.final.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(148, 26);
            this.final.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final";
            // 
            // BuscarImpares
            // 
            this.BuscarImpares.Location = new System.Drawing.Point(228, 212);
            this.BuscarImpares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarImpares.Name = "BuscarImpares";
            this.BuscarImpares.Size = new System.Drawing.Size(202, 39);
            this.BuscarImpares.TabIndex = 4;
            this.BuscarImpares.Text = "Buscar Impares";
            this.BuscarImpares.UseVisualStyleBackColor = true;
            this.BuscarImpares.Click += new System.EventHandler(this.BuscarImpares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 374);
            this.Controls.Add(this.BuscarImpares);
            this.Controls.Add(this.final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Numeros Impares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Inicio;
        private System.Windows.Forms.TextBox final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarImpares;
    }
}

