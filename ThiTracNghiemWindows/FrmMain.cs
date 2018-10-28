using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using BLL;

namespace ThiTracNghiemWindows
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Addusercontrol clsaddtab = new Addusercontrol();
        string taikhoan;
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string tk) 
        {
            taikhoan = tk;
            InitializeComponent();
            FormClosed += FrmMain_FormClosed;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            btn_dangxuat.ItemClick += btn_dangxuat_ItemClick;
            btn_qltaikhoan.ItemClick += btn_qltaikhoan_ItemClick;
            btn_doimatkhau.ItemClick += btn_doimatkhau_ItemClick;
            taikhoandangnhap.Caption = taikhoan;
        }    
        void btn_doimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmChangPass doimk = new FrmChangPass(taikhoandangnhap.Caption.ToString());
            doimk.Show();
        }
        void btn_qltaikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DevExpress.XtraTab.XtraTabPage tab = new DevExpress.XtraTab.XtraTabPage();
            //tab.Name = "QLTaiKhoan ";
            //tab.Text = "Quản lý người dùng";
            //FrmQLnguoidung qltk = new  FrmQLnguoidung();
            //tab.Controls.Add(qltk);
            //qltk.Dock = DockStyle.Fill;
            //tab_hienthi.TabPages.Add(tab);
            // Kiểm tra khi bấm nút Sinh Viên: Nếu đã có TAb này rồi thì không Add vào nữa
            // mà nó sẽ chuyển focus tới TAb Sinh Viên này
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Quản lý người dùng")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Quản lý người dùng", new FrmQLnguoidung());
            }
        }
        void btn_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Login lgin = new Login();
            lgin.Show();
            this.Close();
        }
        private void btn_dethi_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Quản lý câu hỏi")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Quản lý câu hỏi", new FrmCauHoi());
            }
        }
        private void btn_dangxuat_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }
        private void btn_qltaikhoan_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }
        private void tab_hienthi_Click(object sender, EventArgs e)
        {

        }
        private void btn_cauhinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmChangCauHinh chang = new FrmChangCauHinh();
            chang.Show();
        }
        private void btn_qlysinhvien_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Quản lý thông tin người dùng")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Quản lý thông tin người dùng", new QLTTND() );
            }
        }
        private void btn_admin_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Quản lý thông tin người dùng")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Quản lý thông tin người dùng", new QLTTND());
            }
        }
        private void btn_qltheomon_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Bộ đề")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Bộ đề", new FrmBoDe());
            }
        }
        private void btn_qlphong_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Đăng kí thi")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Đăng kí thi", new FrmQLDangKyThi());
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Kết quả thi")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {// Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Kết quả thi", new FrmKetQua());
            }
        }
    }
}