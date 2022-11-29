using FontAwesome.Sharp;
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
    public partial class frm_AddPct : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        int id = 0;
        public frm_AddPct()
        {
            InitializeComponent();       
        }

        //Botones accion
        private void btn_cancelAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_savePct_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Agregar Nuevo Paciente", "Confirmacion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                almacenPacientes();
                conexionDB.cerrar();
                this.Close();
            }
        }

        //Metodos
        public void almacenPacientes() {
            try
            {
                conexionDB.abrir();
                string query = "insert into Pacientes(id_paciente,nombre_pac,sexo_pac,telefono_pac,tipo_sangre,estatura_pac,peso_pac,alergias,enfermedades,patologicos,nopatologicos,adicciones) values(@id,@namefull,@sx,@tel,@tpsg,@alt,@kg,@alergias,@enf,@pat,@nopat,@adcc)";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@id",id.ToString());
                comando.Parameters.AddWithValue("@namefull", txtbx_nmFull.Text);
                comando.Parameters.AddWithValue("@sx", cmbx_Sx.Text);
                comando.Parameters.AddWithValue("@tel", txtbx_Tel.Text);
                comando.Parameters.AddWithValue("@tpsg", cmbx_tpSg.Text);
                comando.Parameters.AddWithValue("@alt", txtbx_Mts.Text);
                comando.Parameters.AddWithValue("@kg", txtbx_kg.Text);
                comando.Parameters.AddWithValue("@alergias", txtbx_Alg.Text);
                comando.Parameters.AddWithValue("@enf", txtbx_Enf.Text);
                comando.Parameters.AddWithValue("@pat", txtbx_Pat.Text);
                comando.Parameters.AddWithValue("@nopat", txtbx_Pat.Text);
                comando.Parameters.AddWithValue("@adcc", txtbx_Adcc.Text);
                comando.ExecuteNonQuery();
                conexionDB.cerrar();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error en la conexion \n porfavor vuelvalo a intentar mas tarde","Lo sentimos!",MessageBoxButtons.OK);
            }
        }

        public void asignacionID() {
            conexionDB.abrir();
            string query = ("select id_paciente from Pacientes where id_paciente = (Select MAX( id_paciente) from Pacientes)");
            SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
            SqlDataReader read = comando.ExecuteReader();
            if (read.Read()) {
                id = Convert.ToInt32(read["id_paciente"].ToString());
                Console.WriteLine(">>ID = "+id.ToString());
                id += 1;
                txtbx_idP.Text = id.ToString();
                read.Close();
            }
            conexionDB.cerrar();
            if (id <= 0)
            {
                id = 1;
                txtbx_idP.Text = id.ToString();
            }
        }

        private void frm_AddPct_Load(object sender, EventArgs e)
        {
            asignacionID();
        }
    }
}
