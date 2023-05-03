namespace Supermercado
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Articulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 22;
            this.Lista.Location = new System.Drawing.Point(446, 83);
            this.Lista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(346, 158);
            this.Lista.TabIndex = 0;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(117, 146);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(180, 26);
            this.Cantidad.TabIndex = 2;
            this.Cantidad.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            this.Cantidad.Leave += new System.EventHandler(this.Cantidad_Leave);
            // 
            // Articulo
            // 
            this.Articulo.FormattingEnabled = true;
            this.Articulo.Items.AddRange(new object[] {
            "PASTA DENTAL",
            "Manzana",
            "Comida Mascota",
            "Sabritas",
            "Refresco",
            "computadora"});
            this.Articulo.Location = new System.Drawing.Point(117, 83);
            this.Articulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(180, 30);
            this.Articulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Imprimir Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(324, 142);
            this.Registrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(60, 39);
            this.Registrar.TabIndex = 7;
            this.Registrar.Text = ">>";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 396);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Articulo);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Lista);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "SuperMercado Potros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.ComboBox Articulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Registrar;
    }
}

