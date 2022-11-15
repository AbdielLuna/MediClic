using FontAwesome.Sharp;
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
using TextBox = System.Windows.Forms.TextBox;

namespace MediClic_v._0._0._1
{
    public partial class frm_Pacientes : Form
    {
        ConexionDB metodos = new ConexionDB();
        double IMC, estatura = 1.81, peso = 180;
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

        //btn EdicionDts
        private void icnbtn_editDG_Click(object sender, EventArgs e)
        {
            editar(txtbx_idPdg, true);
            editar(txtbx_namePdg, true);
            editar(txtbx_sxPdg, true);
            editar(txtbx_telPdg, true);
            editarbtn(icnbtn_editDG, btn_saveDg, true);
        }

        private void icnbtn_editHM_Click(object sender, EventArgs e)
        {
            editar(txtbx_tsgPhm, true);
            editar(txtbx_mtsPhm, true);
            editar(txtbx_kgPhm, true);
            editar(txtbx_algPdts, true);
            editar(txtbx_addcPdts, true);
            editarbtn(icnbtn_editHM, btn_saveHM, false);
        }

        private void icnbtn_editAnt_Click(object sender, EventArgs e)
        {
            editar(txtbx_patPant, true);
            editar(txtbx_notpatPant, true);
            editar(txtbx_enffPant, true);
            editarbtn(icnbtn_editAnt, btn_saveANT, false);
        }
        //btn saveDTS
        private void btn_saveDg_Click(object sender, EventArgs e)
        {
            editarbtn(icnbtn_editDG, btn_saveDg, false);
            editar(txtbx_idPdg, false);
            editar(txtbx_namePdg, false);
            editar(txtbx_sxPdg, false);
            editar(txtbx_telPdg, false);
        }

        private void btn_saveHM_Click(object sender, EventArgs e)
        {
            editarbtn(icnbtn_editHM, btn_saveHM, true);
            editar(txtbx_tsgPhm, false);
            editar(txtbx_mtsPhm, false);
            editar(txtbx_kgPhm, false);
            editar(txtbx_algPdts, false);
            editar(txtbx_addcPdts, false);
        }

        private void btn_saveANT_Click(object sender, EventArgs e)
        {
            editarbtn(icnbtn_editAnt, btn_saveANT, true);
            editar(txtbx_patPant, false);
            editar(txtbx_notpatPant, false);
            editar(txtbx_enffPant, false);
        }

        //Metodos
        public void Cl_IMC()
        {
            //Realizar Calculo

            IMC = (peso / (estatura * estatura));
            lb_dtoIMC.Text = ("IMC: " + (IMC).ToString());
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



        public void editar(TextBox txt, bool act) {
            if (act == true) { txt.ReadOnly = false;  }
            if (act == false) { txt.ReadOnly = true;  }
        }
        public void editarbtn(IconButton icnbtn, IconButton icnbtnSave, bool actt) {
            if (actt == true) {icnbtn.Enabled = false; icnbtnSave.Visible = true;}
            if (actt == false) { icnbtn.Enabled = true; icnbtnSave.Visible = false; }
        }
    
        
    }

}
