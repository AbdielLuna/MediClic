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
    public partial class Frm_PacientesFull : Form
    {
        double IMC, estatura = 0, peso = 0;
        string Cdlselection;
        
        ConexionDB conexionDB = new ConexionDB();
        public Frm_PacientesFull()
        {
            InitializeComponent();
        }
        private void Frm_PacientesFull_Load(object sender, EventArgs e)
        {
            cargarListpac();
        }

        //Acciones Btn
        private void icbtn_addPaciente_Click(object sender, EventArgs e)
        {
            openFrm(new frm_AddPct());
        }
        private void icnbtn_bsqP_Click(object sender, EventArgs e)
        {
            if (txtbx_bsqPacientes.Text == null || txtbx_bsqPacientes.Text == "")
            {

            }
            else
            {

            }
        }

        //Metodos
        private void openFrm(Object f)
        {
            Form newf = f as Form;
            newf.Show();
        }

        private void icbtn_Refresh_Click(object sender, EventArgs e)
        {
            cargarListpac();
        }

        public void cargarListpac()
        {
            conexionDB.abrir();
            try
            {
                string query = "select id_paciente,nombre_pac,sexo_pac,telefono_pac from Pacientes";
                SqlDataAdapter apt = new SqlDataAdapter(query, conexionDB.Conectarbd);
                DataTable dt = new DataTable();
                apt.Fill(dt);
                dtgrd_listPac.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lo sentimos \nHubo un problema con la Conexion porfavor itentelo mas tarde", "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            conexionDB.cerrar();
            dtgrd_listPac.Columns[0].HeaderText = "Matricula";
            dtgrd_listPac.Columns[1].HeaderText = "Nombre";
            dtgrd_listPac.Columns[2].HeaderText = "Sexo";
            dtgrd_listPac.Columns[3].HeaderText = "Contacto";
        }
        private void dtgrd_listPac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Pacientes viwpac = new frm_Pacientes();
            try {
                
                Cdlselection = dtgrd_listPac.Rows[e.RowIndex].Cells[0].Value.ToString();
                conexionDB.abrir();
                try
                    {
                        string query = "select * from Pacientes where id_paciente = @id";
                        SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                        comando.Parameters.AddWithValue("@id", Cdlselection);
                        //comando.Parameters.AddWithValue("@user", );
                        SqlDataReader reader = comando.ExecuteReader();
                        if (reader.Read())
                        {
                            //prfP
                            viwpac.txtbx_idPdg.Text = reader["id_paciente"].ToString();
                            viwpac.txtbx_namePdg.Text = reader["nombre_pac"].ToString();
                            viwpac.txtbx_sxPdg.Text = reader["sexo_pac"].ToString();
                            viwpac.txtbx_telPdg.Text = reader["telefono_pac"].ToString();
                            //HSM
                            viwpac.txtbx_tsgPhm.Text = reader["tipo_sangre"].ToString();
                            viwpac.txtbx_mtsPhm.Text = reader["estatura_pac"].ToString();
                            viwpac.txtbx_kgPhm.Text = reader["peso_pac"].ToString();
                            viwpac.txtbx_algPdts.Text = reader["alergias"].ToString();
                            viwpac.txtbx_addcPdts.Text = reader["adicciones"].ToString();
                            //Ant
                            viwpac.txtbx_patPant.Text = reader["patologicos"].ToString();
                            viwpac.txtbx_notpatPant.Text = reader["nopatologicos"].ToString();
                            viwpac.txtbx_enffPant.Text = reader["enfermedades"].ToString();
                            //dts IMC
                            estatura = Convert.ToDouble(viwpac.txtbx_mtsPhm.Text);
                            peso = Convert.ToDouble(viwpac.txtbx_kgPhm.Text);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Lo sentimos \n Ah Ocurrido un problema, intenta mas tarde", "", MessageBoxButtons.OK);
                    }
                //Realizar Calculo

                IMC = (peso / (estatura * estatura));
                viwpac.lb_dtoIMC.Text = ("IMC: " + (IMC).ToString());
                //Determinar estado de la persona

                if (IMC < 18.5)
                {
                    //Bajo Peso
                    viwpac.icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(56, 182, 255);
                }

                if ((IMC >= 18.5) && (IMC < 25))
                {
                    //Normal
                    viwpac.icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(0, 74, 173);
                }

                if ((IMC >= 25) && (IMC < 30))
                {
                    //Sobrepeso
                    viwpac.icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(126, 217, 87);
                }
                if ((IMC >= 30) && (IMC < 34.9))
                {
                    //Obeso clase1
                    viwpac.icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(255, 222, 89);
                }
                if ((IMC >= 35) && (IMC < 39.9))
                {
                    //Obeso clase2
                    viwpac.icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(255, 189, 89);
                }
                if (IMC >= 40)
                {
                    //Obeso Morbido or clase 3
                    viwpac.icnpic_pacienteIMC.ForeColor = System.Drawing.Color.FromArgb(255, 87, 87);
                }
                conexionDB.cerrar();

                
                
                viwpac.Show();
            }
            catch {
                Console.WriteLine("Error Con el Form");
            }

            
        }

    }
}
