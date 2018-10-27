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
using LinqToSql;
using DevExpress.Office.Utils;
using System.Collections;

namespace ThiTracNghiemWindows
{
    public partial class FrmTTSV : DevExpress.XtraEditors.XtraForm
    {
        string nd;
        DuLieu dl = new DuLieu();
        public FrmTTSV()
        {
            InitializeComponent();
        }
        public FrmTTSV(string mand)
        {
            InitializeComponent();
            nd = mand;
        }
        void loadTT(string mand)
        {
            List<ThongTinNguoiDung> arr = dl.LoaiND(int.Parse(mand));
            for (int i = 0; i < arr.Count; i++)
            {
                lb_ten.Text = arr[0].HoTen.ToString();
                lb_email.Text = arr[0].Email.ToString();
                if (arr[0].GioiTinh.ToString() == "1")
                {
                    lb_gioitinh.Text = "Nam";
                }
                else
                {
                    lb_gioitinh.Text = "Nữ";
                }
                lb_ngsinh.Text = arr[0].NgaySinh.ToString().Substring(0,10);
                lb_sdt.Text = arr[0].SDT.ToString();
                //pic anh
            }
        }
        private void FrmTTSV_Load(object sender, EventArgs e)
        {
            btnXacNhan.BackColor = Color.Red;
            loadTT(nd);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int a = dl.CheckDangKy(int.Parse(nd));
            if (a == 1)
            {
                DialogResult r = MessageBox.Show("Bạn cần đăng ký lịch thi để được thi", "Đăng ký thi?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.OK)
                {
                    int dk = dl.DangKyThi(int.Parse(nd));
                    if (dk == 0)
                    {
                        MessageBox.Show("Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }

            if (a == 2)
            {
                FrmPMThi frmthi = new FrmPMThi(int.Parse(nd));
                frmthi.Show();
                this.Visible = false;
            }
            if(a==0)
            {
                MessageBox.Show("Bạn đã thi rồi nha");
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát chương trình ?", "Thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
             if (r == DialogResult.OK)
             {
                 Login lgin = new Login();
                 lgin.Show();
                 this.Close();
             }
        }
    }
}