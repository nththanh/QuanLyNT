using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    class ChiTietHoaDon_DTO
    {
        private int mahoadon;
        private int mathuoc_mathietbi;
        private string malohang;
	    private int sl;
        private int thanhtien;

        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Mathuoc_mathietbi { get => mathuoc_mathietbi; set => mathuoc_mathietbi = value; }
        public string Malohang { get => malohang; set => malohang = value; }
        public int Sl { get => sl; set => sl = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }

        public ChiTietHoaDon_DTO()
        {

        }


        public ChiTietHoaDon_DTO(int mahoadon2, int mathuoc_mathietbi2, string malohang2, int sl2, int thanhtien2)
        {
            this.mahoadon = mahoadon2;
            this.mathuoc_mathietbi = mathuoc_mathietbi2;
            this.malohang = malohang2;
            this.sl = sl2;
            this.thanhtien = thanhtien2;

        }

    }
}
