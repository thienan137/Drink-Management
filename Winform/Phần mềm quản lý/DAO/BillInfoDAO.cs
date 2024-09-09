using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }

        private BillInfoDAO() { }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExcuteQuery("DELETE dbo.BillInfo WHERE idFood = " + id);
        }
    }
}
