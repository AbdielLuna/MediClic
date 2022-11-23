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
            if (txtbx_idUser.Text != null || txtbx_nmFullUser.Text != null)
            {
              var r =  MessageBox.Show("Seguro que quieres cancelar \n los datos no se guardaran","Confirmacion",MessageBoxButtons.YesNoCancel);
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
  
                var r = MessageBox.Show("Seguro que quieres agregar nuevo usuario?", "Confirmacion", MessageBoxButtons.YesNoCancel);
                if (r == DialogResult.Yes)
                {
                addUsuarios();
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
            if (id == 0)
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

    }
}
