namespace ThiTracNghiemWindows
{
    partial class FrmQLtheophong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_dssvthi = new DevExpress.XtraEditors.GroupControl();
            this.gv_dssvthi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mssv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngaythi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gb_controlsphong = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gb_dssvthi)).BeginInit();
            this.gb_dssvthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dssvthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_controlsphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_dssvthi
            // 
            this.gb_dssvthi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_dssvthi.Controls.Add(this.gv_dssvthi);
            this.gb_dssvthi.Location = new System.Drawing.Point(411, 101);
            this.gb_dssvthi.Name = "gb_dssvthi";
            this.gb_dssvthi.Size = new System.Drawing.Size(497, 408);
            this.gb_dssvthi.TabIndex = 0;
            this.gb_dssvthi.Text = "Danh sách sinh viên thi";
            // 
            // gv_dssvthi
            // 
            this.gv_dssvthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_dssvthi.Location = new System.Drawing.Point(2, 20);
            this.gv_dssvthi.MainView = this.gridView1;
            this.gv_dssvthi.Name = "gv_dssvthi";
            this.gv_dssvthi.Size = new System.Drawing.Size(493, 386);
            this.gv_dssvthi.TabIndex = 0;
            this.gv_dssvthi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.name,
            this.mssv,
            this.ngaythi,
            this.gridColumn1,
            this.Status});
            this.gridView1.GridControl = this.gv_dssvthi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // name
            // 
            this.name.Caption = "Sinh viên";
            this.name.FieldName = "HOTEN";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            // 
            // mssv
            // 
            this.mssv.Caption = "Mã sinh viên";
            this.mssv.FieldName = "MASV";
            this.mssv.Name = "mssv";
            this.mssv.Visible = true;
            this.mssv.VisibleIndex = 0;
            // 
            // ngaythi
            // 
            this.ngaythi.Caption = "Giới tính";
            this.ngaythi.FieldName = "GIOITINH";
            this.ngaythi.Name = "ngaythi";
            this.ngaythi.Visible = true;
            this.ngaythi.VisibleIndex = 2;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "TINHTRANGTHI";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 4;
            // 
            // gb_controlsphong
            // 
            this.gb_controlsphong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_controlsphong.Location = new System.Drawing.Point(5, 101);
            this.gb_controlsphong.Name = "gb_controlsphong";
            this.gb_controlsphong.Size = new System.Drawing.Size(400, 408);
            this.gb_controlsphong.TabIndex = 2;
            this.gb_controlsphong.Text = "Hệ thống phòng thi";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Location = new System.Drawing.Point(5, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(901, 92);
            this.groupControl1.TabIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Kỳ thi";
            this.gridColumn1.FieldName = "KYTHI";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // FrmQLtheophong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gb_dssvthi);
            this.Controls.Add(this.gb_controlsphong);
            this.Name = "FrmQLtheophong";
            this.Size = new System.Drawing.Size(911, 512);
            this.Load += new System.EventHandler(this.FrmQLtheophong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb_dssvthi)).EndInit();
            this.gb_dssvthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_dssvthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_controlsphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gb_dssvthi;
        private DevExpress.XtraEditors.GroupControl gb_controlsphong;
        private DevExpress.XtraGrid.GridControl gv_dssvthi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn mssv;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn ngaythi;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
