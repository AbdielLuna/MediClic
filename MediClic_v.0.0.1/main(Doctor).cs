using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediClic_v._0._0._1
{
    public partial class main_Doctor_ : Form
    {
        int count =0;
        public main_Doctor_()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void main_Doctor__Load(object sender, EventArgs e)
        {
            openFrm(new main_lobby());
        }

        //AccionesBotones
        private void icnbtn_home_Click_1(object sender, EventArgs e)
        {
            openFrm(new main_lobby());
            efectoIcobtn(false, icnbtn_pacientes, icnbtn_citas, icnbtn_receta, icnbtn_info);
        }
        private void icnbtn_pacientes_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_pacientes,icnbtn_citas,icnbtn_receta,icnbtn_info);
            openFrm(new Frm_PacientesFull());
        }
        private void icnbtn_citas_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true,icnbtn_citas, icnbtn_pacientes, icnbtn_receta, icnbtn_info);
            openFrm(new Frm_Agenda());
        }
        private void icnbtn_receta_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_receta, icnbtn_citas, icnbtn_pacientes, icnbtn_info);
            openFrm(new Frm_receta());
        }
        private void icnbtn_info_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_info, icnbtn_receta, icnbtn_citas, icnbtn_pacientes);
            openFrm(new Frm_Info());
        }

        //Metodos############################
        private void openFrm(Object f)
        {
            if (this.pnl_containerPrimary.Controls.Count > 0)
            {
                this.pnl_containerPrimary.Controls.RemoveAt(0);
            }
            Form newf = f as Form;

            newf.TopLevel = false;
            newf.Dock = DockStyle.Fill;

            //f.BringToFront();
            this.pnl_containerPrimary.Controls.Add(newf);
            this.pnl_containerPrimary.Tag = newf;
            newf.Show();

        }

        private void efectoBtn(Button btn) {
            if (count == 0)
            {
                btn.ForeColor = Color.FromArgb(33, 171, 138);
                btn.BackColor = Color.FromArgb(255, 255, 240);
                count = 1;
            }
            if (count == 1)
            {
                btn.ForeColor = Color.FromArgb(255, 255, 240);
                btn.BackColor = Color.FromArgb(33, 171, 138);
            }
        }

        private void efectoIcobtn(bool act,IconButton btnactv, IconButton btn2, IconButton btn3, IconButton btn4) {
            if (act == true)
            {
                btnactv.IconColor = System.Drawing.Color.FromArgb(33, 171, 138);
                btnactv.ForeColor = System.Drawing.Color.FromArgb(33, 171, 138);
                btnactv.BackColor = System.Drawing.Color.White;
                //others
                btn2.IconColor = System.Drawing.Color.White;
                btn2.ForeColor = System.Drawing.Color.White;
                btn2.BackColor = System.Drawing.Color.FromArgb(33, 171, 138);
                btn3.IconColor = System.Drawing.Color.White;
                btn3.ForeColor = System.Drawing.Color.White;
                btn3.BackColor = System.Drawing.Color.FromArgb(33, 171, 138);
                btn4.IconColor = System.Drawing.Color.White;
                btn4.ForeColor = System.Drawing.Color.White;
                btn4.BackColor = System.Drawing.Color.FromArgb(33, 171, 138);
            }
            else {
                btnactv.IconColor = System.Drawing.Color.White;
                btnactv.ForeColor = System.Drawing.Color.White;
                btnactv.BackColor = System.Drawing.Color.FromArgb(33, 171, 138);
                //others
                btn2.IconColor = System.Drawing.Color.White;
                btn2.ForeColor = System.Drawing.Color.White;
                btn2.BackColor = System.Drawing.Color.FromArgb(33, 171, 138);
                btn3.IconColor = System.Drawing.Color.White;
                btn3.ForeColor = System.Drawing.Color.White;
                btn3.BackColor = System.Drawing.Color.FromArgb(33, 171, 138);
                btn4.IconColor = System.Drawing.Color.White;
                btn4.ForeColor = System.Drawing.Color.White;
                btn4.BackColor = System.Drawing.Color.FromArgb(33, 171, 138);
            }

        }

        //opc perfil User
        private void icpic_perfiluser_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Desea cerrar la Sesión?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
                login log = new login();
                log.Show();
            }
        }

        
    }
}
