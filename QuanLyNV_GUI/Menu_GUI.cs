using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNT_GUI
{
    public partial class Menu_GUI : Form
    {
        private int cv;
        public Menu_GUI()
        {
            InitializeComponent();
        }

        public Menu_GUI(int CV)
        {
            InitializeComponent();
            cv = CV;
        }

        private void Menu_GUI_Load(object sender, EventArgs e)
        {
            if (cv != 1)
            {
                
            }
            else
            {
                mtQuanLy.Visible = false;
                mtBaoCao.Visible = false;
                mtTraHangNCC.Visible = false;
                mtNhapHang.Visible = false;
                mtTraCuuNV.Visible = false;
                mtTraCuuCV.Visible = false;
                mtTraCuuTK.Visible = false;
                mtTraCuuLH.Visible = false;
            }
        }      

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void báoCáoDoanhThuTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoDoanhThu_GUI bc = new BaoCaoDoanhThu_GUI();
            bc.ShowDialog();
            this.Show();
            //int Ngay = dtpNgayLap.Value.Day;
            //int Thang = dtpNgayLap.Value.Month;
            //int Nam = dtpNgayLap.Value.Year;
            //BaoCaoDoanhThuTheoNgayViewer viewer = new BaoCaoDoanhThuTheoNgayViewer(Ngay, Thang, Nam);
            //viewer.Show();
        }

        private void báoCáoDoanhThuTheoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int Thang = dtpNgayLap.Value.Month;
            //int Nam = dtpNgayLap.Value.Year;
            //BaoCaoDoanhThuTheoThangViewer viewer = new BaoCaoDoanhThuTheoThangViewer(Thang, Nam);
            //viewer.Show();
        }

        private void báoCáiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BaoCaoDoanhThuTongQuanViewer viewer = new BaoCaoDoanhThuTongQuanViewer();
            //viewer.Show();
        }

        private void lậpPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mtBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void mtQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon_GUI hd = new HoaDon_GUI();
            hd.ShowDialog();
            this.Show();
        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoDoanhThu_GUI bc = new BaoCaoDoanhThu_GUI();
            bc.ShowDialog();
            this.Show();
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien_GUI qlnv = new QuanLyNhanVien_GUI();
            qlnv.ShowDialog();
            this.Show();
        }
    }
}
