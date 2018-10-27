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
using BLL;

namespace ThiTracNghiemWindows
{
    public partial class FrmChangPass : DevExpress.XtraEditors.XtraForm
    {
        string taikhoan;
        XuLy xl = new XuLy();
        public string Taikhoan
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }
        public FrmChangPass()
        {
            InitializeComponent();
        }
        public FrmChangPass(string taikhoan)
        {
            this.taikhoan = taikhoan;
            InitializeComponent();
        }
        private void FrmChangPass_Load(object sender, EventArgs e)
        {
            DataTable dt = xl.cbtaikhoan();
            cb_taikhoan.DataSource = dt;
            cb_taikhoan.DisplayMember = "HoTen";
            cb_taikhoan.ValueMember = "TaiKhoan";
            int a = xl.ktrtk(taikhoan);
            if (a == 1)
            {
                cb_taikhoan.SelectedValue = taikhoan;
                cb_taikhoan.Enabled = false;
                btn_doimk.Text = "Đổi mật khẩu";
                txt_mkmoi.Enabled = txt_mkxn.Enabled = txt_mkht.Enabled = true;
            }
            else
            {
                cb_taikhoan.Enabled = true;
                btn_doimk.Text = "Reset";
                txt_mkmoi.Enabled = txt_mkxn.Enabled = txt_mkht.Enabled = false;
            }
        }
        private void btn_doimk_Click(object sender, EventArgs e)
        {
            int i = -1;
            if (btn_doimk.Text == "Reset")
            {
                i = xl.Doimatkhau(0, cb_taikhoan.SelectedValue.ToString().Trim(), txt_mkht.Text.ToString().Trim(), txt_mkmoi.Text.ToString().Trim(), txt_mkxn.Text.ToString().Trim());

            }
            else
            {
                if (txt_mkht.Text == "" || txt_mkmoi.Text == "" || txt_mkxn.Text == "")
                {
                    MessageBox.Show("Điền đầy đủ thông tin mật khẩu");
                }
                else
                {
                    if (txt_mkxn.Text == txt_mkmoi.Text)
                    {
                        i = xl.Doimatkhau(1, cb_taikhoan.SelectedValue.ToString().Trim(), txt_mkht.Text.ToString().Trim(), txt_mkmoi.Text.ToString().Trim(), txt_mkxn.Text.ToString().Trim());
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận lại mật khẩu");
                    }
                }
            }
            if (i == 0)
            {
                MessageBox.Show(btn_doimk.Text.ToString() + "\t tài khoản của " + cb_taikhoan.Text.ToString() + "  thành công");
            }
            else
            {
                MessageBox.Show(btn_doimk.Text.ToString() + "\t tài khoản của " + cb_taikhoan.Text.ToString() + "  thất bại");
            }

        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_taikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_taikhoan.SelectedIndex == 0)
            {
                btn_doimk.Text = "Đổi mật khẩu";
                txt_mkmoi.Enabled = txt_mkxn.Enabled = txt_mkht.Enabled = true;
            }
        }

    }
}