using Phần_mềm_quản_lý.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }

        private TableDAO() { }

        public static int TableWidth = 120;
        public static int TableHeight = 120;

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public void CheckInStatus(int id)
        {
            string query = "Update TableFood Set status = N'Có người' Where id =" + id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void CheckOutStatus(int id)
        {
            string query = "Update TableFood Set status = N'Trống' Where id =" + id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public bool UpdateTable(int id, string name, string status)
        {
            string query = String.Format("UPDATE dbo.TableFood SET name = N'{0}', status = N'{1}' WHERE id = {2}", name, status, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }

        public bool DeleteTable(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFoodID(id);
            string query = String.Format("DELETE TableFood WHERE id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }

        public bool InsertTable(string name, string status)
        {
            string query = String.Format("INSERT dbo.TableFood (name, type) VALUES ( N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        /*public List<Table> GetListType()
        {
            List<Table> list = new List<Table>();
            string query = "SELECT status FROM TableFood";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Table type = new Table(item);
                list.Add(type);
            }
            return list;
        }*/
    }
}
