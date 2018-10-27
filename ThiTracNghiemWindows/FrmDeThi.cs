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
    public partial class FrmDeThi : DevExpress.XtraEditors.XtraUserControl
    {
        public FrmDeThi()
        {
            InitializeComponent();
            
        }

        private void cAUHOIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void FrmDeThi_Load(object sender, EventArgs e)
        {

        }
    }
}
