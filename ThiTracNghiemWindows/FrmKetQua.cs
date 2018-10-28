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
            btnOk.Click += BtnOk_Click;
            btnXuatExcel.Click += BtnXuatExcel_Click;
        }

        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            ExcelExportPro excel = new ExcelExportPro();
            string path = string.Empty;
            int i = 1;
            int dau = 0;
            int rot = 0;
            List<object> list = new List<object>();
            foreach (var item in ketQuas)
            {
                list.Add(new {
                    STT = i++,
                    item.HoTen,
                    item.NgayDK,
                    item.NgayLam,
                    item.DapAnDung,
                    item.DapAnSai,
                    item.GhiChu

                });
                if(item.DapAnDung >= 16)
                {
                    dau++;
                }
                else
                {
                    rot++;
                }

            }
                    excel.ExportKetQua(list, ref path, false, dau, rot);
            // Confirm for open file was exported
            if (!string.IsNullOrEmpty(path) && MessageBox.Show("Bạn có muốn mở file không?", "Thôngtin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateStart.Text) || (string.IsNullOrWhiteSpace(dateEnd.Text)))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;
            }
            DateTime start = dateStart.DateTime;
            DateTime end = dateEnd.DateTime;
            if (start > end)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }
            LoadKQ(start, end);
        }
        List<KQ> ketQuas = new List<KQ>();
        void LoadKQ(DateTime start, DateTime end)
        {
            gv_ketqua.DataSource = ketQuas = dl.ShowKQ(start, end);
            //ketQuas = dl.ShowKQ(start, end);
        }
        private void KetQua_Load(object sender, EventArgs e)
        {
            LoadKQ(DateTime.Now, DateTime.Now);
        }


    }
}
