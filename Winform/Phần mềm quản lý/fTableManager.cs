using Phần_mềm_quản_lý.DAO;
using Phần_mềm_quản_lý.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Phần_mềm_quản_lý.fAccountProfile;
using Menu = Phần_mềm_quản_lý.DTO.Menu;

namespace Phần_mềm_quản_lý
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
         
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadCategory();
            LoadTable();
            LoadSwitchTable();
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinToolStripMenuItem.Text += "(" + loginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "Name";

        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbbFood.DataSource = listFood;
            cbbFood.DisplayMember = "Name";
        }

        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<Menu> listbillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (Menu item in listbillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvBill.Items.Add(lsvItem);

                txtbTotalPrice.Text = totalPrice.ToString();
            }

        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.AntiqueWhite;
                        break;
                    default:
                        btn.BackColor = Color.MediumSeaGreen;
                        break;
                }
                flpTable.Controls.Add(btn);

            }
        }

        void LoadSwitchTable()
        {
            List<Table> listTf = TableDAO.Instance.LoadTableList();
            cbbSwitchTable.DataSource = listTf;
            cbbSwitchTable.DisplayMember = "Name";
        }



        #region menustrip
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.UpdateAccount += F_UpdateAccount;
            f.ShowDialog();
        }

        private void F_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion

        #region event
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillByTableID(table.ID);
            int foodID = (cbbFood.SelectedItem as Food).Id;
            int count = (int)numCount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            int OldId = (lvBill.Tag as Table).ID;
            int NewId = (cbbSwitchTable.SelectedItem as Table).ID;

            TableDAO.Instance.CheckOutStatus(OldId);
            BillDAO.Instance.change(NewId, OldId);
            TableDAO.Instance.CheckInStatus(NewId);
            LoadTable();
            ShowBill(NewId);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillByTableID(table.ID);

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn muốn thanh toán bàn " + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.CheckOutStatus(table.ID);
                    BillDAO.Instance.CheckOut(idBill);
                    ShowBill(idBill);
                }
                //ShowBill(idBill);
                LoadTable();

                /*Table table = lvBill.Tag as Table;
                int idBill = BillDAO.Instance.GetUnCheckBillByTableID(table.ID);
                int discount = (int)numDiscount.Value;
                double totalPrice = Convert.ToDouble(txtbTotalPrice.Text);
                double finalTotalPrice = totalPrice - ((totalPrice / 100) * discount);

                if (idBill != -1)
                {
                    if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\n . Tổng tiền = {1} ", table.Name, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill, discount, (double)totalPrice );
                        ShowBill(table.ID);
                        LoadTable();
                    }
                }*/
            }
        }

        #endregion

        private void cbbFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
