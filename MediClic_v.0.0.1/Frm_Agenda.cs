using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace MediClic_v._0._0._1
{
    public partial class Frm_Agenda : Form
    {
        int month, year;
        public static int static_month, static_year;
        public Frm_Agenda()
        {
            InitializeComponent();
        }

        private void Frm_Agenda_Load(object sender, EventArgs e)
        {
            desplazamientos();
        }

        //MES Y AÑO NOMBRE
        private void mesyañonom()
        {
            String mesnom = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lb_MesAño.Text = mesnom + " " + year;
        }

        private void desplazamientos()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            mesyañonom();

            //Para que no se vaya el primer día del mes
            DateTime iniciodelmes = new DateTime(year, month, 1);

            //Obtener la cuenta del día del mes
            int dias = DateTime.DaysInMonth(year, month);

            //Convertir el icidiodelmes a entero
            int diasdelasemana = Convert.ToInt32(iniciodelmes.DayOfWeek.ToString("d")) + 1;

            //Crear un control de usuario en blanco
            for (int i = 1; i < diasdelasemana; i++)
            {
                UserControlBlanco controlblanco = new UserControlBlanco();
                flp_daycontainer.Controls.Add(controlblanco);
            }
            //Contador de números
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdays = new UserControlDias();
                ucdays.days(i);
                flp_daycontainer.Controls.Add(ucdays);
            }
        }
        //BOTÓN DE ADELANTE
        private void btn_adelante_Click(object sender, EventArgs e)
        {
            flp_daycontainer.Controls.Clear();
            month++;
            static_month = month;
            static_year = year;
            mesyañonom();
            //
            DateTime iniciodelmes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diasdelasemana = Convert.ToInt32(iniciodelmes.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < diasdelasemana; i++)
            {
                UserControlBlanco controlblanco = new UserControlBlanco();
                flp_daycontainer.Controls.Add(controlblanco);
            }
            //Contador de números
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdays = new UserControlDias();
                ucdays.days(i);
                flp_daycontainer.Controls.Add(ucdays);
            }
        }

        //BOTÓN DE ATRÁS
        private void btn_atras_Click(object sender, EventArgs e)
        {
            flp_daycontainer.Controls.Clear();
            month--;
            static_month = month;
            static_year = year;
            mesyañonom();
            //
            DateTime iniciodelmes = new DateTime(year, month, 1);
            int dias = DateTime.DaysInMonth(year, month);
            int diasdelasemana = Convert.ToInt32(iniciodelmes.DayOfWeek.ToString("d")) + 1;
            for (int i = 1; i < diasdelasemana; i++)
            {
                UserControlBlanco controlblanco = new UserControlBlanco();
                flp_daycontainer.Controls.Add(controlblanco);
            }
            //Contador de números
            for (int i = 1; i <= dias; i++)
            {
                UserControlDias ucdays = new UserControlDias();
                ucdays.days(i);
                flp_daycontainer.Controls.Add(ucdays);
            }
        }

    }
}
