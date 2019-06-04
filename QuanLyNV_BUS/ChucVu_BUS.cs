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
    public class ChucVu_BUS
    {
        ChucVu_DAL dal = new ChucVu_DAL();
        public bool Insert(ChucVu_DTO cv)
        {
            return dal.Insert(cv);
        }
        public bool Delete(int macv)
        {
            return dal.Delete(macv);
        }
        public bool Edit(int macv, string chucvu, string ghichu)
        {
            return dal.Edit(macv,chucvu, ghichu);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
