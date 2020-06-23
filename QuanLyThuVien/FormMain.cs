using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FormMain : Form
    {
        public String tentk;
        public FormMain()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //Hàm bắt sự kiện nhập phím
        {
            switch (keyData)
            {
                case Keys.F1: //Bắt sự kiện nhập phím F1
                    FormHelp fmHelp = new FormHelp();
                    fmHelp.Show();
                    break;
                    //Thêm phím tắt vào đây case2,3,.....

            }
            return base.ProcessCmdKey(ref msg, keyData);//Made by Dat_Dz
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            if (FormLogin.quyen == false)
            {
                lblten.Text = "Chào Admin " + tentk;
            }
            else
            {
                /*btndangky.Enabled = true;
                lblten.Text = "Chào Admin " + tentk;*/
            }
        }

        private void FormMain_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btndausach_Click(object sender, EventArgs e)
        {
            FormDauSach f = new FormDauSach();
            f.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTimDocGia_MuonTra f = new FormTimDocGia_MuonTra();
            f.Show();
            Hide();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.Show();
            
        }

        private void txtdausach_Click(object sender, EventArgs e)
        {
             FormDauSach f = new FormDauSach();
            f.Show();
            Hide();
        }

        private void txtdocgia_Click(object sender, EventArgs e)
        {
            FormDocGia f = new FormDocGia();
            f.Show();
            Hide();
        }

        private void txtMTS_Click(object sender, EventArgs e)
        {
            //FormMuonTra f = new FormMuonTra();
            //f.Show();
            //Hide();
        }

        private void btnhep_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.Show();
            Hide();
        }

        private void btndocgia_Click(object sender, EventArgs e)
        {
            FormDocGia f = new FormDocGia();
            f.Show();
            Hide();
        }

        /*private void btndangky_Click(object sender, EventArgs e)
        {
            FormDangKy fr = new FormDangKy();
            fr.Show();
            Hide();
        }*/

        private void lblten_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            FormHelp f = new FormHelp();
            f.Show();
            Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            Hide();
        }
    }
}
