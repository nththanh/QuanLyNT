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
    public partial class BaoCaoDoanhThuTongQuanViewer : Form
    {
        string connectionString = @"Data Source=USER\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True;";//ConfigurationManager.AppSettings["connectionString"];
        string CRpath = "C:\\Users\\Pc\\資料\\Phan tich thiet ke he thong thong tin\\project\\QuanLyNT\\QuanLyNV_GUI\\";
    
        public BaoCaoDoanhThuTongQuanViewer()
        {
            InitializeComponent();          
            
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
            string cmdText = string.Format("select * from tblHoaDon");
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            adt.Fill(ds, "tblHoaDon");

            cmdText = "select * from tblChiTietHoaDon";
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            adt.Fill(ds, "tblChiTietHoaDon");

            cmdText = "select distinct mathuoc,maloaithuoc,madvt,noisanxuat,ghichu " +
                "from tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc";
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            adt.Fill(ds, "tblThuoc");

            cmdText = "select distinct l.maloaithuoc, l.tenloaithuoc, l.thanhphan, l.chucnang, l.ghichu from " +
                "tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc left " +
                "join tblLoaiThuoc l on l.maloaithuoc = t.maloaithuoc";
            cmd = new SqlCommand(cmdText, con);
            adt = new SqlDataAdapter(cmd);
            adt.Fill(ds, "tblLoaiThuoc");

            ReportDocument rD = new ReportDocument();
            rD.Load(CRpath + "rptBaoCaoDoanhThuTongQuan.rpt");
            rD.SetDataSource(ds);           
           
                      
            crvBaoCaoDoanhThu.ReportSource = rD;
            crvBaoCaoDoanhThu.Refresh();
        }
    }
}
