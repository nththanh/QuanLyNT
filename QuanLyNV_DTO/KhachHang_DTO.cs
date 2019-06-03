using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    public class KhachHang_DTO
    {
        int makhachhang;
        string tenkhachhang;
        string sdt;
        string diachi;
        string gioitinh;
        string ghichu;

        public int Makhachhang
        {
            get
            {
                return makhachhang;
            }

            set
            {
                makhachhang = value;
            }
        }

        public string Tenkhachhang
        {
            get
            {
                return tenkhachhang;
            }

            set
            {
                tenkhachhang = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Ghichu
        {
            get
            {
                return ghichu;
            }

            set
            {
                ghichu = value;
            }
        }

        public KhachHang_DTO() { }

        public KhachHang_DTO(
            int makhachhang_,
            string tenkhachhang_,
            string sdt_,
            string diachi_,
            string gioitinh_,
            string ghichu_)
        {
            this.makhachhang = makhachhang_;
            this.tenkhachhang = tenkhachhang_;
            this.sdt = sdt_;
            this.diachi = diachi_;
            this.gioitinh = gioitinh_;
            this.ghichu = ghichu_;
        }
    }
}
