using Phần_mềm_quản_lý.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phần_mềm_quản_lý.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public List<Account> GetAccount()
        {
            string sql = "SELECT * FROM Account";
            List<Account> listAccount = new List<Account>();
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow item in data.Rows)
            {
                Account f = new Account(item);
                listAccount.Add(f);
            }
            return listAccount;
        }

        public List<Account> GetListType()
        {
            List<Account> list = new List<Account>();
            string query = "SELECT type FROM Account";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account category = new Account(item);
                list.Add(category);
            }
            return list;
        }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable Result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, passWord });
            return Result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Account WHERE userName = '"+userName+"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExcuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] {userName, displayName, pass, newPass });
            return result > 0;
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            string query = String.Format("INSERT dbo.Account (userName, displayName, type) VALUES ( N'{0}', N'{1}', {2})", userName, displayName,type);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public void DeleteAccountByUserName(string userName)
        {
            DataProvider.Instance.ExcuteQuery("DELETE dbo.Account WHERE userName = " + userName);
        }

        public bool DeleteAccount(string userName)
        {
            AccountDAO.Instance.DeleteAccountByUserName(userName);
            string query = String.Format("DELETE Account WHERE userName = N'{0}'", userName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            string query = String.Format("UPDATE dbo.Account SET  displayName = {0}, type = {1} WHERE userName = {2}", displayName,type,userName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;

        }
    }
}
