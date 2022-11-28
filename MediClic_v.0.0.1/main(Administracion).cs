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
    public partial class main_Administracion_ : Form
    {
        public main_Administracion_()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        //acciones Btn

        private void icnbtn_home_Click(object sender, EventArgs e)
        {
            
        }

        private void icnbtn_users_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_users, icnbtn_docList, icnbtn_DBconfig, icnbtn_info);
            openFrm(new Frm_Users());
           
        }

        private void icnbtn_docList_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_docList, icnbtn_users, icnbtn_DBconfig, icnbtn_info);
            openFrm(new Frm_listDocs());
        }

        private void icnbtn_DBconfig_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_DBconfig, icnbtn_users, icnbtn_docList, icnbtn_info);
            openFrm(new Frm_DBconf());
        }

        private void icnbtn_info_Click(object sender, EventArgs e)
        {
            efectoIcobtn(true, icnbtn_info, icnbtn_DBconfig, icnbtn_users, icnbtn_docList);
        }

        //Metodos
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

        private void efectoIcobtn(bool act, IconButton btnactv, IconButton btn2, IconButton btn3, IconButton btn4)
        {
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
            else
            {
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
        //Out Sesion
        private void icnbtn_perfiluser_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Quieres Cerrar la Sesión??", "Cerrar Sesion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
                login log = new login();
                log.Show();
            }
        }

        private void main_Administracion__Load(object sender, EventArgs e)
        {
            openFrm(new Frm_Users());
        }
    }
}
