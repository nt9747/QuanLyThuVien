
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public delegate void SendInFo(string value);
    public partial class FormDauSach : Form
    {
        private SqlConnection conn;
        public DataTable dt = new DataTable("tblDAUSACH");
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
        public void getdata()
        {
            dt.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "sp_TIMKIEMDAUSACH";
            command.Parameters.Add(new SqlParameter("@mahienthi", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@ten", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@theloai", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@tacgia", txtTimKiem.Text));
            command.Parameters.Add(new SqlParameter("@nxb", txtTimKiem.Text));
            da.SelectCommand = command;
            da.Fill(dt);
            dgvDauSach.DataSource = dt;

        }
        public FormDauSach()
        {
            InitializeComponent();
        }

        private void initGrid(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DataGridViewColumn cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "MaHienThi";
            cl.HeaderText = "Mã";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Ten";
            cl.HeaderText = "Tên";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SoLuongLyThuyet";
            cl.HeaderText = "Số lượng lý thuyết";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SoLuongThucTe";
            cl.HeaderText = "Số lượng thực tế";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "SoTrang";
            cl.HeaderText = "Số trang";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "Gia";
            cl.HeaderText = "Giá";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "NamXuatBan";
            cl.HeaderText = "Năm xuất bản";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TheLoai";
            cl.HeaderText = "Loại sách";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "TacGia";
            cl.HeaderText = "Tác giả";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "nxb";
            cl.HeaderText = "Nhà xuất bản";
            dgv.Columns.Add(cl);
            cl = new DataGridViewTextBoxColumn();
            cl.DataPropertyName = "vitri";
            cl.HeaderText = "Vị trí";
            dgv.Columns.Add(cl);
            
           
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemDauSach f = new FormThemDauSach();
            this.Hide();
            f.ShowDialog();
        }

        public void dataBinding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvDauSach.DataSource, "Ma");
            txtMaHienThi.DataBindings.Clear();
            txtMaHienThi.DataBindings.Add("Text", dgvDauSach.DataSource, "MaHienThi");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDauSach.DataSource, "Ten");
            txtSoLuongLyThuyet.DataBindings.Clear();
            txtSoLuongLyThuyet.DataBindings.Add("Text", dgvDauSach.DataSource, "SoLuongLyThuyet");
            txtSoLuongThucTe.DataBindings.Clear();
            txtSoLuongThucTe.DataBindings.Add("Text", dgvDauSach.DataSource, "SoLuongThucTe");
            txtSoTrang.DataBindings.Clear();
            txtSoTrang.DataBindings.Add("Text", dgvDauSach.DataSource, "SoTrang");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvDauSach.DataSource, "Gia");
            txtNamXuatBan.DataBindings.Clear();
            txtNamXuatBan.DataBindings.Add("Text", dgvDauSach.DataSource, "NamXuatBan");
            cbbMaLoaiSach.DataBindings.Clear();
            cbbMaLoaiSach.DataBindings.Add("Text", dgvDauSach.DataSource, "TheLoai");
            cbbMaTacGia.DataBindings.Clear();
            cbbMaTacGia.DataBindings.Add("Text", dgvDauSach.DataSource, "TacGia");
            cbbMaNXB.DataBindings.Clear();
            cbbMaNXB.DataBindings.Add("Text", dgvDauSach.DataSource, "nxb");
            cbbMaViTri.DataBindings.Clear();
            cbbMaViTri.DataBindings.Add("Text", dgvDauSach.DataSource, "vitri");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtGia.Enabled = true;
            txtMaHienThi.Enabled = true;
            txtNamXuatBan.Enabled = true;
            txtSoTrang.Enabled = true;
            txtTen.Enabled = true;
            cbbMaLoaiSach.Enabled = true;
            cbbMaNXB.Enabled = true;
            cbbMaTacGia.Enabled = true;
            cbbMaViTri.Enabled = true;
            dgvDauSach.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                SqlCommand command = new SqlCommand("sp_SUADAUSACH", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMa.Text)));
                command.Parameters.Add(new SqlParameter("@mahienthi", txtMaHienThi.Text));
                command.Parameters.Add(new SqlParameter("@ten", txtTen.Text));
                command.Parameters.Add(new SqlParameter("@sotrang", int.Parse(txtSoTrang.Text)));
                command.Parameters.Add(new SqlParameter("@gia", decimal.Parse(txtGia.Text)));
                command.Parameters.Add(new SqlParameter("@namxb", int.Parse(txtNamXuatBan.Text)));
                command.Parameters.Add(new SqlParameter("@maloaisach", int.Parse(cbbMaLoaiSach.SelectedValue.ToString())));
                command.Parameters.Add(new SqlParameter("@matg", int.Parse(cbbMaTacGia.SelectedValue.ToString())));
                command.Parameters.Add(new SqlParameter("@manxb", int.Parse(cbbMaNXB.SelectedValue.ToString())));
                command.Parameters.Add(new SqlParameter("@mavt", int.Parse(cbbMaViTri.SelectedValue.ToString())));

                command.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt.Clear();
            }
            getdata();
            disconect();
            btnHuy.Enabled = false;
            button1.Enabled = true;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            txtMaHienThi.Enabled = false;
            txtNamXuatBan.Enabled = false;
            txtSoTrang.Enabled = false;
            txtTen.Enabled = false;
            cbbMaLoaiSach.Enabled = false;
            cbbMaNXB.Enabled = false;
            cbbMaTacGia.Enabled = false;
            cbbMaViTri.Enabled = false;
            txtGia.Enabled = false;
            dgvDauSach.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (txtMa.Text == "")
            {
                MessageBox.Show("Không có dữ liệu để xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {

                    connect();
                    SqlCommand command = new SqlCommand("sp_XOADAUSACH", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMa.Text)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.Clear();
                    getdata();
                    disconect();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


        }
        private void FormDauSach_Load(object sender, EventArgs e)
        {
            connect();
            initGrid(dgvDauSach);
            getdata();          
            getdata2();
            dataBinding();
            disconect();

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            connect();
            getdata();
            disconect();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormBoSungSach f = new FormBoSungSach();
            f.ma = txtMa.Text;
            f.mahienthi = txtMaHienThi.Text;
            f.ten = txtTen.Text;
            Hide();
            f.ShowDialog();


        }
        private void getdata2()
        {
            SqlConnection con = new SqlConnection(globalParameter.str);
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable data = new DataTable();
            DataTable data1 = new DataTable();
            DataTable data2 = new DataTable();
            DataTable data3 = new DataTable();
            cm.Connection = con;

            cm.CommandText = "select * from LOAISACH";
            da.SelectCommand = cm;
            da.Fill(data);
            cbbMaLoaiSach.DataSource = data;
            cbbMaLoaiSach.DisplayMember = "Ten";
            cbbMaLoaiSach.ValueMember = "Ma";
   


            cm.CommandText = "select * from TACGIA";
            da.SelectCommand = cm;
            da.Fill(data1);
            cbbMaTacGia.DataSource = data1;
            cbbMaTacGia.DisplayMember = "Ten";
            cbbMaTacGia.ValueMember = "Ma";



            cm.CommandText = "select * from NHAXUATBAN";
            da.SelectCommand = cm;
            da.Fill(data2);
            cbbMaNXB.DataSource = data2;
            cbbMaNXB.DisplayMember = "Ten";
            cbbMaNXB.ValueMember = "Ma";
 


            cm.CommandText = "select * from VITRI";
            da.SelectCommand = cm;
            da.Fill(data3);
            cbbMaViTri.DataSource = data3;
            cbbMaViTri.DisplayMember = "Ten";
            cbbMaViTri.ValueMember = "Ma";
    



        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            Hide();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            connect();
            dt.Clear();
            getdata();
            disconect();
            button1.Enabled = true;
            btnHuy.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            txtMaHienThi.Enabled = false;
            txtNamXuatBan.Enabled = false;
            txtSoTrang.Enabled = false;
            txtTen.Enabled = false;
            cbbMaLoaiSach.Enabled = false;
            cbbMaNXB.Enabled = false;
            cbbMaTacGia.Enabled = false;
            cbbMaViTri.Enabled = false;
            txtGia.Enabled = false;
            dgvDauSach.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
