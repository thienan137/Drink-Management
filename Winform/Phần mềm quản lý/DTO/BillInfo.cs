using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DTO
{
    public class BillInfo
    {
        private int iD;
        private int iDBill;
        private int iDFood;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(int id, int idBill, int idFood, int count)
        {
            this.ID = id;
            this.IDFood = idFood;
            this.IDBill = idBill;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDFood = (int)row["idFood"];
            this.IDBill = (int)row["idBill"];
            this.Count = (int)row["count"];
        }
    }
}
