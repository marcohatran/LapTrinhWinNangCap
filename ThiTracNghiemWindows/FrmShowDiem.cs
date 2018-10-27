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
        }
        private void FrmShowDiem_Load(object sender, EventArgs e)
        {
            LoadKQ(ketqua);
        }
    }
}