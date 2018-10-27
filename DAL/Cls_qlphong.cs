using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class Cls_qlphong
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public DataTable loadphong()
        {
            conn.Open();
            string sl = "select QL_SVTHI.MAPHONG,SOSV,COUNT(*) as 'SISO' from QL_SVTHI,PHONGTHI where QL_SVTHI.MAPHONG=PHONGTHI.MAPHONG group by QL_SVTHI.MAPHONG,SOSV";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable loadgvthi(string maphong)
        {
            conn.Open();
            string sl = "select * from QL_SVTHI,SINHVIEN where SINHVIEN.MASV=QL_SVTHI.MASV and MAPHONG='" + maphong.ToString() + "'";
            SqlDataAdapter dta = new SqlDataAdapter(sl,conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
