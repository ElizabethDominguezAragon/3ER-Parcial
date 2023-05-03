using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Lista.Items.Add(Articulo.Text+" - "+ Cantidad.Text + " piezas");
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cantidad_Leave(object sender, EventArgs e)
        {
            if (Cantidad.Text == ""){
                Cantidad.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StrTiket = "Super mercado Potros \nSu compra es:\n";
            int cont=0
            foreach (var item in Lista.Items)
            {
              
                StrTiket +="\n"+ item.ToString();
            }
            StrTiket += "\n\nGracias por su compra";
            MessageBox.Show(StrTiket);
        }
    }
}
