namespace MediClic_v._0._0._1
{
    partial class Frm_PacientesFull
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.icbtn_addPaciente = new FontAwesome.Sharp.IconButton();
            this.icnbtn_bsqP = new FontAwesome.Sharp.IconButton();
            this.txtbx_bsqPacientes = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrd_listPac = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listPac)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtgrd_listPac);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 473);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.icbtn_addPaciente);
            this.panel9.Controls.Add(this.icnbtn_bsqP);
            this.panel9.Controls.Add(this.txtbx_bsqPacientes);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(899, 51);
            this.panel9.TabIndex = 2;
            // 
            // icbtn_addPaciente
            // 
            this.icbtn_addPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.icbtn_addPaciente.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.icbtn_addPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_addPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_addPaciente.ForeColor = System.Drawing.Color.White;
            this.icbtn_addPaciente.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icbtn_addPaciente.IconColor = System.Drawing.Color.White;
            this.icbtn_addPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_addPaciente.IconSize = 35;
            this.icbtn_addPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_addPaciente.Location = new System.Drawing.Point(13, 3);
            this.icbtn_addPaciente.Name = "icbtn_addPaciente";
            this.icbtn_addPaciente.Size = new System.Drawing.Size(181, 40);
            this.icbtn_addPaciente.TabIndex = 2;
            this.icbtn_addPaciente.Text = "Agregar Nuevo";
            this.icbtn_addPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtn_addPaciente.UseVisualStyleBackColor = false;
            this.icbtn_addPaciente.Click += new System.EventHandler(this.icbtn_addPaciente_Click);
            // 
            // icnbtn_bsqP
            // 
            this.icnbtn_bsqP.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.icnbtn_bsqP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtn_bsqP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnbtn_bsqP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.icnbtn_bsqP.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.icnbtn_bsqP.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.icnbtn_bsqP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtn_bsqP.IconSize = 25;
            this.icnbtn_bsqP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnbtn_bsqP.Location = new System.Drawing.Point(791, 14);
            this.icnbtn_bsqP.Name = "icnbtn_bsqP";
            this.icnbtn_bsqP.Size = new System.Drawing.Size(85, 26);
            this.icnbtn_bsqP.TabIndex = 1;
            this.icnbtn_bsqP.Text = "Buscar";
            this.icnbtn_bsqP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icnbtn_bsqP.UseVisualStyleBackColor = true;
            this.icnbtn_bsqP.Click += new System.EventHandler(this.icnbtn_bsqP_Click);
            // 
            // txtbx_bsqPacientes
            // 
            this.txtbx_bsqPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_bsqPacientes.Location = new System.Drawing.Point(585, 14);
            this.txtbx_bsqPacientes.Name = "txtbx_bsqPacientes";
            this.txtbx_bsqPacientes.Size = new System.Drawing.Size(200, 26);
            this.txtbx_bsqPacientes.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 43);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(348, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Pacientes";
            // 
            // dtgrd_listPac
            // 
            this.dtgrd_listPac.AllowUserToAddRows = false;
            this.dtgrd_listPac.AllowUserToDeleteRows = false;
            this.dtgrd_listPac.AllowUserToOrderColumns = true;
            this.dtgrd_listPac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd_listPac.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listPac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrd_listPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_listPac.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrd_listPac.EnableHeadersVisualStyles = false;
            this.dtgrd_listPac.Location = new System.Drawing.Point(47, 100);
            this.dtgrd_listPac.MultiSelect = false;
            this.dtgrd_listPac.Name = "dtgrd_listPac";
            this.dtgrd_listPac.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listPac.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrd_listPac.RowHeadersVisible = false;
            this.dtgrd_listPac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_listPac.Size = new System.Drawing.Size(792, 361);
            this.dtgrd_listPac.TabIndex = 10;
            this.dtgrd_listPac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_listPac_CellClick);
            // 
            // Frm_PacientesFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 493);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PacientesFull";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_PacientesFull";
            this.Load += new System.EventHandler(this.Frm_PacientesFull_Load);
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listPac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton icbtn_addPaciente;
        private FontAwesome.Sharp.IconButton icnbtn_bsqP;
        public System.Windows.Forms.TextBox txtbx_bsqPacientes;
        private System.Windows.Forms.DataGridView dtgrd_listPac;
    }
}