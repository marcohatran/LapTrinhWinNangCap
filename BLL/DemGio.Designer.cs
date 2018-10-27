namespace BLL
{
    partial class DemGio
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
            this.phut = new DevExpress.XtraEditors.LabelControl();
            this.giay = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.demh = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // phut
            // 
            this.phut.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phut.Appearance.ForeColor = System.Drawing.Color.Red;
            this.phut.Appearance.Options.UseFont = true;
            this.phut.Appearance.Options.UseForeColor = true;
            this.phut.Location = new System.Drawing.Point(2, 12);
            this.phut.Name = "phut";
            this.phut.Size = new System.Drawing.Size(48, 45);
            this.phut.TabIndex = 0;
            this.phut.Text = "00";
            // 
            // giay
            // 
            this.giay.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.giay.Appearance.ForeColor = System.Drawing.Color.Red;
            this.giay.Appearance.Options.UseFont = true;
            this.giay.Appearance.Options.UseForeColor = true;
            this.giay.Location = new System.Drawing.Point(73, 12);
            this.giay.Name = "giay";
            this.giay.Size = new System.Drawing.Size(48, 45);
            this.giay.TabIndex = 1;
            this.giay.Text = "00";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(54, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(13, 45);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = ":";
            // 
            // demh
            // 
            this.demh.Enabled = true;
            this.demh.Interval = 1000;
            this.demh.Tick += new System.EventHandler(this.demh_Tick);
            // 
            // DemGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.giay);
            this.Controls.Add(this.phut);
            this.Name = "DemGio";
            this.Size = new System.Drawing.Size(138, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl phut;
        private DevExpress.XtraEditors.LabelControl giay;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Timer demh;

    }
}
