using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeNumerosRamdom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ntotales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenerarNumeros_Click(object sender, EventArgs e)
        {
            N35.Items.Clear(); N48.Items.Clear(); Ntotales.Items.Clear();
            Random aleatorio = new Random(Environment.TickCount);
            for (int i=1; i<= 15; i++) { 
            int n = aleatorio.Next(200,500);
                Ntotales.Items.Add(i + ": " + n);
                if (n >= 250 && n <=380){
                    N35.Items.Add(i + ": " + n);
                }else if (n >= 400 && n <= 480){
                    N48.Items.Add(i + ": " + n);
                }
            }


        }

        private void N48_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void N35_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
