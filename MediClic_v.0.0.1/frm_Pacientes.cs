using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using TextBox = System.Windows.Forms.TextBox;

namespace MediClic_v._0._0._1
{
    public partial class frm_Pacientes : Form
    {
        ConexionDB conexionDB = new ConexionDB();


        public frm_Pacientes()
        {
            InitializeComponent();
        }

        //btn EdicionDts
        private void icnbtn_editDG_Click(object sender, EventArgs e)
        {
            editar(txtbx_namePdg, true);
            editar(txtbx_sxPdg, true);
            editarEsp(txtbx_telPdg, true);
            editarbtn(icnbtn_editDG, btn_saveDg, true);
        }

        private void icnbtn_editHM_Click(object sender, EventArgs e)
        {
            txtbx_tsgPhm.Enabled = true;
            editarEsp(txtbx_mtsPhm, true);
            editarEsp(txtbx_kgPhm, true);
            editar(txtbx_algPdts, true);
            editar(txtbx_addcPdts, true);
            editarbtn(icnbtn_editHM, btn_saveHM, true);
        }

        private void icnbtn_editAnt_Click(object sender, EventArgs e)
        {
            editar(txtbx_patPant, true);
            editar(txtbx_notpatPant, true);
            editar(txtbx_enffPant, true);
            editarbtn(icnbtn_editAnt, btn_saveANT, true);
        }
        //btn saveDTS
        private void btn_saveDg_Click(object sender, EventArgs e)
        {
            editarbtn(icnbtn_editDG, btn_saveDg, false);
            editar(txtbx_idPdg, false);
            editar(txtbx_namePdg, false);
            editar(txtbx_sxPdg, false);
            editarEsp(txtbx_telPdg, false);
            save();
        }

        private void btn_saveHM_Click(object sender, EventArgs e)
        {
            editarbtn(icnbtn_editHM, btn_saveHM, false);
            txtbx_tsgPhm.Enabled = false;
            editarEsp(txtbx_mtsPhm, false);
            editarEsp(txtbx_kgPhm, false);
            editar(txtbx_algPdts, false);
            editar(txtbx_addcPdts, false);
            save();
        }

        private void btn_saveANT_Click(object sender, EventArgs e)
        {
            editarbtn(icnbtn_editAnt, btn_saveANT, false);
            editar(txtbx_patPant, false);
            editar(txtbx_notpatPant, false);
            editar(txtbx_enffPant, false);
            save();
        }

        //Metodos

        public void editar(TextBox txt, bool act)
        {
            if (act == true) { txt.ReadOnly = false; }
            if (act == false) { txt.ReadOnly = true; }
        }
        public void editarEsp(MaskedTextBox txt, bool act)
        {
            if (act == true) { txt.ReadOnly = false; }
            if (act == false) { txt.ReadOnly = true; }
        }
      
        //Metodos btn superiores  
        public void editarbtn(IconButton icnbtn, IconButton icnbtnSave, bool actt)
        {
            if (actt == true) { icnbtn.Enabled = false; icnbtnSave.Visible = true; }
            if (actt == false) { icnbtn.Enabled = true; icnbtnSave.Visible = false; }
        }

        public void save()
        {
            var res = MessageBox.Show("Seguro que quiere actualizar los datos?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(txtbx_namePdg.Text) && !string.IsNullOrEmpty(txtbx_kgPhm.Text) && !string.IsNullOrEmpty(txtbx_mtsPhm.Text))
                {
                    updateDts();
                    MessageBox.Show("Se actualizó correctamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Faltan campos por llenar\nPorfavor rellene los campos para poder guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        public void updateDts()
        {
            try
            {
                conexionDB.abrir();
                string query = "update Pacientes set nombre_pac=@nmPac,sexo_pac=@sx,telefono_pac=@tel,tipo_sangre=@tpsg,estatura_pac=@mts,peso_pac=@kg,alergias=@Alg,enfermedades=@enfer,patologicos=@pat,nopatologicos=@noPac,adicciones=@adcc where id_paciente = @idpac";
                SqlCommand comando = new SqlCommand(query, conexionDB.Conectarbd);
                comando.Parameters.AddWithValue("@idpac", txtbx_idPdg.Text);
                comando.Parameters.AddWithValue("@nmPac", txtbx_namePdg.Text);
                comando.Parameters.AddWithValue("@sx", txtbx_sxPdg.Text);
                comando.Parameters.AddWithValue("@tel", txtbx_telPdg.Text);
                comando.Parameters.AddWithValue("@tpsg", txtbx_tsgPhm.Text);
                comando.Parameters.AddWithValue("@mts", txtbx_mtsPhm.Text);
                comando.Parameters.AddWithValue("@kg", txtbx_kgPhm.Text);
                comando.Parameters.AddWithValue("@Alg", txtbx_algPdts.Text);
                comando.Parameters.AddWithValue("@enfer", txtbx_enffPant.Text);
                comando.Parameters.AddWithValue("@pat", txtbx_patPant.Text);
                comando.Parameters.AddWithValue("@noPac", txtbx_notpatPant.Text);
                comando.Parameters.AddWithValue("@adcc", txtbx_addcPdts.Text);
                comando.ExecuteNonQuery();
                conexionDB.cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine("------------>>>>" + e);
            }
        }

        private void icnbtn_delete_Click(object sender, EventArgs e)
        {
            var dlt = MessageBox.Show("Deseas eliminar a este pacinete?\nSe eliminara permanentemente", "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dlt == DialogResult.Yes)
            {
                conexionDB.abrir();
                try
                {
                    string query1 = "delete from Pacientes where id_paciente = @iduser";
                    SqlCommand comando1 = new SqlCommand(query1, conexionDB.Conectarbd);
                    comando1.Parameters.AddWithValue("@iduser", txtbx_idPdg.Text);
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("Se elimino correctamente.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                }
                catch { }
                conexionDB.cerrar();
            }


        }

    }
}
