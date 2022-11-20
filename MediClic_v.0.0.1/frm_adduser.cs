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
    public partial class frm_adduser : Form
    {
        public frm_adduser()
        {
            InitializeComponent();
        }

        //Radio Button ROL
        private void rdbtn_rolDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_rolDoc.Checked == true) { 
                pnl_ContDoc.Visible = true;
            }
        }

        private void rdbtn_rolRec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_rolRec.Checked == true)
            {
                pnl_ContDoc.Visible = false;
            }
        }

        private void btn_cnlAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
