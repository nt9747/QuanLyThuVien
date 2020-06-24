
using QuanLyThuVien;
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
    public partial class FormLogin : Form
    {
        public static bool quyen;
        SqlConnection conn;
        SqlCommand command;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(globalParameter.str);
                conn.Open();
                string sql = "select count(*) from [dbo].[USER] where username = @acc and password = @pass";
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@acc", txtUsername.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtPassword.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1) // neu dang nhap thanh cong
                {

                    /*  FormMain fr = new FormMain();

                      fr.tentk = txtUsername.Text;
                      SqlCommand cmd = new SqlCommand("select  quyen from [dbo].[User] where username = '" + txtUsername.Text + "'", conn);
                      quyen = (bool)cmd.ExecuteScalar();

                      fr.Show();
                      this.Hide();
                      */
                    this.Hide();
                    FormMain fr = new FormMain();
                    fr.Show();


                }
                else
                {
                    lbInfor.Text = "ID or Password is incorrect";
                    lbInfor.ForeColor = Color.Red;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
