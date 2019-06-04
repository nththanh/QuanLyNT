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
    public partial class BaoCaoDoanhThuTheoThangViewer : Form
    {
        string CRpath = "C:\\Users\\Pc\\資料\\Phan tich thiet ke he thong thong tin\\project\\QuanLyNT\\QuanLyNV_GUI\\";
        BaoCaoDoanhThu_BUS bcdt;   
        int Thang;
        int Nam;
        public BaoCaoDoanhThuTheoThangViewer(int Thang, int Nam)
        {
            InitializeComponent();          
            this.Thang = Thang;
            this.Nam = Nam;
            this.bcdt = new BaoCaoDoanhThu_BUS();
        }

        private void crvBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

            ReportDocument rD = new ReportDocument();
            rD.Load(CRpath + "rptBaoCaoDoanhThuTheoThang.rpt");
            DataSet rs = bcdt.BaoCaoDoanhThuTheoThang(Thang, Nam);

            rD.SetDataSource(rs);
            rD.SetParameterValue("Thang", this.Thang);
            rD.SetParameterValue("Nam", this.Nam);

            crvBaoCaoDoanhThu.ReportSource = rD;
            crvBaoCaoDoanhThu.Refresh(); ;
        }
    }
}
