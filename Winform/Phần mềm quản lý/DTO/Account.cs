using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DTO
{
    public class Account
    {
        private string userName;
        private string displayName;
        private string password;
        private int type;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }

        public Account (string userName, string displayName, string password, int type)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Password = row["passWord"].ToString();
            this.Type =(int)row["type"];
        }
    }
}
