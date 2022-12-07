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
        public  bool varCond;
        string id;
        ConexionDB conexionDB = new ConexionDB();
        public Frm_listDocs()
        {
            InitializeComponent();
        }
        private void Frm_listDocs_Load(object sender, EventArgs e)
        {
            cargarListdocs();
            condicion(varCond);
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
                if (varCond == false)
                {
                    SeleccionDtsdoc();
                    optID();
                    txtbx_modfCdla.ReadOnly = false;
                    txtbx_modfNmfull.ReadOnly = false;
                    dttm_modfAN.Enabled = true;
                    txtbx_modfNmfull.ReadOnly = false;
                    cmbx_modfSx.Enabled = true;
                    txtbx_modfEspc.ReadOnly = false;
                    txtbx_modfCrro.ReadOnly = false;
                    txtbx_modfTel.ReadOnly = false;
                    btn_modfDoc.Visible = true;
                    btn_cancelDoc.Visible = true;
                    btn_cancelDoc.Enabled = true;
                    btn_modfDoc.Enabled = true;
                }
                else {
                    SeleccionDtsdoc();
                }
                
            }
            catch { }
            
        }

        public void condicion(bool cond) {
            if (cond == true){ 
                btn_modfDoc.Visible = false;
                btn_modfDoc.Enabled = false;
                btn_cancelDoc.Visible = false;
                btn_cancelDoc.Enabled = false;
            }
        }

        private void btn_modfDoc_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que quieres modificar?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Actualizardoc();
                Clearall();
                cargarListdocs();
            }
        }

        public void Clearall() {
            
            txtbx_modfCdla.Text = "";
            txtbx_modfCdla.ReadOnly = true;
            txtbx_modfNmfull.ReadOnly = true;
            txtbx_modfNmfull.Text = "";
            dttm_modfAN.Text = (DateTime.Now.ToLocalTime()).ToShortDateString();
            dttm_modfAN.Enabled = false;
            cmbx_modfSx.Text = "";
            cmbx_modfSx.Enabled = false;
            txtbx_modfEspc.Text = "";
            txtbx_modfEspc.ReadOnly = true;
            txtbx_modfCrro.Text = "";
            txtbx_modfCrro.ReadOnly = true;
            txtbx_modfTel.Text = "";
            txtbx_modfTel.ReadOnly = true;
            btn_modfDoc.Visible = false;
            btn_cancelDoc.Visible = false;
            btn_cancelDoc.Enabled = false;
            btn_modfDoc.Enabled = false;
        }

        public void Actualizardoc() {
            try
            {
                conexionDB.abrir();
                string fecha = dttm_modfAN.Value.ToShortDateString();
                string query = "update Perfiles_Doctores set nombre_doc = @nmDco,fch_nacimiento=@fchNc,sexo_doc=@sxDoc,especialidad_doc=@espDoc,telefono_doc=@telDoc,correo_doc=@corr,cedula_doc=@cdl where id_usuarios=@idDoc";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@idDoc", id);
                comando.Parameters.AddWithValue("@nmDco", txtbx_modfNmfull.Text);
                comando.Parameters.AddWithValue("@fchNc", fecha);
                comando.Parameters.AddWithValue("@sxDoc", cmbx_modfSx.Text);
                comando.Parameters.AddWithValue("@espDoc", txtbx_modfEspc.Text);
                comando.Parameters.AddWithValue("@telDoc", txtbx_modfTel.Text);
                comando.Parameters.AddWithValue("@corr", txtbx_modfCrro.Text);
                comando.Parameters.AddWithValue("@cdl", txtbx_modfCdla.Text);
                comando.ExecuteNonQuery();
                conexionDB.cerrar();
                conexionDB.abrir();
                string query2 = "update Usuarios set correo = @corr, nmFll_usuario= @user where id_usuarios=@idDoc";
                SqlCommand comando2 = new SqlCommand(query2, conexionDB.Conectarbd);
                comando2.Parameters.AddWithValue("@idDoc", id);
                comando2.Parameters.AddWithValue("@user", txtbx_modfNmfull.Text);
                comando2.Parameters.AddWithValue("@corr", txtbx_modfCrro.Text);
                comando2.ExecuteNonQuery();
                conexionDB.cerrar();
                MessageBox.Show("Se Modifico Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clearall();
                cargarListdocs();
            }
            catch
            {
                MessageBox.Show("Ocurrio un error en la conexion \n porfavor vuelvalo a intentar mas tarde", "Lo sentimos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btn_cancelDoc_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        private void optID()
        {
            try
            {
                conexionDB.abrir();
                string query = "Select id_usuarios from Perfiles_Doctores where cedula_doc= @ced";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@ced", Cdlselection);
                SqlDataReader read = comando.ExecuteReader();
                if (read.Read())
                {
                   id  = read["id_usuarios"].ToString();
                }
                conexionDB.cerrar();
            }
            catch { }

        }
    }
}
