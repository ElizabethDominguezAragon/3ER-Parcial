namespace Examen3
{
    partial class Pares_Impares_Aleatorios
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
            this.N_Impares = new System.Windows.Forms.ListBox();
            this.N_todos = new System.Windows.Forms.ListBox();
            this.N_Pares = new System.Windows.Forms.ListBox();
            this.GenerarNumeros = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Impares = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // N_Impares
            // 
            this.N_Impares.FormattingEnabled = true;
            this.N_Impares.Location = new System.Drawing.Point(58, 38);
            this.N_Impares.Name = "N_Impares";
            this.N_Impares.Size = new System.Drawing.Size(120, 303);
            this.N_Impares.TabIndex = 0;
            // 
            // N_todos
            // 
            this.N_todos.FormattingEnabled = true;
            this.N_todos.Location = new System.Drawing.Point(289, 38);
            this.N_todos.Name = "N_todos";
            this.N_todos.Size = new System.Drawing.Size(120, 303);
            this.N_todos.TabIndex = 1;
            // 
            // N_Pares
            // 
            this.N_Pares.FormattingEnabled = true;
            this.N_Pares.Location = new System.Drawing.Point(535, 38);
            this.N_Pares.Name = "N_Pares";
            this.N_Pares.Size = new System.Drawing.Size(120, 303);
            this.N_Pares.TabIndex = 2;
            // 
            // GenerarNumeros
            // 
            this.GenerarNumeros.Location = new System.Drawing.Point(256, 349);
            this.GenerarNumeros.Name = "GenerarNumeros";
            this.GenerarNumeros.Size = new System.Drawing.Size(215, 23);
            this.GenerarNumeros.TabIndex = 3;
            this.GenerarNumeros.Text = "Generar Numeros";
            this.GenerarNumeros.UseVisualStyleBackColor = true;
            this.GenerarNumeros.Click += new System.EventHandler(this.GenerarNumeros_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Impares
            // 
            this.Impares.AutoSize = true;
            this.Impares.Location = new System.Drawing.Point(73, 13);
            this.Impares.Name = "Impares";
            this.Impares.Size = new System.Drawing.Size(44, 13);
            this.Impares.TabIndex = 4;
            this.Impares.Text = "Impares";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Todos";
            // 
            // Pares_Impares_Aleatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Impares);
            this.Controls.Add(this.GenerarNumeros);
            this.Controls.Add(this.N_Pares);
            this.Controls.Add(this.N_todos);
            this.Controls.Add(this.N_Impares);
            this.Name = "Pares_Impares_Aleatorios";
            this.Text = "Pares e Impares ";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox N_Impares;
        private System.Windows.Forms.ListBox N_todos;
        private System.Windows.Forms.ListBox N_Pares;
        private System.Windows.Forms.Button GenerarNumeros;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Impares;
    }
}

