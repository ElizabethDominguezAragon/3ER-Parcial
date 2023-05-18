using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen3
{
    public partial class Pares_Impares_Aleatorios : Form
    {
        public Pares_Impares_Aleatorios()
        {
            InitializeComponent();
        }

        private void GenerarNumeros_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random(Environment.TickCount);
            int Numero;
            for (int i = 1; i <= 30; i++)
            {
                Numero = Aleatorio.Next(25,180);
                N_todos.Items.Add(Numero);
                if (Numero%2== 0){
                    N_Pares.Items.Add(Numero);
                }else{
                    N_Impares.Items.Add(Numero);
                }
              
            }
        }
    }
}
