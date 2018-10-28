namespace ThiTracNghiemWindows
{
    partial class FrmQLDangKyThi
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
            this.gb_chucnang = new DevExpress.XtraEditors.GroupControl();
            this.btn_dangki = new DevExpress.XtraEditors.SimpleButton();
            this.gv_chuadk = new DevExpress.XtraGrid.GridControl();
            this.gv_ctchuadk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pic_hinh = new System.Windows.Forms.PictureBox();
            this.gb_dangki = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.lb_ngaylb = new System.Windows.Forms.Label();
            this.lb_lanthi = new System.Windows.Forms.Label();
            this.lb_ngaydk = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_ht = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_anh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_dk = new DevExpress.XtraGrid.GridControl();
            this.gv_dsdk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gb_chucnang)).BeginInit();
            this.gb_chucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_chuadk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctchuadk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_dangki)).BeginInit();
            this.gb_dangki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsdk)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_chucnang
            // 
            this.gb_chucnang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_chucnang.Controls.Add(this.btn_dangki);
            this.gb_chucnang.Controls.Add(this.gv_chuadk);
            this.gb_chucnang.Controls.Add(this.pic_hinh);
            this.gb_chucnang.Location = new System.Drawing.Point(3, 3);
            this.gb_chucnang.Name = "gb_chucnang";
            this.gb_chucnang.Size = new System.Drawing.Size(400, 542);
            this.gb_chucnang.TabIndex = 0;
            // 
            // btn_dangki
            // 
            this.btn_dangki.Location = new System.Drawing.Point(59, 214);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(149, 42);
            this.btn_dangki.TabIndex = 2;
            this.btn_dangki.Text = "Đăng ký thi";
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // gv_chuadk
            // 
            this.gv_chuadk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_chuadk.Location = new System.Drawing.Point(2, 288);
            this.gv_chuadk.MainView = this.gv_ctchuadk;
            this.gv_chuadk.Name = "gv_chuadk";
            this.gv_chuadk.Size = new System.Drawing.Size(396, 252);
            this.gv_chuadk.TabIndex = 1;
            this.gv_chuadk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ctchuadk});
            // 
            // gv_ctchuadk
            // 
            this.gv_ctchuadk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gv_ctchuadk.GridControl = this.gv_chuadk;
            this.gv_ctchuadk.Name = "gv_ctchuadk";
            this.gv_ctchuadk.OptionsView.ShowGroupPanel = false;
            this.gv_ctchuadk.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_ctchuadk_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Người dùng";
            this.gridColumn1.FieldName = "HoTen";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Email";
            this.gridColumn2.FieldName = "Email";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // pic_hinh
            // 
            this.pic_hinh.Location = new System.Drawing.Point(74, 45);
            this.pic_hinh.Name = "pic_hinh";
            this.pic_hinh.Size = new System.Drawing.Size(134, 140);
            this.pic_hinh.TabIndex = 0;
            this.pic_hinh.TabStop = false;
            // 
            // gb_dangki
            // 
            this.gb_dangki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_dangki.Controls.Add(this.groupControl1);
            this.gb_dangki.Controls.Add(this.gv_dk);
            this.gb_dangki.Location = new System.Drawing.Point(407, 5);
            this.gb_dangki.Name = "gb_dangki";
            this.gb_dangki.Size = new System.Drawing.Size(790, 540);
            this.gb_dangki.TabIndex = 1;
            this.gb_dangki.Text = "groupControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lb_ketqua);
            this.groupControl1.Controls.Add(this.lb_ngaylb);
            this.groupControl1.Controls.Add(this.lb_lanthi);
            this.groupControl1.Controls.Add(this.lb_ngaydk);
            this.groupControl1.Controls.Add(this.lb_sdt);
            this.groupControl1.Controls.Add(this.lb_email);
            this.groupControl1.Controls.Add(this.lb_diachi);
            this.groupControl1.Controls.Add(this.lb_ngaysinh);
            this.groupControl1.Controls.Add(this.lb_ht);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.pic_anh);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(786, 191);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin thi của thí sinh";
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ketqua.Location = new System.Drawing.Point(648, 130);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(58, 19);
            this.lb_ketqua.TabIndex = 21;
            this.lb_ketqua.Text = "Kết quả";
            // 
            // lb_ngaylb
            // 
            this.lb_ngaylb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ngaylb.AutoSize = true;
            this.lb_ngaylb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ngaylb.Location = new System.Drawing.Point(648, 70);
            this.lb_ngaylb.Name = "lb_ngaylb";
            this.lb_ngaylb.Size = new System.Drawing.Size(89, 19);
            this.lb_ngaylb.TabIndex = 20;
            this.lb_ngaylb.Text = "Ngày làm bài";
            // 
            // lb_lanthi
            // 
            this.lb_lanthi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_lanthi.AutoSize = true;
            this.lb_lanthi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_lanthi.Location = new System.Drawing.Point(648, 100);
            this.lb_lanthi.Name = "lb_lanthi";
            this.lb_lanthi.Size = new System.Drawing.Size(50, 19);
            this.lb_lanthi.TabIndex = 19;
            this.lb_lanthi.Text = "Lần thi";
            // 
            // lb_ngaydk
            // 
            this.lb_ngaydk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ngaydk.AutoSize = true;
            this.lb_ngaydk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ngaydk.Location = new System.Drawing.Point(648, 40);
            this.lb_ngaydk.Name = "lb_ngaydk";
            this.lb_ngaydk.Size = new System.Drawing.Size(94, 19);
            this.lb_ngaydk.TabIndex = 18;
            this.lb_ngaydk.Text = "Ngày đăng ký";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_sdt.Location = new System.Drawing.Point(315, 100);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(88, 19);
            this.lb_sdt.TabIndex = 17;
            this.lb_sdt.Text = "Số điện thoại";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_email.Location = new System.Drawing.Point(315, 130);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(42, 19);
            this.lb_email.TabIndex = 16;
            this.lb_email.Text = "Email";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_diachi.Location = new System.Drawing.Point(315, 160);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(51, 19);
            this.lb_diachi.TabIndex = 15;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ngaysinh.Location = new System.Drawing.Point(315, 70);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(69, 19);
            this.lb_ngaysinh.TabIndex = 14;
            this.lb_ngaysinh.Text = "Ngày sinh";
            // 
            // lb_ht
            // 
            this.lb_ht.AutoSize = true;
            this.lb_ht.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_ht.Location = new System.Drawing.Point(315, 40);
            this.lb_ht.Name = "lb_ht";
            this.lb_ht.Size = new System.Drawing.Size(50, 19);
            this.lb_ht.TabIndex = 13;
            this.lb_ht.Text = "Họ tên";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(535, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Kết quả";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(535, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ngày làm bài";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(535, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lần thi";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(535, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày đăng ký";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(220, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(220, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(220, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(220, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày sinh";
            // 
            // pic_anh
            // 
            this.pic_anh.Location = new System.Drawing.Point(36, 34);
            this.pic_anh.Name = "pic_anh";
            this.pic_anh.Size = new System.Drawing.Size(134, 140);
            this.pic_anh.TabIndex = 3;
            this.pic_anh.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(220, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ tên";
            // 
            // gv_dk
            // 
            this.gv_dk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gv_dk.Location = new System.Drawing.Point(2, 291);
            this.gv_dk.MainView = this.gv_dsdk;
            this.gv_dk.Name = "gv_dk";
            this.gv_dk.Size = new System.Drawing.Size(786, 247);
            this.gv_dk.TabIndex = 1;
            this.gv_dk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_dsdk});
            // 
            // gv_dsdk
            // 
            this.gv_dsdk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gv_dsdk.GridControl = this.gv_dk;
            this.gv_dsdk.Name = "gv_dsdk";
            this.gv_dsdk.OptionsBehavior.Editable = false;
            this.gv_dsdk.OptionsBehavior.ReadOnly = true;
            this.gv_dsdk.OptionsView.ShowGroupPanel = false;
            this.gv_dsdk.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_dsdk_FocusedRowChanged_1);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mã đăng kí";
            this.gridColumn3.FieldName = "MaDK";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "HoTen";
            this.gridColumn4.FieldName = "HoTen";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngày đăng ký";
            this.gridColumn5.FieldName = "NgayDK";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Email";
            this.gridColumn6.FieldName = "Mail";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã đề";
            this.gridColumn7.FieldName = "MaDe";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tình Trạng";
            this.gridColumn8.FieldName = "TT";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // FrmQLDangKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_dangki);
            this.Controls.Add(this.gb_chucnang);
            this.Name = "FrmQLDangKyThi";
            this.Size = new System.Drawing.Size(1200, 548);
            this.Load += new System.EventHandler(this.FrmQLDangKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb_chucnang)).EndInit();
            this.gb_chucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_chuadk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ctchuadk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_dangki)).EndInit();
            this.gb_dangki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dsdk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gb_chucnang;
        private DevExpress.XtraEditors.SimpleButton btn_dangki;
        private DevExpress.XtraGrid.GridControl gv_chuadk;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ctchuadk;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.PictureBox pic_hinh;
        private DevExpress.XtraEditors.GroupControl gb_dangki;
        private DevExpress.XtraGrid.GridControl gv_dk;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_dsdk;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.Label lb_ngaylb;
        private System.Windows.Forms.Label lb_lanthi;
        private System.Windows.Forms.Label lb_ngaydk;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_ht;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_anh;
        private System.Windows.Forms.Label label1;
    }
}
