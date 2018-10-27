namespace ThiTracNghiemWindows
{
    partial class FrmDeThi
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
            this.boDeDataLayoutControl = new DevExpress.XtraDataLayout.DataLayoutControl();
            ((System.ComponentModel.ISupportInitialize)(this.boDeDataLayoutControl)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // boDeDataLayoutControl
            // 
            this.boDeDataLayoutControl.Location = new System.Drawing.Point(185, 134);
            this.boDeDataLayoutControl.Name = "boDeDataLayoutControl";
            this.boDeDataLayoutControl.Root = null;
            this.boDeDataLayoutControl.Size = new System.Drawing.Size(300, 220);
            this.boDeDataLayoutControl.TabIndex = 0;
            this.boDeDataLayoutControl.Text = "dataLayoutControl1";
            this.Controls.Add(this.boDeDataLayoutControl);
            this.Name = "FrmDeThi";
            this.Size = new System.Drawing.Size(706, 494);
            this.Load += new System.EventHandler(this.FrmDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boDeDataLayoutControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl boDeDataLayoutControl;

    }
}
