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
    public partial class Frm_Agenda : Form
    {
        int id =0;
        string estado = "Confirmada", Cdlselection;
        ConexionDB conexionDB = new ConexionDB();
        public Frm_Agenda()
        {
            InitializeComponent();
        }

        private void Frm_Agenda_Load(object sender, EventArgs e)
        {
            cargarListcitas();
        }

        //Acciones btn
        private void btn_saveCita_Click(object sender, EventArgs e)
        {
            asignacionID();
            agendarCita();
            limparAll();
            cargarListcitas();
        }

        private void btn_cancelCita_Click(object sender, EventArgs e)
        {
            var resu = MessageBox.Show("Seguro que quieres cancelar?\nLos cambios no se guardaran","Confirmacion",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (resu == DialogResult.Yes)
            {
                limparAll();
            }
            
        }

        //Acciones de Modificar
        private void btn_modfCita_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que quieres modificar?","Confirmacion",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                actualizarCita();
                cargarListcitas();
                pnl_campModif.Visible = false;
            }
            if (result == DialogResult.No) { 
                pnl_campModif.Visible = false;
            }
        }

        private void btn_cancelAccion_Click(object sender, EventArgs e)
        {
            pnl_campModif.Visible = false;
        }

        //Acciones DataGrid
        private void dtgrd_listCitas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dtgrd_listCitas.Columns[e.ColumnIndex].Name == "estado")  //Si es la columna a evaluar
            {
                if (e.Value.ToString().Contains("Confirmada"))   //Si el valor de la celda contiene la palabra hora
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(145, 235, 146);
                }
                if (e.Value.ToString().Contains("Cancelada"))   //Si el valor de la celda contiene la palabra hora
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(228, 81, 81);
                }
            }
        }

        private void dtgrd_listCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                Cdlselection = dtgrd_listCitas.Rows[e.RowIndex].Cells[0].Value.ToString();
                pnl_campModif.Visible = true;
                SeleccionDtsdoc();
            }
            catch { }
            
        }
        //Metodos
        public void cargarListcitas()
        {
            conexionDB.abrir();
            try
            {
                string query = "Select * from Citas";
                SqlDataAdapter apt = new SqlDataAdapter(query, conexionDB.Conectarbd);
                DataTable dt = new DataTable();
                apt.Fill(dt);
                dtgrd_listCitas.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lo sentimos \nHubo un problema con la Conexion porfavor itentelo mas tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexionDB.cerrar();
            dtgrd_listCitas.Columns[0].HeaderText = "Folio";
            dtgrd_listCitas.Columns[1].HeaderText = "Nombre";
            dtgrd_listCitas.Columns[2].HeaderText = "Fecha";
            dtgrd_listCitas.Columns[3].HeaderText = "Hora";
            dtgrd_listCitas.Columns[4].HeaderText = "Motivo";
            dtgrd_listCitas.Columns[5].HeaderText = "Estado";
        }

        public void agendarCita() {
             try
             {
            
            conexionDB.abrir();
                string fecha = dtpic_fch.Value.ToShortDateString();
                string hora = (cmbx_hrs.Text + ":" + cmbx_mins.Text + " " + cmbx_hrsAMPM.Text);
                string query = "insert into Citas(id_cita,nm_cita,fecha,hora,motivo,estado)" +
                    "values(@id,@nmCita,@fch,@hora,@motivo,@estd)";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@id", id.ToString());
                comando.Parameters.AddWithValue("@nmCita", txtbx_nmPacFull.Text);
                comando.Parameters.AddWithValue("@fch", fecha);
                comando.Parameters.AddWithValue("@hora", hora);
                comando.Parameters.AddWithValue("@motivo", txtbx_Motivo.Text);
                comando.Parameters.AddWithValue("@estd", estado);
                comando.ExecuteNonQuery();
                conexionDB.cerrar();
                MessageBox.Show("Se Agrego la cita Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);         
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocurrio un error en la conexion \n porfavor vuelvalo a intentar mas tarde"+e.Message, "Lo sentimos!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void asignacionID()
        {
            conexionDB.abrir();
            string query = ("select id_cita from Citas where id_cita = (Select MAX( id_cita) from Citas)");
            SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
            SqlDataReader read = comando.ExecuteReader();
            if (read.Read())
            {
                id = Convert.ToInt32(read["id_cita"].ToString());
                id += 1;
                read.Close();
            }
            conexionDB.cerrar();
            if (id <=0) {
            id = 1;
            }
        }

        public void limparAll() {
            txtbx_nmPacFull.Text = "";
            cmbx_hrs.Text = "00";
            cmbx_mins.Text = "00";
            cmbx_hrsAMPM.Text = "AM";
            dtpic_fch.Text = DateTime.Now.ToShortTimeString();
            txtbx_Motivo.Text = "";
        }
        public void SeleccionDtsdoc()
        {
            conexionDB.abrir();
            try
            {
                string query = "select fecha,hora,estado from Citas where id_cita = @idc";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@idc", Cdlselection);
                SqlDataReader read = comando.ExecuteReader();
                if (read.Read())
                {
                    cmbx_modfEstado.Text = read["estado"].ToString();
                    dtpic_modfFch.Text = read["fecha"].ToString();
                    string hrfull = read["hora"].ToString();
                    string[] tiempo = hrfull.Split(':');
                    string[] tmpHra = tiempo[1].Split(' ');
                    cmbx_modfHrs.Text = tiempo[0];
                    cmbx_modfMin.Text = tmpHra[0];
                    cmbx_modfAMPM.Text = tmpHra[1];
                }
            }
            catch { }
            conexionDB.cerrar();
        }

        public void actualizarCita() {
            try
            {
                conexionDB.abrir();
                string fecha = dtpic_modfFch.Value.ToShortDateString();
                string hora = (cmbx_modfHrs.Text + ":" + cmbx_modfMin.Text + " " + cmbx_modfAMPM.Text);
                string query = "update Citas set fecha=@fch,estado=@estd,hora=@hora where id_cita = @id";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@id", Cdlselection);
                comando.Parameters.AddWithValue("@fch", fecha);
                comando.Parameters.AddWithValue("@hora", hora);
                comando.Parameters.AddWithValue("@estd", cmbx_modfEstado.Text);
                comando.ExecuteNonQuery();
                conexionDB.cerrar();
                MessageBox.Show("Se Modifico Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error en la conexion \n porfavor vuelvalo a intentar mas tarde", "Lo sentimos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
    }
}
