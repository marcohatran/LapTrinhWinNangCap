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
    public class Updatedulieuthi
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        public void UpdateKetQua(int manguoidung)
        {
            conn.Open();
            
            string sl = "select kq.MaKetQua from KetQua kq, DangKi dk where dk.MaDangKy=kq.MaDangKy and  dk.MaNguoiDung=" + manguoidung + " and kq.DaXoa in (NULL,'False')";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                string laydk = "select * from DangKi where MaNguoiDung =" + manguoidung;
                SqlDataAdapter dta3 = new SqlDataAdapter(laydk, conn);
                DataTable dt3 = new DataTable();
                dta3.Fill(dt3);
                string ht = DateTime.Now.ToShortDateString();
                string ngay = ht.Substring(0, 2);
                string thang = ht.Substring(3, 2);
                ht = thang + "/" + ngay + "/" + ht.Substring(6, 4);
                string insert = "insert into KetQua (MaDangKy,DapAnDung,DapAnSai,NgayLam,DaXoa,GhiChu) values (" + dt3.Rows[0]["MaDangKy"].ToString().Trim() + ",0,0,'" + ht + "','False',N'Làm bài thi')";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
            }
            //string sl1 = "select kq.MaKetQua from KetQua kq, DangKi dk where dk.MaDangKy=kq.MaDangKy and  dk.MaNguoiDung=" + manguoidung + " and kq.DaXoa in (NULL,'False')";
            //SqlDataAdapter dta1 = new SqlDataAdapter(sl1, conn);
            //DataTable dt1 = new DataTable();
            //dta1.Fill(dt1);
            //if (dt1.Rows.Count == 1)
            //{
            //    string update = "update DangKi set MaKetQua=" + int.Parse(dt1.Rows[0][0].ToString()) + " where TinhTrang in (0,'False') and MaNguoiDung =" + manguoidung;
            //    SqlCommand cmdt = new SqlCommand(update, conn);
            //    cmdt.ExecuteNonQuery();
            //}
            conn.Close();
        }
        public void loadcauhoi(int manguoidung)
        {
            
            string slde = "select MaBoDe,MaDangKy from DangKi where TinhTrang in (0,'False') and MaNguoiDung =" + manguoidung;
            SqlDataAdapter dta = new SqlDataAdapter(slde, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            string slch = "select ch.* from CauHoi ch,ChiTietBoDe ct where ch.MaCauHoi=ct.MaCauHoi and  ct.MaBoDe=" + int.Parse(dt.Rows[0][0].ToString().Trim()) + "and (ch.DaXoa IS NULL or  ch.DaXoa in (0,'False'))";
            SqlDataAdapter dta1 = new SqlDataAdapter(slch, conn);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);
            conn.Open();
            string slde1 = "select * from DangKi, KetQua where DangKi.MaDangKy=KetQua.MaDangKy and DangKi.MaNguoiDung=" + manguoidung + " and KetQua.DaXoa in (0,'False') and (DangKi.TinhTrang in (0,'False') or DangKi.TinhTrang IS NULL )";
            SqlDataAdapter dta4 = new SqlDataAdapter(slde1, conn);
            DataTable dt4 = new DataTable();
            dta4.Fill(dt4);
            string check = "select * from ChiTietKetQua where MaKetQua=" + dt4.Rows[0]["MaKetQua"].ToString();
            SqlDataAdapter dta5 = new SqlDataAdapter(check, conn);
            DataTable dt5 = new DataTable();
            dta5.Fill(dt5);
            if (dt5.Rows.Count == 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into ChiTietKetQua (MaKetQua,MaCauHoi,DapAnChon,KetQua) values(" + dt4.Rows[0]["MaKetQua"].ToString() + "," + dt1.Rows[i][0].ToString() + ",'Sai',0)", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        
        }
        public DataTable loaddltraloi(int stt, int manguoidung)
        {
            string slde = "select * from DangKi, KetQua where DangKi.MaDangKy=KetQua.MaDangKy and DangKi.MaNguoiDung=" + manguoidung + " and KetQua.DaXoa in (0,'False') and DangKi.TinhTrang in (0,'False') or DangKi.TinhTrang IS NULL ";
            SqlDataAdapter dta = new SqlDataAdapter(slde, conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            string sl = "";
            if (stt == 0)
            {
                sl = "select * from ChiTietKetQua where MaKetQua=" + dt.Rows[0]["MaKetQua"].ToString();
            }
            if (stt == 1)
            {
                sl = "select * from ChiTietKetQua where DapAnChon in ('Sai,','','Sai') and MaKetQua=" + dt.Rows[0]["MaKetQua"].ToString();
            }
            if (stt == 2)
            {
                sl = "select * from ChiTietKetQua where DapAnChon not like '%Sai%' and MaKetQua=" + dt.Rows[0]["MaKetQua"].ToString();
            }
            SqlDataAdapter dta1 = new SqlDataAdapter(sl, conn);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);
            return dt1;
        }
    }
}
