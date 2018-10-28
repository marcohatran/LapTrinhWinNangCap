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
                txt_cauhoi.Enabled = txt_dapana.Enabled = txt_b.Enabled = txt_c.Enabled = txt_d.Enabled = btn_luu.Enabled= frm_checkda.Enabled=false;
                btn_sua.Enabled = btn_xoa.Enabled = true;
                cb_loaicauhoi.SelectedIndex = int.Parse(gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "MaLoaiCauHoi").ToString())-1;
                txt_cauhoi.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "NoiDungCauHoi").ToString();
                if (gv_ct.GetFocusedRowCellValue("HinhAnh") != null)
                {
                    string nameImage = gv_ct.GetFocusedRowCellValue("HinhAnh").ToString();
                    if (!string.IsNullOrWhiteSpace(nameImage))
                    {
                        
                        pic_hinh.ImageLocation = "Image/i" + nameImage+".jpg";
                    }
                    else
                    {
                        pic_hinh.ImageLocation = string.Empty;
                    }

                }
                else
                {
                    pic_hinh.ImageLocation = string.Empty;
                }
                try
                {
                    txt_dapana.Visible = true;
                    txt_dapana.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnA").ToString();
                }
                catch
                {
                    txt_dapana.Text = null;
                    txt_dapana.Visible = false;
                }
                try
                {
                    txt_b.Visible = true;
                    txt_b.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnB").ToString();
                }
                catch
                {
                    txt_b.Text = null;
                    txt_b.Visible = false;
                }
                try
                {
                    txt_c.Visible = true;
                    txt_c.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnC").ToString();
                }
                catch
                {
                    txt_c.Text = null;
                    txt_c.Visible = false;
                }
                try
                {
                    txt_d.Visible = true;
                    txt_d.Text = gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "DapAnD").ToString();
                }
                catch
                {
                    txt_d.Text = null;
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dl.Xoa(int.Parse(gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "MaCauHoi").ToString()));
                LoadGVCH();
                MessageBox.Show("Xóa thành công!");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void frm_checkda_ItemChecking(object sender, DevExpress.XtraEditors.Controls.ItemCheckingEventArgs e)
        {
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_cauhoi.Enabled = txt_dapana.Enabled = txt_b.Enabled = txt_c.Enabled = txt_d.Enabled = btn_luu.Enabled = frm_checkda.Enabled = cb_loaicauhoi.Enabled = true;
            btn_sua.Enabled = btn_xoa.Enabled = false;
            txt_cauhoi.Visible = txt_b.Visible = txt_c.Visible = txt_d.Visible = txt_dapana.Visible = true;
        }

        private void frm_checkda_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
           
        }

        private void txt_dapana_Leave(object sender, EventArgs e)
        {
            if (txt_dapana.Text == "")
            {
                frm_checkda.Items[0].CheckState = CheckState.Unchecked;
                frm_checkda.Items[0].Enabled = false;
            }
            else
            {
                frm_checkda.Items[0].Enabled = true;
            }
        }

        private void frm_checkda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txt_dapana.Text == "")
            {
                frm_checkda.Items[0].CheckState = CheckState.Unchecked;
                frm_checkda.Items[0].Enabled = false;
            }
            if (txt_b.Text == "")
            {
                frm_checkda.Items[1].CheckState = CheckState.Unchecked;
                frm_checkda.Items[1].Enabled = false;
            }
            if (txt_c.Text == "")
            {
                frm_checkda.Items[2].CheckState = CheckState.Unchecked;
                frm_checkda.Items[2].Enabled = false;
            }
            if (txt_d.Text == "")
            {
                frm_checkda.Items[3].CheckState = CheckState.Unchecked;
                frm_checkda.Items[3].Enabled = false;
            }
        }

        private void txt_b_Leave(object sender, EventArgs e)
        {
            if (txt_b.Text == "")
            {
                frm_checkda.Items[1].CheckState = CheckState.Unchecked;
                frm_checkda.Items[1].Enabled = false;
            }
            else
            {
                frm_checkda.Items[1].Enabled = true;
            }
        }

        private void txt_c_Leave(object sender, EventArgs e)
        {
            if (txt_c.Text == "")
            {
                frm_checkda.Items[2].CheckState = CheckState.Unchecked;
                frm_checkda.Items[2].Enabled = false;
            }
            else
            {
                frm_checkda.Items[2].Enabled = true;
            }
        }

        private void txt_d_Leave(object sender, EventArgs e)
        {
            if (txt_d.Text == "")
            {
                frm_checkda.Items[3].CheckState = CheckState.Unchecked;
                frm_checkda.Items[3].Enabled = false;
            }
            else
            {
                frm_checkda.Items[3].Enabled = true;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string dapan = "";
            for (int i = 0; i <= 3; i++)
            {
                if (frm_checkda.Items[i].CheckState == CheckState.Checked)
                {
                    dapan += frm_checkda.Items[i].Value.ToString().Trim();
                }
            }
            dapan = dapan.Substring(0, dapan.Length - 1);
            string s = pic_hinh.ImageLocation;
            if (s.Length > 0)
            {
                s = s.Substring(7, s.Length - 11);
            }
            try
            {
                dl.Them(int.Parse(gv_ct.GetRowCellValue(gv_ct.FocusedRowHandle, "MaCauHoi").ToString()), int.Parse(cb_loaicauhoi.SelectedValue.ToString().Trim()), txt_cauhoi.Text, txt_dapana.Text, txt_b.Text, txt_c.Text, txt_d.Text, dapan, s);
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void pic_hinh_Click(object sender, EventArgs e)
        {

        }
    }
}
