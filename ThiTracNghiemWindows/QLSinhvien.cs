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
using DevExpress.XtraEditors.Repository;
using System.Configuration;
using DAL;
using BLL;
using DevExpress.XtraGrid.Views.Grid;

namespace ThiTracNghiemWindows
{
    public partial class QLSinhvien : DevExpress.XtraEditors.XtraForm
    {
        Connection kn = new Connection();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ToString());
        Cls_qlsv clsv = new Cls_qlsv();
        XuLy xl = new XuLy();
        public QLSinhvien()
        {
            InitializeComponent();
        }
        public void loadlkup()
        {

            DataTable dt = clsv.loadlop();
            lk_lop.Properties.DataSource = dt;
            lk_lop.Properties.DisplayMember = "TENLOP";
            lk_lop.Properties.ValueMember = "MALOP";
            lk_lop.EditValue = "Lớp học";
            string sl1 = "select distinct GIOITINH from SINHVIEN";
            SqlDataAdapter dta1 = new SqlDataAdapter(sl1, kn.Conn);
            DataTable dt1 = new DataTable();
            dta1.Fill(dt1);
            lk_gioitinh.Properties.DataSource = dt1;
            lk_gioitinh.Properties.DisplayMember = "GIOITINH";
            lk_gioitinh.Properties.ValueMember = "GIOITINH";
            lk_gioitinh.EditValue = "Giới tính";
        }
        void loadgvsv()
        {
            string sl = "select * from SINHVIEN";
            SqlDataAdapter dta = new SqlDataAdapter(sl, kn.Conn);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            gv_sv.DataSource = dt;
        }
        private void QLSinhvien_Load(object sender, EventArgs e)
        {
            if (kn.check_connec() == 0)
            {
                if (kn.Conn.State == ConnectionState.Closed)
                    kn.Conn.Open();
                //  Đổ dữ liệu vào lookupedit lớp (tương tự combobox)
                loadlkup();
                // Đổ dữ liệu vào gridview
                loadgvsv();
                kn.Conn.Close();
                gv_dssv.FocusedRowChanged += gv_dssv_FocusedRowChanged;
                // Sự kiện các nút
                btn_lichthi.Click += btn_lichthi_Click;
                btn_xoa.Click += btn_xoa_Click;
                btn_sua.Click += btn_sua_Click;
                btn_huy.Click += btn_huy_Click;
                btn_them.Click += btn_them_Click;
                // Quản lý enable các nút
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
                btn_luu.Enabled = false;
                txt_mssvthi.ReadOnly = true;
               date_ngaysinh.Enabled= txt_mssv.Enabled=txt_hoten.Enabled=txt_diachi.Enabled=lk_gioitinh.Enabled= lk_monthi.Enabled = false;
                btn_themlichthi.Enabled = btn_xoalichthi.Enabled = btn_sualichthi.Enabled = btn_luulichthi.Enabled = lk_phongthi.Enabled = false;
            }
        }

        
        void btn_huy_Click(object sender, EventArgs e)
        {
            txt_mssvthi.Text = "";
            lk_monthi.SelectedText = "";
            lk_phongthi.SelectedText = "";
            btn_themlichthi.Enabled = btn_xoalichthi.Enabled = btn_sualichthi.Enabled = btn_luulichthi.Enabled = false;
        }

        void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
        }

        void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled=btn_luu.Enabled=btn_xoa.Enabled = false;
            btn_them.Enabled = true;
        }

        void btn_lichthi_Click(object sender, EventArgs e)
        {
            txt_mssvthi.Text = gv_dssv.GetRowCellValue(gv_dssv.FocusedRowHandle, "MASV").ToString();
            btn_themlichthi.Enabled = lk_monthi.Enabled = true;
            
        }

        void gv_dssv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            //Lấy tên cột theo tên trong CSDL không phải name đặt
             txt_mssv.Text = gv_dssv.GetRowCellValue(gv_dssv.FocusedRowHandle, "MASV").ToString();
            txt_hoten.Text = gv_dssv.GetRowCellValue(gv_dssv.FocusedRowHandle, "HOTEN").ToString();
            lk_lop.EditValue = gv_dssv.GetFocusedRowCellValue("MALOP");
            date_ngaysinh.Text = gv_dssv.GetFocusedRowCellValue("NGSINH").ToString();
            lk_gioitinh.EditValue = gv_dssv.GetFocusedRowCellValue("GIOITINH");
            txt_diachi.Text = gv_dssv.GetFocusedRowCellValue("DCHI").ToString();
            //pic_hinh.Image = Image.FromFile("Anh/" + gv_dssv.GetFocusedRowCellValue("HINH").ToString());
            //Nut
            txt_mssv.ReadOnly = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
          btn_luu.Enabled=  date_ngaysinh.Enabled= txt_hoten.Enabled = txt_diachi.Enabled = lk_lop.Enabled = lk_gioitinh.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_mssv.Text = txt_hoten.Text = txt_diachi.Text = string.Empty;
            date_ngaysinh.Text = null;
            lk_gioitinh.Text = null;
            txt_mssv.Enabled= date_ngaysinh.Enabled = txt_hoten.Enabled = txt_diachi.Enabled = lk_lop.Enabled = lk_gioitinh.Enabled = true;
            btn_xoa.Enabled=btn_sua.Enabled= btn_them.Enabled = false;
            btn_luu.Enabled = true;
        }

        private void txt_mssv_EditValueChanged(object sender, EventArgs e)
        {
            btn_xoa.Enabled = true;
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            //int kq = xl.themsinhvien(txt_mssv.Text.ToString(), lk_lop.EditValue.ToString(), txt_hoten.Text.ToString(), date_ngaysinh.Text.ToString(), lk_gioitinh.Text.ToString(), txt_diachi.Text.ToString());
            //if (kq == 0)
            //{
            //    MessageBox.Show("Thành công");
            //    loadgvsv();
            //}
        }
    }
}