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
    public class TaiKhoan_BUS
    {
        TaiKhoan_DAL dal = new TaiKhoan_DAL();
        public bool Insert(TaiKhoan_DTO tk)
        {
            return dal.Insert(tk);
        }
        public bool Delete(int matk)
        {
            return dal.Delete(matk);
        }
        public bool Edit(int matk, int manv, string matkhau, string tinhtrang, string ghichu)
        {
            return dal.Edit(matk, manv, matkhau, tinhtrang, ghichu);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
