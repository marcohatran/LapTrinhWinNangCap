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
        public List<ThongTinNguoiDung> LoaiND(int mand)
        {
            return thi.ThongTinNguoiDungs.Where(t => t.MaNguoiDung == mand).ToList();
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
                          where bd.TenBoDe == TenBoDe && bd.DaXoa != true
                          select bd;
            if (kttenBD.Count() == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int CheckTenTaiKhoan(string tenTK)
        {
            var kttenTK = from tentk in thi.NguoiDungs
                          where tentk.TaiKhoan == tenTK
                          select tenTK;
            if (kttenTK.Count() == 0)
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
            try
            {
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
        public void UpdateCTKQ(int mactkq, string kq)
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
        public void UpdateKQ(int makq, int mand)
        {
            var dung = from kq in thi.ChiTietKetQuas
                       where kq.MaKetQua == makq && kq.KetQua == true
                       select kq;
            var sai = from kq in thi.ChiTietKetQuas
                      where kq.MaKetQua == makq && kq.KetQua == false
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
        public void XoaChiTietBoDe(int maBoDe)
        {
            var listCT = thi.ChiTietBoDes.Where(t => t.MaBoDe == maBoDe).ToList();
            foreach (var chiTiet in listCT)
            {
                chiTiet.DaXoa = true;
            }
            thi.SubmitChanges();
        }

        //Phần xữ lý đăng kí thi 
        public int CheckRot(int madk)
        {
            var a = thi.KetQuas.Where(t => t.MaDangKy == madk);
            if (a == null)
            {
                return 1;
            }
            else
            {
                foreach (var x in a)
                {
                    if (x.DapAnDung > 15)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
                return 4;
            }

        }
        public int CheckDangKi(int mand)
        {
            int giatritrave = 0;
            var a = thi.DangKis.Where(t => t.MaNguoiDung == mand).ToList<DangKi>();
            //Trường hợp chưa đăng kí thi
            if (a.Count == 0)
            {
                giatritrave = 0;
            }
            //Có đăng kí thi và xét thêm trường hợp bên Kết Quả
            else
            {
                //TH đăng kí rồi mà chưa thi
                if (a[0].TinhTrang == false)
                {
                    giatritrave = 1;
                }
                else
                {
                    for (int i = 0; i < a.Count; i++)
                    {
                        int x = CheckRot(a[i].MaDangKy);
                        //TH Đậu
                        if (x == 3)
                        {
                            giatritrave = 3;
                            break;
                        }
                        //TH rớt
                        if (x == 2)
                        {
                            giatritrave = 2;
                            break;
                        }
                    }
                }
            }
            return giatritrave;
        }
        public List<ThongTinNguoiDung> LoadChuaDK(int gtri, int stt)
        {
            if (stt == 0)
            {
                ThongTinNguoiDung ttnd = new ThongTinNguoiDung();
                var ts = (from tt in thi.ThongTinNguoiDungs
                          from nd in thi.NguoiDungs
                          from mh in thi.NguoiDungManHinhs
                          where tt.MaNguoiDung == nd.MaNguoiDung && nd.MaNguoiDung == mh.MaNguoiDung
                          && mh.MaManHinh == 2 && mh.TinhTrang == true && nd.MaNguoiDung != 1
                          select tt).ToList<ThongTinNguoiDung>();
                for (int tx = 0; tx < ts.Count(); tx++)
                {
                    int gt = CheckDangKi(int.Parse(ts[tx].MaNguoiDung.Value.ToString()));
                    if (gt == 3 || gt == 1)
                    {
                        ts.RemoveAt(tx);
                        tx--;
                    }
                }
                return ts.ToList();
            }
            else
            {
                ThongTinNguoiDung ttnd = new ThongTinNguoiDung();
                var ts = (from tt in thi.ThongTinNguoiDungs
                          from nd in thi.NguoiDungs
                          from mh in thi.NguoiDungManHinhs
                          where tt.MaNguoiDung == nd.MaNguoiDung && nd.MaNguoiDung == mh.MaNguoiDung
                          && mh.MaManHinh == 2 && mh.TinhTrang == true && nd.MaNguoiDung == gtri
                          select tt).ToList<ThongTinNguoiDung>();
                for (int i = 0; i < ts.Count; i++)
                {
                    int gt = CheckDangKi(int.Parse(ts[i].MaNguoiDung.Value.ToString()));
                    if (gt == 3 || gt == 1)
                    {
                        ts.RemoveAt(i);
                    }
                }
                return ts.ToList();
            }
        }
        public List<ThongTinNguoiDung> LoadNDThi(int madk)
        {
            var ttin = (from dk in thi.DangKis
                        from nd in thi.NguoiDungs
                        from tt in thi.ThongTinNguoiDungs
                        where dk.MaDangKy == madk && nd.MaNguoiDung == dk.MaNguoiDung && nd.MaNguoiDung == tt.MaNguoiDung
                        select tt).ToList();
            return ttin;
        }
        public List<DK> LoadDK()
        {
            List<DK> dsdk = new List<DK>();
            var ts = (from tt in thi.ThongTinNguoiDungs
                      from nd in thi.NguoiDungs
                      from dk in thi.DangKis
                      from mh in thi.NguoiDungManHinhs
                      where tt.MaNguoiDung == nd.MaNguoiDung && nd.MaNguoiDung == mh.MaNguoiDung
                      && mh.MaManHinh == 2 && mh.TinhTrang == true && nd.MaNguoiDung != 1 && dk.MaNguoiDung == nd.MaNguoiDung
                      select new { MaDK = dk.MaDangKy, MaDe = dk.MaBoDe, HoTen = tt.HoTen, Mail = tt.Email, TT = dk.TinhTrang, Ngay = dk.NgayDangKy }).ToList();
            foreach (var gt in ts)
            {
                DK dk = new DK(gt.MaDK, gt.MaDe, gt.HoTen, gt.Mail, gt.TT, gt.Ngay);
                dsdk.Add(dk);
            }
            return dsdk;

        }

        public List<LoaiCauHoi> LoaddlCH()
        {
            return thi.LoaiCauHois.Select(t => t).ToList<LoaiCauHoi>();
        }
        public List<CauHoi> LoadCauHoi()
        {

            return thi.CauHois.Where(t=>t.DaXoa!=true || t.DaXoa==null).ToList<CauHoi>();
        }
        public void Them(int them, int loaich, string ndch, string a, string b, string c, string d, string dadung, string hinh)
        {
            if (them == 0)
            {
                CauHoi ch = new CauHoi();
                ch.MaLoaiCauHoi = loaich;
                ch.NoiDungCauHoi = ndch;
                ch.DapAnA = a;
                ch.DapAnB = b;
                ch.DapAnC = c;
                ch.DapAnD = d;
                ch.DapAnDung = dadung;
                ch.HinhAnh = hinh;
                ch.DaXoa = false;
                thi.CauHois.InsertOnSubmit(ch);
                thi.SubmitChanges();
            }
            else
            {
                CauHoi ch = thi.CauHois.Where(t => t.MaCauHoi == them).FirstOrDefault();
                if (ch != null)
                {
                    ch.NoiDungCauHoi = ndch;
                    ch.DapAnA = a;
                    ch.DapAnB = b;
                    ch.DapAnC = c;
                    ch.DapAnD = d;
                    ch.DapAnDung = dadung;
                    if (hinh != "")
                    {
                        ch.HinhAnh = hinh;
                    }
                    ch.DaXoa = false;
                    thi.SubmitChanges();
                }
            }
        }
        public void Xoa(int MaCH)
        {
            CauHoi ch = thi.CauHois.Where(t => t.MaCauHoi == MaCH).FirstOrDefault();
            if (ch != null)
            {
                ch.DaXoa = true;
                thi.SubmitChanges();
            }
        }

        public List<KQ> ShowKQ()
        {
            List<KQ> diem = new List<KQ>();
            var kqua = (from kq in thi.KetQuas
                        from dk in thi.DangKis
                        from nd in thi.NguoiDungs
                        from tt in thi.ThongTinNguoiDungs
                        where kq.MaDangKy == dk.MaDangKy && dk.MaNguoiDung == nd.MaNguoiDung
                        && nd.MaNguoiDung == tt.MaNguoiDung
                        select new
                        {
                            MaDK = dk.MaDangKy,
                            MaKQ = kq.MaKetQua,
                            GhiChu = kq.GhiChu,
                            HoTen = tt.HoTen,
                            NgayDK = dk.NgayDangKy,
                            NgayLam = kq.NgayLam,
                            DapanDung = kq.DapAnDung,
                            DapanSai = kq.DapAnSai
                        }).ToList();
            foreach (var gt in kqua)
            {
                KQ dk = new KQ(gt.MaDK, gt.GhiChu, gt.MaKQ, gt.HoTen, gt.NgayDK, gt.NgayLam, gt.DapanDung, gt.DapanSai);
                diem.Add(dk);
            }
            return diem;
        }
    }
}
