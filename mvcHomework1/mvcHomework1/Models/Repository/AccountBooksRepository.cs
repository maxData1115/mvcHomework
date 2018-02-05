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
        
        public IEnumerable<AccountBooks> GetAccount(int count)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"SELECT TOP({count}) *");
            sb.AppendLine("FROM AccountBook ab");
            sb.AppendLine("WHERE 1=1");
            sb.AppendLine("ORDER BY ab.Dateee desc");

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
        
        public void AddAccount(Guid id, int category, decimal amount, DateTime date, string remark)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Insert into AccountBook(Id, Categoryyy, Amounttt, Dateee, Remarkkk)");
            sb.AppendLine($"Values({id}, {category}, { amount}, { date}, { remark})");

            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sb.ToString(), conn))
                    {
                        conn.Open();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("AddAccount(): " + ex.Message);
            }
        }
    }
}