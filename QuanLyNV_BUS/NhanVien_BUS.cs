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
    public class NhanVien_BUS
    {
        NhanVien_DAL dal = new NhanVien_DAL();
        public bool Insert(NhanVien_DTO nv)
        {
            return dal.Insert(nv);
        }
        public bool Delete(int manv)
        {
            return dal.Delete(manv);
        }
        public bool Edit(int manv, string tennv, string diachi, DateTime namsinh, string gioitinh, string noilamviec, int macv, string trinhdochuyenmon, string namcapbang_noicap, string ghichu)
        {
            return dal.Edit(manv, tennv, diachi, namsinh, gioitinh, noilamviec, macv, trinhdochuyenmon, namcapbang_noicap, ghichu);
        }

        public DataTable Display(string sql)
        {
            return dal.Display(sql);
        }
    }
}
