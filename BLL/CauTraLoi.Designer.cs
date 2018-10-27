namespace BLL
{
    partial class CauTraLoi
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
            this.rdg_trl = new DevExpress.XtraEditors.RadioGroup();
            this.lb_cauhoi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_trl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rdg_trl
            // 
            this.rdg_trl.Location = new System.Drawing.Point(54, 0);
            this.rdg_trl.Name = "rdg_trl";
            this.rdg_trl.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "A"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "B"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "C"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "D")});
            this.rdg_trl.Size = new System.Drawing.Size(166, 30);
            this.rdg_trl.TabIndex = 0;
            this.rdg_trl.SelectedIndexChanged += new System.EventHandler(this.rdg_trl_SelectedIndexChanged);
            // 
            // lb_cauhoi
            // 
            this.lb_cauhoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_cauhoi.Appearance.Options.UseFont = true;
            this.lb_cauhoi.Location = new System.Drawing.Point(3, 8);
            this.lb_cauhoi.Name = "lb_cauhoi";
            this.lb_cauhoi.Size = new System.Drawing.Size(45, 16);
            this.lb_cauhoi.TabIndex = 1;
            this.lb_cauhoi.Text = "Câu 01:";
            // 
            // CauTraLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_cauhoi);
            this.Controls.Add(this.rdg_trl);
            this.Name = "CauTraLoi";
            this.Size = new System.Drawing.Size(220, 30);
            this.Load += new System.EventHandler(this.CauTraLoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rdg_trl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup rdg_trl;
        private DevExpress.XtraEditors.LabelControl lb_cauhoi;
    }
}
