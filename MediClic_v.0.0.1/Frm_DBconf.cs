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
    public partial class Frm_DBconf : Form
    {
        public Frm_DBconf()
        {
            InitializeComponent();
        }

        //Btn Acciones 
        private void btn_Export_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Exporto Correctamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Importo Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
