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
    public partial class Frm_Users : Form
    {
        public Frm_Users()
        {
            InitializeComponent();
        }

        private void icbtn_addUser_Click(object sender, EventArgs e)
        {
            openFrm(new frm_adduser());
        }

        //Metodos
        private void openFrm(Object f)
        {
            Form newf = f as Form;
            newf.Show();
        }
    }
}
