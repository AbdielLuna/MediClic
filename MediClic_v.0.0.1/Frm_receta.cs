﻿using System;
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
    public partial class Frm_receta : Form
    {
        String Cdlselection;
        int idFl=0;
        ConexionDB conexionDB = new ConexionDB();
        public Frm_receta()
        {
            InitializeComponent();
        }
        private void Frm_receta_Load(object sender, EventArgs e)
        {
            cargarListdocs();
            txtbx_idFolio.Text = idFl.ToString();
        }

        //btn Accions
        private void btn_impresion_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Desea guardar la receta?", "Confirmacion", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                idFl = Convert.ToInt32(txtbx_idFolio.Text) +1;
            }
        }
        private void dtgrd_listPac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cdlselection = dtgrd_listPac.Rows[e.RowIndex].Cells[0].Value.ToString();
                SeleccionDtspac();
            }
            catch { }
        }
        //Metodos
        public void clearall() {
            var res = MessageBox.Show("Seguro que quieres cancelar?\nLos datos no se guardaran","Confirmacion",MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes) {
                Console.Write("OK");
            } 
        }
        public void imprimir() {
            
            /*
                SaveFileDialog savefile = new SaveFileDialog();
               savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

               string PaginaHTML_Texto = Properties.Resources.Receta.ToString();
               PaginaHTML_Texto = PaginaHTML_Texto.Replace("@palabra", label1.Text);

               if (savefile.ShowDialog() == DialogResult.OK)
               {
                   using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                   {
                       //Creamos un nuevo documento y lo definimos como PDF
                       Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                       PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                       pdfDoc.Open();
                       pdfDoc.Add(new Phrase(""));

                       //Agregamos la imagen del banner al documento
                       iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.Prototipo_LOGO_200x200, System.Drawing.Imaging.ImageFormat.Png);
                       img.ScaleToFit(60, 60);
                       img.Alignment = iTextSharp.text.Image.UNDERLYING;

                       //img.SetAbsolutePosition(10,100);
                       img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                       pdfDoc.Add(img);


                       //pdfDoc.Add(new Phrase("Hola Mundo"));
                       using (StringReader sr = new StringReader(PaginaHTML_Texto))
                       {
                           XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                       }

                       pdfDoc.Close();
                       stream.Close();
                   }

               }
                */
        }
        public void cargarListdocs()
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
                MessageBox.Show("Lo sentimos \nHubo un problema con la Conexion porfavor itentelo mas tarde", "Advertencia", MessageBoxButtons.OK);
            }
            conexionDB.cerrar();
            dtgrd_listPac.Columns[0].HeaderText = "Matricula";
            dtgrd_listPac.Columns[1].HeaderText = "Nombre";
            dtgrd_listPac.Columns[2].HeaderText = "Sexo";
            dtgrd_listPac.Columns[3].HeaderText = "Contacto";
        }
        public void SeleccionDtspac()
        {
            conexionDB.abrir();
            try
            {
                string query = "select * from Pacientes where id_paciente = @idc";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@idc", Cdlselection);
                SqlDataReader read = comando.ExecuteReader();
                if (read.Read())
                {
                    txtbx_rcNmfull.Text = read["nombre_pac"].ToString();
                    txtbx_rcmts.Text = read["estatura_pac"].ToString();
                    txtbx_rcKg.Text = read["peso_pac"].ToString();
                    txtbx_rcAlg.Text = read["alergias"].ToString();
                }
            }
            catch {
                Console.WriteLine("Error en la seleccion");
            }
            conexionDB.cerrar();
        }

    }
}
