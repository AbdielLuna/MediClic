using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MediClic_v._0._0._1
{
    public partial class frm_Pacientes : Form
    {
        ConexionDB metodos = new ConexionDB();
        double IMC,estatura=1.81,peso=180;
        frm_AddPct addp = new frm_AddPct();
        private void icbtn_addPaciente_Click(object sender, EventArgs e)
        {
            addp.Show();
        }

        public frm_Pacientes()
        {
            InitializeComponent();
            Cl_IMC();
        }


        //Metodos
        public void Cl_IMC()
        {
            //Realizar Calculo

            IMC = (peso / (estatura * estatura));
            lb_dtoIMC.Text = ("IMC: "+(IMC).ToString());
            //Determinar estado de la persona

            if (IMC < 18.5)
            {
                //Bajo Peso
                icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(56, 182, 255);
            }

            if ((IMC >= 18.5) && (IMC < 25))
            {
                //Normal
                icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(0, 74, 173);
            }

            if ((IMC >= 25) && (IMC < 30))
            {
                //Sobrepeso
                icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(126, 217, 87);
            }
            if ((IMC >= 30) && (IMC < 34.9))
            {
                //Obeso clase1
                icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(255, 222, 89);
            }
            if ((IMC >= 35) && (IMC < 39.9))
            {
                //Obeso clase2
                icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(255, 189, 89);
            }
            if (IMC >= 40)
            {
                //Obeso Morbido or clase 3
                icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(255, 87, 87);
            }
        }
    
    
    }

}
