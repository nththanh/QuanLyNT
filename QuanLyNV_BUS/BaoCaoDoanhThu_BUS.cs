using QuanLyNT_DAL;
using QuanLyNT_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNT_BUS
{
    //khi tạo xong HoaDonDAL, ChiTietHoaDonDAL, ThuocDAL, LoaiThuocDAL
    // thì chỉnh lại ở đây cho giống với thiết kế trong class diagram
    public class BaoCaoDoanhThu_BUS
    {
        ChiTietHoaDon_DAL cthd = new ChiTietHoaDon_DAL();
        HoaDon_DAL hd = new HoaDon_DAL();
        Thuoc_DAL t = new Thuoc_DAL();
        LoaiThuoc_DAL lt = new LoaiThuoc_DAL();

         

        public DataSet BaoCaoDoanhThuTheoNgay(int Ngay,int Thang, int Nam)
        {
            DataSet rs = new DataSet();
            //Hóa đơn
            string cmdText = string.Format("select * from tblHoaDon where year(ngaylap)={0} and month(ngaylap)={1} and day(ngaylap)={2}", Nam, Thang, Ngay);
            DataTable HoaDon = hd.Display(cmdText);
            HoaDon.TableName="tblHoaDon";
            rs.Tables.Add(HoaDon);

            //Chi tiết hóa đơn
            cmdText = string.Format("select * from tblChiTietHoaDon c where " +
                "exists(select * from tblHoaDon h where year(h.ngaylap)={0} " +
                "and month(h.ngaylap)={1} and day(h.ngaylap)={2} and c.mahoadon=h.mahoadon)",
                Nam, Thang, Ngay);
            DataTable ChiTietHoaDon = cthd.Display(cmdText);
            ChiTietHoaDon.TableName = "tblChiTietHoaDon";
            rs.Tables.Add(ChiTietHoaDon);
            //Thuốc
            cmdText = string.Format("select distinct mathuoc,maloaithuoc,madvt,noisanxuat,ghichu from tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc " +
                "where exists(select * from tblHoaDon h where year(h.ngaylap)={0} " +
                "and month(h.ngaylap)={1} and day(h.ngaylap)={2} and c.mahoadon=h.mahoadon)",
                Nam, Thang, Ngay);
            DataTable Thuoc = t.Display(cmdText);
            Thuoc.TableName = "tblThuoc";
            rs.Tables.Add(Thuoc);
            //Loại thuốc
            cmdText = string.Format("select distinct l.maloaithuoc, l.tenloaithuoc, l.thanhphan, l.chucnang, l.ghichu from " +
                "tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc left " +
                "join tblLoaiThuoc l on l.maloaithuoc = t.maloaithuoc where " +
                "exists(select *from tblHoaDon h where year(h.ngaylap) = {0} " +
                "and month(h.ngaylap) = {1} and day(h.ngaylap) = {2} and c.mahoadon = h.mahoadon)"
                , Nam, Thang, Ngay);
            DataTable LoaiThuoc = lt.Display(cmdText);
            LoaiThuoc.TableName = "tblLoaiThuoc";
            rs.Tables.Add(LoaiThuoc);

            return rs;
        }
        public DataSet BaoCaoDoanhThuTheoThang(int Thang, int Nam)
        {
            DataSet rs = new DataSet();
            //Hóa đơn
            string cmdText = string.Format("select * from tblHoaDon where year(ngaylap)={0} and month(ngaylap)={1}", Nam, Thang);
            DataTable HoaDon = hd.Display(cmdText);
            HoaDon.TableName = "tblHoaDon";
            rs.Tables.Add(HoaDon);

            //Chi tiết hóa đơn
            cmdText = string.Format("select * from tblChiTietHoaDon c where " +
                "exists(select * from tblHoaDon h where year(h.ngaylap)={0} " +
                "and month(h.ngaylap)={1} and c.mahoadon=h.mahoadon)",
                Nam, Thang);
            DataTable ChiTietHoaDon = cthd.Display(cmdText);
            ChiTietHoaDon.TableName = "tblChiTietHoaDon";
            rs.Tables.Add(ChiTietHoaDon);
            //Thuốc
            cmdText = string.Format("select distinct mathuoc,maloaithuoc,madvt,noisanxuat,ghichu from tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc " +
                "where exists(select * from tblHoaDon h where year(h.ngaylap)={0} " +
                "and month(h.ngaylap)={1} and c.mahoadon=h.mahoadon)",
                Nam, Thang);
            DataTable Thuoc = t.Display(cmdText);
            Thuoc.TableName = "tblThuoc";
            rs.Tables.Add(Thuoc);
            //Loại thuốc
            cmdText = string.Format("select distinct l.maloaithuoc, l.tenloaithuoc, l.thanhphan, l.chucnang, l.ghichu from " +
                "tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc left " +
                "join tblLoaiThuoc l on l.maloaithuoc = t.maloaithuoc where " +
                "exists(select *from tblHoaDon h where year(h.ngaylap) = {0} " +
                "and month(h.ngaylap) = {1} and c.mahoadon = h.mahoadon)"
                , Nam, Thang);
            DataTable LoaiThuoc = lt.Display(cmdText);
            LoaiThuoc.TableName = "tblLoaiThuoc";
            rs.Tables.Add(LoaiThuoc);

            return rs;
        }
        public DataSet BaoCaoDoanhThuTongQuan()
        {
            DataSet rs = new DataSet();
            //Hóa đơn
            string cmdText = string.Format("select * from tblHoaDon");
            DataTable HoaDon = hd.Display(cmdText);
            HoaDon.TableName = "tblHoaDon";
            rs.Tables.Add(HoaDon);

            //Chi tiết hóa đơn
            cmdText = "select * from tblChiTietHoaDon";
            DataTable ChiTietHoaDon = cthd.Display(cmdText);
            ChiTietHoaDon.TableName = "tblChiTietHoaDon";
            rs.Tables.Add(ChiTietHoaDon);
            //Thuốc
            cmdText = "select distinct mathuoc,maloaithuoc,madvt,noisanxuat,ghichu " +
                "from tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc";
            DataTable Thuoc = t.Display(cmdText);
            Thuoc.TableName = "tblThuoc";
            rs.Tables.Add(Thuoc);
            //Loại thuốc
            cmdText = "select distinct l.maloaithuoc, l.tenloaithuoc, l.thanhphan, l.chucnang, l.ghichu from " +
                "tblChiTietHoaDon c left join tblThuoc t on c.mathuoc_mathietbi = t.mathuoc left " +
                "join tblLoaiThuoc l on l.maloaithuoc = t.maloaithuoc";
            DataTable LoaiThuoc = lt.Display(cmdText);
            LoaiThuoc.TableName = "tblLoaiThuoc";
            rs.Tables.Add(LoaiThuoc);

            return rs;
        }
    }

}
