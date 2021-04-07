using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLib
{
    public class AccountDAL
    {
        public Account ShowDetails(long Account_NO)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Banking"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Account where account_NO=" +Account_NO, cn);
           
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            Account ac = new Account();
            ac.Account_NO = Account_NO;
            ac.Account_Balance = Convert.ToInt64(dr["Account_Balance"]);
            cn.Close();
            return ac;
           
        }
        
    }
}
