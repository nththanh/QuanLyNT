using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNT_DAL;
using QuanLyNT_DTO;
using System.Data;

namespace QuanLyNT_BUS
{
    public class ChiTietHoaDon_BUS
    {
        ChiTietHoaDon_DAL dal = new ChiTietHoaDon_DAL();
        public bool Insert(ChiTietHoaDon_DTO hd)
        {
            return dal.Insert(hd);
        }
        public bool Delete(int mahd, int mathuoc_mathietbi)
        {
            return dal.Delete(mahd, mathuoc_mathietbi);
        }
        public bool Edit(int mahoadon, int mathuoc_mathietbi, string malohang, int sl, int thanhtien)
        {
            return dal.Edit(mahoadon, mathuoc_mathietbi, malohang, sl, thanhtien);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
