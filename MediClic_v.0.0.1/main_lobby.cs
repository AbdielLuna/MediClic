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
    public partial class main_lobby : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        public main_lobby()
        {
            InitializeComponent();
        }

        //Reloj para Lobby
        private void tm_reloj_Tick(object sender, EventArgs e)
        {
            lb_reloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
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

        private void main_lobby_Load(object sender, EventArgs e)
        {
            cargarListcitas();
        }

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
    

    }
}
