using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    public class LoaiThuoc_DTO
    {
        private string maloaithuoc;
        private string tenthuoc;
        private string thanhphan;
        private string chucnang;
        private string ghichu;

        public string Maloaithuoc
        {
            get
            {
                return maloaithuoc;
            }

            set
            {
                maloaithuoc = value;
            }
        }

        public string Tenthuoc
        {
            get
            {
                return tenthuoc;
            }

            set
            {
                tenthuoc = value;
            }
        }

        public string Thanhphan
        {
            get
            {
                return thanhphan;
            }

            set
            {
                thanhphan = value;
            }
        }

        public string Chucnang
        {
            get
            {
                return chucnang;
            }

            set
            {
                chucnang = value;
            }
        }

        public string Ghichu { get => ghichu; set => ghichu = value; }

        public LoaiThuoc_DTO() { }

        public LoaiThuoc_DTO(string maloaithuoc_, string tenthuoc_, string thanhphan_, string chucnang_, string ghichu_)
        {
            this.maloaithuoc = maloaithuoc_;
            this.tenthuoc = tenthuoc_;
            this.thanhphan = thanhphan_;
            this.chucnang = chucnang_;
            this.Ghichu = ghichu_;
        }
    }
}
