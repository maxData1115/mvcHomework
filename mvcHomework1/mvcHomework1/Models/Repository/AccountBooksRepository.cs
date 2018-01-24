using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using mvcHomework1.Models.Domain;

namespace mvcHomework1.Models.Repository
{
    public class AccountBooksRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["HomeWorkDB"].ConnectionString;
        public IEnumerable<AccountBooks> GetAccount()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT *");
            sb.AppendLine("FROM AccountBook ab");
            sb.AppendLine("WHERE 1=1");

            try
            {              
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    return conn.Query<AccountBooks>(sb.ToString());
                }
            }
            catch(Exception ex)
            {
                throw new Exception("GetAccount(): " + ex.Message);
            }
        }
    }
}