using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNT_DTO
{
    public class NhanVien_DTO
    {
        private int manv;
        private string tennv;
        private string diachi;
        private DateTime namsinh;
        private string gioitinh;
        private string noilamviec;
        private int macv;
        private string trinhdochuyenmon;
        private string namcapbang_noicap;
        private string ghichu;

        public int Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Namsinh { get => namsinh; set => namsinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Noilamviec { get => noilamviec; set => noilamviec = value; }
        public int Macv { get => macv; set => macv = value; }
        public string Trinhdochuyenmon { get => trinhdochuyenmon; set => trinhdochuyenmon = value; }
        public string Namcapbang_noicap { get => namcapbang_noicap; set => namcapbang_noicap = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public NhanVien_DTO()
        {
        
        }

        public NhanVien_DTO(int manv2, string tennv2, string diachi2, DateTime namsinh2, string gioitinh2, string noilamviec2, int macv2, string trinhdochuyenmon2, string namcapbang_noicap2, string ghichu2)
        {
            this.manv = manv2;
            this.tennv = tennv2;
            this.diachi = diachi2;
            this.namsinh = namsinh2;
            this.gioitinh = gioitinh2;
            this.noilamviec = noilamviec;
            this.macv = macv2;
            this.trinhdochuyenmon = trinhdochuyenmon2;
            this.namcapbang_noicap = namcapbang_noicap2;
            this.ghichu = ghichu2;

    }
}
}
