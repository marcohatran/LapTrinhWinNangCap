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

namespace ThiTracNghiemWindows
{
    public partial class QL_CauHoi : DevExpress.XtraEditors.XtraUserControl
    {
        public QL_CauHoi()
        {
            InitializeComponent();
        }

        private void cauHoiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cauHoiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLThiBangLai);

        }

        private void QL_CauHoi_Load(object sender, EventArgs e)
        {
            this.cauHoiTableAdapter.Fill(this.qLThiBangLai.CauHoi);
        }
    }
}
