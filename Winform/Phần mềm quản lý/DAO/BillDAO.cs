using Phần_mềm_quản_lý.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public int GetUnCheckBillByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Bill WHERE idTable = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }



        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM Bill");
            }
            catch
            {
                return 1;
            }

        }

        public void change(int idNew, int id)
        {
            string query = "UPDATE Bill SET idTable = '" + idNew + "' WHERE idTable = '" + id + "' AND status = 0";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void CheckOut(int id)//, int discount, double totalPrice)
        {
            string sql = "Update Bill Set Status = 1, DatecheckOut = getdate() where id =" + id;
            DataProvider.Instance.ExcuteNonQuery(sql);

            /*string query = "UPDATE Bill SET dateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + "totalPrice =" + totalPrice+" WHERE id = " + id;
            DataProvider.Instance.ExcuteNonQuery(query);*/
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT T.name AS N'Tên bàn' , B.DateCheckIn AS N'Ngày vào' , B.DateCheckOut AS N'Ngày ra',(Bi.count * F.price) AS 'Tổng tiền' FROM TableFood T, Bill B, BillInfo Bi, Food F WHERE T.id = b.idTable AND b.id = Bi.idBill AND Bi.idFood = F.id AND B.DateCheckIn >='"+ checkIn +"'AND B.DateCheckOut <='"+ checkOut +"'AND B.status = 1");
        }
    }
}
