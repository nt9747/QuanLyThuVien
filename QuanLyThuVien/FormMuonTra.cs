using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    public partial class FormMuonTra : Form
    {
        public int docgia;
        private SqlConnection conn;
        private DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        private SqlDataAdapter da = new SqlDataAdapter();
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("LỖI");
            }
        }
        public void disconect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Ten";
            cl.HeaderText = "Tên Sách";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgayMuon";
            cl.HeaderText = "Ngày Mượn Sách";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgayHenTra";
            cl.HeaderText = "Ngày Hẹn Trả";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "GhiChu";
            cl.HeaderText = "Ghi Chú";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HoTen";
            cl.HeaderText = "Người xác nhận";
            dgv.Columns.Add(cl);
        }
        private void initGrid1(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MaHienThi";
            cl.HeaderText = "Mã";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Ten";
            cl.HeaderText = "Tên Sách";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Soluongthucte";
            cl.HeaderText = "Số lượng còn lại";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TheLoai";
            cl.HeaderText = "Thể Loại";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Tacgia";
            cl.HeaderText = "Tác giả";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "nxb";
            cl.HeaderText = "Nhà xuất bản";
            dgv.Columns.Add(cl);
        }
        private void initGrid2(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Ten";
            cl.HeaderText = "Tên Sách";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgayMuon";
            cl.HeaderText = "Ngày Mượn Sách";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgayHenTra";
            cl.HeaderText = "Ngày Hẹn Trả";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NgayTra";
            cl.HeaderText = "Ngày Trả";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "GhiChu";
            cl.HeaderText = "Ghi Chú";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "HoTen";
            cl.HeaderText = "Người xác nhận";
            dgv.Columns.Add(cl);

        }

        public void getdata()
        {
            SqlCommand command = new SqlCommand("SP_THONGTIN_DOCGIA", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@mathe", docgia));
            SqlDataReader r = command.ExecuteReader();
            if (r.Read())
            {
                txtMaThe.Text = r["MaThe"].ToString();
                txtDocGia.Text = r["MaHienThi"].ToString();
                txtHoTen.Text = r["HoTen"].ToString();
                txtNgaySinh.Text = r["NgaySinh"].ToString();
                if (r["GioiTinh"].ToString() == "True") txtGioiTinh.Text = "Nam";
                else txtGioiTinh.Text = "Nữ";
                txtDiaChi.Text = r["DiaChi"].ToString();
                txtSDT.Text = r["SDT"].ToString();
                txtNgayCap.Text = r["NgayCap"].ToString();
                txtNgayhan.Text = r["NgayHetHan"].ToString();
            }
        }
        public void getdateTra()
        {
            dt.Clear();
            SqlCommand command = new SqlCommand("sp_THONGTINTRASACH", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@maDG", docgia));
            command.Parameters.Add(new SqlParameter("@tensach", txtTenSach.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dataGTraSach.DataSource = dt;
            txtMaTra.Clear();
            txtMaTra.DataBindings.Clear();
            txtMaTra.DataBindings.Add("Text", dataGTraSach.DataSource, "Ma");
        }

        public void getdateMuon()
        {
            dt1.Clear();
            txtMaMuon.Text = docgia.ToString();
            SqlCommand command = new SqlCommand("sp_THONGTINMUONSACH", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@maDG", docgia));
            command.Parameters.Add(new SqlParameter("@tensach", txtSachMuon.Text));
            da.SelectCommand = command;
            da.Fill(dt1);
            dataGTTMuon.DataSource = dt1;
            txtMaMuon.Clear();
            txtMaMuon.DataBindings.Clear();
            txtMaMuon.DataBindings.Add("Text", dataGTTMuon.DataSource, "Ma");
        }
        public void getdataThemmuon()
        {
            
            dt2.Clear();
            SqlCommand command = new SqlCommand("sp_HIENTHIDAUSACH", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@mahienthi", txtSach.Text));
            command.Parameters.Add(new SqlParameter("@ten", txtSach.Text));
            command.Parameters.Add(new SqlParameter("@theloai", txtSach.Text));
            command.Parameters.Add(new SqlParameter("@tacgia", txtSach.Text));
            command.Parameters.Add(new SqlParameter("@nxb", txtSach.Text));
            da.SelectCommand = command;
            da.Fill(dt2);
            dataGThemMuon.DataSource = dt2;
        }

        public FormMuonTra()
        {
            InitializeComponent();
        }

        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dataGTTMuon);
            initGrid2(dataGTraSach);
            initGrid1(dataGThemMuon);
            getdataThemmuon();
            getdateMuon();
            getdateTra();
            getdata();
            disconect();

        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGThemMuon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //    SqlCommand command = new SqlCommand("SP_MUONSACH", conn);
            //    command.CommandType = CommandType.StoredProcedure;

            //    command.Parameters.Add(new SqlParameter("@madg", docgia));
            //    command.Parameters.Add(new SqlParameter("@masach", cmbLopHoc.SelectedValue));
            //    command.Parameters.Add(new SqlParameter("@ngayhen", int.Parse(cmbThu.SelectedItem.ToString())));
            //    command.Parameters.Add(new SqlParameter("@ghichu", int.Parse(cmbTiet.SelectedItem.ToString())));
            //    command.ExecuteNonQuery();
            //    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        
        //private void btnTimSach_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        connect();
        //        initGrid(dataGTTMuon);
        //        getdateMuon();
        //        disconect();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Bạn chưa nhập đủ thông tin !", " Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            


        }

        private void btnTraHet_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn Chắc chắn muốn trả tất cả?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connect();
                    SqlCommand command = new SqlCommand("SP_TRATATCASACH", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@maDG", int.Parse(txtMaThe.Text)));
                    command.ExecuteNonQuery();
                    getdataThemmuon();
                    getdateMuon();
                    getdateTra();
                    MessageBox.Show("Trả thành công");
                    //initGrid(dataGTTMuon);
                    //  getdateMuon();
                    disconect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã mượn gì đâu mà trả");
                    return;
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                FormTimDocGia_MuonTra tk = new FormTimDocGia_MuonTra();
                this.Hide();
                tk.Show();
        }

        private void txtSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect();
                initGrid1(dataGThemMuon);
                getdataThemmuon();
                disconect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin !", " Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGThemMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDS.DataBindings.Clear();
            txtMaDS.DataBindings.Add("Text", dataGThemMuon.DataSource, "Ma");
        }

        private void dataGThemMuon_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dtpNgayHen.Value <= DateTime.Today.Add(new System.TimeSpan(1, 0, 0, 0)))
            {
                MessageBox.Show("Ngày hẹn trả không hợp lệ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn muốn mượn sách này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connect();
                    SqlCommand command = new SqlCommand("sp_MUONSACH", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@mads", int.Parse(txtMaDS.Text)));
                    command.Parameters.Add(new SqlParameter("@madg", int.Parse(txtMaThe.Text)));
                    command.Parameters.Add(new SqlParameter("@ngayhen", dtpNgayHen.Value));
                    command.ExecuteNonQuery();
                    getdateMuon();
                    getdataThemmuon();
                    disconect();
                    MessageBox.Show("Mượn thành công");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sách này đang được mượn, không thể mượn thêm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void dataGTTMuon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtMaMuon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi!", "Thông báo!!!");
                return;
            }
            if (MessageBox.Show("Bạn muốn trả quyển sách này?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connect();
                    SqlCommand command = new SqlCommand("SP_TRASACH", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Ma", int.Parse(txtMaMuon.Text)));
                    command.ExecuteNonQuery();
                    getdateMuon();
                    getdataThemmuon();
                    getdateTra();
                    disconect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gì đó");
                    return;
                }
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect();
                getdateTra();
                disconect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin !", " Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtSachMuon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect();
                getdateMuon();
                disconect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin !", " Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoaMuon_Click(object sender, EventArgs e)
        {
            if (txtMaMuon.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào");
                return;
            }
            if (MessageBox.Show("Sách này chưa được trả, bạn có chắc chắn muốn xóa?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                connect();
                SqlCommand cmd = new SqlCommand("sp_XOAMUON", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMaMuon.Text)));
                cmd.ExecuteNonQuery();
                getdateMuon();
                disconect();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnXoaTra_Click(object sender, EventArgs e)
        {
            if(txtMaTra.Text.Trim()=="")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect();
                SqlCommand cmd = new SqlCommand("sp_XOATRA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMaTra.Text)));
                cmd.ExecuteNonQuery();
                getdateTra();
                disconect();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaTra.Text.Trim() == "")
            {
                MessageBox.Show("Không còn gì để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả bản ghi?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connect();
                SqlCommand cmd = new SqlCommand("sp_XOATATCATTTRASACH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maDG", int.Parse(txtMaThe.Text)));
                cmd.ExecuteNonQuery();
                getdateTra();
                disconect();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if(txtMaMuon.Text.Trim()=="")
            {
                MessageBox.Show("Chưa chọn bản ghi");
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn muốn gia hạn?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    connect();
                    SqlCommand cmd = new SqlCommand("sp_GIAHANMUONSACH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMaMuon.Text)));
                    cmd.Parameters.Add(new SqlParameter("@ngay", dtpNgay.Value));
                    cmd.ExecuteNonQuery();
                    getdateMuon();
                    disconect();
                    MessageBox.Show("Gia hạn thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thể gia hạn, kiểm tra lại ngày");
                    return;
                }
            }
            
        }

        private void tabPTTMuon_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
