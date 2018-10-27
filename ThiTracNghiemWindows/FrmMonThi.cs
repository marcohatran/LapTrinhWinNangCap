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

namespace ThiTracNghiemWindows
{
    public partial class FrmMonThi : DevExpress.XtraEditors.XtraForm
    {
        public FrmMonThi()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmMonThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_ThiTracNghiemDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qL_ThiTracNghiemDataSet.MONHOC);
          

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_ThiTracNghiemDataSet);

        }
    }
}