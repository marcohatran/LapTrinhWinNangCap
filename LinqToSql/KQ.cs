using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToSql
{
    public class KQ
    {
        int maDK;
        string ghiChu;
        int maKQ;
        string hoTen;
        DateTime? ngayDK;
        DateTime? ngayLam;
        int? dapAnDung;
        int? dapAnSai;
        public int MaDK
        {
            get { return maDK; }
            set { maDK = value; }
        }


        public int MaKQ
        {
            get { return maKQ; }
            set { maKQ = value; }
        }


        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public DateTime? NgayDK
        {
            get { return ngayDK; }
            set { ngayDK = value; }
        }

        public DateTime? NgayLam
        {
            get { return ngayLam; }
            set { ngayLam = value; }
        }

        public int? DapAnDung
        {
            get { return dapAnDung; }
            set { dapAnDung = value; }
        }

        public int? DapAnSai
        {
            get { return dapAnSai; }
            set { dapAnSai = value; }
        }


        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        public KQ(int maDK,string ghiChu,int maKQ,string hoTen,DateTime? ngayDK,DateTime? ngayLam,int? dapAnDung,int? dapAnSai)
        {
            this.maDK = maDK;
            this.ghiChu = ghiChu;
            this.maKQ = maKQ;
            this.hoTen = hoTen;
            this.ngayDK = ngayDK;
            this.ngayLam = ngayLam;
            this.dapAnDung = dapAnDung;
            this.dapAnSai = dapAnSai;
        }
    }
}
