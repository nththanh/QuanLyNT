using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    public class HoaDon_DTO
    {
        private int mahoadon;
        private int manv;
        private int makh;
        private DateTime ngaylap;
        private int tongthanhtien;
	    private string ghichu;

        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Manv { get => manv; set => manv = value; }
        public int Makh { get => makh; set => makh = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public int Tongthanhtien { get => tongthanhtien; set => tongthanhtien = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public HoaDon_DTO() { }

        public HoaDon_DTO(int mahoadon2,
                        int manv2,
                        int makh2,
                        DateTime ngaylap2,
                        int tongthanhtien2,
                        string ghichu2)
        {
            this.mahoadon = mahoadon2;
            this.manv = manv2;
            this.makh = makh2;
            this.ngaylap = ngaylap2;
            this.tongthanhtien = tongthanhtien2;
            this.ghichu = ghichu2;
        }

        
    }
}
