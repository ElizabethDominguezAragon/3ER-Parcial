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
    public partial class obtenermesdiasaño : Form
    {
        public obtenermesdiasaño()
        {
            InitializeComponent();
        }

        private void obtenermesdiasaño_Load(object sender, EventArgs e)
        {

        }

        private void btnobtenerfecha_Click(object sender, EventArgs e)
        {
            DateTime dtfechaactual = DateTime.Now;
            lbldia.Text = dtfechaactual.Day.ToString();
            lblmes.Text = dtfechaactual.Month.ToString();
            lblaño.Text = dtfechaactual.Year.ToString();
            lblhora.Text = dtfechaactual.Hour.ToString();
            lblminuto.Text = dtfechaactual.Minute.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
