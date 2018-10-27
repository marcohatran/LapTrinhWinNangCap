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
using System.Data.SqlClient;
using System.Configuration;
using BLL;

namespace ThiTracNghiemWindows
{
    public partial class UserControlDangNhap : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy xl = new XuLy();
        public UserControlDangNhap()
        {
            InitializeComponent();
        }
        public string User { get; set; }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
            {
                return;
            }
            KiemTraDangNhap(sender,e);
        }
        public event EventHandler Login;
        private void KiemTraDangNhap(object sender, EventArgs e)
        {
            //kiem tra chuoi ket noi
            int kn = KiemTraChuoiKetNoi();
            if (kn == 0 || kn == 2)
            {
                //ket noi lai
                FrmChangCauHinh cauHinh = new FrmChangCauHinh();
                cauHinh.ShowDialog();
            }
            else if (kn == 1)
            {
                //Dang Nhap
                string user = txtUser.Text;
                string pass = txtPass.Text;
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
                SqlCommand cm = new SqlCommand
                {
                    Connection = connection, //truyen connection
                    CommandText = "select * from NguoiDung where TaiKhoan = @TaiKhoan and MatKhau = @MatKhau" //truyen parameter
                };
                cm.Parameters.Add(new SqlParameter("@TaiKhoan", user));
                cm.Parameters.Add(new SqlParameter("@MatKhau", pass));
                SqlDataAdapter dta = new SqlDataAdapter(cm); // nguon nuoc
                DataTable dt = new DataTable(); //  thung chua
                dta.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("User OR Pass incorect");
                }
                else
                {
                    DataRow dr = dt.Rows[0];
                    if (dr["TinhTrang"].ToString() == bool.TrueString)
                    {
                        //lock
                        MessageBox.Show("Tai khoan bi khoa");
                    }
                    else
                    {
                        int formdangnhap = xl.checkmanhinh(dt.Rows[0][0].ToString());
                        if (formdangnhap == 0)
                        {
                            //Program.mainform = new FrmMain(txtUser.Text);
                            //Program.mainform.Show();
                            User = user;
                            Login(sender, e);

                        }
                        if (formdangnhap == 4)
                        {
                            MessageBox.Show("Tài khoản bạn không có quyền quản trị yêu cầu liên hệ Admin cấp quyền");
                        }
                        if(formdangnhap==2)
                        {
                            Program.ttsv = new FrmTTSV(dr["MaNguoiDung"].ToString());
                            Program.ttsv.Show();
                        }
                        if (formdangnhap == 3)
                        {
                            MessageBox.Show("Tài khoản đã khóa quyền thi");
                        }

                        //this.Visible = false ;
                    }
                }
            }
            //false : open form ket noi sql
            // true: kiem tra tk, mk, status cua username

            ///->> sai tk or mk
            ///->> dung va status -> flase -> tk bi block
            ///->> dung va status != false -> open form Home

        }
        private int KiemTraChuoiKetNoi()
        {
            //string chuoiKetNoi = Properties.Settings.Default.FormDangNhap; // lay chuoi ket noi
            string chuoiKetNoi = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            if (string.IsNullOrWhiteSpace(chuoiKetNoi)) // null or rong
            {
                return 0;
            }
            SqlConnection connection = new SqlConnection(chuoiKetNoi);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    return 1;   //ket noi thanh cong
                }
            }
            catch (Exception)
            {

                return 2;//chuoi ket noi sai
            }
            return int.MaxValue;

        }
        private bool CheckValid()
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Username không được rỗng");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Password không được rỗng!");
                return false;
            }
            return true;
        }
    }
}
