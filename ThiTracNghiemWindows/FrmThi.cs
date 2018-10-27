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
    public partial class FrmThi : DevExpress.XtraEditors.XtraForm
    {
        public FrmThi()
        {
            
            InitializeComponent();
            DataTable table = new DataTable();
            table.Columns.Add("Test");
            table.Columns.Add("Grabado", typeof(bool));
            table.Columns.Add("Selecciona", typeof(bool));
            for (int i = 0; i < 10; i++)
            {
                DataRow row = table.NewRow();
                row[0] = i;
                row[1] = false;
                row[2] = false;
                table.Rows.Add(row);
            }
            gridControl1.DataSource = table;
            gridView1.ShowingEditor += new CancelEventHandler(gridView1_ShowingEditor);
            gridView1.ShownEditor += new EventHandler(gridView1_ShownEditor);
            gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView1_CellValueChanged);
        }
        int PreviouslySelectedGrabado = 0;
        int PreviouslySelectedSelecciona = 0;
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "Grabado")
            {
                if ((bool)gridView1.GetFocusedValue() == true)
                    e.Cancel = true;
            }
        }


        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmThi_Load(object sender, EventArgs e)
        {
            
        }
        
        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "Grabado" || gridView1.FocusedColumn.FieldName == "Selecciona")
            {
                gridView1.ActiveEditor.EditValueChanged += new EventHandler(ActiveEditor_EditValueChanged);
            }
        }

        private void ActiveEditor_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.CloseEditor();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "Grabado":
                    {
                        ProcessGrabado(e.RowHandle);
                        MessageBox.Show(e.RowHandle.ToString());
                        break;
                    }
                case "Selecciona": ProcessSelecciona(e.RowHandle); break;
            }
        }

        private void ProcessSelecciona(int CurrentRow)
        {
            if (CurrentRow == PreviouslySelectedSelecciona) return;
            gridView1.SetRowCellValue(PreviouslySelectedSelecciona, gridView1.Columns["Selecciona"], false);
            PreviouslySelectedSelecciona = CurrentRow;
        }
       
        private void ProcessGrabado(int p)
        {
            if (p == PreviouslySelectedGrabado) return;

            gridView1.SetRowCellValue(PreviouslySelectedGrabado, gridView1.Columns["Grabado"], false);
            gridView1.SetRowCellValue(p, gridView1.Columns["Selecciona"], true);
            PreviouslySelectedGrabado = p;
        }

       
    }
}