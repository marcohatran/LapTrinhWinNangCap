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

namespace BLL
{
    public partial class CauTraLoi : DevExpress.XtraEditors.XtraUserControl
    {
        public CauTraLoi()
        {
            InitializeComponent();
        }
        string cauhoi;

        public string Cauhoi
        {
            get { return cauhoi; }
            set { cauhoi = value; }
        }
        public CauTraLoi(int ch)
        {
            InitializeComponent();
            cauhoi = ch.ToString();
        }
        int thaydoi = 0;
        private void CauTraLoi_Load(object sender, EventArgs e)
        {
            lb_cauhoi.Text = "Câu " +cauhoi;
            rdg_trl.SelectedIndex = -1;
            rdg_trl.Left = 54;
        }

        private void rdg_trl_SelectedIndexChanged(object sender, EventArgs e)
        {
            thaydoi++;
            if (thaydoi > 1)
            {
                //Đổi màu thì cần qua bên PMThi đổi phần selected nha
                ((DevExpress.XtraEditors.RadioGroup)sender).BackColor = Color.Yellow;
               // ((DevExpress.XtraEditors.RadioGroup)sender).SelectedIndex.ToString();
            }
        }
    }
}
