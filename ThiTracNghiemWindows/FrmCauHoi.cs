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
    public partial class FrmCauHoi : DevExpress.XtraEditors.XtraUserControl
    {
        DuLieu dl = new DuLieu();
        public FrmCauHoi()
        {
            InitializeComponent();
        }
        void LoadCB()
        {
            cb_loaicauhoi.DataSource = dl.LoaddlCH();
            cb_loaicauhoi.ValueMember = "MaLoaiCauHoi";
            cb_loaicauhoi.DisplayMember = "TenLoaiCauHoi";
        }
        void LoadGVCH()
        {
            gv_cauhoi.DataSource = dl.LoadCauHoi();
        }
        private void FrmCauHoi_Load(object sender, EventArgs e)
        {
            LoadCB();
            LoadGVCH();
        }
        void XuLyNut(string dapan)
        {
            frm_checkda.Items[0].CheckState = CheckState.Unchecked;
            frm_checkda.Items[1].CheckState = CheckState.Unchecked;
            frm_checkda.Items[2].CheckState = CheckState.Unchecked;
            frm_checkda.Items[3].CheckState = CheckState.Unchecked;
            string[] catchuoi = (dapan+",").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < catchuoi.Length; i++)
            {

                if (catchuoi[i].ToString().Trim() == "A")
                {
                    frm_checkda.Items[0].CheckState = CheckState.Checked;
                }
                if (catchuoi[i].ToString().Trim() == "B")
                {
                    frm_checkda.Items[1].CheckState = CheckState.Checked;
                }
                if (catchuoi[i].ToString().Trim() == "C")
                {
                    frm_checkda.Items[2].CheckState = CheckState.Checked;
                }
                if (catchuoi[i].ToString().Trim() == "D")
                {
                    frm_checkda.Items[3].CheckState = CheckState.Checked;
                }
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_ct.FocusedRowHandle >= 0 && gv_ct.RowCount>0)
            {
                txt_cauhoi.Enabled = txt_dapana.Enabled = txt_b.Enabled = txt_c.Enabled = txt_d.Enabled = btn_luu.Enabled= frm_checkda.Enabled=cb_loaicauhoi.Enabled= false;
                cb_loaicauhoi.SelectedValue = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "MaLoaiCauHoi").ToString().Trim();
                txt_cauhoi.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "NoiDungCauHoi").ToString();
                try
                {
                    txt_dapana.Visible = true;
                    txt_dapana.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnA").ToString();
                }
                catch
                {
                    txt_dapana.Visible = false;
                }
                try
                {
                    txt_b.Visible = true;
                    txt_b.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnB").ToString();
                }
                catch
                {
                    txt_b.Visible = false;
                }
                try
                {
                    txt_c.Visible = true;
                    txt_c.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnC").ToString();
                }
                catch
                {
                    txt_c.Visible = false;
                }
                try
                {
                    txt_d.Visible = true;
                    txt_d.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnD").ToString();
                }
                catch
                {
                    txt_d.Visible = false;
                }
                XuLyNut(gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnDung").ToString());
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_cauhoi.Enabled = txt_dapana.Enabled = txt_b.Enabled = txt_c.Enabled = txt_d.Enabled = btn_luu.Enabled = frm_checkda.Enabled = cb_loaicauhoi.Enabled = true;
            btn_sua.Enabled = btn_xoa.Enabled = false;
            txt_cauhoi.Visible = txt_b.Visible = txt_c.Visible = txt_d.Visible = txt_dapana.Visible = true;
            txt_cauhoi.Text = txt_dapana.Text = txt_b.Text = txt_c.Text = txt_d.Text = "";
            XuLyNut("sssss");

        }
    }
}
