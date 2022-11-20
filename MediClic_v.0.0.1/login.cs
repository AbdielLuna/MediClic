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
using System.Windows.Media.Media3D;

namespace MediClic_v._0._0._1
{
    public partial class login : Form
    {
        //Inicializacion
        main_Doctor_ startsesionDOC = new main_Doctor_();
        main_Recepcion_ startsesionRec = new main_Recepcion_();
        main_Administracion_ startsesionAdm = new main_Administracion_();
        //Conexion DB
        ConexionDB conexionDB = new ConexionDB();
        
        public login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            conexionDB.abrir();
            mostrarPass();
        }

        private void chckbx_showpass_CheckedChanged(object sender, EventArgs e)
        {
            mostrarPass();
        }

        //botones 
        private void btn_startSession_Click(object sender, EventArgs e)
        {
            autentificacion();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        //Metodos##############################
        public void mostrarPass()
        {
            if (chckbx_showpass.Checked == true)
            {
                txtbx_pass.UseSystemPasswordChar = false;
            }
            else {
            txtbx_pass.UseSystemPasswordChar=true;
            }

        }

        public void autentificacion()
        {
            try
            {
                conexionDB.abrir();
                string query = "select id_usuarios,nombre_usuario,psswrd,tipo_usuario from Usuarios where nombre_usuario = @user and psswrd = @pass";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@user",txtbx_user.Text);
                comando.Parameters.AddWithValue("@pass", txtbx_pass.Text);
                SqlDataReader reader = comando.ExecuteReader();
                

                if (reader.Read()) {
                    
                    string id = reader["id_usuarios"].ToString();
                    string iduser = (txtbx_user.Text + "#"+ id );
                    if (reader["tipo_usuario"].ToString() == "doc") {
                        startsesionDOC.lb_nmUser.Text = iduser;
                        startsesionDOC.Show();
                        this.Close();
                    }
                    if (reader["tipo_usuario"].ToString() == "sec") {
                        startsesionRec.lb_nmUser.Text = iduser;
                        startsesionRec.Show();
                        this.Close();
                    }
                    if (reader["tipo_usuario"].ToString() == "adm")
                    {
                        startsesionAdm.lb_nmUser.Text = iduser;
                        startsesionAdm.Show();
                        this.Close();
                    }

                }
                else {
                    lb_errorAut.Visible = true;
                    conexionDB.cerrar();
                }

            }
            catch {
                MessageBox.Show("Losiento! \n Ocurrio un error, porfavor intentelo mas tarde.","Advertencia",MessageBoxButtons.OK);
            }
            /* if(txtbx_user.Text == "admin" && txtbx_pass.Text == "admin"){
                 openFrm(new main_Administracion_());
             }
             if (txtbx_user.Text == "doc" && txtbx_pass.Text == "doc")
             {
                 openFrm(new main_Doctor_());
             }
             if (txtbx_user.Text == "rec" && txtbx_pass.Text == "rec")
             {
                 openFrm(new main_Recepcion_());
             }*/
        }


       
    }
}
