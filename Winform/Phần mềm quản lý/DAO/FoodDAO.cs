using Phần_mềm_quản_lý.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "SELECT * FROM Food WHERE idCategory = " + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<Food> GetFood()
        {
            string sql = "SELECT * FROM Food";
            List<Food> listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                Food f = new Food(item);
                listFood.Add(f);
            }
            return listFood;
        }

        public bool DeleteFood(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(id);
            string query = String.Format("DELETE Food WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }

        /*public void DeleteFood(int id, string name, int idCategory, float price)
        {
            string sql = "DELETE FROM Food WHERE ten = N'" + name + "', idCategory = '" + idCategory + "', price = '" + price + "' , id = '" + id + "'";
            DataProvider.Instance.ExcuteNonQuery(sql);
        }*/

        public bool InsertFood(string name, int idCategory, float price)
        {
            string query = String.Format("INSERT dbo.Food (name, idCategory, price) VALUES ( N'{0}', {1}, {2})", name, idCategory, price);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateFood(int id, string name, int idCategory, float price)
        {
            string query = String.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, idCategory, price, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }

        public int GetUnCheckFoodName(string name)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Food WHERE name = '" + name + "'");

            if (data.Rows.Count > 0)
            {
                Food foodName = new Food(data.Rows[0]);
                return foodName.Id;
            }
            return -1;
        }

        public List<Food> SearchFoodByName(string name)
        {
            string sql = string.Format( "SELECT * FROM Food WHERE name = N'{0}'", name);
            List<Food> listFood = new List<Food>();
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                Food f = new Food(item);
                listFood.Add(f);
            }
            return listFood;
        }
    }
}
