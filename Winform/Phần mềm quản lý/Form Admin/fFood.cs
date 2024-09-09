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
    public partial class fFood : Form
    {
        //BindingSource foodlist = new BindingSource();
        public fFood()
        {
            InitializeComponent();
            //LoadFood();
            LoadCategory();
            //Loading();
            btnAddFood.Enabled = false;
        }

        void LoadFood()
        {
            dtgvFood.DataSource =  FoodDAO.Instance.GetFood();
        }

        /*void Loading()
        {
            dtgvFood.DataSource = foodlist;
            AddFoodBinding();
            LoadCategoryIntoCombobox(cbbFoodCategory);
        }*/

        void LoadCategory()
        {
            List<Category> list = CategoryDAO.Instance.GetListCategory();
            cbbFoodCategory.DataSource = list;
            cbbFoodCategory.DisplayMember = "Name";
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        /*void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }*/

        void AddFoodBinding()
        {
            //txtbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            //txtbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            //txtbPrice.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));

        }


        #region event
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtbFoodID.Clear();
            txtbFoodName.Clear();
            txtbPrice.Clear();
            txtbFoodName.Focus();
            btnAddFood.Enabled = true;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (txtbFoodName.Text == "" || txtbPrice.Text == "")
            {
                MessageBox.Show("Tên món hoặc giá không được Trống!");

            }
            string name = txtbFoodName.Text;
            int categoryID = (cbbFoodCategory.SelectedItem as Category).Id;
            float price = float.Parse(txtbPrice.Text);

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                
                txtbFoodID.Clear();
                txtbFoodName.Clear();
                txtbPrice.Clear();
                txtbFoodName.Focus();
                LoadFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txtbFoodName.Text;
            int categoryID = (cbbFoodCategory.SelectedItem as Category).Id;
            float price = float.Parse(txtbPrice.Text);
            int id = Convert.ToInt32(txtbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                
                txtbFoodID.Clear();
                txtbFoodName.Clear();
                txtbPrice.Clear();
                txtbFoodName.Focus();
                LoadFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            txtbSearch.Clear();
            txtbFoodID.Clear();
            txtbFoodName.Clear();
            txtbPrice.Clear();
            LoadFood();
        }


        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvFood.Rows[e.RowIndex];
            txtbFoodID.Text = Convert.ToString(row.Cells["id"].Value);
            txtbFoodName.Text = Convert.ToString(row.Cells["name"].Value);
            txtbPrice.Text = Convert.ToString(row.Cells["price"].Value);
           

            /*int numrow;
            numrow = e.RowIndex;
            txtbFoodID.Text = dtgvFood.Rows[numrow].Cells[0].Value.ToString();
            txtbFoodName.Text = dtgvFood.Rows[numrow].Cells[1].Value.ToString();
            string ct = dtgvFood.Rows[numrow].Cells[2].Value.ToString();
            Category category = CategoryDAO.Instance.GetCategoryID(int.Parse(ct));
            cbbFoodCategory.Text = category.Name;
            txtbPrice.Text = dtgvFood.Rows[numrow].Cells[3].Value.ToString();*/
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                txtbSearch.Clear();
                txtbFoodID.Clear();
                txtbFoodName.Clear();
                txtbPrice.Clear();
                LoadFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }

        private void txtbFoodID_TextChanged(object sender, EventArgs e)
        {
            if (dtgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dtgvFood.SelectedCells[0].OwningRow.Cells["idCategory"].Value;
                Category category = CategoryDAO.Instance.GetCategoryID(id);
                cbbFoodCategory.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in cbbFoodCategory.Items)
                {
                    if (item.Id == category.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbbFoodCategory.SelectedIndex = index;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgvFood.DataSource =  FoodDAO.Instance.SearchFoodByName(txtbSearch.Text);
        }
        #endregion



        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


    }
}
