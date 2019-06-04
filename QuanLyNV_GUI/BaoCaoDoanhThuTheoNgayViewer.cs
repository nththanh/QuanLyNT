using CrystalDecisions.CrystalReports.Engine;
using QuanLyNT_GUI;
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
using QuanLyNT_BUS;

namespace QuanLyNV_GUI
{
    public partial class BaoCaoDoanhThuTheoNgayViewer : Form
    {
        BaoCaoDoanhThu_BUS bcdt;
        string CRpath = "C:\\Users\\Pc\\資料\\Phan tich thiet ke he thong thong tin\\project\\QuanLyNT\\QuanLyNV_GUI\\";
        int Ngay;
        int Thang;
        int Nam;
        public BaoCaoDoanhThuTheoNgayViewer(int Ngay,int Thang, int Nam)
        {
            InitializeComponent();
            this.Ngay = Ngay;
            this.Thang = Thang;
            this.Nam = Nam;
            this.bcdt = new BaoCaoDoanhThu_BUS();
        }

        private void crvBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

           
            ReportDocument rD = new ReportDocument();      
            rD.Load(CRpath + "rptBaoCaoDoanhThuTheoNgay.rpt");         
            DataSet rs = bcdt.BaoCaoDoanhThuTheoNgay(Ngay, Thang, Nam);

            rD.SetDataSource(rs);           
            rD.SetParameterValue("Ngay", this.Ngay);
            rD.SetParameterValue("Thang", this.Thang);
            rD.SetParameterValue("Nam", this.Nam);
                      
            crvBaoCaoDoanhThu.ReportSource = rD;
            crvBaoCaoDoanhThu.Refresh();
        }
    }
}
