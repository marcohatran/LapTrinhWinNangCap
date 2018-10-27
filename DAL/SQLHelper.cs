using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
namespace DAL
{
    public class SQLHelper
    {
        SqlConnection con;
        public SQLHelper()
        {
            con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Conn"].ToString();
        }
        private void Open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        private void Close()
        {
            if (con.State == ConnectionState.Open)
                con.Close() ;
        }
        public DataTable GetAll(string query, SqlParameter[] Parameters)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = query;
            com.Parameters.AddRange(Parameters);
            com.Connection = con;
            SqlDataAdapter adt = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            return dt;
        }
    }
}
