namespace QuanLyNV_GUI
{
    partial class BaoCaoDoanhThuTheoNgayViewer
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
            this.crvBaoCaoDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();          
            // 
            // crvBaoCaoDoanhThu
            // 
            this.crvBaoCaoDoanhThu.ActiveViewIndex = -1;
            this.crvBaoCaoDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBaoCaoDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBaoCaoDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvBaoCaoDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.crvBaoCaoDoanhThu.Name = "crvBaoCaoDoanhThu";
            this.crvBaoCaoDoanhThu.Size = new System.Drawing.Size(800, 450);
            this.crvBaoCaoDoanhThu.TabIndex = 1;
            this.crvBaoCaoDoanhThu.Load += new System.EventHandler(this.crvBaoCaoDoanhThu_Load);
            // 
            // BaoCaoDanhThuViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvBaoCaoDoanhThu);
            this.Name = "BaoCaoDanhThuViewer";
            this.Text = "BaoCaoDanhThuViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBaoCaoDoanhThu;
    }
}