using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using LinqToSql;
namespace ThiTracNghiemWindows
{
    public partial class FrmBoDe : UserControl
    {
        XuLy xl = new XuLy();
        DuLieu dl = new DuLieu();
        public FrmBoDe()
        {
            InitializeComponent();
        }
        private void boDeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.boDeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLThiBangLai);
        } 
        void loadbd()
        {
            this.boDeTableAdapter.Fill(this.qLThiBangLai.BoDe);
        }
        private void FrmBoDe_Load(object sender, EventArgs e)
        {
            loadbd();
            btn_capphat.Enabled = false;
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tenBoDeTextEdit.Text == "" || ghiChuTextEdit.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {

                int a = xl.ThemBD(tenBoDeTextEdit.Text.ToString().Trim(), ghiChuTextEdit.Text.ToString().Trim());
                if (a != 0)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            loadbd();
            bam = 0;
        }
        int bam = 1;
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //gv_dssv.GetRowCellValue(
            //gv_dssv.FocusedRowHandle, "MaThongTinNguoiDung").ToString());
            int a = xl.capnhat(gv_bode.GetRowCellValue(gv_bode.FocusedRowHandle, "MaBoDe").ToString().Trim(), tenBoDeTextEdit.Text.ToString().Trim(), ghiChuTextEdit.Text.ToString().Trim(), 0);
            if (a != 0)
            {
                MessageBox.Show("Xóa thất bại");
            }
            loadbd();
            bam = 0;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (tenBoDeTextEdit.Text == "" || ghiChuTextEdit.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                int a = xl.capnhat(gv_bode.GetRowCellValue(gv_bode.FocusedRowHandle, "MaBoDe").ToString().Trim(), tenBoDeTextEdit.Text.ToString().Trim(), ghiChuTextEdit.Text.ToString().Trim(), 1);
                if (a != 0)
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            loadbd();
            bam = 0;
        }
        void loadct(string mabd)
        {
            gv_ct.DataSource = xl.LoadChiTiet(mabd);
        }
        private void boDeGridControl_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

            //txt_hoten.Text = gv_dssv.GetRowCellValue(gv_dssv.FocusedRowHandle, "HoTen").ToString();
            //date_ngaysinh.Text = gv_dssv.GetFocusedRowCellValue("NgaySinh").ToString();

            //loadct(gv_bode.GetFocusedRowCellValue("MaBoDe").ToString());
        }
        private void gv_bode_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_bode.RowCount>0 && gv_bode.FocusedRowHandle>=0)
            {
                loadct(gv_bode.GetFocusedRowCellValue("MaBoDe").ToString());
            }
            if (gv_ctch.RowCount > 0)
            {
                btn_capphat.Enabled = false;
            }
            else
            {
                btn_capphat.Enabled = true;
            }
            bam++;
        }
        private void btn_capphat_Click(object sender, EventArgs e)
        {
            int a= xl.CapPhat(gv_bode.GetFocusedRowCellValue("MaBoDe").ToString());
            if(a==0)
            {
                loadct(gv_bode.GetFocusedRowCellValue("MaBoDe").ToString());
            }
            else
            {
                MessageBox.Show("Cấp phát thất bại");
            }
        }
    }
}
