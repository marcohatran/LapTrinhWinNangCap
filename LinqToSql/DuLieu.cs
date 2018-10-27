using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    public class DuLieu
    {
        DataClasses1DataContext thi = new DataClasses1DataContext();
        public List<LoaiCauHoi> LoadLoaiCH()
        {
            return thi.LoaiCauHois.Select(t => t).ToList<LoaiCauHoi>();
        }
        public List<ThongTinNguoiDung> LoaiND( int mand)
        {
            return thi.ThongTinNguoiDungs.Where(t => t.MaNguoiDung == mand).ToList() ;
        }
        public int CheckDangKy(int mand)
        {
            var nd = from tt in thi.NguoiDungs
                     join dk in thi.DangKis
                     on tt.MaNguoiDung equals dk.MaNguoiDung
                     where tt.MaNguoiDung == mand
                     select dk;
            if (nd.Count() == 0)
            {
                return 1;
            }
            else
            {
                var nd1 = from tt in thi.NguoiDungs
                         join dk in thi.DangKis
                         on tt.MaNguoiDung equals dk.MaNguoiDung
                         where tt.MaNguoiDung == mand && dk.TinhTrang == true
                         select dk;
                if (nd1.Count() == 0)
                {
                    return 2;
                }
                else
                    return 0;
            }
                
                    
        }
        public int CheckDaThi(int mand)
        {
            var nd = from tt in thi.NguoiDungs
                     join dk in thi.DangKis
                     on tt.MaNguoiDung equals dk.MaNguoiDung
                     where tt.MaNguoiDung == mand && dk.TinhTrang == true
                     select dk;
            if (nd.Count() == 0)
            {
                return 1;
            }
            else
                return 0;
        }
        public int CheckTenBoDe(string TenBoDe)
        {
            var kttenBD = from bd in thi.BoDes
                          where bd.TenBoDe.Equals(TenBoDe, StringComparison.OrdinalIgnoreCase)
                          select bd;
            if(kttenBD.Count()==0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int DangKyThi(int mand)
        {
            try {
                DangKi a = new DangKi();
                string ngay = DateTime.Today.Day.ToString();
                string thang = DateTime.Today.Month.ToString();
                string nam = DateTime.Today.Year.ToString();
                string ngaydk = thang + "/" + ngay + "/" + nam;
                DateTime dtime = new DateTime(2018, 12, 27);
                //string formattedStrings = dti
                a.NgayDangKy = DateTime.Today;
                a.TinhTrang = false;
                a.MaNguoiDung = mand;
                var prolist = thi.BoDes.ToList(); // lấy tất cả sản phẩm
                int count = prolist.Count();
                int index = new Random().Next(count); // lấy random từ 0 => count nhằm mục đính lấy random trong danh sách Product
                BoDe pro = prolist.Skip(index).FirstOrDefault();
                // dùng Skip để lấy Product thứ index
                a.MaBoDe = pro.MaBoDe;
                thi.DangKis.InsertOnSubmit(a);
                thi.SubmitChanges();
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        public List<CauHoi> LoadCauHoi(int mach)
        {
            return thi.CauHois.Where(t => t.MaCauHoi == mach).ToList<CauHoi>();
        }
        public void UpdateCTKQ(int mactkq,string kq)
        {
            ChiTietKetQua ct = thi.ChiTietKetQuas.Where(t => t.MaChiTietKQ == mactkq).FirstOrDefault();
            if (ct != null)
            {
                
                ct.DapAnChon = kq;
                string[] dapan = kq.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                
                CauHoi ch = thi.CauHois.Where(t => t.MaCauHoi == ct.MaCauHoi).FirstOrDefault();
                string dp = ch.DapAnDung.ToString().Trim() + ",";
                string[] source = dp.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int dem = 0;
                for (int i = 0; i < source.Length; i++)
                {
                    var matchQuery = from word in dapan
                                     where word == source[i]
                                     select word;
                    dem = matchQuery.Count();
                }
                if (dem == dapan.Length)
                {
                    ct.KetQua = true;
                }
                else
                {
                    ct.KetQua = false;
                }
                thi.SubmitChanges();
            }
        }
        public void UpdateKQ(int makq,int mand)
        {
            var dung = from kq in thi.ChiTietKetQuas
                     where kq.MaKetQua == makq && kq.KetQua==true
                     select kq;
            var sai = from kq in thi.ChiTietKetQuas
                     where kq.MaKetQua == makq && kq.KetQua==false
                     select kq;
            KetQua ketqua = thi.KetQuas.Where(t => t.MaKetQua == makq).FirstOrDefault();
            if (ketqua != null)
            {
                ketqua.DapAnSai = sai.Count();
                ketqua.DapAnDung = dung.Count();
                
            }
            DangKi dangki = thi.DangKis.Where(t => t.MaNguoiDung == mand && t.TinhTrang == false).FirstOrDefault();
            if (dangki != null)
            {
                dangki.TinhTrang = true;
            }
            thi.SubmitChanges();
        }
        public List<KetQua> LoadKQ(int makq)
        {
            return thi.KetQuas.Where(t => t.MaKetQua == makq).ToList<KetQua>();
        }

    }
}
