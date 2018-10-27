namespace ThiTracNghiemWindows
{
    partial class FrmShowDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_causai = new System.Windows.Forms.Label();
            this.lb_caudung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(68, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số câu sai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(44, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số câu đúng :";
            // 
            // lb_causai
            // 
            this.lb_causai.AutoSize = true;
            this.lb_causai.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_causai.Location = new System.Drawing.Point(198, 154);
            this.lb_causai.Name = "lb_causai";
            this.lb_causai.Size = new System.Drawing.Size(100, 23);
            this.lb_causai.TabIndex = 2;
            this.lb_causai.Text = "Số câu sai:";
            // 
            // lb_caudung
            // 
            this.lb_caudung.AutoSize = true;
            this.lb_caudung.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_caudung.Location = new System.Drawing.Point(198, 199);
            this.lb_caudung.Name = "lb_caudung";
            this.lb_caudung.Size = new System.Drawing.Size(124, 23);
            this.lb_caudung.TabIndex = 3;
            this.lb_caudung.Text = "Số câu đúng :";
            // 
            // FrmShowDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 385);
            this.Controls.Add(this.lb_caudung);
            this.Controls.Add(this.lb_causai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmShowDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin kết quả ";
            this.Load += new System.EventHandler(this.FrmShowDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_causai;
        private System.Windows.Forms.Label lb_caudung;
    }
}