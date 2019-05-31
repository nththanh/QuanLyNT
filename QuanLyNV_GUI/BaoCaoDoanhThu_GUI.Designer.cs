namespace QuanLyNT_GUI
{
    partial class BaoCaoDoanhThu_GUI
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
            this.btnBaoCaoTheoNgay = new System.Windows.Forms.Button();
            this.btnBaoCaoTheoThang = new System.Windows.Forms.Button();
            this.btnBaoCaoTongQuan = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnBaoCaoTheoNgay
            // 
            this.btnBaoCaoTheoNgay.Location = new System.Drawing.Point(70, 108);
            this.btnBaoCaoTheoNgay.Name = "btnBaoCaoTheoNgay";
            this.btnBaoCaoTheoNgay.Size = new System.Drawing.Size(146, 72);
            this.btnBaoCaoTheoNgay.TabIndex = 0;
            this.btnBaoCaoTheoNgay.Text = "Theo ngày";
            this.btnBaoCaoTheoNgay.UseVisualStyleBackColor = true;
            this.btnBaoCaoTheoNgay.Click += new System.EventHandler(this.btnBaoCaoTheoNgay_Click);
            // 
            // btnBaoCaoTheoThang
            // 
            this.btnBaoCaoTheoThang.Location = new System.Drawing.Point(272, 108);
            this.btnBaoCaoTheoThang.Name = "btnBaoCaoTheoThang";
            this.btnBaoCaoTheoThang.Size = new System.Drawing.Size(146, 72);
            this.btnBaoCaoTheoThang.TabIndex = 1;
            this.btnBaoCaoTheoThang.Text = "Theo tháng";
            this.btnBaoCaoTheoThang.UseVisualStyleBackColor = true;
            this.btnBaoCaoTheoThang.Click += new System.EventHandler(this.btnBaoCaoTheoThang_Click);
            // 
            // btnBaoCaoTongQuan
            // 
            this.btnBaoCaoTongQuan.Location = new System.Drawing.Point(472, 108);
            this.btnBaoCaoTongQuan.Name = "btnBaoCaoTongQuan";
            this.btnBaoCaoTongQuan.Size = new System.Drawing.Size(146, 72);
            this.btnBaoCaoTongQuan.TabIndex = 2;
            this.btnBaoCaoTongQuan.Text = "Tổng quan";
            this.btnBaoCaoTongQuan.UseVisualStyleBackColor = true;
            this.btnBaoCaoTongQuan.Click += new System.EventHandler(this.btnBaoCaoTongQuan_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(240, 44);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayLap.TabIndex = 3;
            // 
            // BaoCaoDoanhThu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 216);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.btnBaoCaoTongQuan);
            this.Controls.Add(this.btnBaoCaoTheoThang);
            this.Controls.Add(this.btnBaoCaoTheoNgay);
            this.Name = "BaoCaoDoanhThu_GUI";
            this.Text = "Báo cáo doanh thu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCaoTheoNgay;
        private System.Windows.Forms.Button btnBaoCaoTheoThang;
        private System.Windows.Forms.Button btnBaoCaoTongQuan;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
    }
}