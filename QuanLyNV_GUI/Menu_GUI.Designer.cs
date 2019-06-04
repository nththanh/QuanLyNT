namespace QuanLyNT_GUI
{
    partial class Menu_GUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mtHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mtNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mtBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.mtQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mtLapPhieuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuTheoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoDoanhThuTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuuHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuuLH = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuuCV = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuuTK = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quánLýThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchTrảHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảHàngNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mtKhachTraHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraHangNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuuThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTraCuuThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtNhapHang,
            this.mtHoaDon,
            this.mtTraHang,
            this.mtQuanLy,
            this.mtBaoCao,
            this.mtTraCuu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mtHoaDon
            // 
            this.mtHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpHóaĐơnToolStripMenuItem});
            this.mtHoaDon.Name = "mtHoaDon";
            this.mtHoaDon.Size = new System.Drawing.Size(65, 20);
            this.mtHoaDon.Text = "Hóa đơn";
            // 
            // mtNhapHang
            // 
            this.mtNhapHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtLapPhieuNhap});
            this.mtNhapHang.Name = "mtNhapHang";
            this.mtNhapHang.Size = new System.Drawing.Size(78, 20);
            this.mtNhapHang.Text = "Nhập hàng";
            this.mtNhapHang.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // mtBaoCao
            // 
            this.mtBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoDoanhThuTheoNgàyToolStripMenuItem,
            this.báoCáoDoanhThuTheoThángToolStripMenuItem,
            this.báoCáiToolStripMenuItem});
            this.mtBaoCao.Name = "mtBaoCao";
            this.mtBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mtBaoCao.Text = "Báo cáo";
            this.mtBaoCao.Click += new System.EventHandler(this.mtBaoCao_Click);
            // 
            // mtTraCuu
            // 
            this.mtTraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtTraCuuNV,
            this.mtTraCuuHD,
            this.mtTraCuuLH,
            this.mtTraCuuCV,
            this.mtTraCuuTK,
            this.mtTraCuuThuoc,
            this.mtTraCuuThietBi});
            this.mtTraCuu.Name = "mtTraCuu";
            this.mtTraCuu.Size = new System.Drawing.Size(58, 20);
            this.mtTraCuu.Text = "Tra cứu";
            // 
            // mtQuanLy
            // 
            this.mtQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem,
            this.quảnLýChứcVụToolStripMenuItem,
            this.quánLýThuốcToolStripMenuItem,
            this.quảnLýLoạiThuốcToolStripMenuItem,
            this.quảnLýKháchTrảHàngToolStripMenuItem,
            this.quảnLýTrảHàngNhàCungCấpToolStripMenuItem});
            this.mtQuanLy.Name = "mtQuanLy";
            this.mtQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mtQuanLy.Text = "Quản lý";
            this.mtQuanLy.Click += new System.EventHandler(this.mtQuanLy_Click);
            // 
            // mtLapPhieuNhap
            // 
            this.mtLapPhieuNhap.Name = "mtLapPhieuNhap";
            this.mtLapPhieuNhap.Size = new System.Drawing.Size(180, 22);
            this.mtLapPhieuNhap.Text = "Lập phiếu nhập";
            this.mtLapPhieuNhap.Click += new System.EventHandler(this.lậpPhiếuNhậpToolStripMenuItem_Click);
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            this.lậpHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnToolStripMenuItem_Click);
            // 
            // báoCáoDoanhThuTheoNgàyToolStripMenuItem
            // 
            this.báoCáoDoanhThuTheoNgàyToolStripMenuItem.Name = "báoCáoDoanhThuTheoNgàyToolStripMenuItem";
            this.báoCáoDoanhThuTheoNgàyToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.báoCáoDoanhThuTheoNgàyToolStripMenuItem.Text = "Báo cáo doanh thu theo ngày";
            this.báoCáoDoanhThuTheoNgàyToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuTheoNgàyToolStripMenuItem_Click);
            // 
            // báoCáoDoanhThuTheoThángToolStripMenuItem
            // 
            this.báoCáoDoanhThuTheoThángToolStripMenuItem.Name = "báoCáoDoanhThuTheoThángToolStripMenuItem";
            this.báoCáoDoanhThuTheoThángToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.báoCáoDoanhThuTheoThángToolStripMenuItem.Text = "Báo cáo doanh thu theo tháng";
            this.báoCáoDoanhThuTheoThángToolStripMenuItem.Click += new System.EventHandler(this.báoCáoDoanhThuTheoThángToolStripMenuItem_Click);
            // 
            // báoCáiToolStripMenuItem
            // 
            this.báoCáiToolStripMenuItem.Name = "báoCáiToolStripMenuItem";
            this.báoCáiToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.báoCáiToolStripMenuItem.Text = "Báo cáo doanh thu tổng quan";
            this.báoCáiToolStripMenuItem.Click += new System.EventHandler(this.báoCáiToolStripMenuItem_Click);
            // 
            // mtTraCuuNV
            // 
            this.mtTraCuuNV.Name = "mtTraCuuNV";
            this.mtTraCuuNV.Size = new System.Drawing.Size(180, 22);
            this.mtTraCuuNV.Text = "Tra cứu nhân viên";
            // 
            // mtTraCuuHD
            // 
            this.mtTraCuuHD.Name = "mtTraCuuHD";
            this.mtTraCuuHD.Size = new System.Drawing.Size(180, 22);
            this.mtTraCuuHD.Text = "Tra cứu hóa đơn";
            // 
            // mtTraCuuLH
            // 
            this.mtTraCuuLH.Name = "mtTraCuuLH";
            this.mtTraCuuLH.Size = new System.Drawing.Size(180, 22);
            this.mtTraCuuLH.Text = "Tra cứu lô hàng";
            // 
            // mtTraCuuCV
            // 
            this.mtTraCuuCV.Name = "mtTraCuuCV";
            this.mtTraCuuCV.Size = new System.Drawing.Size(180, 22);
            this.mtTraCuuCV.Text = "Tra cứu chức vụ";
            // 
            // mtTraCuuTK
            // 
            this.mtTraCuuTK.Name = "mtTraCuuTK";
            this.mtTraCuuTK.Size = new System.Drawing.Size(180, 22);
            this.mtTraCuuTK.Text = "Tra cứu tài khoản";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // quảnLýChứcVụToolStripMenuItem
            // 
            this.quảnLýChứcVụToolStripMenuItem.Name = "quảnLýChứcVụToolStripMenuItem";
            this.quảnLýChứcVụToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quảnLýChứcVụToolStripMenuItem.Text = "Quản lý chức vụ";
            // 
            // quánLýThuốcToolStripMenuItem
            // 
            this.quánLýThuốcToolStripMenuItem.Name = "quánLýThuốcToolStripMenuItem";
            this.quánLýThuốcToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quánLýThuốcToolStripMenuItem.Text = "Quán lý thuốc";
            // 
            // quảnLýLoạiThuốcToolStripMenuItem
            // 
            this.quảnLýLoạiThuốcToolStripMenuItem.Name = "quảnLýLoạiThuốcToolStripMenuItem";
            this.quảnLýLoạiThuốcToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quảnLýLoạiThuốcToolStripMenuItem.Text = "Quản lý loại thuốc";
            // 
            // quảnLýKháchTrảHàngToolStripMenuItem
            // 
            this.quảnLýKháchTrảHàngToolStripMenuItem.Name = "quảnLýKháchTrảHàngToolStripMenuItem";
            this.quảnLýKháchTrảHàngToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quảnLýKháchTrảHàngToolStripMenuItem.Text = "Quản lý khách trả hàng";
            // 
            // quảnLýTrảHàngNhàCungCấpToolStripMenuItem
            // 
            this.quảnLýTrảHàngNhàCungCấpToolStripMenuItem.Name = "quảnLýTrảHàngNhàCungCấpToolStripMenuItem";
            this.quảnLýTrảHàngNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.quảnLýTrảHàngNhàCungCấpToolStripMenuItem.Text = "Quản lý trả hàng nhà cung cấp";
            // 
            // mtTraHang
            // 
            this.mtTraHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtKhachTraHang,
            this.mtTraHangNCC});
            this.mtTraHang.Name = "mtTraHang";
            this.mtTraHang.Size = new System.Drawing.Size(65, 20);
            this.mtTraHang.Text = "Trả hàng";
            // 
            // mtKhachTraHang
            // 
            this.mtKhachTraHang.Name = "mtKhachTraHang";
            this.mtKhachTraHang.Size = new System.Drawing.Size(195, 22);
            this.mtKhachTraHang.Text = "Khách trả hàng";
            // 
            // mtTraHangNCC
            // 
            this.mtTraHangNCC.Name = "mtTraHangNCC";
            this.mtTraHangNCC.Size = new System.Drawing.Size(195, 22);
            this.mtTraHangNCC.Text = "Trả hàng nhà cung cấp";
            // 
            // mtTraCuuThuoc
            // 
            this.mtTraCuuThuoc.Name = "mtTraCuuThuoc";
            this.mtTraCuuThuoc.Size = new System.Drawing.Size(180, 22);
            this.mtTraCuuThuoc.Text = "Tra cứu thuốc";
            // 
            // mtTraCuuThietBi
            // 
            this.mtTraCuuThietBi.Name = "mtTraCuuThietBi";
            this.mtTraCuuThietBi.Size = new System.Drawing.Size(180, 22);
            this.mtTraCuuThietBi.Text = "Tra cứu thiết bị";
            // 
            // Menu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(454, 281);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;

            this.Name = "Menu_GUI";
            this.Text = "Menu_GUI";
            this.Load += new System.EventHandler(this.Menu_GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mtHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mtNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mtBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuu;
        private System.Windows.Forms.ToolStripMenuItem mtLapPhieuNhap;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuTheoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoDoanhThuTheoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuuNV;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuuHD;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuuLH;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuuCV;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuuTK;
        private System.Windows.Forms.ToolStripMenuItem mtTraHang;
        private System.Windows.Forms.ToolStripMenuItem mtKhachTraHang;
        private System.Windows.Forms.ToolStripMenuItem mtTraHangNCC;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quánLýThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiThuốcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchTrảHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảHàngNhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuuThuoc;
        private System.Windows.Forms.ToolStripMenuItem mtTraCuuThietBi;
    }
}