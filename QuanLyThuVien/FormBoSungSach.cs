
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
    public partial class FormBoSungSach : Form
    {
        private SqlConnection conn;
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


        public FormBoSungSach()
        {
            InitializeComponent();
        }
        public string ma, mahienthi, ten;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormDauSach f = new FormDauSach();
            Hide();
            f.ShowDialog();



        }

        private void txtSoLuongBoSung_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMahienthi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBoSungSach_Load(object sender, EventArgs e)
        {
            txtMa.Text = ma;
            txtMahienthi.Text = mahienthi;
            txtTen.Text = ten;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            connect();
            if(txtSoLuongBoSung.Text.Trim()=="")
            {
                MessageBox.Show("Chưa nhập gì");
                return;
            }
            try
            {
                if (int.Parse(txtSoLuongBoSung.Text) > 0)
                {
                    SqlCommand command = new SqlCommand("sp_BOSUNGDAUSACH", conn);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@ma", int.Parse(txtMa.Text)));
                    command.Parameters.Add(new SqlParameter("@soluong", int.Parse(txtSoLuongBoSung.Text)));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormDauSach f = new FormDauSach();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Số lượng không hợp lệ. Mời nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đéo đúng kiểu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            disconect();

        }
    }
}
