namespace QuanLyThuVien
{
    partial class FormMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtdausach = new System.Windows.Forms.ToolStripMenuItem();
            this.txtdocgia = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMTS = new System.Windows.Forms.ToolStripMenuItem();
            this.btndocgia = new System.Windows.Forms.ToolStripButton();
            this.lblten = new System.Windows.Forms.ToolStripLabel();
            this.btndausach = new System.Windows.Forms.ToolStripButton();
            this.button3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.toolStrip1.BackgroundImage = global::QuanLyThuVien.Properties.Resources.background1;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMenu,
            this.lblten,
            this.btndausach,
            this.btndocgia,
            this.button3,
            this.toolStripButton4,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1148, 27);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // txtMenu
            // 
            this.txtMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtdausach,
            this.txtdocgia,
            this.txtMTS});
            this.txtMenu.Image = global::QuanLyThuVien.Properties.Resources._1493874144_menu;
            this.txtMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(80, 24);
            this.txtMenu.Text = "&Menu";
            // 
            // txtdausach
            // 
            this.txtdausach.Name = "txtdausach";
            this.txtdausach.Size = new System.Drawing.Size(182, 26);
            this.txtdausach.Text = "&Đầu Sách";
            this.txtdausach.Click += new System.EventHandler(this.txtdausach_Click);
            // 
            // txtdocgia
            // 
            this.txtdocgia.Name = "txtdocgia";
            this.txtdocgia.Size = new System.Drawing.Size(182, 26);
            this.txtdocgia.Text = "&Độc Giả";
            this.txtdocgia.Click += new System.EventHandler(this.txtdocgia_Click);
            // 
            // txtMTS
            // 
            this.txtMTS.Name = "txtMTS";
            this.txtMTS.Size = new System.Drawing.Size(182, 26);
            this.txtMTS.Text = "&Mượn Trả Sách";
            this.txtMTS.Click += new System.EventHandler(this.txtMTS_Click);
            // 
            // btndocgia
            // 
            this.btndocgia.Image = global::QuanLyThuVien.Properties.Resources.docgia;
            this.btndocgia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndocgia.Name = "btndocgia";
            this.btndocgia.Size = new System.Drawing.Size(85, 24);
            this.btndocgia.Text = "Độc giả";
            this.btndocgia.Click += new System.EventHandler(this.btndocgia_Click);
            // 
            // lblten
            // 
            this.lblten.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(30, 24);
            this.lblten.Text = "???";
            this.lblten.Click += new System.EventHandler(this.lblten_Click);
            // 
            // btndausach
            // 
            this.btndausach.Image = global::QuanLyThuVien.Properties.Resources._1493875386_books;
            this.btndausach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndausach.Name = "btndausach";
            this.btndausach.Size = new System.Drawing.Size(95, 24);
            this.btndausach.Text = "Đầu Sách";
            this.btndausach.Click += new System.EventHandler(this.btndausach_Click);
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyThuVien.Properties.Resources.muontra;
            this.button3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 24);
            this.button3.Text = "Mượn trả sách";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::QuanLyThuVien.Properties.Resources._1493873182_help_browser;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton4.Text = "Trợ Giúp";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::QuanLyThuVien.Properties.Resources._1493874057_logout;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(103, 24);
            this.toolStripButton3.Text = "&Đăng Xuất";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.hoc_cao_hoc_nganh_khoa_hoc_thu_vien_tai_dh_van_hoa_tphcm_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 559);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed_1);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton txtMenu;
        private System.Windows.Forms.ToolStripMenuItem txtdausach;
        private System.Windows.Forms.ToolStripMenuItem txtdocgia;
        private System.Windows.Forms.ToolStripMenuItem txtMTS;
        private System.Windows.Forms.ToolStripButton btndocgia;
        private System.Windows.Forms.ToolStripLabel lblten;
        private System.Windows.Forms.ToolStripButton btndausach;
        private System.Windows.Forms.ToolStripButton button3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}