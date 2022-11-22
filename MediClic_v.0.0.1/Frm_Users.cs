using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MediClic_v._0._0._1
{
    public partial class Frm_Users : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        public Frm_Users()
        {
            InitializeComponent();
        }
        private void Frm_Users_Load(object sender, EventArgs e)
        {
            cargarListuser();
        }
        //Acciones BTN
        private void icbtn_addUser_Click(object sender, EventArgs e)
        {
            openFrm(new frm_adduser());
        }

        //rfresch btn
        private void icnbtn_refreshDtg_Click(object sender, EventArgs e)
        {
            cargarListuser();
        }

        //Metodos
        private void openFrm(Object f)
        {
            Form newf = f as Form;
            newf.Show();
        }
        public void cargarListuser() {
            conexionDB.abrir();
            try
            {
                
                string query = "select * from Usuarios";
                SqlDataAdapter adapter = new SqlDataAdapter(query,conexionDB.Conectarbd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dtgrd_listUsuarios.DataSource = dt;
                
            }
            catch {
                MessageBox.Show("Lo sentimos \nHubo un problema con la Conexion porfavor itentalo mas tarde","Advertencia",MessageBoxButtons.OK);
            }
            conexionDB.cerrar();
        }

        
    }
}
