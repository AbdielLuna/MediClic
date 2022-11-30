namespace MediClic_v._0._0._1
{
    partial class main_lobby
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_reloj = new System.Windows.Forms.Label();
            this.uI_Calendario1 = new Calendario.UI_Calendario();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgrd_listCitas = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tm_reloj = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listCitas)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.64641F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.35359F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 423);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.uI_Calendario1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 423);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_reloj);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 45);
            this.panel2.TabIndex = 1;
            // 
            // lb_reloj
            // 
            this.lb_reloj.AutoSize = true;
            this.lb_reloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_reloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reloj.ForeColor = System.Drawing.Color.White;
            this.lb_reloj.Location = new System.Drawing.Point(89, 6);
            this.lb_reloj.Name = "lb_reloj";
            this.lb_reloj.Size = new System.Drawing.Size(178, 33);
            this.lb_reloj.TabIndex = 2;
            this.lb_reloj.Text = "hh:mm:ss tt";
            // 
            // uI_Calendario1
            // 
            this.uI_Calendario1.BackColor = System.Drawing.Color.White;
            this.uI_Calendario1.ButtonCollapse = true;
            this.uI_Calendario1.ButtonDay = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uI_Calendario1.ButtonDayFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_Calendario1.ButtonDownColor = System.Drawing.Color.WhiteSmoke;
            this.uI_Calendario1.ButtonOverColor = System.Drawing.Color.WhiteSmoke;
            this.uI_Calendario1.ButtonTextFormat = true;
            this.uI_Calendario1.DayFont = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_Calendario1.DayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.uI_Calendario1.DayFormat = Calendario.UI_Calendario.DiaLetra.Abbreviation;
            this.uI_Calendario1.DayMonthFollowForeColor = System.Drawing.Color.Gray;
            this.uI_Calendario1.DayMonthForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.uI_Calendario1.DayMonthPassedForeColor = System.Drawing.Color.Gray;
            this.uI_Calendario1.DaySemanaFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_Calendario1.DaysForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uI_Calendario1.DayWeekForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.uI_Calendario1.ElipceSize = 5;
            this.uI_Calendario1.HourFont = new System.Drawing.Font("Arial", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_Calendario1.Location = new System.Drawing.Point(12, 52);
            this.uI_Calendario1.MonthFont = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_Calendario1.MonthForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            this.uI_Calendario1.MoveCalendar = false;
            this.uI_Calendario1.Name = "uI_Calendario1";
            this.uI_Calendario1.PanelBottonBackColor = System.Drawing.Color.White;
            this.uI_Calendario1.PanelDateBackColor = System.Drawing.Color.White;
            this.uI_Calendario1.PanelDateHeight = 100;
            this.uI_Calendario1.PanelDayBackColor = System.Drawing.Color.White;
            this.uI_Calendario1.PanelLowerBackColor = System.Drawing.Color.White;
            this.uI_Calendario1.SemanaFont = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_Calendario1.Size = new System.Drawing.Size(365, 374);
            this.uI_Calendario1.TabIndex = 0;
            this.uI_Calendario1.Text = "uI_Calendario1";
            this.uI_Calendario1.TimeForeColor = System.Drawing.Color.White;
            this.uI_Calendario1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.uI_Calendario1.TitleFont = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.uI_Calendario1.TitleForeColor = System.Drawing.Color.White;
            this.uI_Calendario1.TitleFormat = Calendario.UI_Calendario.TextHora.Text;
            this.uI_Calendario1.TitleHeight = 35;
            this.uI_Calendario1.TitleText = "Calendario";
            this.uI_Calendario1.TitleVisible = true;
            this.uI_Calendario1.YearFont = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uI_Calendario1.YearForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dtgrd_listCitas);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(399, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 423);
            this.panel4.TabIndex = 1;
            // 
            // dtgrd_listCitas
            // 
            this.dtgrd_listCitas.AllowUserToAddRows = false;
            this.dtgrd_listCitas.AllowUserToDeleteRows = false;
            this.dtgrd_listCitas.AllowUserToOrderColumns = true;
            this.dtgrd_listCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrd_listCitas.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(171)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrd_listCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_listCitas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrd_listCitas.EnableHeadersVisualStyles = false;
            this.dtgrd_listCitas.Location = new System.Drawing.Point(3, 52);
            this.dtgrd_listCitas.MultiSelect = false;
            this.dtgrd_listCitas.Name = "dtgrd_listCitas";
            this.dtgrd_listCitas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_listCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrd_listCitas.RowHeadersVisible = false;
            this.dtgrd_listCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_listCitas.Size = new System.Drawing.Size(487, 374);
            this.dtgrd_listCitas.TabIndex = 9;
            this.dtgrd_listCitas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgrd_listCitas_CellPainting);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(228)))), ((int)(((byte)(183)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(493, 45);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CITAS";
            // 
            // tm_reloj
            // 
            this.tm_reloj.Enabled = true;
            this.tm_reloj.Interval = 1000;
            this.tm_reloj.Tick += new System.EventHandler(this.tm_reloj_Tick);
            // 
            // main_lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_lobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "main_lobby";
            this.Load += new System.EventHandler(this.main_lobby_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_listCitas)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tm_reloj;
        private Calendario.UI_Calendario uI_Calendario1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_reloj;
        private System.Windows.Forms.DataGridView dtgrd_listCitas;
    }
}