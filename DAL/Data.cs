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
    public class Data
    {
        SqlConnection conn;

        public Data()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        }
        public void capnhatconnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        }
        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        SQLHelper hl = new SQLHelper();
        public int check_user(string pUser, string pPass)
        {

            //string kn = "select * from NguoiDung where TaiKhoan='" + pUser.ToString() + "' and MatKhau='" + pPass.ToString() + "'";
            string kn = "select * from NguoiDung where TaiKhoan = @TaiKhoan and MatKhau =@MatKhau";
            DataTable dt = new DataTable();
            SqlParameter[] a ={new SqlParameter("@TaiKhoan",pUser),
                               new SqlParameter("@MatKhau", pPass)};
            dt = hl.GetAll(kn, a);
            //conn.Open();
            //SqlDataAdapter daUser= new SqlDataAdapter(kn,conn);
            //DataTable dt = new DataTable();
            //MessageBox.Show(kn.ToString());
            //daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 1;
            }
            else if (dt.Rows[0][4] == null || dt.Rows[0][4].ToString() == "True")
            {
                return 2;
            }
            else if (dt.Rows[0][3].ToString() == "GV")
            {
                return 3;
            }
            else if (dt.Rows[0][3].ToString() == "SV")
            {
                return 4;
            }
            return 0;
            //conn.Close();
        }
        public DataTable loadtaikhoan_frmqlnd()
        {
            conn.Open();
            string sl = "select * from NguoiDung,ThongTinNguoiDung where NguoiDung.MaNguoiDung =ThongTinNguoiDung.MaNguoiDung and NguoiDung.TaiKhoan != 'admin'";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable cbloaitk()
        {
            conn.Open();
            string sl = "select Nhom from NguoiDung";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable loaddlcb(string tk)
        {
            conn.Open();
            DataTable dt = new DataTable();
            string sl = "select mh.*,q.* from NguoiDung nd, NguoiDungManHinh q, ManHinh mh where q.MaManHinh=mh.MaManHinh and nd.MaNguoiDung=q.MaNguoiDung and nd.MaNguoiDung ='" + tk + "' order by mh.MaManHinh";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            dta.Fill(dt);
            conn.Close();
            return dt;

        }
        public void updatequyen(string ma, string gt,int  mamh,string mand)
        {
            conn.Open();
            if (mamh != 2)
            {
                string sl = "update NguoiDungManHinh set TinhTrang ='" + gt + "' where MaNguoiDungManHinh=" + ma;
                SqlCommand cmd = new SqlCommand(sl, conn);
                cmd.ExecuteNonQuery();
                string up = "update NguoiDungManHinh set TinhTrang ='False' where MaNguoiDung=" + mand + " and MaManHinh = 2";
                SqlCommand cmd1 = new SqlCommand(up, conn);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                if (gt == "False")
                {
                    string sl = "update NguoiDungManHinh set TinhTrang ='" + gt + "' where MaNguoiDungManHinh=" + ma;
                    SqlCommand cmd1 = new SqlCommand(sl, conn);
                    cmd1.ExecuteNonQuery();
                }
                else
                {
                    string up = "update NguoiDungManHinh set TinhTrang ='False' where MaNguoiDung="+mand+" and MaManHinh != 2";
                    SqlCommand cmd = new SqlCommand(up, conn);
                    cmd.ExecuteNonQuery();
                    string sl = "update NguoiDungManHinh set TinhTrang ='True' where MaNguoiDungManHinh=" + ma;
                    SqlCommand cmd1 = new SqlCommand(sl, conn);
                    cmd1.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
        public DataTable cbtaikhoan()
        {
            string sl = "select * from NguoiDung,ThongTinNguoiDung where NguoiDung.MaNguoiDung=ThongTinNguoiDung.MaNguoiDung";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            return dt;
        }
        public int Doimatkhau(int i, string tk, string cu, string moi, string xn)
        {
            conn.Open();
            if (i == 0)
            {
                string up = "Update NguoiDung set MatKhau ='123456' where TaiKhoan='" + tk + "'";
                SqlCommand cmd = new SqlCommand(up, conn);
                cmd.ExecuteNonQuery();
                return 0;
            }
            else
            {
                string sl = "select * from NguoiDung where TaiKhoan='" + tk + "' and MatKhau ='" + cu + "'";
                SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    string up = "Update NguoiDung set MatKhau ='" + moi + "' where TaiKhoan='" + tk + "'";
                    SqlCommand cmd = new SqlCommand(up, conn);
                    cmd.ExecuteNonQuery();
                    return 0;
                }
                else
                    return 1;
            }
            conn.Close();
        }
        public int ktrataikhoan(string a)
        {
            //string kn = "select * from NguoiDung where TaiKhoan = @TaiKhoan and MatKhau =@MatKhau";
            //DataTable dt = new DataTable();
            //SqlParameter[] a ={new SqlParameter("@TaiKhoan",pUser),
            //                   new SqlParameter("@MatKhau", pPass)};
            //dt = hl.GetAll(kn, a);
            string sl = "select nd.* from NguoiDung nd , NguoiDungManHinh mh where nd.TaiKhoan='" + a + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            dta.Fill(dt);
            if (string.Compare(dt.Rows[0]["MaNguoiDung"].ToString().Trim(), "1") == 0)
            {
                return 0;
            }
            else
                return 1;
        }
        public void capnhat(string a, string b)
        {
            conn.Open();
            string sl = "Update NguoiDung set TinhTrang ='" + b.ToString() + "' where MaNguoiDung='" + a.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sl, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public int checkmanhinh(string taikhoan)
        {
            capnhatconnection();
            // SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
            conn.Open();
            string sl = "select * from NguoiDung nd, NguoiDungManHinh mh where nd.MaNguoiDung=mh.MaNguoiDung and nd.MaNguoiDung='" + taikhoan + "'";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (string.Compare(dr[6].ToString(), "1") == 0)
                {
                    if (string.Compare(dr[8].ToString(), "True") == 0)
                    {
                        return 0;
                    }
                }
                if (string.Compare(dr[6].ToString(), "2") == 0)
                {
                    if (string.Compare(dr[8].ToString(), "True") == 0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
            return 4;
            conn.Close();
        }
    }
}
