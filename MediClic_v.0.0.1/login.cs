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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            mostrarPass();
        }

        private void chckbx_showpass_CheckedChanged(object sender, EventArgs e)
        {
            mostrarPass();
        }

        private void btn_startSession_Click(object sender, EventArgs e)
        {
            autentificacion();
        }


        //Metodos##############################
        public void mostrarPass()
        {
            if (chckbx_showpass.Checked == true)
            {
                txtbx_pass.UseSystemPasswordChar = false;
            }
            else {
            txtbx_pass.UseSystemPasswordChar=true;
            }

        }

        public void autentificacion()
        {
            if(txtbx_user.Text == "admin" && txtbx_pass.Text == "admin"){
                openFrm(new main_Doctor_());
            }
        }

        private void openFrm(Object f)
        {
            Form newf = f as Form;
            newf.Show();
            this.Hide();

        }
    }
}
