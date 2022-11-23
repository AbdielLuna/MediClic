using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediClic_v._0._0._1
{
    public partial class Frm_listDocs : Form
    {
        string Cdlselection;
        ConexionDB conexionDB = new ConexionDB();
        public Frm_listDocs()
        {
            InitializeComponent();
        }
        private void Frm_listDocs_Load(object sender, EventArgs e)
        {
            cargarListdocs();
        }

        //Accion Btn
        private void icnbtn_refreshDtg_Click(object sender, EventArgs e)
        {
            SeleccionDtsdoc();
        }

        //Metodos
        public void cargarListdocs()
        {
            conexionDB.abrir();
            try
            {
                string query = "select cedula_doc,nombre_doc,especialidad_doc from Perfiles_Doctores";
                SqlDataAdapter apt = new SqlDataAdapter(query, conexionDB.Conectarbd);
                DataTable dt = new DataTable();
                apt.Fill(dt);
                dtgrd_listDoc.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lo sentimos \nHubo un problema con la Conexion porfavor itentalo mas tarde", "Advertencia", MessageBoxButtons.OK);
            }
            conexionDB.cerrar();
            dtgrd_listDoc.Columns[0].HeaderText = "Cedula";
            dtgrd_listDoc.Columns[1].HeaderText = "Nombre";
            dtgrd_listDoc.Columns[2].HeaderText = "Especialidad";
        }

        public void SeleccionDtsdoc() {
            conexionDB.abrir();
            try
            {
                string query = "select * from Perfiles_Doctores where cedula_doc = @idc";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@idc", Cdlselection);
                SqlDataReader read = comando.ExecuteReader();
                if (read.Read())
                {
                    txtbx_modfCdla.Text = Cdlselection;
                    txtbx_modfNmfull.Text = read["nombre_doc"].ToString();
                    dttm_modfAN.Text = read["fch_nacimiento"].ToString();
                    cmbx_modfSx.Text = read["sexo_doc"].ToString();
                    txtbx_modfEspc.Text = read["especialidad_doc"].ToString();
                    txtbx_modfCrro.Text = read["correo_doc"].ToString();
                    txtbx_modfTel.Text = read["telefono_doc"].ToString();

                }
            }
            catch { }
            conexionDB.cerrar();
        }

        private void dtgrd_listDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                Cdlselection = dtgrd_listDoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                SeleccionDtsdoc();
            }
            catch { }
            
        }

       
    }
}
