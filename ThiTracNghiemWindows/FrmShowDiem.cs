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

namespace ThiTracNghiemWindows
{
    public partial class FrmShowDiem : DevExpress.XtraEditors.XtraForm
    {
        int ketqua;
        DuLieu dlieu = new DuLieu();
        public FrmShowDiem()
        {
            InitializeComponent();
        }
        public FrmShowDiem(int makq)
        {
            InitializeComponent();
            ketqua = makq;
        }
        void LoadKQ(int a)
        {
            List<KetQua> kq = dlieu.LoadKQ(a);
            lb_caudung.Text = kq[0].DapAnDung.Value.ToString();
            lb_causai.Text = kq[0].DapAnSai.Value.ToString();
            lb_ngaylam.Text = kq[0].NgayLam.Value.ToShortDateString();
            lb_ketqua.Text = kq[0].GhiChu.ToString();
            if (kq[0].DapAnDung.Value>15)
            {
                string nameImage = "Pass.png";
                if (!string.IsNullOrWhiteSpace(nameImage))
                {
                    pic_kq.ImageLocation = "../../Images" + "/" + nameImage;
                } 
            }
            else
            {
                string nameImage = "Fail.png";
                if (!string.IsNullOrWhiteSpace(nameImage))
                {
                    pic_kq.ImageLocation = "../../Images" + "/" + nameImage;
                } 
            }
        }
        private void FrmShowDiem_Load(object sender, EventArgs e)
        {
            LoadKQ(ketqua);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Login lgin = Program.loginform;
            if (lgin != null)
            {
                Program.loginform.Show();
            }
            this.Close();
        }
    }
}