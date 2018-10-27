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
using BLL;
using DAL;

namespace ThiTracNghiemWindows
{
    public partial class Phongthi : DevExpress.XtraEditors.XtraUserControl
    {
        XuLy xl = new XuLy();
        string tenphong;
        string sosv;
        public event EventHandler ButtonClick = null;
        public string Sosv
        {
            get { return sosv; }
            set { sosv = value; }
        }

        public string Tenphong
        {
            get { return tenphong; }
            set { tenphong = value; }
        }
        public Phongthi()
        {
            InitializeComponent();
        }

        private void Phongthi_Load(object sender, EventArgs e)
        {
            lb_tenphong.Text = tenphong.ToString();
            lb_sv.Text = sosv.ToString();
            btn_chitiet.Tag = lb_tenphong.Text.ToString();
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(sender, e);
            //xl.check_usphong(this.lb_tenphong.Text.ToString());
        }
        
       
    }
}
