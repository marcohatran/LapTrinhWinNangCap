namespace ThiTracNghiemWindows
{
    partial class FrmQLnguoidung
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_change = new DevExpress.XtraEditors.SimpleButton();
            this.rd_false = new System.Windows.Forms.RadioButton();
            this.rd_true = new System.Windows.Forms.RadioButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gv_taikhoan = new DevExpress.XtraGrid.GridControl();
            this.gv_cttk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoatk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gv_quyen = new DevExpress.XtraGrid.GridControl();
            this.gv_phanquyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ManHinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrueFalse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.gioithieu = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_taikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cttk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_quyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_phanquyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_change);
            this.groupControl1.Controls.Add(this.rd_false);
            this.groupControl1.Controls.Add(this.rd_true);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(6, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(464, 126);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Quản lý loại tài khoản";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(123, 79);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(183, 32);
            this.btn_change.TabIndex = 2;
            this.btn_change.Text = "Change";
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // rd_false
            // 
            this.rd_false.AutoSize = true;
            this.rd_false.Location = new System.Drawing.Point(250, 40);
            this.rd_false.Name = "rd_false";
            this.rd_false.Size = new System.Drawing.Size(56, 17);
            this.rd_false.TabIndex = 1;
            this.rd_false.TabStop = true;
            this.rd_false.Text = "Unlock";
            this.rd_false.UseVisualStyleBackColor = true;
            // 
            // rd_true
            // 
            this.rd_true.AutoSize = true;
            this.rd_true.Location = new System.Drawing.Point(123, 40);
            this.rd_true.Name = "rd_true";
            this.rd_true.Size = new System.Drawing.Size(46, 17);
            this.rd_true.TabIndex = 0;
            this.rd_true.TabStop = true;
            this.rd_true.Text = "Lock";
            this.rd_true.UseVisualStyleBackColor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Location = new System.Drawing.Point(229, -22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Loại tài khoản";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.Controls.Add(this.gv_taikhoan);
            this.groupControl3.Location = new System.Drawing.Point(8, 136);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(460, 377);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách tài khoản đăng nhập";
            // 
            // gv_taikhoan
            // 
            this.gv_taikhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_taikhoan.Location = new System.Drawing.Point(2, 20);
            this.gv_taikhoan.MainView = this.gv_cttk;
            this.gv_taikhoan.Name = "gv_taikhoan";
            this.gv_taikhoan.Size = new System.Drawing.Size(456, 355);
            this.gv_taikhoan.TabIndex = 0;
            this.gv_taikhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_cttk});
            // 
            // gv_cttk
            // 
            this.gv_cttk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.gridColumn,
            this.khoatk});
            this.gv_cttk.GridControl = this.gv_taikhoan;
            this.gv_cttk.Name = "gv_cttk";
            this.gv_cttk.OptionsBehavior.Editable = false;
            this.gv_cttk.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "Tài khoản";
            this.ID.FieldName = "TaiKhoan";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // gridColumn
            // 
            this.gridColumn.Caption = "Họ Tên";
            this.gridColumn.FieldName = "HoTen";
            this.gridColumn.Name = "gridColumn";
            this.gridColumn.Visible = true;
            this.gridColumn.VisibleIndex = 1;
            // 
            // khoatk
            // 
            this.khoatk.Caption = "Lock";
            this.khoatk.FieldName = "TinhTrang";
            this.khoatk.Name = "khoatk";
            this.khoatk.Visible = true;
            this.khoatk.VisibleIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gv_quyen);
            this.groupControl2.Location = new System.Drawing.Point(476, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(307, 509);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Danh sách quyền";
            // 
            // gv_quyen
            // 
            this.gv_quyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_quyen.Location = new System.Drawing.Point(2, 20);
            this.gv_quyen.MainView = this.gv_phanquyen;
            this.gv_quyen.Name = "gv_quyen";
            this.gv_quyen.Size = new System.Drawing.Size(303, 487);
            this.gv_quyen.TabIndex = 0;
            this.gv_quyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_phanquyen});
            // 
            // gv_phanquyen
            // 
            this.gv_phanquyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ManHinh,
            this.TrueFalse});
            this.gv_phanquyen.GridControl = this.gv_quyen;
            this.gv_phanquyen.Name = "gv_phanquyen";
            this.gv_phanquyen.OptionsView.ShowGroupPanel = false;
            this.gv_phanquyen.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_phanquyen_CellValueChanging);
            // 
            // ManHinh
            // 
            this.ManHinh.Caption = "Quyền";
            this.ManHinh.FieldName = "TenManHinh";
            this.ManHinh.Name = "ManHinh";
            this.ManHinh.OptionsColumn.AllowEdit = false;
            this.ManHinh.OptionsColumn.ReadOnly = true;
            this.ManHinh.Visible = true;
            this.ManHinh.VisibleIndex = 0;
            // 
            // TrueFalse
            // 
            this.TrueFalse.Caption = "True/False";
            this.TrueFalse.FieldName = "TinhTrang";
            this.TrueFalse.Name = "TrueFalse";
            this.TrueFalse.Visible = true;
            this.TrueFalse.VisibleIndex = 1;
            // 
            // groupControl7
            // 
            this.groupControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl7.Controls.Add(this.gioithieu);
            this.groupControl7.Location = new System.Drawing.Point(789, 4);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(305, 507);
            this.groupControl7.TabIndex = 11;
            this.groupControl7.Text = "Danh sách quyền";
            // 
            // gioithieu
            // 
            this.gioithieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioithieu.Enabled = false;
            this.gioithieu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gioithieu.Location = new System.Drawing.Point(2, 20);
            this.gioithieu.Name = "gioithieu";
            this.gioithieu.ReadOnly = true;
            this.gioithieu.Size = new System.Drawing.Size(301, 485);
            this.gioithieu.TabIndex = 0;
            this.gioithieu.Text = "";
            // 
            // FrmQLnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmQLnguoidung";
            this.Size = new System.Drawing.Size(1097, 520);
            this.Load += new System.EventHandler(this.FrmQLnguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_taikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_cttk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_quyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_phanquyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gv_taikhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_cttk;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn khoatk;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_change;
        private System.Windows.Forms.RadioButton rd_false;
        private System.Windows.Forms.RadioButton rd_true;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn;
        private DevExpress.XtraGrid.GridControl gv_quyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_phanquyen;
        private DevExpress.XtraGrid.Columns.GridColumn ManHinh;
        private DevExpress.XtraGrid.Columns.GridColumn TrueFalse;
        private System.Windows.Forms.RichTextBox gioithieu;
    }
}
