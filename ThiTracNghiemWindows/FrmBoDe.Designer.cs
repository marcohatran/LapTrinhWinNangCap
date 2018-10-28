namespace ThiTracNghiemWindows
{
    partial class FrmBoDe
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
            System.Windows.Forms.Label tenBoDeLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoDe));
            this.qLThiBangLai = new ThiTracNghiemWindows.QLThiBangLai();
            this.boDeBindingSource = new System.Windows.Forms.BindingSource();
            this.boDeTableAdapter = new ThiTracNghiemWindows.QLThiBangLaiTableAdapters.BoDeTableAdapter();
            this.tableAdapterManager = new ThiTracNghiemWindows.QLThiBangLaiTableAdapters.TableAdapterManager();
            this.boDeBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.boDeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.boDeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gv_bode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaBoDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenBoDeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ghiChuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gv_ct = new DevExpress.XtraGrid.GridControl();
            this.gv_ctch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MACT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NDCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_capphat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoact = new DevExpress.XtraEditors.SimpleButton();
            tenBoDeLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLThiBangLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boDeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boDeBindingNavigator)).BeginInit();
            this.boDeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boDeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenBoDeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctch)).BeginInit();
            this.SuspendLayout();
            // 
            // tenBoDeLabel
            // 
            tenBoDeLabel.AutoSize = true;
            tenBoDeLabel.Location = new System.Drawing.Point(17, 50);
            tenBoDeLabel.Name = "tenBoDeLabel";
            tenBoDeLabel.Size = new System.Drawing.Size(57, 13);
            tenBoDeLabel.TabIndex = 4;
            tenBoDeLabel.Text = "Tên bộ đề";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(231, 50);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(45, 13);
            ghiChuLabel.TabIndex = 6;
            ghiChuLabel.Text = "Ghi Chú";
            // 
            // qLThiBangLai
            // 
            this.qLThiBangLai.DataSetName = "QLThiBangLai";
            this.qLThiBangLai.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boDeBindingSource
            // 
            this.boDeBindingSource.DataMember = "BoDe";
            this.boDeBindingSource.DataSource = this.qLThiBangLai;
            // 
            // boDeTableAdapter
            // 
            this.boDeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoDeTableAdapter = this.boDeTableAdapter;
            this.tableAdapterManager.CauHoiTableAdapter = null;
            this.tableAdapterManager.ChiTietBoDeTableAdapter = null;
            this.tableAdapterManager.ChiTietKetQuaTableAdapter = null;
            this.tableAdapterManager.DangKiTableAdapter = null;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.LoaiCauHoiTableAdapter = null;
            this.tableAdapterManager.ManHinhTableAdapter = null;
            this.tableAdapterManager.NguoiDungManHinhTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = null;
            this.tableAdapterManager.ThongTinNguoiDungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ThiTracNghiemWindows.QLThiBangLaiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // boDeBindingNavigator
            // 
            this.boDeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.boDeBindingNavigator.BindingSource = this.boDeBindingSource;
            this.boDeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.boDeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.boDeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.boDeBindingNavigatorSaveItem});
            this.boDeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.boDeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.boDeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.boDeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.boDeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.boDeBindingNavigator.Name = "boDeBindingNavigator";
            this.boDeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.boDeBindingNavigator.Size = new System.Drawing.Size(937, 25);
            this.boDeBindingNavigator.TabIndex = 1;
            this.boDeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // boDeBindingNavigatorSaveItem
            // 
            this.boDeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boDeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("boDeBindingNavigatorSaveItem.Image")));
            this.boDeBindingNavigatorSaveItem.Name = "boDeBindingNavigatorSaveItem";
            this.boDeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.boDeBindingNavigatorSaveItem.Text = "Save Data";
            this.boDeBindingNavigatorSaveItem.Click += new System.EventHandler(this.boDeBindingNavigatorSaveItem_Click);
            // 
            // boDeGridControl
            // 
            this.boDeGridControl.DataSource = this.boDeBindingSource;
            this.boDeGridControl.Location = new System.Drawing.Point(3, 145);
            this.boDeGridControl.MainView = this.gv_bode;
            this.boDeGridControl.Name = "boDeGridControl";
            this.boDeGridControl.Size = new System.Drawing.Size(413, 414);
            this.boDeGridControl.TabIndex = 0;
            this.boDeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_bode});
            this.boDeGridControl.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.boDeGridControl_FocusedViewChanged);
            // 
            // gv_bode
            // 
            this.gv_bode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaBoDe,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_bode.GridControl = this.boDeGridControl;
            this.gv_bode.Name = "gv_bode";
            this.gv_bode.OptionsView.ShowGroupPanel = false;
            this.gv_bode.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_bode_FocusedRowChanged);
            // 
            // MaBoDe
            // 
            this.MaBoDe.Caption = "Mã bộ đê";
            this.MaBoDe.FieldName = "MaBoDe";
            this.MaBoDe.Name = "MaBoDe";
            this.MaBoDe.Visible = true;
            this.MaBoDe.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên bộ đề";
            this.gridColumn2.FieldName = "TenBoDe";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ghi chú";
            this.gridColumn3.FieldName = "GhiChu";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // tenBoDeTextEdit
            // 
            this.tenBoDeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.boDeBindingSource, "TenBoDe", true));
            this.tenBoDeTextEdit.Location = new System.Drawing.Point(85, 47);
            this.tenBoDeTextEdit.Name = "tenBoDeTextEdit";
            this.tenBoDeTextEdit.Size = new System.Drawing.Size(126, 20);
            this.tenBoDeTextEdit.TabIndex = 5;
            // 
            // ghiChuTextEdit
            // 
            this.ghiChuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.boDeBindingSource, "GhiChu", true));
            this.ghiChuTextEdit.Location = new System.Drawing.Point(291, 47);
            this.ghiChuTextEdit.Name = "ghiChuTextEdit";
            this.ghiChuTextEdit.Size = new System.Drawing.Size(132, 20);
            this.ghiChuTextEdit.TabIndex = 7;
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(270, 97);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 28);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(150, 97);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 28);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(30, 97);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 28);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gv_ct);
            this.groupControl1.Location = new System.Drawing.Point(422, 145);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(512, 414);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Chi tiết bộ đề";
            // 
            // gv_ct
            // 
            this.gv_ct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_ct.Location = new System.Drawing.Point(2, 20);
            this.gv_ct.MainView = this.gv_ctch;
            this.gv_ct.Name = "gv_ct";
            this.gv_ct.Size = new System.Drawing.Size(508, 392);
            this.gv_ct.TabIndex = 0;
            this.gv_ct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ctch});
            // 
            // gv_ctch
            // 
            this.gv_ctch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACT,
            this.gridColumn1,
            this.LCH,
            this.NDCH});
            this.gv_ctch.GridControl = this.gv_ct;
            this.gv_ctch.Name = "gv_ctch";
            this.gv_ctch.OptionsView.ShowGroupPanel = false;
            // 
            // MACT
            // 
            this.MACT.Caption = "Mã chi tiết bộ đề";
            this.MACT.FieldName = "MaChiTietBoDe";
            this.MACT.Name = "MACT";
            this.MACT.Visible = true;
            this.MACT.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã câu hỏi";
            this.gridColumn1.FieldName = "MaCauHoi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // LCH
            // 
            this.LCH.Caption = "Loại câu hỏi";
            this.LCH.FieldName = "TenLoaiCauHoi";
            this.LCH.Name = "LCH";
            this.LCH.Visible = true;
            this.LCH.VisibleIndex = 2;
            // 
            // NDCH
            // 
            this.NDCH.Caption = "Nội dung câu hỏi";
            this.NDCH.FieldName = "NoiDungCauHoi";
            this.NDCH.Name = "NDCH";
            this.NDCH.Visible = true;
            this.NDCH.VisibleIndex = 3;
            // 
            // btn_capphat
            // 
            this.btn_capphat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capphat.Appearance.Options.UseFont = true;
            this.btn_capphat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_capphat.ImageOptions.Image = global::ThiTracNghiemWindows.Properties.Resources.Document_Add_icon;
            this.btn_capphat.Location = new System.Drawing.Point(498, 87);
            this.btn_capphat.Name = "btn_capphat";
            this.btn_capphat.Size = new System.Drawing.Size(168, 48);
            this.btn_capphat.TabIndex = 0;
            this.btn_capphat.Text = "Cấp phát đề";
            this.btn_capphat.Click += new System.EventHandler(this.btn_capphat_Click);
            // 
            // btn_xoact
            // 
            this.btn_xoact.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoact.Appearance.Options.UseFont = true;
            this.btn_xoact.ImageOptions.Image = global::ThiTracNghiemWindows.Properties.Resources.red_document_cross_icon;
            this.btn_xoact.Location = new System.Drawing.Point(715, 87);
            this.btn_xoact.Name = "btn_xoact";
            this.btn_xoact.Size = new System.Drawing.Size(168, 48);
            this.btn_xoact.TabIndex = 20;
            this.btn_xoact.Text = "Xóa câu hỏi";
            // 
            // FrmBoDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_xoact);
            this.Controls.Add(this.btn_capphat);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(tenBoDeLabel);
            this.Controls.Add(this.tenBoDeTextEdit);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextEdit);
            this.Controls.Add(this.boDeGridControl);
            this.Controls.Add(this.boDeBindingNavigator);
            this.Name = "FrmBoDe";
            this.Size = new System.Drawing.Size(937, 562);
            this.Load += new System.EventHandler(this.FrmBoDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLThiBangLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boDeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boDeBindingNavigator)).EndInit();
            this.boDeBindingNavigator.ResumeLayout(false);
            this.boDeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boDeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenBoDeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLThiBangLai qLThiBangLai;
        private System.Windows.Forms.BindingSource boDeBindingSource;
        private QLThiBangLaiTableAdapters.BoDeTableAdapter boDeTableAdapter;
        private QLThiBangLaiTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator boDeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton boDeBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl boDeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_bode;
        private DevExpress.XtraGrid.Columns.GridColumn MaBoDe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.TextEdit tenBoDeTextEdit;
        private DevExpress.XtraEditors.TextEdit ghiChuTextEdit;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btn_capphat;
        private DevExpress.XtraGrid.GridControl gv_ct;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ctch;
        private DevExpress.XtraGrid.Columns.GridColumn MACT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn LCH;
        private DevExpress.XtraGrid.Columns.GridColumn NDCH;
        private DevExpress.XtraEditors.SimpleButton btn_xoact;
    }
}
