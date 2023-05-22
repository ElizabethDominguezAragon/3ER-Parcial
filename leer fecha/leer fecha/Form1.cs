using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leer_fecha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            DateTime dfecha = dtfecha.Value;
            MessageBox.Show("fecha seleccionanda es : " + dfecha.ToString());
        }

        private void btnsepararfecha_Click(object sender, EventArgs e)
        {
            Form frm = new ();
            frm.ShowDialog();
        }
    }
}
