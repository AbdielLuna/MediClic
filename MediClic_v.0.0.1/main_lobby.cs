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
    public partial class main_lobby : Form
    {
        public main_lobby()
        {
            InitializeComponent();
        }

        //Reloj para Lobby
        private void tm_reloj_Tick(object sender, EventArgs e)
        {
            lb_reloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
