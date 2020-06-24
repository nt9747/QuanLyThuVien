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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            FormMain fr = new FormMain();
            fr.Show();
            Hide();
        }

        private SqlConnection conn;
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

        private void btndangky_Click(object sender, EventArgs e)
        {
            connect();
            if (txtpassword1.Text != txtpassword2.Text)
            {
                MessageBox.Show("mật khẩu không trùng xin nhập lại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                SqlCommand command = new SqlCommand("sp_DANGKYUSER", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@username", txtUsername.Text));
                command.Parameters.Add(new SqlParameter("@password", txtpassword1.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Đăng Ký thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormMain fr = new FormMain();
                fr.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng Ký không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtpassword1.Clear();
                txtpassword2.Clear();
            }
            disconect();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
