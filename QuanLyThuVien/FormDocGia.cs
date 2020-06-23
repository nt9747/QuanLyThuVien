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
    public partial class FormDocGia : Form
    {

        public bool isChecked = false;
        public bool isClick;
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblDOCGIA");
        private SqlDataAdapter da = new SqlDataAdapter();
        public void connect()
        {
            String conStr = globalParameter.str;
            try
            {

                conn = new SqlConnection(conStr);
                conn.Open();
            }
            catch (Exception)
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
        public void getdata()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select MaThe,MaHienThi,HoTen,NgaySinh,case(GioiTinh) when 1 then 'Nam' else N'Nữ' end GioiTinh,DiaChi,SDT,NgayCap,NgayHetHan from DOCGIA";
            da.SelectCommand = command;
            dt.Clear();
            da.Fill(dt);
            dgvDocgia.DataSource = dt;
        }
        public FormDocGia()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            Binding();
            disconect();

        }
        private void FormDocGia_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString().Equals("UserClosing"))
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuuthemmoi.Enabled = true;
            btnHuy.Enabled = true;
            btnCapnhat.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvDocgia.Enabled = false;
            txtMathe.Clear();
            ClearData();
            EnableData();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isChecked)
            {
                EnableData();
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnHuy.Enabled = true;
                btnCapnhat.Enabled = true;
                dgvDocgia.Enabled = false;

            }
            else
            {
                MessageBox.Show("Chọn 1 ");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (isChecked == false)
            {
                MessageBox.Show("Chọn 1 ");
                return;
            }
            if (isEmpty()) return;
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_SUADOCGIA", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMathe.Text)));
                command.Parameters.Add(new SqlParameter("@maht", txtMaHT.Text));
                command.Parameters.Add(new SqlParameter("@hoten", txtHoten.Text));
                command.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));
                command.Parameters.Add(new SqlParameter("@sdt", txtDienthoai.Text));
                command.Parameters.Add(new SqlParameter("@ngaysinh", dtpNgaysinh.Value));
                command.Parameters.Add(new SqlParameter("@ngayhethan", dtpNgayhethan.Value));
                if (rdbnam.Checked == true)
                {
                    command.Parameters.Add(new SqlParameter("@gioitinh", true));
                }
                else if (rdbnu.Checked == true)
                {
                    command.Parameters.Add(new SqlParameter("@gioitinh", false));
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                btnHuy.Enabled = false;
                btnCapnhat.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            getdata();
            disconect();
            DisableData();
            dgvDocgia.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_XOADOCGIA", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMathe.Text)));
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata();
            disconect();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc chắn muốn thoát ko ?", "Thông báo :", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dia == DialogResult.OK)
            {
                FormMain f = new FormMain();
                f.Show();
                Hide();
            }

        }

        private void dgvDocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            connect();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TIMKIEMDOCGIA";
            command.Parameters.Add(new SqlParameter("@mahienthi", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@hoten", txtTimKiem.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dgvDocgia.DataSource = dt;
            disconect();
        }
        void Binding()
        {
            txtMathe.DataBindings.Clear();
            txtMathe.DataBindings.Add("Text", dgvDocgia.DataSource, "MaThe");
            txtMaHT.DataBindings.Clear();
            txtMaHT.DataBindings.Add("Text", dgvDocgia.DataSource, "MaHienThi");
            txtHoten.DataBindings.Clear();
            txtHoten.DataBindings.Add("Text", dgvDocgia.DataSource, "HoTen");
            dtpNgaysinh.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Add("Text", dgvDocgia.DataSource, "NgaySinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDocgia.DataSource, "DiaChi");
            txtDienthoai.DataBindings.Clear();
            txtDienthoai.DataBindings.Add("Text", dgvDocgia.DataSource, "SDT");
            dtpNgaycap.DataBindings.Clear();
            dtpNgaycap.DataBindings.Add("Text", dgvDocgia.DataSource, "NgayCap");
            dtpNgayhethan.DataBindings.Clear();
            dtpNgayhethan.DataBindings.Add("Text", dgvDocgia.DataSource, "NgayHetHan");
        }
        void ClearData()
        {
            txtMaHT.Clear();
            txtHoten.Clear();
            txtMaHT.Clear();
            txtDiaChi.Clear();
            txtDienthoai.Clear();
        }
        void EnableData()
        {
            txtHoten.Enabled = true;
            txtMaHT.Enabled = true;
            dtpNgaysinh.Enabled = true;
            rdbnam.Enabled = true;
            rdbnu.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienthoai.Enabled = true;
            dtpNgaycap.Enabled = false;
            dtpNgayhethan.Enabled = true;
        }
        void DisableData()
        {
            txtHoten.Enabled = false;
            txtMaHT.Enabled = false;
            dtpNgaysinh.Enabled = false;
            rdbnam.Enabled = false;
            rdbnu.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienthoai.Enabled = false;
            dtpNgaycap.Enabled = false;
            dtpNgayhethan.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            connect();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuuthemmoi.Enabled = false;
            btnCapnhat.Enabled = false;
            dgvDocgia.Enabled = true;
            getdata();
            disconect();
            DisableData();
        }

        private void btnLuuthemmoi_Click(object sender, EventArgs e)
        {
            if (isEmpty())
                return;
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_THEMDOCGIA", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@maht", txtMaHT.Text));
                command.Parameters.Add(new SqlParameter("@hoten", txtHoten.Text));
                command.Parameters.Add(new SqlParameter("@diachi", txtDiaChi.Text));
                command.Parameters.Add(new SqlParameter("@sdt", txtDienthoai.Text));
                command.Parameters.Add(new SqlParameter("@ngaysinh", dtpNgaysinh.Value));
                command.Parameters.Add(new SqlParameter("@ngayhethan", dtpNgayhethan.Value));
                if (rdbnam.Checked == true)
                {
                    command.Parameters.Add(new SqlParameter("@gioitinh", true));
                }
                else if (rdbnu.Checked == true)
                {
                    command.Parameters.Add(new SqlParameter("@gioitinh", false));
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
                btnHuy.Enabled = false;
                btnCapnhat.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata();
            disconect();
            DisableData();
            dgvDocgia.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuuthemmoi.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void dgvDocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isChecked = true;
            string gt = this.dgvDocgia.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim();
            if (gt == "Nam")
            {
                rdbnam.Checked = true;

            }
            else if (gt == "Nữ")
            {
                rdbnu.Checked = true;

            }
            Binding();
        }
        private bool isEmpty()
        {
            if(txtHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (txtMaHT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hiển thị", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (txtDienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điện thoại", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void txtMaHT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaycap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdbnu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvDocgia_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbnam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtMathe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtDienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayhethan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
