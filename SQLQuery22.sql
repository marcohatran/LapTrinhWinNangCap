select MaBoDe,MaDangKy from DangKi where TinhTrang in (0,'False') and MaNguoiDung =9

select * from NguoiDung

select ch.* from CauHoi ch,ChiTietBoDe ct where ch.MaCauHoi=ct.MaCauHoi and  ct.MaBoDe=14 
and ch.DaXoa IS NULL or  ch.DaXoa in (0,'False')

select * from DangKi, KetQua where DangKi.MaDangKy=KetQua.MaDangKy and DangKi.MaNguoiDung=9 and KetQua.DaXoa in (0,'False') 
and DangKi.TinhTrang in (0,'False') or DangKi.TinhTrang IS NULL 

select * from ChiTietKetQua where MaKetQua=7

select * from DangKi
select ChiTietKetQua.MaCauHoi,ChiTietKetQua.DapAnChon,CauHoi.DapAnDung from ChiTietKetQua, CauHoi where ChiTietKetQua.MaCauHoi=CauHoi.MaCauHoi

select * from CauHoi where MaCauHoi=147
