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
        string Cdlselection;

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
                string query = "select id_usuarios,nm_usuario,tipo_usuario from Usuarios";
                SqlDataAdapter apt = new SqlDataAdapter(query, conexionDB.Conectarbd);
                DataTable dt = new DataTable();
                apt.Fill(dt);
                dtgrd_listUsuarios.DataSource = dt;
            }
            catch {
                MessageBox.Show("Lo sentimos \nHubo un problema con la Conexion porfavor itentalo mas tarde", "Advertencia", MessageBoxButtons.OK);
            }
            conexionDB.cerrar();
            dtgrd_listUsuarios.Columns[0].HeaderText = "ID";
            dtgrd_listUsuarios.Columns[1].HeaderText = "Nombre";
            dtgrd_listUsuarios.Columns[2].HeaderText = "Rol";
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            var dlt = MessageBox.Show("Deseas eliminar a este usuario?\nSe eliminara permanentemente","Advertencia",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (dlt == DialogResult.Yes) {
                int iden = Convert.ToInt32(Cdlselection);
                conexionDB.abrir();
                if (iden >= 1000 && iden <= 2000)
                {
                    
                    try
                    {
                        string query1 = "delete from Usuarios where id_usuarios = @iduser";
                        SqlCommand comando1 = new SqlCommand(query1, conexionDB.Conectarbd);
                        comando1.Parameters.AddWithValue("@iduser", Cdlselection);
                        comando1.ExecuteNonQuery();
                        string query = "delete from Perfiles_Doctores where id_usuarios = @iduser";
                        SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                        comando.Parameters.AddWithValue("@iduser", Cdlselection);
                        comando.ExecuteNonQuery();

                    }
                    catch { }
                    conexionDB.cerrar();
                    Clearall();
                    cargarListuser();

                }
                else {
                    try
                    {
                        string query1 = "delete from Usuarios where id_usuarios = @iduser";
                    SqlCommand comando1 = new SqlCommand(query1, conexionDB.Conectarbd);
                    comando1.Parameters.AddWithValue("@iduser", Cdlselection);
                    comando1.ExecuteNonQuery();
                    }
                    catch { }
                    conexionDB.cerrar();
                    Clearall();
                    cargarListuser();
                }
            
            }
        }

        private void dtgrd_listUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cdlselection = dtgrd_listUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (Cdlselection == 1.ToString())
                {
                    SeleccionDtsdoc();
                }
                else {
                    SeleccionDtsdoc();
                    txtbx_tagUser.ReadOnly = false;
                    txtbx_nmFull.ReadOnly = false;
                    txtbx_correo.ReadOnly = false;
                    txtbx_modfPass.ReadOnly = false;
                    txtbx_Tel.ReadOnly = false;
                    btn_deleteUser.Enabled = true;
                    btn_modfUser.Enabled = true;
                    btn_deleteUser.Visible = true;
                    btn_modfUser.Visible = true;
                }

            }
            catch { }
        }

        public void SeleccionDtsdoc()
        {
            conexionDB.abrir();
            try
            {
                string query = "select * from Usuarios where id_usuarios = @idc";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@idc", Cdlselection);
                SqlDataReader read = comando.ExecuteReader();
                if (read.Read())
                {
                    txtbx_tpUser.Text = Cdlselection;
                    txtbx_tagUser.Text = read["nm_usuario"].ToString();
                    txtbx_nmFull.Text = read["nmFll_usuario"].ToString();
                    txtbx_Tel.Text = read["telefono"].ToString();
                    txtbx_correo.Text = read["correo"].ToString();
                    txtbx_modfPass.Text = read["psswrd"].ToString();

                }
            }
            catch(Exception e) {
                Console.WriteLine(">>>"+e);
            }
            conexionDB.cerrar();
        }

        public void actualizarUser()
        {
            try
            {
                conexionDB.abrir();
                string query = "update Usuarios set nm_usuario = @nmuser,nmFll_usuario=@nmFull,telefono=@tel,correo=@crro,psswrd=@pss where id_usuarios=@idUser";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@idUser", Cdlselection);
                comando.Parameters.AddWithValue("@nmuser",txtbx_tagUser.Text);
                comando.Parameters.AddWithValue("@nmFull",txtbx_nmFull.Text);
                comando.Parameters.AddWithValue("@tel",txtbx_Tel.Text);
                comando.Parameters.AddWithValue("@crro",txtbx_correo.Text);
                comando.Parameters.AddWithValue("@pss", txtbx_modfPass.Text);
                comando.ExecuteNonQuery();
                conexionDB.cerrar();
                conexionDB.abrir();
                string query2 = "update Perfiles_Doctores set correo_doc = @corr, nombre_doc = @nmDco where id_usuarios=@idDoc";
                SqlCommand comando2 = new SqlCommand(query2, conexionDB.Conectarbd);
                comando2.Parameters.AddWithValue("@idDoc", Cdlselection);
                comando2.Parameters.AddWithValue("@nmDco", txtbx_nmFull.Text);
                comando2.Parameters.AddWithValue("@corr", txtbx_correo.Text);
                comando2.ExecuteNonQuery();
                conexionDB.cerrar();
                MessageBox.Show("Se Modifico Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error en la conexion \n porfavor vuelvalo a intentar mas tarde", "Lo sentimos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_modfUser_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que quieres modificar?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                actualizarUser();
                Clearall();
                cargarListuser();
            }
        }

        private void Clearall() {
            txtbx_tpUser.Text = "";
            txtbx_tagUser.Text = "";
            txtbx_nmFull.Text = "";
            txtbx_Tel.Text = "";
            txtbx_correo.Text = "";
            txtbx_modfPass.Text = "";
            txtbx_tpUser.ReadOnly = true;
            txtbx_tagUser.ReadOnly = true;
            txtbx_nmFull.ReadOnly = true;
            txtbx_Tel.ReadOnly = true;
            txtbx_correo.ReadOnly = true;
            txtbx_modfPass.ReadOnly = true;
            btn_deleteUser.Enabled = false;
            btn_modfUser.Enabled = false;
            btn_deleteUser.Visible = false;
            btn_modfUser.Visible = false;

        }

        
    }
}
