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
using LinqToSql;

namespace ThiTracNghiemWindows
{
    public partial class FrmKetQua : DevExpress.XtraEditors.XtraUserControl
    {
        DuLieu dl = new DuLieu();
        public FrmKetQua()
        {
            InitializeComponent();
        }

        void LoadKQ()
        {
            gv_ketqua.DataSource = dl.ShowKQ();
        }
        private void KetQua_Load(object sender, EventArgs e)
        {
            LoadKQ();
        }


    }
}
