namespace ThiTracNghiemWindows
{
    partial class FrmPMThi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPMThi));
            this.gb_cauhoi = new DevExpress.XtraEditors.GroupControl();
            this.btn_next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pre = new DevExpress.XtraEditors.SimpleButton();
            this.txt_dapand = new System.Windows.Forms.RichTextBox();
            this.txt_dapanc = new System.Windows.Forms.RichTextBox();
            this.txt_dapanb = new System.Windows.Forms.RichTextBox();
            this.txt_dapana = new System.Windows.Forms.RichTextBox();
            this.cauhoi = new System.Windows.Forms.RichTextBox();
            this.gb_nopbai = new DevExpress.XtraEditors.GroupControl();
            this.btn_nopbai = new DevExpress.XtraEditors.SimpleButton();
            this.gb_ketqua = new DevExpress.XtraEditors.GroupControl();
            this.gv_trl = new DevExpress.XtraGrid.GridControl();
            this.gv_dapan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cb_dk = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gb_cauhoi)).BeginInit();
            this.gb_cauhoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gb_nopbai)).BeginInit();
            this.gb_nopbai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gb_ketqua)).BeginInit();
            this.gb_ketqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_trl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dapan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_dk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_cauhoi
            // 
            this.gb_cauhoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_cauhoi.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.gb_cauhoi.Appearance.Options.UseBackColor = true;
            this.gb_cauhoi.Controls.Add(this.btn_next);
            this.gb_cauhoi.Controls.Add(this.btn_pre);
            this.gb_cauhoi.Controls.Add(this.txt_dapand);
            this.gb_cauhoi.Controls.Add(this.txt_dapanc);
            this.gb_cauhoi.Controls.Add(this.txt_dapanb);
            this.gb_cauhoi.Controls.Add(this.txt_dapana);
            this.gb_cauhoi.Controls.Add(this.cauhoi);
            this.gb_cauhoi.Location = new System.Drawing.Point(-1, 0);
            this.gb_cauhoi.Name = "gb_cauhoi";
            this.gb_cauhoi.Size = new System.Drawing.Size(772, 729);
            this.gb_cauhoi.TabIndex = 4;
            this.gb_cauhoi.TabStop = true;
            this.gb_cauhoi.Text = "Câu hỏi";
            // 
            // btn_next
            // 
            this.btn_next.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_next.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btn_next.Appearance.Options.UseFont = true;
            this.btn_next.Appearance.Options.UseForeColor = true;
            this.btn_next.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.ImageOptions.Image")));
            this.btn_next.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_next.Location = new System.Drawing.Point(438, 611);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(118, 43);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = "Next";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Appearance.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_pre.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btn_pre.Appearance.Options.UseFont = true;
            this.btn_pre.Appearance.Options.UseForeColor = true;
            this.btn_pre.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_pre.ImageOptions.Image")));
            this.btn_pre.Location = new System.Drawing.Point(267, 611);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(117, 43);
            this.btn_pre.TabIndex = 11;
            this.btn_pre.Text = "Previous";
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // txt_dapand
            // 
            this.txt_dapand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dapand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_dapand.Location = new System.Drawing.Point(385, 347);
            this.txt_dapand.Margin = new System.Windows.Forms.Padding(0);
            this.txt_dapand.Name = "txt_dapand";
            this.txt_dapand.Size = new System.Drawing.Size(370, 100);
            this.txt_dapand.TabIndex = 10;
            this.txt_dapand.Text = "";
            // 
            // txt_dapanc
            // 
            this.txt_dapanc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_dapanc.Location = new System.Drawing.Point(14, 347);
            this.txt_dapanc.Margin = new System.Windows.Forms.Padding(0);
            this.txt_dapanc.Name = "txt_dapanc";
            this.txt_dapanc.Size = new System.Drawing.Size(370, 100);
            this.txt_dapanc.TabIndex = 9;
            this.txt_dapanc.Text = "";
            // 
            // txt_dapanb
            // 
            this.txt_dapanb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dapanb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_dapanb.Location = new System.Drawing.Point(385, 185);
            this.txt_dapanb.Margin = new System.Windows.Forms.Padding(0);
            this.txt_dapanb.Name = "txt_dapanb";
            this.txt_dapanb.Size = new System.Drawing.Size(370, 100);
            this.txt_dapanb.TabIndex = 8;
            this.txt_dapanb.Text = "";
            // 
            // txt_dapana
            // 
            this.txt_dapana.BackColor = System.Drawing.SystemColors.Window;
            this.txt_dapana.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_dapana.Location = new System.Drawing.Point(14, 185);
            this.txt_dapana.Margin = new System.Windows.Forms.Padding(0);
            this.txt_dapana.Name = "txt_dapana";
            this.txt_dapana.Size = new System.Drawing.Size(370, 100);
            this.txt_dapana.TabIndex = 7;
            this.txt_dapana.Text = "";
            // 
            // cauhoi
            // 
            this.cauhoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cauhoi.BackColor = System.Drawing.SystemColors.Window;
            this.cauhoi.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cauhoi.ForeColor = System.Drawing.Color.Black;
            this.cauhoi.Location = new System.Drawing.Point(14, 33);
            this.cauhoi.Margin = new System.Windows.Forms.Padding(0);
            this.cauhoi.Name = "cauhoi";
            this.cauhoi.Size = new System.Drawing.Size(741, 90);
            this.cauhoi.TabIndex = 3;
            this.cauhoi.Text = "";
            // 
            // gb_nopbai
            // 
            this.gb_nopbai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_nopbai.Controls.Add(this.btn_nopbai);
            this.gb_nopbai.Location = new System.Drawing.Point(777, 0);
            this.gb_nopbai.Name = "gb_nopbai";
            this.gb_nopbai.Size = new System.Drawing.Size(291, 336);
            this.gb_nopbai.TabIndex = 5;
            // 
            // btn_nopbai
            // 
            this.btn_nopbai.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_nopbai.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btn_nopbai.Appearance.Options.UseFont = true;
            this.btn_nopbai.Appearance.Options.UseForeColor = true;
            this.btn_nopbai.ImageOptions.Image = global::ThiTracNghiemWindows.Properties.Resources.submit;
            this.btn_nopbai.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_nopbai.Location = new System.Drawing.Point(15, 97);
            this.btn_nopbai.Name = "btn_nopbai";
            this.btn_nopbai.Size = new System.Drawing.Size(248, 68);
            this.btn_nopbai.TabIndex = 0;
            this.btn_nopbai.Text = "NỘP BÀI";
            this.btn_nopbai.Click += new System.EventHandler(this.btn_nopbai_Click);
            // 
            // gb_ketqua
            // 
            this.gb_ketqua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_ketqua.Controls.Add(this.gv_trl);
            this.gb_ketqua.Controls.Add(this.cb_dk);
            this.gb_ketqua.Location = new System.Drawing.Point(777, 197);
            this.gb_ketqua.Name = "gb_ketqua";
            this.gb_ketqua.Size = new System.Drawing.Size(291, 521);
            this.gb_ketqua.TabIndex = 6;
            this.gb_ketqua.Text = "Trả lời";
            // 
            // gv_trl
            // 
            this.gv_trl.Location = new System.Drawing.Point(5, 62);
            this.gv_trl.MainView = this.gv_dapan;
            this.gv_trl.Name = "gv_trl";
            this.gv_trl.Size = new System.Drawing.Size(281, 454);
            this.gv_trl.TabIndex = 1;
            this.gv_trl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_dapan});
            // 
            // gv_dapan
            // 
            this.gv_dapan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_dapan.GridControl = this.gv_trl;
            this.gv_dapan.Name = "gv_dapan";
            this.gv_dapan.OptionsView.ShowGroupPanel = false;
            this.gv_dapan.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_dapan_CellValueChanged);
            this.gv_dapan.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_dapan_CellValueChanging);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Câu hỏi";
            this.gridColumn1.FieldName = "cauhoi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 45;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "A";
            this.gridColumn2.FieldName = "a";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 45;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "B";
            this.gridColumn3.FieldName = "b";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 44;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "C";
            this.gridColumn4.FieldName = "c";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 48;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "D";
            this.gridColumn5.FieldName = "d";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 47;
            // 
            // cb_dk
            // 
            this.cb_dk.Location = new System.Drawing.Point(5, 32);
            this.cb_dk.Name = "cb_dk";
            this.cb_dk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_dk.Properties.Appearance.Options.UseFont = true;
            this.cb_dk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_dk.Properties.Items.AddRange(new object[] {
            "Tất cả các câu trả lời",
            "Câu chưa trả lời",
            "Câu đã trả lời"});
            this.cb_dk.Size = new System.Drawing.Size(270, 22);
            this.cb_dk.TabIndex = 0;
            this.cb_dk.SelectedIndexChanged += new System.EventHandler(this.cb_dk_SelectedIndexChanged);
            // 
            // FrmPMThi
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 730);
            this.Controls.Add(this.gb_ketqua);
            this.Controls.Add(this.gb_cauhoi);
            this.Controls.Add(this.gb_nopbai);
            this.Name = "FrmPMThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPMThi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPMThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gb_cauhoi)).EndInit();
            this.gb_cauhoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gb_nopbai)).EndInit();
            this.gb_nopbai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gb_ketqua)).EndInit();
            this.gb_ketqua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_trl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_dapan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_dk.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gb_cauhoi;
        private DevExpress.XtraEditors.GroupControl gb_nopbai;
        private DevExpress.XtraEditors.SimpleButton btn_nopbai;
        private System.Windows.Forms.RichTextBox cauhoi;
        private DevExpress.XtraEditors.GroupControl gb_ketqua;
        private DevExpress.XtraEditors.ComboBoxEdit cb_dk;
        private System.Windows.Forms.RichTextBox txt_dapand;
        private System.Windows.Forms.RichTextBox txt_dapanc;
        private System.Windows.Forms.RichTextBox txt_dapanb;
        private System.Windows.Forms.RichTextBox txt_dapana;
        private DevExpress.XtraEditors.SimpleButton btn_next;
        private DevExpress.XtraEditors.SimpleButton btn_pre;
        private DevExpress.XtraGrid.GridControl gv_trl;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_dapan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}