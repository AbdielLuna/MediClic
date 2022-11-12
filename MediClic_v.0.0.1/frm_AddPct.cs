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
    public partial class frm_AddPct : Form
    {
        ConexionDB metodos = new ConexionDB();
        
        public frm_AddPct()
        {
            InitializeComponent();
        }

        //Botones accion
        private void btn_cancelAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
