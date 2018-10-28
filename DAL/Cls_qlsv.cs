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
    public class Cls_qlsv
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }
        public DataTable loadlop()
        {
            string sl = "select MALOP,TENLOP from LOP";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            return dt;
        }
        public DataTable loadgv()
        {
            string sl = "select ttnd.*, nd.TaiKhoan from ThongTinNguoiDung ttnd, NguoiDung nd where nd.MaNguoiDung=ttnd.MaNguoiDung and nd.TaiKhoan!='admin'";
            SqlDataAdapter dta = new SqlDataAdapter(sl,conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            return dt;
        }
        public void themsv(string matt, string hoten, string ngsinh, string gt, string dc,string sdt, string mail,int kieu ,string hinh )
        {
            conn.Open();
            if (kieu == 0)
            {
                string addtk = "insert into NguoiDung(TaiKhoan,MatKhau,TinhTrang) values('" + matt.ToString() + "','123456',0)";
                SqlCommand cmd = new SqlCommand(addtk, conn);
                cmd.ExecuteNonQuery();
                string sl = "select * from NguoiDung where TaiKhoan ='" + matt.ToString() + "'";
                SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                int ktr = dt.Rows.Count;
                if (ktr == 1)
                {
                    string day = ngsinh.Substring(0, 2);
                    string month = ngsinh.Substring(3, 2);
                    string ns = month + "/" + day + "/" + ngsinh.Substring(6, 4);
                    if (gt == "Nam")
                        gt = "1";
                    else
                        gt = "0";
                    string addsv = "insert into ThongTinNguoiDung (MaNguoiDung,HoTen,NgaySinh,GioiTinh,DiaChi,SDT,Email,Hinh) values ('" + dt.Rows[0][0].ToString().Trim() + "',N'" + hoten.ToString() + "','" + ns.ToString() + "'," + gt.ToString() + ",N'" + dc.ToString() + "','" + sdt.ToString() + "','" + mail.ToString() + "', '"+hinh+"')";
                    SqlCommand cmdsv = new SqlCommand(addsv, conn);
                    cmdsv.ExecuteNonQuery();
                }
                string slmh = "select * from ManHinh";
                SqlDataAdapter dta1 = new SqlDataAdapter(slmh, conn);
                DataTable dt1 = new DataTable();
                dta1.Fill(dt1);
                string addquyen = "insert into NguoiDungManHinh (MaNguoiDung,MaManHinh,TinhTrang) values ";
                foreach (DataRow dr in dt1.Rows)
                {
                    if (dr["MaManHinh"].ToString().Trim() == "2" || dr["MaManHinh"].ToString().Trim() == "2")
                    {
                        addquyen += "(" + dt.Rows[0][0].ToString().Trim() + "," + dr["MaManHinh"].ToString().Trim() + ",1),";
                    }
                    else
                    {
                        addquyen += "(" + dt.Rows[0][0].ToString().Trim() + "," + dr["MaManHinh"].ToString().Trim() + ",0),";
                    }
                }
                addquyen = addquyen.Substring(0, addquyen.Length - 1);
                SqlCommand cmd1 = new SqlCommand(addquyen, conn);
                cmd1.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void xoasv(string matt)
        {
            conn.Open();
            string delete = "delete from ThongTinNguoiDung where MaThongTinNguoiDung ='" + matt.ToString() + "'";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void suasv(string matt, string hoten, string ngsinh, string gt, string dc, string sdt, string mail, int kieu ,string hinh)
        {
            conn.Open();
            string day = ngsinh.Substring(0, 2);
            string month = ngsinh.Substring(3, 2);
            string ns = month + "/" + day + "/" + ngsinh.Substring(6, 4);
            if (gt == "Nam")
                gt = "1";
            else
                gt = "0";
            string str = "Update ThongTinNguoiDung set HoTen= N'" + hoten.ToString() + "',NgaySinh='" + ns.ToString() + "',GioiTinh= N'" + gt.ToString() + "',DiaChi= N'" + dc.ToString() + "',SDT='" + sdt.ToString() + "',Email='" + mail.ToString() + "',Hinh='"+hinh+" ' where MaThongTinNguoiDung='" + matt.ToString() + "'";
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
