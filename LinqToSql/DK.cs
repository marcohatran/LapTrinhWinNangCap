using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    public class DK
    {
        //MaDK=dk.MaDangKy,HoTen=tt.HoTen,NgayDK=dk.NgayDangKy,
        //Mail=tt.Email,Made=dk.MaBoDe,TT=dk.TinhTrang}).ToList();
        //    return ts.ToList();
        int maDK;
        int? maDe;
        string hoTen, mail;
        bool? tT;
        DateTime? ngayDK;
        public int? MaDe
        {
            get { return maDe; }
            set { maDe = value; }
        }

        public int MaDK
        {
            get { return maDK; }
            set { maDK = value; }
        }


        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }


        public bool? TT
        {
            get { return tT; }
            set { tT = value; }
        }


        public DateTime? NgayDK
        {
            get { return ngayDK; }
            set { ngayDK = value; }
        }
        public DK(int MDK, int? MDe, string HT, string M, bool? TR, DateTime? DAY)
        {
            this.maDK = MDK;
            this.maDe = MDe;
            this.hoTen = HT;
            this.mail = M;
            this.tT = TR;
            this.ngayDK = DAY;
        }
    }
}
