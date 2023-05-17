namespace ListaDeNumerosRamdom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ntotales = new System.Windows.Forms.ListBox();
            this.N48 = new System.Windows.Forms.ListBox();
            this.N35 = new System.Windows.Forms.ListBox();
            this.GenerarNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "250 - 320";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(200, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Todos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(336, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "400-480";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Ntotales
            // 
            this.Ntotales.BackColor = System.Drawing.Color.Silver;
            this.Ntotales.FormattingEnabled = true;
            this.Ntotales.ItemHeight = 22;
            this.Ntotales.Location = new System.Drawing.Point(168, 90);
            this.Ntotales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ntotales.Name = "Ntotales";
            this.Ntotales.Size = new System.Drawing.Size(112, 334);
            this.Ntotales.TabIndex = 3;
            this.Ntotales.SelectedIndexChanged += new System.EventHandler(this.Ntotales_SelectedIndexChanged);
            // 
            // N48
            // 
            this.N48.BackColor = System.Drawing.Color.Silver;
            this.N48.FormattingEnabled = true;
            this.N48.ItemHeight = 22;
            this.N48.Location = new System.Drawing.Point(312, 90);
            this.N48.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.N48.Name = "N48";
            this.N48.Size = new System.Drawing.Size(112, 334);
            this.N48.TabIndex = 4;
            this.N48.SelectedIndexChanged += new System.EventHandler(this.N48_SelectedIndexChanged);
            // 
            // N35
            // 
            this.N35.BackColor = System.Drawing.Color.Silver;
            this.N35.FormattingEnabled = true;
            this.N35.ItemHeight = 22;
            this.N35.Location = new System.Drawing.Point(21, 90);
            this.N35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.N35.Name = "N35";
            this.N35.Size = new System.Drawing.Size(112, 334);
            this.N35.TabIndex = 5;
            this.N35.SelectedIndexChanged += new System.EventHandler(this.N35_SelectedIndexChanged);
            // 
            // GenerarNumeros
            // 
            this.GenerarNumeros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerarNumeros.BackColor = System.Drawing.Color.Violet;
            this.GenerarNumeros.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GenerarNumeros.Location = new System.Drawing.Point(169, 14);
            this.GenerarNumeros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerarNumeros.Name = "GenerarNumeros";
            this.GenerarNumeros.Size = new System.Drawing.Size(112, 39);
            this.GenerarNumeros.TabIndex = 6;
            this.GenerarNumeros.Text = "Generar";
            this.GenerarNumeros.UseVisualStyleBackColor = false;
            this.GenerarNumeros.Click += new System.EventHandler(this.GenerarNumeros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(442, 475);
            this.Controls.Add(this.GenerarNumeros);
            this.Controls.Add(this.N35);
            this.Controls.Add(this.N48);
            this.Controls.Add(this.Ntotales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Numeros Al Azar 200-500";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Ntotales;
        private System.Windows.Forms.ListBox N48;
        private System.Windows.Forms.ListBox N35;
        private System.Windows.Forms.Button GenerarNumeros;
    }
}

