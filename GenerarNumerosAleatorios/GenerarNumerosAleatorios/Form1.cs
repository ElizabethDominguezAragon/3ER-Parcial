using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerarNumerosAleatorios
{
    public partial class GenerarNumeros : Form
    {
        public GenerarNumeros()
        {
            InitializeComponent();
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            int nbase= Environment.TickCount;
            Random aleatorio = new Random(nbase);
            for (int i = 0; i <=10; i++)
            {
                int numero = aleatorio.Next(0, 50);
                MessageBox.Show(numero.ToString());
            }
        }
    }
}
