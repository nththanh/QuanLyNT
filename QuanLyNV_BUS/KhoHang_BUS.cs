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
    public class KhoHang_BUS
    {
        KhoHang_DAL dal = new KhoHang_DAL();
        public bool Insert(KhoHang_DTO kh)
        {
            return dal.Insert(kh);
        }
        public bool Delete(int malohang, int mathuoc_mathietbi)
        {
            return dal.Delete(malohang, mathuoc_mathietbi);
        }
        public bool Edit(string malohang, int mathuoc_mathietbi, int soluong, int giaban)
        {
            return dal.Edit(malohang, mathuoc_mathietbi, soluong, giaban);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
