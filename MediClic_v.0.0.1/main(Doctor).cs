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
        }

        private void main_Doctor__Load(object sender, EventArgs e)
        {
            openFrm(new main_lobby());
        }

        //AccionesBotones
        private void icnbtn_home_Click_1(object sender, EventArgs e)
        {
            openFrm(new main_lobby());
            efectoIcobtn(icnbtn_home);
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

        private void efectoIcobtn(IconButton icobtn) {
            icobtn.IconColor = System.Drawing.Color.FromArgb(33, 171, 138);
            icobtn.ForeColor = System.Drawing.Color.FromArgb(33, 171, 138);
            icobtn.BackColor = System.Drawing.Color.White;
            
        }

        private void icnbtn_pacientes_Click(object sender, EventArgs e)
        {
            efectoIcobtn(icnbtn_pacientes);
            openFrm(new frm_Pacientes());
        }
    }
}
