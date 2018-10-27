using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ThiTracNghiemWindows
{
    public partial class FrmQLtheophong : DevExpress.XtraEditors.XtraUserControl
    {
        Cls_qlphong qlp = new Cls_qlphong();
        public FrmQLtheophong()
        {
            InitializeComponent();
        }

        private void gb_chucnangphong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmQLtheophong_Load(object sender, EventArgs e)
        {
            DataTable dt = qlp.loadphong();
            int x = dt.Rows.Count;
            for (int i = 0; i < x; i++)
            {
                //Button btn = new Button();
                //btn.Size = new Size(50, 50);
                //btn.Name = "btn" + i.ToString();
                //btn.Left = btn.Left + 70;
                //btn.Top = 70;
                Phongthi pt = new Phongthi();
                pt.Left = i*130;
                pt.Top = 30;
                pt.Tag = dt.Rows[i]["MAPHONG"].ToString();
                pt.Tenphong = dt.Rows[i]["MAPHONG"].ToString();
                string ssv =dt.Rows[i]["SOSV"].ToString();
                string ss = dt.Rows[i]["SISO"].ToString();
                pt.Sosv = "Số TS: " + ss.ToString() + "/" + ssv.ToString();
                gb_controlsphong.Controls.Add(pt);
                pt.ButtonClick+=new EventHandler(loaddsts);
            }
        }
        private void loaddsts(object sender, EventArgs e)
        {
            //XuLy xl = new XuLy();
            //DataTable dt=xl.check_usphong(((DevExpress.XtraEditors.SimpleButton)sender).Tag.ToString());
            //gv_dssvthi.DataSource = dt;
        }
    }
}
