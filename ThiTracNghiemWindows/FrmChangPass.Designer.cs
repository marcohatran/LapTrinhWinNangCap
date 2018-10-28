namespace ThiTracNghiemWindows
{
    partial class FrmChangPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangPass));
            this.txt_mkht = new DevExpress.XtraEditors.TextEdit();
            this.txt_mkmoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mkxn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cb_taikhoan = new System.Windows.Forms.ComboBox();
            this.btn_huy = new DevExpress.XtraEditors.SimpleButton();
            this.btn_doimk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mkht.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mkmoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mkxn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mkht
            // 
            this.txt_mkht.Location = new System.Drawing.Point(144, 88);
            this.txt_mkht.Name = "txt_mkht";
            this.txt_mkht.Properties.PasswordChar = '*';
            this.txt_mkht.Size = new System.Drawing.Size(202, 20);
            this.txt_mkht.TabIndex = 2;
            this.txt_mkht.EditValueChanged += new System.EventHandler(this.txt_mkht_EditValueChanged);
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Location = new System.Drawing.Point(144, 114);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.Properties.PasswordChar = '*';
            this.txt_mkmoi.Size = new System.Drawing.Size(202, 20);
            this.txt_mkmoi.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 137);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 19);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Nhập lại mật khẩu ";
            // 
            // txt_mkxn
            // 
            this.txt_mkxn.Location = new System.Drawing.Point(144, 140);
            this.txt_mkxn.Name = "txt_mkxn";
            this.txt_mkxn.Properties.PasswordChar = '*';
            this.txt_mkxn.Size = new System.Drawing.Size(202, 20);
            this.txt_mkxn.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 19);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Mật khẩu mới ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(108, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Mật khẩu hiện tại ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tài khoản :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(85, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(208, 31);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "ĐỔI MẬT KHẨU";
            // 
            // cb_taikhoan
            // 
            this.cb_taikhoan.FormattingEnabled = true;
            this.cb_taikhoan.Location = new System.Drawing.Point(144, 61);
            this.cb_taikhoan.Name = "cb_taikhoan";
            this.cb_taikhoan.Size = new System.Drawing.Size(202, 21);
            this.cb_taikhoan.TabIndex = 1;
            this.cb_taikhoan.SelectedIndexChanged += new System.EventHandler(this.cb_taikhoan_SelectedIndexChanged);
            // 
            // btn_huy
            // 
            this.btn_huy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huy.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btn_huy.Appearance.Options.UseFont = true;
            this.btn_huy.Appearance.Options.UseForeColor = true;
            this.btn_huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.ImageOptions.Image")));
            this.btn_huy.Location = new System.Drawing.Point(195, 184);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(122, 36);
            this.btn_huy.TabIndex = 6;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_doimk
            // 
            this.btn_doimk.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_doimk.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.btn_doimk.Appearance.Options.UseFont = true;
            this.btn_doimk.Appearance.Options.UseForeColor = true;
            this.btn_doimk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_doimk.ImageOptions.Image")));
            this.btn_doimk.Location = new System.Drawing.Point(39, 184);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(129, 36);
            this.btn_doimk.TabIndex = 5;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // FrmChangPass
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 272);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cb_taikhoan);
            this.Controls.Add(this.txt_mkht);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.txt_mkxn);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Name = "FrmChangPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmChangPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_mkht.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mkmoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mkxn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_mkht;
        private DevExpress.XtraEditors.TextEdit txt_mkmoi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_mkxn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_doimk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_huy;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cb_taikhoan;

    }
}