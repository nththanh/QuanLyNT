using CrystalDecisions.CrystalReports.Engine;
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
    public partial class BaoCaoDoanhThuTheoNgayViewer : Form
    {
        string connectionString = @"Data Source=USER\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True;";//ConfigurationManager.AppSettings["connectionString"];
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

        }

        private void crvBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = connectionString;
            
            con.Open();
            SqlDataAdapter adt;
            DataSet ds = new DataSet();
            //sau khi tạo DAL của các bảng liên quan thì đổi cái đống dưới đây lại cho khớp với class diagram
            string cmdText = string.Format("select * from tblHoaDon where year(ngaylap)={0} and month(ngaylap)={1} and day(ngaylap)={2}", Nam, Thang, Ngay);
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            adt.Fill(ds, "tblHoaDon");

            cmdText = string.Format("select * from tblChiTietHoaDon c where " +
                "exists(select * from tblHoaDon h where year(h.ngaylap)={0} " +
                "and month(h.ngaylap)={1} and day(h.ngaylap)={2} and c.mahoadon=h.mahoadon)",
                Nam, Thang, Ngay);
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            adt.Fill(ds, "tblChiTietHoaDon");

            cmdText = string.Format("select distinct mathuoc,maloaithuoc,madvt,noisanxuat,ghichu from tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc " +
                "where exists(select * from tblHoaDon h where year(h.ngaylap)={0} " +
                "and month(h.ngaylap)={1} and day(h.ngaylap)={2} and c.mahoadon=h.mahoadon)",
                Nam, Thang, Ngay);
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            adt.Fill(ds, "tblThuoc");

            cmdText = string.Format("select distinct l.maloaithuoc, l.tenloaithuoc, l.thanhphan, l.chucnang, l.ghichu from " +
                "tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc left " +
                "join tblLoaiThuoc l on l.maloaithuoc = t.maloaithuoc where " +
                "exists(select *from tblHoaDon h where year(h.ngaylap) = {0} " +
                "and month(h.ngaylap) = {1} and day(h.ngaylap) = {2} and c.mahoadon = h.mahoadon)"
                , Nam, Thang, Ngay);
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            
            ReportDocument rD = new ReportDocument();
            rD.Load(CRpath + "rptBaoCaoDoanhThuTheoNgay.rpt");
            rD.SetDataSource(ds);           
            rD.SetParameterValue("Ngay", this.Ngay);
            rD.SetParameterValue("Thang", this.Thang);
            rD.SetParameterValue("Nam", this.Nam);
                      
            crvBaoCaoDoanhThu.ReportSource = rD;
            crvBaoCaoDoanhThu.Refresh();
        }
    }
}
