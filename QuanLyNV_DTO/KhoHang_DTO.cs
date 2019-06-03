using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNT_DTO
{
    public class KhoHang_DTO
    {
        private string malohang;
        private int mathuoc_mathietbi;
        private int soluong;
        private int giaban;

        public string Malohang { get => malohang; set => malohang = value; }
        public int Mathuoc_mathietbi { get => mathuoc_mathietbi; set => mathuoc_mathietbi = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Giaban { get => giaban; set => giaban = value; }

        public KhoHang_DTO()
        {

        }

        public KhoHang_DTO(string malohang2, int mathuoc_mathietbi2, int soluong2, int giaban2)
        {
            this.malohang = malohang2;
            this.mathuoc_mathietbi = mathuoc_mathietbi2;
            this.soluong = soluong2;
            this.giaban = giaban2;
        }

    }
}
