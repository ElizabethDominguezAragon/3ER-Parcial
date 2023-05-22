using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosImpares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BuscarImpares_Click(object sender, EventArgs e)
        {
            int N_Inicial = int.Parse(Inicio.Text), N_Final = int.Parse(final.Text), contador=0;
            string Texto = "Numeros impares: ", cadena = "";
            for (int i = N_Inicial; i <= N_Final; i++){
                if (i % 2 != 0){
                    contador += 1;
                    cadena +="\n   * "+ i.ToString();
                    //MessageBox.Show(i.ToString()+", es numero impar");
                }
            }
            MessageBox.Show("Impares encontrados: " + contador.ToString() + "\n"+ Texto + cadena);
            //MessageBox.Show( Texto +cadena);

        }
    }
}
