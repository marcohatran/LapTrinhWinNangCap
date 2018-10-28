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
using LinqToSql;

namespace ThiTracNghiemWindows
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Addusercontrol clsaddtab = new Addusercontrol();
        DuLieu dl = new DuLieu();
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
        void LoadND(string tk)
        {
            List<ThongTinNguoiDung> a = dl.LoadDLND(tk);
            if (a!=null)
            {
                lb_tendangnhap.Caption = "Chào mừng bạn " + a[0].HoTen + " đã đến với phần mềm!";
            }
            lb_ngaygio.Caption = DateTime.Now.ToString();
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void LoadQuyenMain(string a)
        {
            btn_cauhinh.Enabled = btn_qltaikhoan.Enabled = btn_doimatkhau.Enabled = btn_qlysinhvien.Enabled = btn_admin.Enabled = btn_qlphong.Enabled = btn_qltheomon.Enabled = btn_dethi.Enabled = true;
            List<NguoiDungManHinh> ndmh = dl.LoadQuyen(a);
            for (int i = 0; i < ndmh.Count; i++)
            {
                if (ndmh[i].TinhTrang == false)
                {
                    if (i == 2)
                    {
                        btn_cauhinh.Enabled = false;
                    }
                    if (i == 3) { btn_qltaikhoan.Enabled = false; }
                    if (i == 4) { btn_doimatkhau.Enabled = false; }
                    if (i == 5) { btn_qlysinhvien.Enabled = btn_admin.Enabled = false; }
                    if (i == 6) { btn_qlphong.Enabled = false; }
                    if (i == 7) { btn_qltheomon.Enabled = false; }
                    if (i == 8) { btn_dethi.Enabled = false; }
                   // if (i == 9) { btn_qltaikhoan.Enabled = false; }
                }
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            btn_dangxuat.ItemClick += btn_dangxuat_ItemClick;
            btn_qltaikhoan.ItemClick += btn_qltaikhoan_ItemClick;
            btn_doimatkhau.ItemClick += btn_doimatkhau_ItemClick;
            taikhoandangnhap.Caption = taikhoan;
            LoadND(taikhoan);
            clsaddtab.AddTab(tab_hienthi, "", "", new BackgroundMain());
            timer1.Start();
            LoadQuyenMain(taikhoan);
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
            Login lgin = Program.loginform;
            if(lgin==null)
            {
                lgin = new Login();
            }
            lgin.Show();
            this.Hide();
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

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in tab_hienthi.TabPages)
            {
                if (tab.Text == "Nhóm thực hiện")
                {
                    tab_hienthi.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t == 1)
            {

            }
            else
            {
                // Nếu chưa có TAb này thì gọi hàm Addtab xây dựng ở trên để Add Tab con vào
                clsaddtab.AddTab(tab_hienthi, "", "Nhóm thực hiện", new FrmThongTinNhom());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_ngaygio.Caption = DateTime.Now.ToString();
        }
    }
}