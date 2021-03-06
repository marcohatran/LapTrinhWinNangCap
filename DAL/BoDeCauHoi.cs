﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class BoDeCauHoi
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        public void ThemBD(string tenbd, string gchu)
        {
            conn.Open();
            string them = "insert into BoDe (TenBoDe,GhiChu,DaXoa) values (N'" + tenbd + "',N'" + gchu + "',0)";
            SqlCommand cmd = new SqlCommand(them, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void capnhat(string mabd, string tenbd, string gchu, int th)
        {
            conn.Open();
            string update;
            if (th == 0)
            {
                update = "update BoDe set DaXoa = 1 where MaBoDe = " + mabd;
            }
            else
            {
                update = "update BoDe set TenBoDe =N'" + tenbd + "', GhiChu=N'" + gchu + "'  where MaBoDe = " + mabd;
            }
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable LoadChiTiet(string mabode)
        {
            DataTable dt = new DataTable();
            string sl = "select * from  ChiTietBoDe ct,LoaiCauHoi l, CauHoi ch ";
            sl += "where l.MaLoaiCauHoi=ch.MaLoaiCauHoi and ch.MaCauHoi=ct.MaCauHoi and ";
            sl += "ct.MaBoDe=" + mabode;
            sl += " and (ct.DaXoa IS NULL or ct.DaXoa in ('False',0)) order by ct.MaChiTietBoDe";
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            dta.Fill(dt);
            return dt;
        }
        public void CapPhat(string mabd)
        {
            //string sl = "select TOP 20* from CauHoi order by NEWID()";
            //SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            //DataTable dt = new DataTable();
            //dta.Fill(dt);
            var tableLuatGT = getRamDonCauHoi("Luật giao thông", 10);
            var tableSaHinh = getRamDonCauHoi("Sa hình", 5);
            var tableBienBao = getRamDonCauHoi("Biển báo giao thông", 5);
            //var dt = tableBienBao.Merge(tableSaHinh.Merge(tableBienBao));

            //merge table
            tableLuatGT.Merge(tableSaHinh);
            tableLuatGT.Merge(tableBienBao);
            var dt = tableLuatGT;
            conn.Open();
            string insert = "insert into ChiTietBoDe(MaBoDe,MaCauHoi,DaXoa) values ";
            foreach (DataRow dr in dt.Rows)
            {
                insert += "(" + mabd + "," + dr["MaCauHoi"].ToString() + ",0),";
            }
            insert = insert.Substring(0, insert.Length - 1);
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getRamDonCauHoi(string loaiCauHoi, int count)
        {
            DataTable dt = new DataTable();
            string sl = "select top " + count +
                        "* from CauHoi c, LoaiCauHoi h" +
                        " where c.MaLoaiCauHoi = h.MaLoaiCauHoi and " +
                        " h.TenLoaiCauHoi = N'" + loaiCauHoi + "'" +
                        " and (c.DaXoa is null or c.DaXoa =0) " +
                        " order by NEWID()";
            if (conn.State == ConnectionState.Open)
                conn.Open();
            SqlDataAdapter dta = new SqlDataAdapter(sl, conn);
            dta.Fill(dt);
            if (conn.State == ConnectionState.Closed)
                conn.Close();
            return dt;

        }

    }
}
