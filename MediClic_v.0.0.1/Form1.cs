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
    public partial class Splash_frm1 : Form
    {
        int splsh = 0;
        public Splash_frm1()
        {
            InitializeComponent();
        }

        private void tm_splash_Tick(object sender, EventArgs e)
        {
            splsh += 1;

            if (splsh >=2) {
                this.Hide();
                login login = new login();
                login.Show();
                apagar();
            }
        }

        public void apagar() {
            tm_splash.Stop();
        }
    }
}
