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
    public partial class main_Recepcion_ : Form
    {
        public main_Recepcion_()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void main_Recepcion__Load(object sender, EventArgs e)
        {
            openFrm(new main_lobby());
        }

        //acciones btn
        private void icnbtn_home_Click(object sender, EventArgs e)
        {
            efectoIcobtn(false, icnbtn_docList, icnbtn_citas, icnbtn_info);
            openFrm(new main_lobby());
        }

        private void icnbtn_docList_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_docList, icnbtn_citas, icnbtn_info);
            CondicionCi();
        }

        private void icnbtn_citas_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_citas, icnbtn_docList, icnbtn_info);
            openFrm(new Frm_Agenda());
        }
        private void icnbtn_info_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_info, icnbtn_docList, icnbtn_citas);
            openFrm(new Frm_Info());
        }


        //metodos

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

        private void efectoIcobtn(bool act, IconButton btnactv, IconButton btn2, IconButton btn3)
        {
            if (act == true)
            {
                btnactv.IconColor = System.Drawing.Color.FromArgb(0, 167, 238);
                btnactv.ForeColor = System.Drawing.Color.FromArgb(0, 167, 238);
                btnactv.BackColor = System.Drawing.Color.White;
                //others
                btn2.IconColor = System.Drawing.Color.White;
                btn2.ForeColor = System.Drawing.Color.White;
                btn2.BackColor = System.Drawing.Color.FromArgb(0, 167, 238);
                btn3.IconColor = System.Drawing.Color.White;
                btn3.ForeColor = System.Drawing.Color.White;
                btn3.BackColor = System.Drawing.Color.FromArgb(0, 167, 238);
            }
            else
            {
                btnactv.IconColor = System.Drawing.Color.White;
                btnactv.ForeColor = System.Drawing.Color.White;
                btnactv.BackColor = System.Drawing.Color.FromArgb(0, 167, 238);
                //others
                btn2.IconColor = System.Drawing.Color.White;
                btn2.ForeColor = System.Drawing.Color.White;
                btn2.BackColor = System.Drawing.Color.FromArgb(0, 167, 238);
                btn3.IconColor = System.Drawing.Color.White;
                btn3.ForeColor = System.Drawing.Color.White;
                btn3.BackColor = System.Drawing.Color.FromArgb(0, 167, 238);
            }

        }

        //opc perfil User
        private void icnpic_perfiluser_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Desea cerrar la Sesión?", "Cerrar Sesion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
                login log = new login();
                log.Show();
            }
        }

        private void CondicionCi(){
            Frm_listDocs doc = new Frm_listDocs();
            
            if (this.pnl_containerPrimary.Controls.Count > 0)
            {
                this.pnl_containerPrimary.Controls.RemoveAt(0);
            }
            doc.TopLevel = false;
            doc.Dock = DockStyle.Fill;
            doc.varCond = true;
            //f.BringToFront();
            this.pnl_containerPrimary.Controls.Add(doc);
            this.pnl_containerPrimary.Tag = doc;
            doc.Show();
        }
    }
}
