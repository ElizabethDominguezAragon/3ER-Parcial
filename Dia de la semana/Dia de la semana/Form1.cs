using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dia_de_la_semana
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

        private void EncontrarDia_Click(object sender, EventArgs e)
        {
            
            Fecha.Value = GenerarFechaAleatoria().Value;
            
            switch (Fecha.Value.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    MessageBox.Show("Es domingo");
                    break;
                case DayOfWeek.Monday:
                    MessageBox.Show("Es Lunes");
                    break;
                case DayOfWeek.Tuesday:
                    MessageBox.Show("Es Martes");
                    break;
                case DayOfWeek.Wednesday:
                    MessageBox.Show("Es Miercoles");
                    break;
                case DayOfWeek.Thursday:
                    MessageBox.Show("Es Jueves");
                    break;
                case DayOfWeek.Friday:
                    MessageBox.Show("Es viernes");
                    break;
                case DayOfWeek.Saturday:
                    MessageBox.Show("Es sabado");
                    break;
            }
        }
        public DateTimePicker GenerarFechaAleatoria(){
            Random aleatorio = new Random(Environment.TickCount);
            int año = aleatorio.Next(1800, 2023);
            int mes = aleatorio.Next(1, 12);
            int Dia;
            if (mes == 2) {
                if (año % 400 == 0 || (año % 100 != 0 && año % 4 == 0)){
                     Dia = aleatorio.Next(1, 29);
                }else{
                     Dia = aleatorio.Next(1, 28);
                }
            }else if (mes == 1 || mes == 3 || mes == 5|| mes == 7 || mes == 8 || mes == 10 || mes == 12) {
                Dia = aleatorio.Next(1, 31);
            }else {
                Dia = aleatorio.Next(1, 30); 
            }
            DateTimePicker fechaAleatoria = new DateTimePicker();
            fechaAleatoria.MinDate = new DateTime(1800, 1, 1);
            fechaAleatoria.Value = new DateTime(año, mes, Dia);
            return fechaAleatoria;
        }
    }
}
