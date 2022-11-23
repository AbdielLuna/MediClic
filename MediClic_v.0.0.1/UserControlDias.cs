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
    public partial class UserControlDias : UserControl
    {
        public UserControlDias()
        {
            InitializeComponent();
        }
        public void days(int numday)
        {
            lbl_dias.Text = numday + "";
        }

        //private void UserControlDias_Click(object sender, EventArgs e)
        //{
        //    static_day = lbl_dias.Text;
        //    EventForm eventForm = new EventForm;
        //    eventForm.Show();
        //}
    }
}
