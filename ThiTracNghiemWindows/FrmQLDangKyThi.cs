using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LinqToSql;

namespace ThiTracNghiemWindows
{
    public partial class FrmQLDangKyThi : DevExpress.XtraEditors.XtraUserControl
    {
        DuLieu dl;
        public FrmQLDangKyThi()
        {
            InitializeComponent();
        }
       
        void LoadDLTSThi(int madk)
        {
            List<ThongTinNguoiDung> tt = dl.LoadNDThi(madk);
            lb_ht.Text = tt[0].HoTen.ToString();
            lb_ngaysinh.Text = tt[0].NgaySinh.Value.ToShortDateString();
            lb_sdt.Text = tt[0].SDT.ToString();
            lb_email.Text = tt[0].Email.ToString();
            lb_diachi.Text = tt[0].DiaChi.ToString();
            lb_ngaydk.Text = gv_dsdk.GetFocusedRowCellValue("NgayDK").ToString().Substring(0,10);
            if (tt[0].Hinh != null)
            {
                string nameImage = tt[0].Hinh.ToString() ;
                if (!string.IsNullOrWhiteSpace(nameImage))
                {
                    pic_anh.ImageLocation = "../../Images" + "/" + nameImage;
                }
                else
                {
                    pic_anh.ImageLocation = string.Empty;
                }
            }
            else
            {
                pic_anh.ImageLocation = string.Empty;
            }
        }
        private void FrmQLDangKyThi_Load(object sender, EventArgs e)
        {
            dl= new DuLieu();
            LoadChuaThi(0,0);
        }
        void LoadChuaThi(int mand,int stt)
        {
            gv_chuadk.DataSource = dl.LoadChuaDK(mand,stt);
            gv_dsdk.FocusedRowHandle = -1;
            gv_dk.DataSource = dl.LoadDK();

        }
        private void gv_ctchuadk_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_ctchuadk.GetFocusedRowCellValue("Hinh") != null)
            {
                string nameImage = gv_ctchuadk.GetFocusedRowCellValue("Hinh").ToString();
                if (!string.IsNullOrWhiteSpace(nameImage))
                {
                    pic_hinh.ImageLocation = "../../Images" + "/" + nameImage;
                }
                else
                {
                    pic_hinh.ImageLocation = string.Empty;
                }

            }
            else
            {
                pic_hinh.ImageLocation = string.Empty;
            }
        }

        private void gv_dsdk_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_dsdk.FocusedRowHandle >= 0 && gv_dsdk.RowCount > 0)
            {
                LoadDLTSThi(int.Parse(gv_dsdk.GetFocusedRowCellValue("MaDK").ToString()));
            }
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            int a = dl.CheckDangKy(int.Parse(gv_ctchuadk.GetFocusedRowCellValue("MaNguoiDung").ToString()));
            if (a == 1)
            {
                DialogResult r = MessageBox.Show("Bạn cần đăng ký lịch thi để được thi", "Đăng ký thi?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.OK)
                {
                    int dk = dl.DangKyThi(int.Parse(gv_ctchuadk.GetFocusedRowCellValue("MaNguoiDung").ToString()));
                    if (dk == 0)
                    {
                        MessageBox.Show("Thành công");
                        LoadChuaThi(int.Parse(gv_ctchuadk.GetFocusedRowCellValue("MaNguoiDung").ToString()),1);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }
    }
}
