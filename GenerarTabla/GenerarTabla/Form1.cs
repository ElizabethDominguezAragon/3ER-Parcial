using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerarTabla
{
    public partial class GENERARTABLE : Form
    {
        public GENERARTABLE()
        {
            InitializeComponent();
        }

        private void GTabla_Click(object sender, EventArgs e)
        {
            int nbase = Environment.TickCount;
            Random aleatorio = new Random(nbase);
            int numero = aleatorio.Next(10, 500);
            string StrMensaje = "tabla del " + numero.ToString() +"\n";
            for (int i = 1; i <= 10; i++)
            {
                int multi = numero * i;
                StrMensaje+= "\n"+ numero.ToString() +" x " + i.ToString()+ " = "+ multi.ToString() ;
            }
            MessageBox.Show(StrMensaje);
        }
    }
}
