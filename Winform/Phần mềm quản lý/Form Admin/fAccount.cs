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

namespace Phần_mềm_quản_lý.Form_Admin
{
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();
            btnAddAccount.Enabled = false;
            // LoadType();
        }

        void LoadAccount()
        {
            dtgvAccount.DataSource = AccountDAO.Instance.GetAccount();
        }


        #region Event

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            txtbDisplayName.Clear();
            txtbUserName.Clear();
            txtbUserName.Focus();
            btnAddAccount.Enabled = true;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txtbUserName.Text == "" || txtbDisplayName.Text == "")
            {
                MessageBox.Show("Tên tài khoản hoặc tên hiển thị không được Trống!");

            }
            string userName = txtbUserName.Text;
            string displayName = txtbDisplayName.Text;
            int type = Int32.Parse(txtbType.Text);
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                
                txtbDisplayName.Clear();
                txtbUserName.Clear();
                txtbUserName.Focus();
                LoadAccount();
                if (insertAccount != null)
                    insertAccount(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txtbUserName.Text;

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                
                txtbDisplayName.Clear();
                txtbUserName.Clear();
                txtbUserName.Focus();
                LoadAccount();
                if (deleteAccount != null)
                    deleteAccount(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa tài khoản");
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txtbUserName.Text;
            string displayName = txtbDisplayName.Text;
            int type = Int32.Parse(txtbType.Text);

            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                txtbDisplayName.Clear();
                txtbUserName.Clear();
                txtbUserName.Focus();
                LoadAccount();
                
                if (updateAccount != null)
                    updateAccount(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản");
            }
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            txtbDisplayName.Clear();
            txtbUserName.Clear();
            txtbUserName.Focus();
            LoadAccount();
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvAccount.Rows[e.RowIndex];
            txtbUserName.Text = Convert.ToString(row.Cells["userName"].Value);
            txtbDisplayName.Text = Convert.ToString(row.Cells["displayName"].Value);
            txtbType.Text = Convert.ToString(row.Cells["type"].Value);
        }

        private event EventHandler insertAccount;
        public event EventHandler InsertAccount
        {
            add { insertAccount += value; }
            remove { insertAccount -= value; }
        }

        private event EventHandler deleteAccount;
        public event EventHandler DeleteAccount
        {
            add { deleteAccount += value; }
            remove { deleteAccount -= value; }
        }

        private event EventHandler updateAccount;
        public event EventHandler UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        #endregion


    }
}
