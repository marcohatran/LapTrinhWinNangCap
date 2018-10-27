using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DAL;
using System.Data.Sql;
namespace BLL
{
    public class XuLy
    {
        Cls_qlsv clsv = new Cls_qlsv();
        Data dl = new Data();
        BoDeCauHoi bdch = new BoDeCauHoi();
        Updatedulieuthi dlthi = new Updatedulieuthi();
        public int check_config()
        {
            string a = ConfigurationManager.ConnectionStrings["Conn"].ToString();
            if (a == string.Empty)
            {
                //return 1;
            }
            SqlConnection _Sqlconn = new SqlConnection(a.ToString());
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }
        public DataTable GetServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public DataTable cbnguoidung()
        {
            return dl.cbloaitk();
        }
        public DataTable loadnguoidung()
        {
            return dl.loadtaikhoan_frmqlnd();
        }
        public void frmqltk_khoatk(string a, string b)
        {
            Data dl = new Data();
            dl.capnhat(a.ToString(), b.ToString());
        }
        public DataTable loadtttk(string a)
        {
            return dl.loaddlcb(a);
        }
        public int ktrtk(string a)
        {
            return dl.ktrataikhoan(a);
        }
        public DataTable cbtaikhoan()
        {
            return dl.cbtaikhoan();
        }
        public void UpdateKetQua(int manguoidung)
        {
            dlthi.UpdateKetQua(manguoidung);
        
        }
        public void loadcauhoi(int manguoidung)
        {
            dlthi.loadcauhoi(manguoidung);
        }
        public int checkmanhinh(string taikhoan)
        {
            return dl.checkmanhinh(taikhoan);
        }
        public int Doimatkhau(int i, string tk, string cu, string moi, string xn)
        {
            try
            {

                int x = dl.Doimatkhau(i, tk, cu, moi, xn);
                if (x == 0)
                {
                    return 0;
                }
                else
                    return 1;
            }
            catch
            {
                return 1;
            }
        }
        public DataTable loaddltraloi(int stt, int manguoidung)
        {
            return dlthi.loaddltraloi(stt, manguoidung);
        }
        public int  updatequyen(string ma, string gt,int mamh,string mand)
        {
            try
            {
                dl.updatequyen(ma, gt,mamh,mand);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public DataTable loadgv()
        {
            return clsv.loadgv();
        }
        public int themsinhvien(string matt, string hoten, string ngsinh, string gt, string dc, string sdt, string mail, string hinh)
        {
            try
            {
                clsv.themsv(matt, hoten, ngsinh, gt, dc, sdt, mail, 0, hinh);
                return 0;
            }
            catch
            {
                return 1;
            }

        }
        public int xoathongtinngdung(string matt)
        {
            try
            {
                clsv.xoasv(matt);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public int suathongtinnguoidung(string matt, string hoten, string ngsinh, string gt, string dc, string sdt, string mail, string hinh)
        {
            try
            {
                clsv.suasv(matt, hoten, ngsinh, gt, dc, sdt, mail, 0, hinh);
                return 0;
            }
            catch
            {
                return 1;
            }

        }
        public int ThemBD(string tenbd, string gchu)
        {
            try
            {
                bdch.ThemBD(tenbd, gchu);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public int capnhat(string mabd, string tenbd, string gchu, int th)
        {
            try
            {
                bdch.capnhat(mabd, tenbd, gchu, th);
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public bool CapPhat(string mabd)
        {
            try
            {
                bdch.CapPhat(mabd);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadChiTiet(string mabode)
        {
            return bdch.LoadChiTiet(mabode);
        }
        //public DataTable check_usphong(string maphong)
        //{
        //    Cls_qlphong clp = new Cls_qlphong();
        //    DataTable dt= clp.loadgvthi(maphong.ToString());
        //    return dt;
        //}
        //public int themsinhvien(string mssv,string malop,string hoten,string ngsinh,string gt,string dc)
        //{
        //    try
        //    {
        //        clsv.themsv(mssv, malop, hoten, ngsinh, gt, dc, 0);
        //        return 0;
        //    }
        //    catch
        //    {
        //        return 1;
        //    }

        //}
    }
}
