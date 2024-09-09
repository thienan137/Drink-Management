using Phần_mềm_quản_lý.DAO;
using Phần_mềm_quản_lý.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_quản_lý
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtbUserName.Text;
            string pass = txtbPassWord.Text;

            if (Login(userName, pass))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager frm = new fTableManager(loginAccount);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
                txtbUserName.Focus();
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            txtbUserName.Clear();
            txtbPassWord.Clear();
            txtbUserName.Focus();
        }
    }
}
