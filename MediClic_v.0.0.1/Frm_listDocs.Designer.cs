namespace MediClic_v._0._0._1
{
    partial class Frm_listDocs
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
            this.label5 = new System.Windows.Forms.Label();
            this.icnbtn_refreshDtg = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrd_listDoc = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtbx_modfNmfull = new System.Windows.Forms.TextBox();
            this.txtbx_modfCdla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtbx_modfTel = new System.Windows.Forms.TextBox();
            this.txtbx_modfCrro = new System.Windows.Forms.TextBox();
            this.txtbx_modfEspc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbx_modfSx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dttm_modfAN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.icnbtn_bsqP = new FontAwesome.Sharp.IconButton();
            this.txtbx_bsqPacientes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
            // 
            // icnbtn_refreshDtg
            // 
            this.icnbtn_refreshDtg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.icnbtn_refreshDtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtn_refreshDtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnbtn_refreshDtg.ForeColor = System.Drawing.Color.DimGray;
            this.icnbtn_refreshDtg.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.icnbtn_refreshDtg.IconColor = System.Drawing.Color.White;
            this.icnbtn_refreshDtg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtn_refreshDtg.IconSize = 25;
            this.icnbtn_refreshDtg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icnbtn_refreshDtg.Location = new System.Drawing.Point(359, 10);
            this.icnbtn_refreshDtg.Name = "icnbtn_refreshDtg";
            this.icnbtn_refreshDtg.Size = new System.Drawing.Size(96, 32);
            this.icnbtn_refreshDtg.TabIndex = 2;
            this.icnbtn_refreshDtg.Text = "Refrescar";
            this.icnbtn_refreshDtg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnbtn_refreshDtg.UseVisualStyleBackColor = true;
            this.icnbtn_refreshDtg.Click += new System.EventHandler(this.icnbtn_refreshDtg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Doctores";
            // 
            // dtgrd_listDoc
            // 
            this.dtgrd_listDoc.AllowUserToAddRows = false;
            this.dtgrd_listDoc.AllowUserToDeleteRows = false;
            this.dtgrd_listDoc.AllowUserToOrderColumns = true;
            this.dtgrd_listDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd_listDoc.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrd_listDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_listDoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrd_listDoc.EnableHeadersVisualStyles = false;
            this.dtgrd_listDoc.Location = new System.Drawing.Point(12, 61);
            this.dtgrd_listDoc.MultiSelect = false;
            this.dtgrd_listDoc.Name = "dtgrd_listDoc";
            this.dtgrd_listDoc.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrd_listDoc.RowHeadersVisible = false;
            this.dtgrd_listDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_listDoc.Size = new System.Drawing.Size(443, 371);
            this.dtgrd_listDoc.TabIndex = 7;
            this.dtgrd_listDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_listDoc_CellClick);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 118;
            this.iconPictureBox1.Location = new System.Drawing.Point(131, 50);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(141, 118);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtgrd_listDoc);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 470);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.panel4.Controls.Add(this.icnbtn_refreshDtg);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 45);
            this.panel4.TabIndex = 6;
            // 
            // txtbx_modfNmfull
            // 
            this.txtbx_modfNmfull.Location = new System.Drawing.Point(145, 211);
            this.txtbx_modfNmfull.Name = "txtbx_modfNmfull";
            this.txtbx_modfNmfull.ReadOnly = true;
            this.txtbx_modfNmfull.Size = new System.Drawing.Size(176, 20);
            this.txtbx_modfNmfull.TabIndex = 10;
            // 
            // txtbx_modfCdla
            // 
            this.txtbx_modfCdla.Location = new System.Drawing.Point(145, 185);
            this.txtbx_modfCdla.Name = "txtbx_modfCdla";
            this.txtbx_modfCdla.ReadOnly = true;
            this.txtbx_modfCdla.Size = new System.Drawing.Size(113, 20);
            this.txtbx_modfCdla.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cedula:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 470);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtbx_modfTel);
            this.panel5.Controls.Add(this.txtbx_modfCrro);
            this.panel5.Controls.Add(this.txtbx_modfEspc);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cmbx_modfSx);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dttm_modfAN);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtbx_modfNmfull);
            this.panel5.Controls.Add(this.txtbx_modfCdla);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.iconPictureBox1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(522, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 470);
            this.panel5.TabIndex = 0;
            // 
            // txtbx_modfTel
            // 
            this.txtbx_modfTel.Location = new System.Drawing.Point(145, 363);
            this.txtbx_modfTel.Name = "txtbx_modfTel";
            this.txtbx_modfTel.ReadOnly = true;
            this.txtbx_modfTel.Size = new System.Drawing.Size(176, 20);
            this.txtbx_modfTel.TabIndex = 20;
            // 
            // txtbx_modfCrro
            // 
            this.txtbx_modfCrro.Location = new System.Drawing.Point(145, 338);
            this.txtbx_modfCrro.Name = "txtbx_modfCrro";
            this.txtbx_modfCrro.ReadOnly = true;
            this.txtbx_modfCrro.Size = new System.Drawing.Size(176, 20);
            this.txtbx_modfCrro.TabIndex = 19;
            // 
            // txtbx_modfEspc
            // 
            this.txtbx_modfEspc.Location = new System.Drawing.Point(144, 308);
            this.txtbx_modfEspc.Name = "txtbx_modfEspc";
            this.txtbx_modfEspc.ReadOnly = true;
            this.txtbx_modfEspc.Size = new System.Drawing.Size(114, 20);
            this.txtbx_modfEspc.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Especialidad:";
            // 
            // cmbx_modfSx
            // 
            this.cmbx_modfSx.Enabled = false;
            this.cmbx_modfSx.FormattingEnabled = true;
            this.cmbx_modfSx.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbx_modfSx.Location = new System.Drawing.Point(144, 281);
            this.cmbx_modfSx.Name = "cmbx_modfSx";
            this.cmbx_modfSx.Size = new System.Drawing.Size(114, 21);
            this.cmbx_modfSx.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sexo:";
            // 
            // dttm_modfAN
            // 
            this.dttm_modfAN.Enabled = false;
            this.dttm_modfAN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttm_modfAN.Location = new System.Drawing.Point(145, 254);
            this.dttm_modfAN.Name = "dttm_modfAN";
            this.dttm_modfAN.Size = new System.Drawing.Size(113, 20);
            this.dttm_modfAN.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de\r\nNacimiento:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(104, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.button1.Location = new System.Drawing.Point(227, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tel.:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 44);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perfil Doctores";
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
            this.icnbtn_bsqP.Location = new System.Drawing.Point(787, 19);
            this.icnbtn_bsqP.Name = "icnbtn_bsqP";
            this.icnbtn_bsqP.Size = new System.Drawing.Size(85, 26);
            this.icnbtn_bsqP.TabIndex = 8;
            this.icnbtn_bsqP.Text = "Buscar";
            this.icnbtn_bsqP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icnbtn_bsqP.UseVisualStyleBackColor = true;
            // 
            // txtbx_bsqPacientes
            // 
            this.txtbx_bsqPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_bsqPacientes.Location = new System.Drawing.Point(581, 19);
            this.txtbx_bsqPacientes.Name = "txtbx_bsqPacientes";
            this.txtbx_bsqPacientes.Size = new System.Drawing.Size(200, 26);
            this.txtbx_bsqPacientes.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.icnbtn_bsqP);
            this.panel1.Controls.Add(this.txtbx_bsqPacientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 62);
            this.panel1.TabIndex = 3;
            // 
            // Frm_listDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_listDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_listDocs";
            this.Load += new System.EventHandler(this.Frm_listDocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton icnbtn_refreshDtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrd_listDoc;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtbx_modfNmfull;
        private System.Windows.Forms.TextBox txtbx_modfCdla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton icnbtn_bsqP;
        private System.Windows.Forms.TextBox txtbx_bsqPacientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbx_modfTel;
        private System.Windows.Forms.TextBox txtbx_modfCrro;
        private System.Windows.Forms.TextBox txtbx_modfEspc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbx_modfSx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dttm_modfAN;
        private System.Windows.Forms.Label label4;
    }
}