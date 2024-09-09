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
    public partial class fTableFood : Form
    {
        public fTableFood()
        {
            InitializeComponent();
            btnAddTable.Enabled = false;
            //LoadType();
        }


        void LoadTable()
        {
            dtgvTableFood.DataSource = TableDAO.Instance.LoadTableList();
        }

        /*void LoadType()
        {

            List<Table> list = TableDAO.Instance.GetListType();
            cbbStatus.DataSource = list;
            cbbStatus.DisplayMember = "Name";
        }*/

        #region Event

        private void btnNewTable_Click(object sender, EventArgs e)
        {
            txtbTableID.Clear();
            txtbTableName.Clear();
            txtbTableName.Focus();
            btnAddTable.Enabled = true;
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txtbTableName.Text;
            int id = Convert.ToInt32(txtbTableID.Text);
            string status = txtbStatus.Text;

            if (TableDAO.Instance.UpdateTable(id, name, status))
            {
                MessageBox.Show("Sửa bàn thành công");
                
                txtbTableID.Clear();
                txtbTableName.Clear();
                txtbTableName.Focus();
                LoadTable();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbTableID.Text);

            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công");
                
                txtbTableID.Clear();
                txtbTableName.Clear();
                txtbTableName.Focus();
                LoadTable();
                if (deleteTable != null)
                    deleteTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa bàn");
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (txtbTableName.Text == "")
            {
                MessageBox.Show("Tên bàn không được Trống!");

            }
            string name = txtbTableName.Text;
            string status = txtbStatus.Text;
            if (TableDAO.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Thêm bàn thành công");
                
                txtbTableID.Clear();
                txtbTableName.Clear();
                txtbTableName.Focus();
                LoadTable();
                if (insertTable != null)
                    insertTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }

        private void dtgvTableFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvTableFood.Rows[e.RowIndex];
            txtbTableID.Text = Convert.ToString(row.Cells["id"].Value);
            txtbTableName.Text = Convert.ToString(row.Cells["name"].Value);
            txtbStatus.Text = Convert.ToString(row.Cells["status"].Value);
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            txtbTableID.Clear();
            txtbTableName.Clear();
            txtbTableName.Focus();
            LoadTable();
        }


        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }



        #endregion

        
    }
}
