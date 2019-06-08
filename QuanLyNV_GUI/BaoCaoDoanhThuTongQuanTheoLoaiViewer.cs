using CrystalDecisions.CrystalReports.Engine;
using QuanLyNT_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNV_GUI
{
    public partial class BaoCaoDoanhThuTongQuanTheoLoaiViewer : Form
    {
        string CRpath = "C:\\Users\\Pc\\資料\\Phan tich thiet ke he thong thong tin\\project\\QuanLyNT\\QuanLyNV_GUI\\";
        BaoCaoDoanhThu_BUS bcdt;
        public BaoCaoDoanhThuTongQuanTheoLoaiViewer()
        {
            InitializeComponent();
            bcdt = new BaoCaoDoanhThu_BUS();
            
        }

        private void crvBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            DataSet rs = bcdt.BaoCaoDoanhThuTongQuanTheoLoai();
            ReportDocument rD = new ReportDocument();
            rD.Load(CRpath + "BaoCaoDoanhThuTheoLoaiThuoc.rpt");
            rD.SetDataSource(rs);           
           
                      
            crvBaoCaoDoanhThu.ReportSource = rD;
            crvBaoCaoDoanhThu.Refresh();
        }
    }
}
