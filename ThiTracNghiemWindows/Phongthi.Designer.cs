namespace ThiTracNghiemWindows
{
    partial class Phongthi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phongthi));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lb_tenphong = new DevExpress.XtraEditors.LabelControl();
            this.lb_sv = new DevExpress.XtraEditors.LabelControl();
            this.btn_chitiet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(23, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Properties.ZoomPercent = 150D;
            this.pictureEdit1.Size = new System.Drawing.Size(69, 64);
            this.pictureEdit1.TabIndex = 0;
            // 
            // lb_tenphong
            // 
            this.lb_tenphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tenphong.Appearance.Options.UseFont = true;
            this.lb_tenphong.Location = new System.Drawing.Point(29, 73);
            this.lb_tenphong.Name = "lb_tenphong";
            this.lb_tenphong.Size = new System.Drawing.Size(52, 22);
            this.lb_tenphong.TabIndex = 1;
            this.lb_tenphong.Text = "Phong";
            // 
            // lb_sv
            // 
            this.lb_sv.Location = new System.Drawing.Point(21, 101);
            this.lb_sv.Name = "lb_sv";
            this.lb_sv.Size = new System.Drawing.Size(71, 13);
            this.lb_sv.TabIndex = 2;
            this.lb_sv.Text = "Số SV thi: 2/20";
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.Location = new System.Drawing.Point(19, 120);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(75, 23);
            this.btn_chitiet.TabIndex = 3;
            this.btn_chitiet.Text = "Xem chi tiết";
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // Phongthi
            // 
            this.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_chitiet);
            this.Controls.Add(this.lb_sv);
            this.Controls.Add(this.lb_tenphong);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "Phongthi";
            this.Size = new System.Drawing.Size(120, 150);
            this.Load += new System.EventHandler(this.Phongthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lb_tenphong;
        private DevExpress.XtraEditors.LabelControl lb_sv;
        private DevExpress.XtraEditors.SimpleButton btn_chitiet;
    }
}
