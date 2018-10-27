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
    public partial class FrmGiaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        public FrmGiaoVien()
        {
            InitializeComponent();
            this.gIAOVIENTableAdapter.Fill(this.qL_ThiTracNghiemDataSet.GIAOVIEN);

        }

        private void gIAOVIENBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.gIAOVIENBindingSource1.EndEdit();
                this.tableAdapterManager.UpdateAll(this.qL_ThiTracNghiemDataSet);
            }
            catch
            {
                MessageBox.Show("Thao tác thất bại");
            }
           

        }

       
    }
}
