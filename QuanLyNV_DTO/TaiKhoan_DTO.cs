using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNT_DTO
{
    public class TaiKhoan_DTO
    {
        private int matk;
        private int manv;
        private string matkhau;
        private string tinhtrang;
        private string ghichu;

        public int Matk { get => matk; set => matk = value; }
        public int Manv { get => manv; set => manv = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public TaiKhoan_DTO()
        { }

        public TaiKhoan_DTO(int matk2, int manv2, string matkhau2, string tinhtrang2, string ghichu2)
        {
            this.matk = matk2;
            this.manv = manv2;
            this.matkhau = matkhau2;
            this.tinhtrang = tinhtrang2;
            this.ghichu = ghichu2;
        }
    }
}
