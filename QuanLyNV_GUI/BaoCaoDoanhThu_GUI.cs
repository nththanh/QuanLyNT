using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using QuanLyNT_DAL;
using QuanLyNV_GUI;

namespace QuanLyNT_GUI
{
    public partial class BaoCaoDoanhThu_GUI : Form
    {
        string connectionString = "Data Source=USER\\SQLSERVER;Initial Catalog=QLNT;Integrated Security=True";//ConfigurationManager.AppSettings["connectionString"];
        public BaoCaoDoanhThu_GUI()
        {
            InitializeComponent();
        }

        private void btnBaoCaoTheoNgay_Click(object sender, EventArgs e)
        {
            
            int Ngay = dtpNgayLap.Value.Day;
            int Thang = dtpNgayLap.Value.Month;
            int Nam = dtpNgayLap.Value.Year;
            BaoCaoDoanhThuTheoNgayViewer viewer = new BaoCaoDoanhThuTheoNgayViewer(Ngay, Thang, Nam);
            viewer.Show(); 

            
        }

        private void btnBaoCaoTheoThang_Click(object sender, EventArgs e)
        {
            int Thang = dtpNgayLap.Value.Month;
            int Nam = dtpNgayLap.Value.Year;
            BaoCaoDoanhThuTheoThangViewer viewer = new BaoCaoDoanhThuTheoThangViewer(Thang, Nam);
            viewer.Show();
        }

        private void btnBaoCaoTongQuan_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuTongQuanViewer viewer = new BaoCaoDoanhThuTongQuanViewer();
            viewer.Show();
        }

        private void BaoCaoDoanhThu_GUI_Load(object sender, EventArgs e)
        {

        }

        private void btnTongQuanTheoLoai_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuTongQuanTheoLoaiViewer viewer = new BaoCaoDoanhThuTongQuanTheoLoaiViewer();
            viewer.Show();
        }
    }
}
