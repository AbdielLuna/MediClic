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
    public partial class frm_adduser : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        int id;
        string tp;
        public frm_adduser()
        {
            InitializeComponent();
        }

        //Radio Button ROL
        private void rdbtn_rolDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_rolDoc.Checked == true) { 
                pnl_ContDoc.Visible = true;
                tp = "doc";
                asignacionID();

            }
        }

        private void rdbtn_rolRec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_rolRec.Checked == true)
            {
                pnl_ContDoc.Visible = false;
                tp = "sec";
                asignacionID();
            }
        }
        //Btn Acciones
        private void btn_cnlAcc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_tagUser.Text))
            {
              var r =  MessageBox.Show("Seguro que quieres cancelar \n los datos no se guardaran","Confirmacion",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (r == DialogResult.Yes) {
                    this.Close();
                }
            }
            else {
                this.Close();
            }
            
        }
        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbx_idUser.Text)) {
                if (!string.IsNullOrEmpty(txtbx_tagUser.Text) && !string.IsNullOrEmpty(txtbx_confirmPass.Text) && txtbx_confirmPass.Text == txtbx_pass.Text)
                {
                    var r = MessageBox.Show("Seguro que quieres agregar nuevo usuario?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        addUsuarios();
                        MessageBox.Show("Se agrego correctamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else {
                    MessageBox.Show("Faltan datos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
            else {
                MessageBox.Show("Faltan datos por llenar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
                
            
        }
        //Metodos
        public void asignacionID()
        {
            id = 0;
            conexionDB.abrir();
            string query = ("select id_usuarios from Usuarios where id_usuarios =(Select MAX(id_usuarios) from Usuarios where tipo_usuario = @tipouser)");
            SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
            comando.Parameters.AddWithValue("@tipouser",tp);
            SqlDataReader read = comando.ExecuteReader();
            if (read.Read())
            {
                id = Convert.ToInt32(read["id_usuarios"].ToString());
                id += 1;
                txtbx_idUser.Text = id.ToString();
                read.Close();
            }
            if (id <= 0)
            {
                if (tp == "doc")
                {
                    id = 1001;
                    txtbx_idUser.Text = id.ToString();
                }
                if (tp == "sec")
                {
                    id = 3001;
                    txtbx_idUser.Text = id.ToString();
                }
            }
            conexionDB.cerrar();
        }

        public void addUsuarios() {
            conexionDB.abrir();
            if (tp == "doc") {
                string query = "insert into Usuarios (id_usuarios,tipo_usuario,nm_usuario,nmFll_usuario,psswrd,telefono,correo)" +
                        "values (@id,@tipuser,@nmUser,@nmFll,@pss,@tel,@crro);";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@id", id.ToString());
                comando.Parameters.AddWithValue("@tipuser", tp);
                comando.Parameters.AddWithValue("@nmUser", txtbx_tagUser.Text);
                comando.Parameters.AddWithValue("@nmFll", txtbx_nmFullUser.Text);
                comando.Parameters.AddWithValue("@pss", txtbx_confirmPass.Text);
                comando.Parameters.AddWithValue("@tel", txtbx_tel.Text);
                comando.Parameters.AddWithValue("@crro", txtbx_crro.Text);
                comando.ExecuteNonQuery();
                conexionDB.cerrar();
                conexionDB.abrir();
                string querydoc = "insert into Perfiles_Doctores (id_usuarios,nombre_doc,fch_nacimiento,sexo_doc,especialidad_doc,telefono_doc,correo_doc,cedula_doc)" +
                    "values(@iddoc,@nmDoc,@fchNac,@sxDoc,@especDoc,@telDoc,@corrDoc,@cedlDoc);";
                SqlCommand comandodoc = new SqlCommand(querydoc, conexionDB.Conectarbd);
                comandodoc.Parameters.AddWithValue("@iddoc", id.ToString());
                comandodoc.Parameters.AddWithValue("@nmDoc", txtbx_nmFullUser.Text);
                string fechanc = dtatim_docAn.Value.ToShortDateString();
                comandodoc.Parameters.AddWithValue("@fchNac", fechanc);
                comandodoc.Parameters.AddWithValue("@sxDoc", cmbx_sxDoc.Text);
                comandodoc.Parameters.AddWithValue("@especDoc", txtbx_docEsp.Text);
                comandodoc.Parameters.AddWithValue("@telDoc", txtbx_tel.Text);
                comandodoc.Parameters.AddWithValue("@corrDoc", txtbx_crro.Text);
                comandodoc.Parameters.AddWithValue("@cedlDoc", txtbx_docCdprf.Text);
                comandodoc.ExecuteNonQuery();
                conexionDB.cerrar();
            }
            if (tp == "sec") {
                try
                {
                    string query = "insert into Usuarios (id_usuarios,tipo_usuario,nm_usuario,nmFll_usuario,psswrd,telefono,correo)" +
                        "values (@id,@tipuser,@nmUser,@nmFll,@pss,@tel,@crro);";
                    SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                    comando.Parameters.AddWithValue("@id", id.ToString());
                    comando.Parameters.AddWithValue("@tipuser", tp);
                    comando.Parameters.AddWithValue("@nmUser", txtbx_tagUser.Text);
                    comando.Parameters.AddWithValue("@nmFll", txtbx_nmFullUser.Text);
                    comando.Parameters.AddWithValue("@pss", txtbx_confirmPass.Text);
                    comando.Parameters.AddWithValue("@tel", txtbx_tel.Text);
                    comando.Parameters.AddWithValue("@crro", txtbx_crro.Text);
                    comando.ExecuteNonQuery();
                    conexionDB.cerrar();
                }
                catch
                {
                    MessageBox.Show("Ocurrio un error en la conexion \n porfavor vuelvalo a intentar mas tarde", "Lo sentimos!", MessageBoxButtons.OK);
                }
                conexionDB.cerrar();
            }

        }

        private void chckbx_most_CheckedChanged(object sender, EventArgs e)
        {
            mostrarPass();
        }

        //Metodos
        public void mostrarPass()
        {
            if (chckbx_most.Checked == true)
            {
                txtbx_pass.UseSystemPasswordChar = false;
                txtbx_confirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtbx_pass.UseSystemPasswordChar = true;
                txtbx_confirmPass.UseSystemPasswordChar = true;
            }

        }

        private void txtbx_confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_confirmPass.Text != txtbx_pass.Text)
            {
                lb_concidencia.Visible = true;
            }
            else {
                lb_concidencia.Visible = false;
            }
        }
    }
}
