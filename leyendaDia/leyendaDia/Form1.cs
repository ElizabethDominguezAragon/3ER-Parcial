using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leyendaDia
{
    public partial class LeyendaFecha : Form
    {
        public LeyendaFecha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = "La fecha seleccionada es " + fecha.Value.Day+ " del mes de ";
            switch (fecha.Value.Month)
            {
                case 1: m += "Enero ";break;
                case 2:m += "Febrero ";break;
                case 3:m += "Marzo ";break;
                case 4: m += "Abril ";
                    break;
                case 5: m += "Mayo ";
                    break;
                case 6:m += "Junio ";
                    break;
                case 7: m += "julio ";
                    break;
                case 8:m += "Agosto ";
                    break;
                case 9:m += "Septiembre ";
                    break;
                case 10:m += "Octubre ";
                    break;
                case 11:m += "Noviembre ";
                    break;
                case 12: m += "Diciembre ";
                    break;
            }
            m += "del año " + fecha.Value.Year;
            MessageBox.Show(m);
               

        }
    }
}
