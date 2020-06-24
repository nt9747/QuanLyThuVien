
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
    public partial class FormThemDauSach : Form
    {
        private SqlConnection conn;
        private DataTable dt = new DataTable("tblDAUSACH");
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
        public FormThemDauSach()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            connect();
            if (txtGia.Text == "" || txtMaHienThi.Text == "" || txtNamXuatBan.Text == "" || txtSoLuongLyThuyet.Text == "" || txtSoTrang.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_THEMDAUSACH", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@mahienthi", txtMaHienThi.Text));
                    command.Parameters.Add(new SqlParameter("@ten", txtTen.Text));
                    command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txtSoLuongLyThuyet.Text)));
                    command.Parameters.Add(new SqlParameter("@sotrang", int.Parse(txtSoTrang.Text)));
                    command.Parameters.Add(new SqlParameter("@gia", decimal.Parse(txtGia.Text)));
                    command.Parameters.Add(new SqlParameter("@namxb", int.Parse(txtNamXuatBan.Text)));
                    command.Parameters.Add(new SqlParameter("@maloaisach", cbbMaLoaiSach.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@matg", cbbMaTacGia.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@manxb", cbbMaNXB.SelectedValue));
                    command.Parameters.Add(new SqlParameter("@mavt", cbbMaViTri.SelectedValue));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(MessageBox.Show("Thêm nữa không?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        txtMaHienThi.Clear();
                        txtGia.Clear();
                        txtNamXuatBan.Clear();
                        txtSoLuongLyThuyet.Clear();
                        txtSoTrang.Clear();
                        txtTen.Clear();
                        return;
                    }
                    FormDauSach f = new FormDauSach();
                    f.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            
            disconect();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            txtMaHienThi.Clear();
            txtGia.Clear();
            txtNamXuatBan.Clear();
            txtSoLuongLyThuyet.Clear();
            txtSoTrang.Clear();
            txtTen.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormDauSach f = new FormDauSach();
            this.Hide();
            f.Show();
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

