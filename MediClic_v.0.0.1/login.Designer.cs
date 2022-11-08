namespace MediClic_v._0._0._1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtbx_user = new System.Windows.Forms.TextBox();
            this.txtbx_pass = new System.Windows.Forms.TextBox();
            this.btn_startSession = new System.Windows.Forms.Button();
            this.chckbx_showpass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbx_user
            // 
            this.txtbx_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_user.Location = new System.Drawing.Point(94, 283);
            this.txtbx_user.Name = "txtbx_user";
            this.txtbx_user.Size = new System.Drawing.Size(200, 26);
            this.txtbx_user.TabIndex = 1;
            // 
            // txtbx_pass
            // 
            this.txtbx_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_pass.Location = new System.Drawing.Point(94, 349);
            this.txtbx_pass.Name = "txtbx_pass";
            this.txtbx_pass.Size = new System.Drawing.Size(200, 26);
            this.txtbx_pass.TabIndex = 2;
            // 
            // btn_startSession
            // 
            this.btn_startSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.btn_startSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startSession.ForeColor = System.Drawing.Color.White;
            this.btn_startSession.Location = new System.Drawing.Point(107, 438);
            this.btn_startSession.Name = "btn_startSession";
            this.btn_startSession.Size = new System.Drawing.Size(174, 46);
            this.btn_startSession.TabIndex = 3;
            this.btn_startSession.Text = "Iniciar Sesion";
            this.btn_startSession.UseVisualStyleBackColor = false;
            this.btn_startSession.Click += new System.EventHandler(this.btn_startSession_Click);
            // 
            // chckbx_showpass
            // 
            this.chckbx_showpass.AutoSize = true;
            this.chckbx_showpass.Location = new System.Drawing.Point(94, 391);
            this.chckbx_showpass.Name = "chckbx_showpass";
            this.chckbx_showpass.Size = new System.Drawing.Size(118, 17);
            this.chckbx_showpass.TabIndex = 4;
            this.chckbx_showpass.Text = "Mostrar Contraseña";
            this.chckbx_showpass.UseVisualStyleBackColor = true;
            this.chckbx_showpass.CheckedChanged += new System.EventHandler(this.chckbx_showpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediClic_v._0._0._1.Properties.Resources.Prototipo_LOGO_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(94, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chckbx_showpass);
            this.Controls.Add(this.btn_startSession);
            this.Controls.Add(this.txtbx_pass);
            this.Controls.Add(this.txtbx_user);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbx_user;
        private System.Windows.Forms.TextBox txtbx_pass;
        private System.Windows.Forms.Button btn_startSession;
        private System.Windows.Forms.CheckBox chckbx_showpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}