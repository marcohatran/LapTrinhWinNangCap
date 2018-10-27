using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using BLL;

namespace ThiTracNghiemWindows
{
    public partial class FrmQLnguoidung : UserControl
    {
        XuLy xl = new XuLy();
        DataTable quyen = new DataTable();
        public FrmQLnguoidung()
        {
            InitializeComponent();
        }
        public void loadgv()
        {
            DataTable dt = xl.loadnguoidung();
            gv_taikhoan.DataSource = dt;
            loadcapquyen(gv_cttk.GetRowCellValue(gv_cttk.FocusedRowHandle, "MaNguoiDung").ToString().Trim());
        }
        private void FrmQLnguoidung_Load(object sender, EventArgs e)
        {
            loadgv();
            gv_cttk.FocusedRowChanged += gv_cttk_FocusedRowChanged;
            gv_phanquyen.FocusedRowChanged += gv_phanquyen_FocusedRowChanged;
            gv_cttk.FocusedRowHandle = 0;
        }

        void gv_phanquyen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            gioithieu.Text = quyen.Rows[gv_phanquyen.FocusedRowHandle]["GhiChu"].ToString();
        }
        public void loadcapquyen(string taikhoan)
        {
            quyen = xl.loadtttk(taikhoan);
            gv_quyen.DataSource = quyen;
        }
        void gv_cttk_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //gv_dssv.GetRowCellValue(gv_dssv.FocusedRowHandle, "MASV").ToString();
            if (string.Compare(gv_cttk.GetRowCellValue(gv_cttk.FocusedRowHandle, "TinhTrang").ToString(), "True") == 0)
            {
                rd_true.Checked = true;
            }
            else
            {
                rd_false.Checked = true;
            }
            loadcapquyen(gv_cttk.GetRowCellValue(gv_cttk.FocusedRowHandle, "MaNguoiDung").ToString().Trim());
        }

        private void btn_change_Click(object sender, EventArgs e)
        {

            if (rd_true.Checked == true)
            {
                xl.frmqltk_khoatk(gv_cttk.GetRowCellValue(gv_cttk.FocusedRowHandle, "MaNguoiDung").ToString(), "True");
            }
            else
            {
                xl.frmqltk_khoatk(gv_cttk.GetRowCellValue(gv_cttk.FocusedRowHandle, "MaNguoiDung").ToString(), "False");
            }
            loadgv();
        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            loadgv();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            
        }
        private void gv_phanquyen_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           // MessageBox.Show(e.Value.ToString() + e.RowHandle.ToString() + quyen.Rows[e.RowHandle]["MaNguoiDungManHinh"].ToString(), "sdsadsd");
            int check = xl.updatequyen(quyen.Rows[e.RowHandle]["MaNguoiDungManHinh"].ToString(), e.Value.ToString(), int.Parse(quyen.Rows[e.RowHandle]["MaManHinh"].ToString()), quyen.Rows[e.RowHandle]["MaNguoiDung"].ToString());
            if (check == 1)
            {
                MessageBox.Show("Cấp quyền không thành công");
            }
            loadcapquyen(gv_cttk.GetRowCellValue(gv_cttk.FocusedRowHandle, "MaNguoiDung").ToString().Trim());
        }

   
    }
}
