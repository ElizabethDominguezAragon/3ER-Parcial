namespace leer_fecha
{
    partial class obtenermesdiasaño
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
            this.btnobtenerfecha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmes = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.lblaño = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblminuto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnobtenerfecha
            // 
            this.btnobtenerfecha.Location = new System.Drawing.Point(50, 19);
            this.btnobtenerfecha.Name = "btnobtenerfecha";
            this.btnobtenerfecha.Size = new System.Drawing.Size(126, 23);
            this.btnobtenerfecha.TabIndex = 0;
            this.btnobtenerfecha.Text = "obtener fecha";
            this.btnobtenerfecha.UseVisualStyleBackColor = true;
            this.btnobtenerfecha.Click += new System.EventHandler(this.btnobtenerfecha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mes";
            // 
            // lblmes
            // 
            this.lblmes.AutoSize = true;
            this.lblmes.Location = new System.Drawing.Point(62, 87);
            this.lblmes.Name = "lblmes";
            this.lblmes.Size = new System.Drawing.Size(26, 13);
            this.lblmes.TabIndex = 2;
            this.lblmes.Text = "mes";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(121, 87);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(21, 13);
            this.lbldia.TabIndex = 3;
            this.lbldia.Text = "dia";
            // 
            // lblaño
            // 
            this.lblaño.AutoSize = true;
            this.lblaño.Location = new System.Drawing.Point(20, 87);
            this.lblaño.Name = "lblaño";
            this.lblaño.Size = new System.Drawing.Size(25, 13);
            this.lblaño.TabIndex = 4;
            this.lblaño.Text = "año";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblminuto);
            this.groupBox1.Controls.Add(this.lblhora);
            this.groupBox1.Controls.Add(this.btnobtenerfecha);
            this.groupBox1.Controls.Add(this.lblmes);
            this.groupBox1.Controls.Add(this.lblaño);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbldia);
            this.groupBox1.Location = new System.Drawing.Point(43, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 254);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "fecha";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(47, 175);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(28, 13);
            this.lblhora.TabIndex = 5;
            this.lblhora.Text = "hora";
            // 
            // lblminuto
            // 
            this.lblminuto.AutoSize = true;
            this.lblminuto.Location = new System.Drawing.Point(151, 175);
            this.lblminuto.Name = "lblminuto";
            this.lblminuto.Size = new System.Drawing.Size(38, 13);
            this.lblminuto.TabIndex = 6;
            this.lblminuto.Text = "minuto";
            // 
            // obtenermesdiasaño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "obtenermesdiasaño";
            this.Text = "obtener mes dia año";
            this.Load += new System.EventHandler(this.obtenermesdiasaño_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnobtenerfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmes;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblaño;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblminuto;
        private System.Windows.Forms.Label lblhora;
    }
}