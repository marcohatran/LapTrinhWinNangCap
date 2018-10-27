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
using BLL;
using DevExpress.XtraGrid.Views.Grid;
using LinqToSql;

namespace ThiTracNghiemWindows
{
    public partial class FrmPMThi : DevExpress.XtraEditors.XtraForm
    {
        XuLy xl = new XuLy();
        DuLieu dlieu = new DuLieu();
        DataTable trl = new DataTable();
        PictureBox a = new PictureBox();
        int mand;
        int landau = 0;
        public FrmPMThi()
        {
            InitializeComponent();
        }
        public FrmPMThi(int nd)
        {
            InitializeComponent();
            mand = nd;
        }
        int cauhoithu = 0;
        private void FrmPMThi_Load(object sender, EventArgs e)
        {
            xl.UpdateKetQua(mand);//Chỉnh lại theo mã người dùng phù hợp
            xl.loadcauhoi(mand);
            cb_dk.SelectedIndex = 0;
            gv_dapan.ShowingEditor += gv_dapan_ShowingEditor;
            gv_dapan.FocusedRowChanged += gv_dapan_FocusedRowChanged;
            loadtungcau();
        }

        void gv_dapan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_dapan.RowCount > 0)
            {
                int ab = int.Parse(gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "MaChiTietKQ").ToString()) - landau;
                cauhoithu = ab;
                loadtungcau();
            }
        }
        void gv_dapan_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gv_dapan.FocusedColumn.FieldName == "Câu hỏi")
            {
                    e.Cancel = true;
            }
        }
        int anh = 0;
        void loadtungcau()
        {
            List<CauHoi> ch=dlieu.LoadCauHoi(int.Parse(trl.Rows[gv_dapan.FocusedRowHandle][2].ToString()));
            cauhoi.Text = "Câu " + (cauhoithu + 1).ToString() + ": " + ch[0].NoiDungCauHoi.ToString();
            cauhoi.SelectionIndent += 25;
            cauhoi.Enabled = false;
            txt_dapana.Enabled = txt_dapanb.Enabled = txt_dapanc.Enabled = txt_dapand.Enabled = false;
            FontFamily f = new FontFamily("Times New Roman");
            txt_dapand.Font = txt_dapanc.Font = txt_dapanb.Font = txt_dapana.Font = new Font(f, 12);
            txt_dapana.SelectionIndent = txt_dapanb.SelectionIndent = txt_dapanc.SelectionIndent = txt_dapand.SelectionIndent = 15;
            txt_dapana.Left = txt_dapanc.Left = 10;
            txt_dapanb.Left = txt_dapand.Left = 540;
            txt_dapana.Width = txt_dapanb.Width = txt_dapanc.Width = txt_dapand.Width = 500;
            if (anh == 0)
            {
                gb_cauhoi.Controls.Add(a);
                a.Size = new Size(400, 250);
                a.Top = cauhoi.Height + cauhoi.Top + 10;
                a.Left = gb_cauhoi.Width / 2 - a.Width / 2;
                txt_dapana.Top = txt_dapanb.Top = cauhoi.Top + cauhoi.Height + 30 + a.Height;
            }
            anh++;
            if (ch[0].HinhAnh != null)
            {
                a.Visible = true;
                a.Image = Image.FromFile("Image/i" + ch[0].HinhAnh.ToString().Trim()+ ".jpg");
                a.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                a.Visible = false;
            }
            txt_dapanc.Top = txt_dapand.Top = txt_dapana.Top + txt_dapana.Height + 10;
            btn_pre.Top = btn_next.Top = txt_dapand.Top + txt_dapand.Height + 50;
            btn_pre.Left = 500 + txt_dapana.Left - btn_pre.Width;
            btn_next.Left = btn_pre.Left + btn_pre.Width + 30;
            if (ch[0].DapAnA != null)
            {
                txt_dapana.Visible = true;
                txt_dapana.Text = "Đáp án A: " + ch[0].DapAnA.ToString();
            }
            else
            {
                txt_dapana.Visible = false;
            }
            if (ch[0].DapAnB != null)
            {
                txt_dapanb.Visible = true;
                txt_dapanb.Text = "Đáp án B: " + ch[0].DapAnB.ToString();
            }
            else
            {
                txt_dapanb.Visible = false;
            }
            if (ch[0].DapAnC != null)
            {
                txt_dapanc.Visible = true;
                txt_dapanc.Text = "Đáp án C: " + ch[0].DapAnC.ToString();
            }
            else
            {
                txt_dapanc.Visible = false;
            }
            if (ch[0].DapAnD != null)
            {
                txt_dapand.Visible = true;
                txt_dapand.Text = "Đáp án D: " + ch[0].DapAnD.ToString();
            }
            else
            {
                txt_dapand.Visible = false;
            }
            if (gv_dapan.FocusedRowHandle == 0)
                btn_pre.Enabled = false;
            else
                btn_pre.Enabled = true;
            if (gv_dapan.FocusedRowHandle+1 == gv_dapan.RowCount)
                btn_next.Enabled = false;
            else
                btn_next.Enabled = true;
        }
        //void loadgvtrl(DataTable all)
        //{
        //    DataTable table = new DataTable();
        //    table.Columns.Add("Câu hỏi");
        //    table.Columns.Add("A", typeof(bool));
        //    table.Columns.Add("B", typeof(bool));
        //    table.Columns.Add("C", typeof(bool));
        //    table.Columns.Add("D", typeof(bool));
        //    for (int i = 0; i < all.Rows.Count; i++)
        //    {
        //        DataRow row = table.NewRow();
        //        row[0] = "Câu " + (i + 1).ToString();
        //        row[1] = false;
        //        row[2] = false;
        //        row[3] = false;
        //        row[4] = false;
        //        table.Rows.Add(row);
        //    }
        //    gv_trl.DataSource = table;
        //}

        private void cb_dk_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_dk.SelectedIndex == 0)
            {
                trl = xl.loaddltraloi(0, mand);
                if (landau == 0)
                {
                    landau = int.Parse(trl.Rows[0][0].ToString());
                }
                trl.Columns.Add("cauhoi");
                trl.Columns.Add("a", typeof(bool));
                trl.Columns.Add("b", typeof(bool));
                trl.Columns.Add("c", typeof(bool));
                trl.Columns.Add("d", typeof(bool));

                foreach (DataRow row in trl.Rows)
                {
                    row[5] = "Câu " + (int.Parse(row[0].ToString()) - landau +1).ToString();
                    row[6] = false;
                    row[7] = false;
                    row[8] = false;
                    row[9] = false;
                    if (row[3].ToString().Trim() != "Sai" || row[3].ToString() != "")
                    {
                        string[] catchuoi = row[3].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < catchuoi.Length; i++)
                        {

                            if (catchuoi[i].ToString().Trim() == "A")
                            {
                                row[6] = true;
                            }
                            if (catchuoi[i].ToString().Trim() == "B")
                            {
                                row[7] = true;
                            }
                            if (catchuoi[i].ToString().Trim() == "C")
                            {
                                row[8] = true;
                            }
                            if (catchuoi[i].ToString().Trim() == "D")
                            {
                                row[9] = true;
                            }
                        }
                    }
                }
                gv_trl.DataSource = trl;
            }
            if(cb_dk.SelectedIndex==1)
            {
                trl = xl.loaddltraloi(1, mand);
                trl.Columns.Add("cauhoi");
                trl.Columns.Add("a", typeof(bool));
                trl.Columns.Add("b", typeof(bool));
                trl.Columns.Add("c", typeof(bool));
                trl.Columns.Add("d", typeof(bool));

                foreach (DataRow row in trl.Rows)
                {
                    row[5] = "Câu " + (int.Parse(row[0].ToString()) - landau + 1).ToString();
                    row[6] = false;
                    row[7] = false;
                    row[8] = false;
                    row[9] = false;
                }
                gv_trl.DataSource = trl;
            }
            if (cb_dk.SelectedIndex == 2)
            {
                trl = xl.loaddltraloi(2, mand);
                trl.Columns.Add("cauhoi");
                trl.Columns.Add("a", typeof(bool));
                trl.Columns.Add("b", typeof(bool));
                trl.Columns.Add("c", typeof(bool));
                trl.Columns.Add("d", typeof(bool));
                foreach (DataRow row in trl.Rows)
                {
                    row[5] = "Câu " + (int.Parse(row[0].ToString()) - landau + 1).ToString();
                    row[6] = false;
                    row[7] = false;
                    row[8] = false;
                    row[9] = false;
                    if (row[3].ToString().Trim() != "Sai" || row[3].ToString() != "" )
                    {
                        string[] catchuoi = row[3].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < catchuoi.Length; i++)
                        {

                            if (catchuoi[i].ToString().Trim() == "A")
                            {
                                row[6] = true;
                            }
                            if (catchuoi[i].ToString().Trim() == "B")
                            {
                                row[7] = true;
                            }
                            if (catchuoi[i].ToString().Trim() == "C")
                            {
                                row[8] = true;
                            }
                            if (catchuoi[i].ToString().Trim() == "D")
                            {
                                row[9] = true;
                            }
                        }
                    }
                }
                gv_trl.DataSource = trl;
            }
        }
        //public DataTable Checkgv(DataTable dt, int index)
        //{
        //    DataTable reload = new DataTable();
            
        //}
        private void btn_pre_Click(object sender, EventArgs e)
        {
            gv_dapan.FocusedRowHandle = gv_dapan.FocusedRowHandle - 1;
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            gv_dapan.FocusedRowHandle = gv_dapan.FocusedRowHandle + 1;
        }

        private void gv_dapan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        //private void gv_dapan_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        //{
        //    GridView view = sender as GridView;
        //    DataView dv = view.DataSource as DataView;
        //    if ((bool)dv[e.ListSourceRow][6] == true)
        //    {
        //        e.Visible = false;
        //        e.Handled = true;
        //    }
        //}

        private void gv_dapan_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //MessageBox.Show(e.RowHandle.ToString() + e.Value.ToString() + e.Column.ToString());
            string dapan = "";
            if (e.Value.ToString() == "True")
            {
                dapan += e.Column.ToString() + ",";
            }
            
            string[] vt = new string[4] { "a", "b", "c", "d" };
            string[] da = new string[4] { "A,", "B,", "C,", "D," }; 
            for (int i = 0; i < 4; i++)
            {
                if (gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, vt[i]).ToString().Trim() == "True")
                {
                    dapan += da[i];
                }
            }
            //if (gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "a").ToString().Trim() == "True")
            //{
            //    dapan += "A,";
            //}
            //if (gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "b").ToString().Trim() == "True")
            //{
            //    dapan += "B,";
            //}
            //if (gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "c").ToString().Trim() == "True")
            //{
            //    dapan += "C,";
            //}
            //if (gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "d").ToString().Trim() == "True")
            //{
            //    dapan += "D,";
            //}
            if (dapan == "")
            {
                dapan = "Sai,";
            }
            dlieu.UpdateCTKQ(int.Parse(gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "MaChiTietKQ").ToString()), dapan);
        }

        private void btn_nopbai_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn xác định nộp bài chứ ?", "Nộp bài", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                try
                {
                    dlieu.UpdateKQ(int.Parse(gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "MaKetQua").ToString()), mand);
                    FrmShowDiem show = new FrmShowDiem(int.Parse(gv_dapan.GetRowCellValue(gv_dapan.FocusedRowHandle, "MaKetQua").ToString()));
                    show.Show();
                    this.Visible = false;
                }
                catch
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        
    }
}