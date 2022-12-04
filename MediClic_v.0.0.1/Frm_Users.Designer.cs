namespace MediClic_v._0._0._1
{
    partial class Frm_Users
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
            this.icbtn_addUser = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgrd_listUsuarios = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.icnbtn_refreshDtg = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtbx_correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_Tel = new System.Windows.Forms.TextBox();
            this.txtbx_nmFull = new System.Windows.Forms.TextBox();
            this.txtbx_tagUser = new System.Windows.Forms.TextBox();
            this.txtbx_tpUser = new System.Windows.Forms.TextBox();
            this.btn_modfUser = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_modfPass = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listUsuarios)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 20);
            this.panel1.TabIndex = 0;
            // 
            // icbtn_addUser
            // 
            this.icbtn_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            this.icbtn_addUser.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.icbtn_addUser.FlatAppearance.BorderSize = 0;
            this.icbtn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_addUser.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_addUser.ForeColor = System.Drawing.Color.White;
            this.icbtn_addUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.icbtn_addUser.IconColor = System.Drawing.Color.White;
            this.icbtn_addUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_addUser.IconSize = 35;
            this.icbtn_addUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbtn_addUser.Location = new System.Drawing.Point(294, 4);
            this.icbtn_addUser.Name = "icbtn_addUser";
            this.icbtn_addUser.Size = new System.Drawing.Size(173, 36);
            this.icbtn_addUser.TabIndex = 6;
            this.icbtn_addUser.Text = "Añadir Usuario";
            this.icbtn_addUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbtn_addUser.UseVisualStyleBackColor = false;
            this.icbtn_addUser.Click += new System.EventHandler(this.icbtn_addUser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtgrd_listUsuarios);
            this.panel2.Controls.Add(this.icnbtn_refreshDtg);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(15, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 482);
            this.panel2.TabIndex = 1;
            // 
            // dtgrd_listUsuarios
            // 
            this.dtgrd_listUsuarios.AllowUserToAddRows = false;
            this.dtgrd_listUsuarios.AllowUserToDeleteRows = false;
            this.dtgrd_listUsuarios.AllowUserToOrderColumns = true;
            this.dtgrd_listUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd_listUsuarios.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrd_listUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(188)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_listUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrd_listUsuarios.EnableHeadersVisualStyles = false;
            this.dtgrd_listUsuarios.Location = new System.Drawing.Point(12, 77);
            this.dtgrd_listUsuarios.MultiSelect = false;
            this.dtgrd_listUsuarios.Name = "dtgrd_listUsuarios";
            this.dtgrd_listUsuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrd_listUsuarios.RowHeadersVisible = false;
            this.dtgrd_listUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_listUsuarios.Size = new System.Drawing.Size(443, 384);
            this.dtgrd_listUsuarios.TabIndex = 7;
            this.dtgrd_listUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_listUsuarios_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(188)))), ((int)(((byte)(247)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.icbtn_addUser);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 45);
            this.panel4.TabIndex = 6;
            // 
            // icnbtn_refreshDtg
            // 
            this.icnbtn_refreshDtg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(188)))), ((int)(((byte)(247)))));
            this.icnbtn_refreshDtg.FlatAppearance.BorderSize = 0;
            this.icnbtn_refreshDtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtn_refreshDtg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnbtn_refreshDtg.ForeColor = System.Drawing.Color.DimGray;
            this.icnbtn_refreshDtg.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.icnbtn_refreshDtg.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            this.icnbtn_refreshDtg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtn_refreshDtg.IconSize = 25;
            this.icnbtn_refreshDtg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icnbtn_refreshDtg.Location = new System.Drawing.Point(361, 50);
            this.icnbtn_refreshDtg.Name = "icnbtn_refreshDtg";
            this.icnbtn_refreshDtg.Size = new System.Drawing.Size(94, 31);
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
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Usuarios";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(490, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 482);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtbx_modfPass);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtbx_correo);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtbx_Tel);
            this.panel5.Controls.Add(this.txtbx_nmFull);
            this.panel5.Controls.Add(this.txtbx_tagUser);
            this.panel5.Controls.Add(this.txtbx_tpUser);
            this.panel5.Controls.Add(this.btn_modfUser);
            this.panel5.Controls.Add(this.btn_deleteUser);
            this.panel5.Controls.Add(this.iconPictureBox1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(17, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 482);
            this.panel5.TabIndex = 0;
            // 
            // txtbx_correo
            // 
            this.txtbx_correo.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_correo.Location = new System.Drawing.Point(144, 307);
            this.txtbx_correo.Name = "txtbx_correo";
            this.txtbx_correo.ReadOnly = true;
            this.txtbx_correo.Size = new System.Drawing.Size(190, 28);
            this.txtbx_correo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo:";
            // 
            // txtbx_Tel
            // 
            this.txtbx_Tel.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Tel.Location = new System.Drawing.Point(144, 269);
            this.txtbx_Tel.MaxLength = 10;
            this.txtbx_Tel.Name = "txtbx_Tel";
            this.txtbx_Tel.ReadOnly = true;
            this.txtbx_Tel.Size = new System.Drawing.Size(190, 28);
            this.txtbx_Tel.TabIndex = 11;
            // 
            // txtbx_nmFull
            // 
            this.txtbx_nmFull.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_nmFull.Location = new System.Drawing.Point(143, 235);
            this.txtbx_nmFull.Name = "txtbx_nmFull";
            this.txtbx_nmFull.ReadOnly = true;
            this.txtbx_nmFull.Size = new System.Drawing.Size(191, 28);
            this.txtbx_nmFull.TabIndex = 10;
            // 
            // txtbx_tagUser
            // 
            this.txtbx_tagUser.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_tagUser.Location = new System.Drawing.Point(144, 199);
            this.txtbx_tagUser.MaxLength = 8;
            this.txtbx_tagUser.Name = "txtbx_tagUser";
            this.txtbx_tagUser.ReadOnly = true;
            this.txtbx_tagUser.Size = new System.Drawing.Size(113, 28);
            this.txtbx_tagUser.TabIndex = 9;
            // 
            // txtbx_tpUser
            // 
            this.txtbx_tpUser.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_tpUser.Location = new System.Drawing.Point(144, 161);
            this.txtbx_tpUser.Name = "txtbx_tpUser";
            this.txtbx_tpUser.ReadOnly = true;
            this.txtbx_tpUser.Size = new System.Drawing.Size(113, 28);
            this.txtbx_tpUser.TabIndex = 8;
            // 
            // btn_modfUser
            // 
            this.btn_modfUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            this.btn_modfUser.Enabled = false;
            this.btn_modfUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_modfUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modfUser.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modfUser.ForeColor = System.Drawing.Color.White;
            this.btn_modfUser.Location = new System.Drawing.Point(103, 397);
            this.btn_modfUser.Name = "btn_modfUser";
            this.btn_modfUser.Size = new System.Drawing.Size(108, 37);
            this.btn_modfUser.TabIndex = 7;
            this.btn_modfUser.Text = "Modificar";
            this.btn_modfUser.UseVisualStyleBackColor = false;
            this.btn_modfUser.Visible = false;
            this.btn_modfUser.Click += new System.EventHandler(this.btn_modfUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Enabled = false;
            this.btn_deleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUser.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            this.btn_deleteUser.Location = new System.Drawing.Point(226, 397);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(108, 37);
            this.btn_deleteUser.TabIndex = 6;
            this.btn_deleteUser.Text = "Eliminar";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Visible = false;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(62)))), ((int)(((byte)(210)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 95;
            this.iconPictureBox1.Location = new System.Drawing.Point(144, 50);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(125, 95);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tel.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(188)))), ((int)(((byte)(247)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perfil Usuarios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contraseña:";
            // 
            // txtbx_modfPass
            // 
            this.txtbx_modfPass.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_modfPass.Location = new System.Drawing.Point(143, 346);
            this.txtbx_modfPass.Name = "txtbx_modfPass";
            this.txtbx_modfPass.ReadOnly = true;
            this.txtbx_modfPass.Size = new System.Drawing.Size(191, 28);
            this.txtbx_modfPass.TabIndex = 15;
            this.txtbx_modfPass.UseSystemPasswordChar = true;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Users";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Users";
            this.Load += new System.EventHandler(this.Frm_Users_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listUsuarios)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icbtn_addUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton icnbtn_refreshDtg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_Tel;
        private System.Windows.Forms.TextBox txtbx_nmFull;
        private System.Windows.Forms.TextBox txtbx_tagUser;
        private System.Windows.Forms.TextBox txtbx_tpUser;
        private System.Windows.Forms.Button btn_modfUser;
        private System.Windows.Forms.Button btn_deleteUser;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgrd_listUsuarios;
        private System.Windows.Forms.TextBox txtbx_correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_modfPass;
        private System.Windows.Forms.Label label8;
    }
}