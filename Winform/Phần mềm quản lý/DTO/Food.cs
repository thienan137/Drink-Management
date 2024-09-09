using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private int idCategory;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }

        public Food(int id, string name, int idCategory, float price)
        {
            this.Id = id;
            this.Name = name;
            this.IdCategory = idCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IdCategory = (int)row["idCategory"];
            this.Price = float.Parse(row["price"].ToString());
        }
    }
}
