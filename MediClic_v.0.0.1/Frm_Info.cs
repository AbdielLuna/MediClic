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
    public partial class Frm_Info : Form
    {
        public Frm_Info()
        {
            InitializeComponent();
        }

        private void linkInfo1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkInfo1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://padlet.com/yazminvelarde741/6frxc1j1vgnhxyk8");
        }

        private void linkInfo2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkInfo1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://padlet.com/yazminvelarde741/6frxc1j1vgnhxyk8");
        }
    }
}
