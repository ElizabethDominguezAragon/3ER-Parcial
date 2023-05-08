using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fecha
{
    public partial class EFecha : Form
    {
        public EFecha()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strM = "los meses seleccionados son:\n";
            DateTime dFecha = new DateTime();
            foreach  (var item in ListFecha.Items)
            {
                dFecha = DateTime.Parse(item.ToString());
                strM +="\n"+  dFecha.Month.ToString();

            }
            MessageBox.Show(strM);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListFecha.Items.Add(Fecha.Value.ToString());
        }
    }
}
