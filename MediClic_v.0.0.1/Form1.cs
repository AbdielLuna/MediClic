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
        List<string> splsh_list = new List<string>() { 
        "Cargando la base de datos.","Cargar Formularios..","Estableciendo Conexion...","Cargando."
        };
        public Splash_frm1()
        {
            InitializeComponent();
            
        }

        private void tm_splash_Tick(object sender, EventArgs e)
        {
            label1.Text = splsh_list[splsh];
            splsh += 1;

            if (splsh >=4) {
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
