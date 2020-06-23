namespace QuanLyThuVien
{
    partial class FormMuonTra
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
            this.tabCMuonTra = new System.Windows.Forms.TabControl();
            this.tabPTTMuon = new System.Windows.Forms.TabPage();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXoaMuon = new System.Windows.Forms.Button();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnTraHet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGTTMuon = new System.Windows.Forms.DataGridView();
            this.txtSachMuon = new System.Windows.Forms.TextBox();
            this.tabPTTTra = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoaTra = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGTraSach = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.tabPMuonSach = new System.Windows.Forms.TabPage();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMaDS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSach = new System.Windows.Forms.TextBox();
            this.dataGThemMuon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayhan = new System.Windows.Forms.TextBox();
            this.txtNgayCap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.txtDocGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabCMuonTra.SuspendLayout();
            this.tabPTTMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGTTMuon)).BeginInit();
            this.tabPTTTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGTraSach)).BeginInit();
            this.tabPMuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGThemMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCMuonTra
            // 
            this.tabCMuonTra.Controls.Add(this.tabPTTMuon);
            this.tabCMuonTra.Controls.Add(this.tabPTTTra);
            this.tabCMuonTra.Controls.Add(this.tabPMuonSach);
            this.tabCMuonTra.Location = new System.Drawing.Point(16, 241);
            this.tabCMuonTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCMuonTra.Name = "tabCMuonTra";
            this.tabCMuonTra.SelectedIndex = 0;
            this.tabCMuonTra.Size = new System.Drawing.Size(1065, 327);
            this.tabCMuonTra.TabIndex = 2;
            // 
            // tabPTTMuon
            // 
            this.tabPTTMuon.BackColor = System.Drawing.SystemColors.Control;
            this.tabPTTMuon.Controls.Add(this.btnGiaHan);
            this.tabPTTMuon.Controls.Add(this.dtpNgay);
            this.tabPTTMuon.Controls.Add(this.btnXoaMuon);
            this.tabPTTMuon.Controls.Add(this.txtMaMuon);
            this.tabPTTMuon.Controls.Add(this.label16);
            this.tabPTTMuon.Controls.Add(this.btnTraHet);
            this.tabPTTMuon.Controls.Add(this.label14);
            this.tabPTTMuon.Controls.Add(this.dataGTTMuon);
            this.tabPTTMuon.Controls.Add(this.txtSachMuon);
            this.tabPTTMuon.Location = new System.Drawing.Point(4, 25);
            this.tabPTTMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPTTMuon.Name = "tabPTTMuon";
            this.tabPTTMuon.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPTTMuon.Size = new System.Drawing.Size(1057, 298);
            this.tabPTTMuon.TabIndex = 0;
            this.tabPTTMuon.Text = "Thông tin mượn sách";
            this.tabPTTMuon.Click += new System.EventHandler(this.tabPTTMuon_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Location = new System.Drawing.Point(691, 57);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(69, 28);
            this.btnGiaHan.TabIndex = 17;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(691, 22);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpNgay.TabIndex = 16;
            // 
            // btnXoaMuon
            // 
            this.btnXoaMuon.Location = new System.Drawing.Point(393, 57);
            this.btnXoaMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaMuon.Name = "btnXoaMuon";
            this.btnXoaMuon.Size = new System.Drawing.Size(69, 28);
            this.btnXoaMuon.TabIndex = 15;
            this.btnXoaMuon.Text = "Xóa";
            this.btnXoaMuon.UseVisualStyleBackColor = true;
            this.btnXoaMuon.Click += new System.EventHandler(this.btnXoaMuon_Click);
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Enabled = false;
            this.txtMaMuon.ForeColor = System.Drawing.Color.Black;
            this.txtMaMuon.Location = new System.Drawing.Point(167, 60);
            this.txtMaMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(51, 22);
            this.txtMaMuon.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 60);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 17);
            this.label16.TabIndex = 13;
            this.label16.Text = "ID :";
            // 
            // btnTraHet
            // 
            this.btnTraHet.Location = new System.Drawing.Point(393, 18);
            this.btnTraHet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTraHet.Name = "btnTraHet";
            this.btnTraHet.Size = new System.Drawing.Size(108, 28);
            this.btnTraHet.TabIndex = 12;
            this.btnTraHet.Text = "Trả tất cả";
            this.btnTraHet.UseVisualStyleBackColor = true;
            this.btnTraHet.Click += new System.EventHandler(this.btnTraHet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 25);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Thông tin sách :";
            // 
            // dataGTTMuon
            // 
            this.dataGTTMuon.AllowUserToAddRows = false;
            this.dataGTTMuon.AllowUserToDeleteRows = false;
            this.dataGTTMuon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGTTMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGTTMuon.Location = new System.Drawing.Point(49, 98);
            this.dataGTTMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGTTMuon.Name = "dataGTTMuon";
            this.dataGTTMuon.ReadOnly = true;
            this.dataGTTMuon.Size = new System.Drawing.Size(843, 176);
            this.dataGTTMuon.TabIndex = 9;
            this.dataGTTMuon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGTTMuon_CellDoubleClick);
            // 
            // txtSachMuon
            // 
            this.txtSachMuon.ForeColor = System.Drawing.Color.Black;
            this.txtSachMuon.Location = new System.Drawing.Point(167, 22);
            this.txtSachMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSachMuon.Name = "txtSachMuon";
            this.txtSachMuon.Size = new System.Drawing.Size(156, 22);
            this.txtSachMuon.TabIndex = 5;
            this.txtSachMuon.TextChanged += new System.EventHandler(this.txtSachMuon_TextChanged);
            // 
            // tabPTTTra
            // 
            this.tabPTTTra.BackColor = System.Drawing.SystemColors.Control;
            this.tabPTTTra.Controls.Add(this.button1);
            this.tabPTTTra.Controls.Add(this.btnXoaTra);
            this.tabPTTTra.Controls.Add(this.label12);
            this.tabPTTTra.Controls.Add(this.dataGTraSach);
            this.tabPTTTra.Controls.Add(this.label11);
            this.tabPTTTra.Controls.Add(this.txtTenSach);
            this.tabPTTTra.Controls.Add(this.txtMaTra);
            this.tabPTTTra.Location = new System.Drawing.Point(4, 25);
            this.tabPTTTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPTTTra.Name = "tabPTTTra";
            this.tabPTTTra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPTTTra.Size = new System.Drawing.Size(1057, 298);
            this.tabPTTTra.TabIndex = 1;
            this.tabPTTTra.Text = "Thông tin trả sách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xóa tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoaTra
            // 
            this.btnXoaTra.Location = new System.Drawing.Point(648, 25);
            this.btnXoaTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaTra.Name = "btnXoaTra";
            this.btnXoaTra.Size = new System.Drawing.Size(69, 23);
            this.btnXoaTra.TabIndex = 5;
            this.btnXoaTra.Text = "Xóa";
            this.btnXoaTra.UseVisualStyleBackColor = true;
            this.btnXoaTra.Click += new System.EventHandler(this.btnXoaTra_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Thông tin sách :";
            // 
            // dataGTraSach
            // 
            this.dataGTraSach.AllowUserToAddRows = false;
            this.dataGTraSach.AllowUserToDeleteRows = false;
            this.dataGTraSach.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGTraSach.Location = new System.Drawing.Point(47, 73);
            this.dataGTraSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGTraSach.Name = "dataGTraSach";
            this.dataGTraSach.ReadOnly = true;
            this.dataGTraSach.Size = new System.Drawing.Size(867, 201);
            this.dataGTraSach.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID :";
            // 
            // txtTenSach
            // 
            this.txtTenSach.ForeColor = System.Drawing.Color.Black;
            this.txtTenSach.Location = new System.Drawing.Point(393, 25);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(203, 22);
            this.txtTenSach.TabIndex = 0;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // txtMaTra
            // 
            this.txtMaTra.Enabled = false;
            this.txtMaTra.Location = new System.Drawing.Point(91, 25);
            this.txtMaTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.Size = new System.Drawing.Size(61, 22);
            this.txtMaTra.TabIndex = 0;
            // 
            // tabPMuonSach
            // 
            this.tabPMuonSach.BackColor = System.Drawing.SystemColors.Control;
            this.tabPMuonSach.Controls.Add(this.dtpNgayHen);
            this.tabPMuonSach.Controls.Add(this.label18);
            this.tabPMuonSach.Controls.Add(this.txtMaDS);
            this.tabPMuonSach.Controls.Add(this.label17);
            this.tabPMuonSach.Controls.Add(this.label13);
            this.tabPMuonSach.Controls.Add(this.txtSach);
            this.tabPMuonSach.Controls.Add(this.dataGThemMuon);
            this.tabPMuonSach.Location = new System.Drawing.Point(4, 25);
            this.tabPMuonSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPMuonSach.Name = "tabPMuonSach";
            this.tabPMuonSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPMuonSach.Size = new System.Drawing.Size(1057, 298);
            this.tabPMuonSach.TabIndex = 2;
            this.tabPMuonSach.Text = "Mượn sách";
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.Location = new System.Drawing.Point(533, 66);
            this.dtpNgayHen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(249, 22);
            this.dtpNgayHen.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(389, 69);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 17);
            this.label18.TabIndex = 21;
            this.label18.Text = "Ngày hẹn trả";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtMaDS
            // 
            this.txtMaDS.Enabled = false;
            this.txtMaDS.Location = new System.Drawing.Point(161, 66);
            this.txtMaDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDS.Name = "txtMaDS";
            this.txtMaDS.Size = new System.Drawing.Size(73, 22);
            this.txtMaDS.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 65);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Thông tin sách : ";
            // 
            // txtSach
            // 
            this.txtSach.Location = new System.Drawing.Point(161, 26);
            this.txtSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSach.Name = "txtSach";
            this.txtSach.Size = new System.Drawing.Size(167, 22);
            this.txtSach.TabIndex = 1;
            this.txtSach.TextChanged += new System.EventHandler(this.txtSach_TextChanged);
            // 
            // dataGThemMuon
            // 
            this.dataGThemMuon.AllowUserToAddRows = false;
            this.dataGThemMuon.AllowUserToDeleteRows = false;
            this.dataGThemMuon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGThemMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGThemMuon.Location = new System.Drawing.Point(43, 95);
            this.dataGThemMuon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGThemMuon.Name = "dataGThemMuon";
            this.dataGThemMuon.ReadOnly = true;
            this.dataGThemMuon.Size = new System.Drawing.Size(848, 191);
            this.dataGThemMuon.TabIndex = 0;
            this.dataGThemMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGThemMuon_CellClick);
            this.dataGThemMuon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGThemMuon_CellDoubleClick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(175, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(736, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÔNG TIN MƯỢN TRẢ SÁCH CỦA THÀNH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgayhan);
            this.groupBox1.Controls.Add(this.txtNgayCap);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaThe);
            this.groupBox1.Controls.Add(this.txtDocGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1060, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả ";
            // 
            // txtNgayhan
            // 
            this.txtNgayhan.Enabled = false;
            this.txtNgayhan.Location = new System.Drawing.Point(896, 135);
            this.txtNgayhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgayhan.Name = "txtNgayhan";
            this.txtNgayhan.Size = new System.Drawing.Size(159, 22);
            this.txtNgayhan.TabIndex = 28;
            // 
            // txtNgayCap
            // 
            this.txtNgayCap.Enabled = false;
            this.txtNgayCap.Location = new System.Drawing.Point(896, 87);
            this.txtNgayCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgayCap.Name = "txtNgayCap";
            this.txtNgayCap.Size = new System.Drawing.Size(159, 22);
            this.txtNgayCap.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(752, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ngày hết hạn :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(752, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ngày cấp thẻ :";
            // 
            // txtSDT
            // 
            this.txtSDT.Enabled = false;
            this.txtSDT.Location = new System.Drawing.Point(896, 39);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(155, 22);
            this.txtSDT.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(533, 135);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(183, 22);
            this.txtDiaChi.TabIndex = 24;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Enabled = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(533, 87);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(183, 22);
            this.txtGioiTinh.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số Điện Thoại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Địa Chỉ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Giới tính";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Location = new System.Drawing.Point(533, 39);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(183, 22);
            this.txtNgaySinh.TabIndex = 17;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(160, 135);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(209, 22);
            this.txtHoTen.TabIndex = 18;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Enabled = false;
            this.txtMaThe.Location = new System.Drawing.Point(160, 39);
            this.txtMaThe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(79, 22);
            this.txtMaThe.TabIndex = 19;
            // 
            // txtDocGia
            // 
            this.txtDocGia.Enabled = false;
            this.txtDocGia.Location = new System.Drawing.Point(160, 87);
            this.txtDocGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocGia.Name = "txtDocGia";
            this.txtDocGia.Size = new System.Drawing.Size(209, 22);
            this.txtDocGia.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày Sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ Tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Thẻ :";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.No;
            this.btnThoat.Location = new System.Drawing.Point(981, 9);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Quay lại";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 569);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabCMuonTra);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMuonTra";
            this.Text = "Thông tin mượn trả sách";
            this.Load += new System.EventHandler(this.FormMuonTra_Load);
            this.tabCMuonTra.ResumeLayout(false);
            this.tabPTTMuon.ResumeLayout(false);
            this.tabPTTMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGTTMuon)).EndInit();
            this.tabPTTTra.ResumeLayout(false);
            this.tabPTTTra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGTraSach)).EndInit();
            this.tabPMuonSach.ResumeLayout(false);
            this.tabPMuonSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGThemMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCMuonTra;
        private System.Windows.Forms.TabPage tabPTTTra;
        private System.Windows.Forms.TabPage tabPMuonSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNgayCap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPTTMuon;
        private System.Windows.Forms.TextBox txtNgayhan;
        private System.Windows.Forms.DataGridView dataGTraSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGThemMuon;
        private System.Windows.Forms.TextBox txtSach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTraHet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGTTMuon;
        private System.Windows.Forms.TextBox txtSachMuon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMaDS;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Button btnXoaMuon;
        private System.Windows.Forms.Button btnXoaTra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.DateTimePicker dtpNgay;
    }
}