select * from BoDe
where MaBoDe not in (select MaBoDe from ChiTietBoDe group by MaBoDe)

select * from LoaiCauHoi

select * from CauHoi


select * from  ChiTietBoDe ct,LoaiCauHoi l, CauHoi ch 
where l.MaLoaiCauHoi=ch.MaLoaiCauHoi and ch.MaCauHoi=ct.MaCauHoi and ct.MaBoDe=1  and (ct.DaXoa IS NULL or ct.DaXoa in ('False',0))
order by ct.MaChiTietBoDe

select TOP 20* from CauHoi order by NEWID()
select * from ChiTietBoDe

insert into ChiTietBoDe(MaBoDe,MaCauHoi,DaXoa) 
values (1,1,0),(1,1,0)

insert into ChiTietBoDe(MaBoDe,MaCauHoi,DaXoa) 
values (7,21,0),(7,45,0),(7,104,0),(7,34,0),
(7,81,0),(7,26,0),(7,53,0),(7,119,0),(7,30,0),
(7,52,0),(7,140,0),(7,129,0),(7,89,0),(7,141,0),
(7,23,0),(7,116,0),(7,44,0),(7,51,0),(7,13,0),
(7,63,0)


