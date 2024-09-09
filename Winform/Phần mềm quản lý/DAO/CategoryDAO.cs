using Phần_mềm_quản_lý.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "SELECT * FROM FoodCategory";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        }

        public Category GetCategoryName(string name)
        {
            Category category = null;
            string sql = "SELECT * FROM FoodCategory WHERE name = N'" + name + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }

        public Category GetCategoryID(int id)
        {
            Category category = null;
            string sql = "SELECT * FROM FoodCategory WHERE id = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = String.Format("INSERT dbo.FoodCategory (name) VALUES ( N'{0}')", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(id);
            string query = String.Format("DELETE FoodCategory WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }

        public bool UpdateCategory(int id, string name)
        {
            string query = String.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }
    }
}
