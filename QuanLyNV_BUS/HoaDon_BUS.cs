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
    public class HoaDon_BUS
    {
        HoaDon_DAL dal= new HoaDon_DAL();
        public bool Insert(HoaDon_DTO hd)
        {
            return dal.Insert(hd);
        }
        public bool Delete(int mahd)
        {
            return dal.Delete(mahd);
        }
        public bool Edit(int mahoadon, int manv, int makh, DateTime ngaylap, int tongthanhtien, string ghichu)
        {
            return dal.Edit(mahoadon, manv, makh, ngaylap, tongthanhtien, ghichu);
        }

        public DataTable Display(string sql)
        {            
            return dal.Display(sql);
        }
    }
}
