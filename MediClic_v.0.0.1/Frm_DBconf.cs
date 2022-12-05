﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediClic_v._0._0._1
{
    public partial class Frm_DBconf : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        public Frm_DBconf()
        {
            InitializeComponent();
        }
        private void Frm_DBconf_Load(object sender, EventArgs e)
        {
            CargarDts();
        }
        //Btn Acciones 
        private void btn_Export_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea hacer Exportar su base de datos?","Confirmación",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                try {
                    int i=0;
                    conexionDB.abrir();
                    string Query = "BACKUP DATABASE [MediClic] TO  DISK = N'" + txtbx_ubiexprt.Text+ "\\MediClic.bak' WITH NOFORMAT, NOINIT,  NAME = N'MediClic-Full Database Backup', SKIP, NOREWIND, NOUNLOAD, STATS = 10";
                    SqlCommand comando = new SqlCommand(Query,conexionDB.Conectarbd);
                    comando.ExecuteNonQuery();
                    conexionDB.cerrar();
                    MessageBox.Show("Se Exporto Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (i <=5) {
                        i++;
                        lb_nota.Visible = true;
                    }
                    lb_nota.Visible = false;
                } catch{MessageBox.Show("Hubo un error con la ruta de direccion\nintente con una nueva","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            
            
        }
        //Seleccion de directorio
        private void icnbtn_Srchexp_Click(object sender, EventArgs e)
        {
            try {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string path = fbd.SelectedPath;
                        txtbx_ubiexprt.Text = path;
                    }
                }
            }
            catch { }
            

        }
        //Metodos
        public void CargarDts()
        {
            try {
                conexionDB.abrir();
                string query = "select * from Bitacora";
                SqlDataAdapter apt = new SqlDataAdapter(query, conexionDB.Conectarbd);
                DataTable dt = new DataTable();
                apt.Fill(dt);
                dtgrd_Bitacora.DataSource = dt;
                conexionDB.cerrar();
                dtgrd_Bitacora.Columns[0].HeaderText = "ID";
                dtgrd_Bitacora.Columns[1].HeaderText = "Nombre";
                dtgrd_Bitacora.Columns[2].HeaderText = "Rol";
                dtgrd_Bitacora.Columns[3].HeaderText = "Fecha E/S";
            }
            catch { }
        }


        
    }
}
