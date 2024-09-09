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
    public partial class fCategory : Form
    {
        public fCategory()
        {
            InitializeComponent();
            //LoadCategory();
            btnAddCategory.Enabled = false;
        }

        void LoadCategory()
        {
            dtgvCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            
        }

        #region Event
        
        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvCategory.Rows[e.RowIndex];
            txtbCategoryID.Text = Convert.ToString(row.Cells["id"].Value);
            txtbCategory.Text = Convert.ToString(row.Cells["name"].Value);
        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            if (txtbCategory.Text == "")
            {
                MessageBox.Show("Tên danh mục không được Trống!");

            }
            string name = txtbCategory.Text;

            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh mục thành công");
                
                txtbCategoryID.Clear();
                txtbCategory.Clear();
                txtbCategory.Focus();
                LoadCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            txtbCategoryID.Clear();
            txtbCategory.Clear();
            txtbCategory.Focus();
            btnAddCategory.Enabled = true;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbCategoryID.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh mục thành công");
                
                txtbCategoryID.Clear();
                txtbCategory.Clear();
                txtbCategory.Focus();
                LoadCategory();
                if (deleteCategory != null)
                    deleteCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa danh mục");
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txtbCategory.Text;
            int id = Convert.ToInt32(txtbCategoryID.Text);

            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa danh mục thành công");
                
                txtbCategoryID.Clear();
                txtbCategory.Clear();
                txtbCategory.Focus();
                LoadCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa danh mục");
            }
        }

        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            txtbCategoryID.Clear();
            txtbCategory.Clear();
            txtbCategory.Focus();
            LoadCategory();
        }




        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }


        #endregion


    }
}
