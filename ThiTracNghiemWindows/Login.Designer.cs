namespace ThiTracNghiemWindows
{
    partial class Login
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
            this.userControlDangNhap1 = new ThiTracNghiemWindows.UserControlDangNhap();
            this.SuspendLayout();
            // 
            // userControlDangNhap1
            // 
            this.userControlDangNhap1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.userControlDangNhap1.Appearance.Options.UseBackColor = true;
            this.userControlDangNhap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDangNhap1.Location = new System.Drawing.Point(0, 0);
            this.userControlDangNhap1.Name = "userControlDangNhap1";
            this.userControlDangNhap1.Size = new System.Drawing.Size(485, 219);
            this.userControlDangNhap1.TabIndex = 0;
            this.userControlDangNhap1.Load += new System.EventHandler(this.userControlDangNhap1_Load);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 219);
            this.Controls.Add(this.userControlDangNhap1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlDangNhap userControlDangNhap1;
    }
}