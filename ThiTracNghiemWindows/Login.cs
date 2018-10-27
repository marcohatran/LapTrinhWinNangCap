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

namespace ThiTracNghiemWindows
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            this.userControlDangNhap1.Login += UserControlDangNhap1_Login;
        }

        private void UserControlDangNhap1_Login(object sender, EventArgs e)
        {
            Program.mainform = new FrmMain(this.userControlDangNhap1.User);
            Program.mainform.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void userControlDangNhap1_Load(object sender, EventArgs e)
        {

        }
    }
}