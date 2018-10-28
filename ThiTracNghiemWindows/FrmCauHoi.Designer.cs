namespace ThiTracNghiemWindows
{
    partial class FrmCauHoi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCauHoi));
            this.gv_cauhoi = new DevExpress.XtraGrid.GridControl();
            this.gv_ct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grp_ttsv = new DevExpress.XtraEditors.GroupControl();
            this.txt_d = new DevExpress.XtraEditors.TextEdit();
            this.txt_c = new DevExpress.XtraEditors.TextEdit();
            this.txt_cauhoi = new System.Windows.Forms.RichTextBox();
            this.cb_loaicauhoi = new System.Windows.Forms.ComboBox();
            this.frm_checkda = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.pic_hinh = new System.Windows.Forms.PictureBox();
            this.txt_b = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_d = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_dapana = new DevExpress.XtraEditors.TextEdit();
            this.lb_c = new DevExpress.XtraEditors.LabelControl();
            this.lb_b = new DevExpress.XtraEditors.LabelControl();
            this.lb_a = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv_cauhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ttsv)).BeginInit();
            this.grp_ttsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_d.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_c.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm_checkda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_b.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dapana.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_cauhoi
            // 
            this.gv_cauhoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_cauhoi.Location = new System.Drawing.Point(0, 271);
            this.gv_cauhoi.MainView = this.gv_ct;
            this.gv_cauhoi.Name = "gv_cauhoi";
            this.gv_cauhoi.Size = new System.Drawing.Size(1297, 277);
            this.gv_cauhoi.TabIndex = 0;
            this.gv_cauhoi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ct});
            // 
            // gv_ct
            // 
            this.gv_ct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn7});
            this.gv_ct.GridControl = this.gv_cauhoi;
            this.gv_ct.Name = "gv_ct";
            this.gv_ct.OptionsView.ShowGroupPanel = false;
            this.gv_ct.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã câu hỏi";
            this.gridColumn1.FieldName = "MaCauHoi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nội Dung";
            this.gridColumn2.FieldName = "NoiDungCauHoi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đáp án A";
            this.gridColumn3.FieldName = "DapAnA";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đáp án B";
            this.gridColumn4.FieldName = "DapAnB";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Đáp án C";
            this.gridColumn5.FieldName = "DapAnC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Đáp án D";
            this.gridColumn6.FieldName = "DapAnD";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Hình ảnh";
            this.gridColumn8.FieldName = "HinhAnh";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã loại câu hỏi";
            this.gridColumn7.FieldName = "MaLoaiCauHoi";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // grp_ttsv
            // 
            this.grp_ttsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_ttsv.Controls.Add(this.txt_d);
            this.grp_ttsv.Controls.Add(this.txt_c);
            this.grp_ttsv.Controls.Add(this.txt_cauhoi);
            this.grp_ttsv.Controls.Add(this.cb_loaicauhoi);
            this.grp_ttsv.Controls.Add(this.frm_checkda);
            this.grp_ttsv.Controls.Add(this.pic_hinh);
            this.grp_ttsv.Controls.Add(this.txt_b);
            this.grp_ttsv.Controls.Add(this.labelControl3);
            this.grp_ttsv.Controls.Add(this.lb_d);
            this.grp_ttsv.Controls.Add(this.labelControl10);
            this.grp_ttsv.Controls.Add(this.btn_luu);
            this.grp_ttsv.Controls.Add(this.btn_sua);
            this.grp_ttsv.Controls.Add(this.btn_xoa);
            this.grp_ttsv.Controls.Add(this.btn_them);
            this.grp_ttsv.Controls.Add(this.txt_dapana);
            this.grp_ttsv.Controls.Add(this.lb_c);
            this.grp_ttsv.Controls.Add(this.lb_b);
            this.grp_ttsv.Controls.Add(this.lb_a);
            this.grp_ttsv.Controls.Add(this.labelControl2);
            this.grp_ttsv.Location = new System.Drawing.Point(0, 0);
            this.grp_ttsv.Name = "grp_ttsv";
            this.grp_ttsv.Size = new System.Drawing.Size(1297, 265);
            this.grp_ttsv.TabIndex = 2;
            this.grp_ttsv.Text = "Thông tin sinh viên";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(469, 162);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(234, 20);
            this.txt_d.TabIndex = 34;
            this.txt_d.Leave += new System.EventHandler(this.txt_d_Leave);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(469, 126);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(234, 20);
            this.txt_c.TabIndex = 33;
            this.txt_c.Leave += new System.EventHandler(this.txt_c_Leave);
            // 
            // txt_cauhoi
            // 
            this.txt_cauhoi.Location = new System.Drawing.Point(95, 38);
            this.txt_cauhoi.Name = "txt_cauhoi";
            this.txt_cauhoi.Size = new System.Drawing.Size(608, 67);
            this.txt_cauhoi.TabIndex = 32;
            this.txt_cauhoi.Text = "";
            // 
            // cb_loaicauhoi
            // 
            this.cb_loaicauhoi.FormattingEnabled = true;
            this.cb_loaicauhoi.Location = new System.Drawing.Point(747, 70);
            this.cb_loaicauhoi.Name = "cb_loaicauhoi";
            this.cb_loaicauhoi.Size = new System.Drawing.Size(125, 21);
            this.cb_loaicauhoi.TabIndex = 31;
            // 
            // frm_checkda
            // 
            this.frm_checkda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.behaviorManager1.SetBehaviors(this.frm_checkda, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraEditors.DragDropBehaviorSourceForListBox), true, true, true)))});
            this.frm_checkda.Cursor = System.Windows.Forms.Cursors.Default;
            this.frm_checkda.ItemAutoHeight = true;
            this.frm_checkda.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("A,", "A"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("B,", "B"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("C,", "C"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("D,", "D")});
            this.frm_checkda.Location = new System.Drawing.Point(747, 129);
            this.frm_checkda.Name = "frm_checkda";
            this.frm_checkda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.frm_checkda.Size = new System.Drawing.Size(120, 95);
            this.frm_checkda.TabIndex = 30;
            this.frm_checkda.ItemChecking += new DevExpress.XtraEditors.Controls.ItemCheckingEventHandler(this.frm_checkda_ItemChecking);
            this.frm_checkda.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.frm_checkda_ItemCheck);
            this.frm_checkda.SelectedValueChanged += new System.EventHandler(this.frm_checkda_SelectedValueChanged);
            // 
            // pic_hinh
            // 
            this.pic_hinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_hinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_hinh.Location = new System.Drawing.Point(900, 28);
            this.pic_hinh.Name = "pic_hinh";
            this.pic_hinh.Size = new System.Drawing.Size(378, 220);
            this.pic_hinh.TabIndex = 29;
            this.pic_hinh.TabStop = false;
            this.pic_hinh.Click += new System.EventHandler(this.pic_hinh_Click);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(95, 162);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(234, 20);
            this.txt_b.TabIndex = 27;
            this.txt_b.Leave += new System.EventHandler(this.txt_b_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(747, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Đáp án đúng";
            // 
            // lb_d
            // 
            this.lb_d.Location = new System.Drawing.Point(394, 165);
            this.lb_d.Name = "lb_d";
            this.lb_d.Size = new System.Drawing.Size(45, 13);
            this.lb_d.TabIndex = 23;
            this.lb_d.Text = "Đáp án D";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(783, 41);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(56, 13);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = "Loại câu hỏi";
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.Location = new System.Drawing.Point(501, 207);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 28);
            this.btn_luu.TabIndex = 20;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.ImageOptions.Image")));
            this.btn_sua.Location = new System.Drawing.Point(381, 207);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 28);
            this.btn_sua.TabIndex = 15;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.ImageOptions.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(261, 207);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 28);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.Location = new System.Drawing.Point(141, 207);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 28);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_dapana
            // 
            this.txt_dapana.Location = new System.Drawing.Point(95, 122);
            this.txt_dapana.Name = "txt_dapana";
            this.txt_dapana.Size = new System.Drawing.Size(234, 20);
            this.txt_dapana.TabIndex = 8;
            this.txt_dapana.Leave += new System.EventHandler(this.txt_dapana_Leave);
            // 
            // lb_c
            // 
            this.lb_c.Location = new System.Drawing.Point(394, 129);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(45, 13);
            this.lb_c.TabIndex = 6;
            this.lb_c.Text = "Đáp án C";
            // 
            // lb_b
            // 
            this.lb_b.Location = new System.Drawing.Point(24, 165);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(44, 13);
            this.lb_b.TabIndex = 5;
            this.lb_b.Text = "Đáp án B";
            // 
            // lb_a
            // 
            this.lb_a.Location = new System.Drawing.Point(24, 129);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(45, 13);
            this.lb_a.TabIndex = 4;
            this.lb_a.Text = "Đáp án A";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nội dung";
            // 
            // FrmCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grp_ttsv);
            this.Controls.Add(this.gv_cauhoi);
            this.Name = "FrmCauHoi";
            this.Size = new System.Drawing.Size(1297, 548);
            this.Load += new System.EventHandler(this.FrmCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_cauhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_ttsv)).EndInit();
            this.grp_ttsv.ResumeLayout(false);
            this.grp_ttsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_d.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_c.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frm_checkda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_b.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dapana.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gv_cauhoi;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ct;
        private DevExpress.XtraEditors.GroupControl grp_ttsv;
        private System.Windows.Forms.PictureBox pic_hinh;
        private DevExpress.XtraEditors.TextEdit txt_b;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lb_d;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.TextEdit txt_dapana;
        private DevExpress.XtraEditors.LabelControl lb_c;
        private DevExpress.XtraEditors.LabelControl lb_b;
        private DevExpress.XtraEditors.LabelControl lb_a;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckedListBoxControl frm_checkda;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox cb_loaicauhoi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.RichTextBox txt_cauhoi;
        private DevExpress.XtraEditors.TextEdit txt_d;
        private DevExpress.XtraEditors.TextEdit txt_c;
    }
}
