using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DTO
{
    public class Bill
    {
        private int id;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;
        private int discount;
        //private double totalPrice;

        public int Id { get => id; set => id = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
        //public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
           // this.TotalPrice = totalPrice;

        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var DateCheckOutTemp = row["dateCheckOut"];
            if (DateCheckOutTemp.ToString() != "")
                this.dateCheckOut = (DateTime?)row["dateCheckOut"];
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
            //this.TotalPrice = double.Parse(row["totalPrice"].ToString());
        }
    }
}
