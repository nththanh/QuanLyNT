using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    public class Thuoc_DTO
    {
        private int mathuoc;
        private int maloaithuoc;
        private string tenthuoc;
        private int madvt;
        private string noisanxuat;
        private string ghichu;

        public int Mathuoc
        {
            get
            {
                return mathuoc;
            }

            set
            {
                mathuoc = value;
            }
        }

        public int Maloaithuoc
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

        public int Madvt
        {
            get
            {
                return madvt;
            }

            set
            {
                madvt = value;
            }
        }

        public string Noisanxuat
        {
            get
            {
                return noisanxuat;
            }

            set
            {
                noisanxuat = value;
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

        public string Tenthuoc { get => tenthuoc; set => tenthuoc = value; }

        public Thuoc_DTO() { }

        public Thuoc_DTO(int mathuoc_, int maloaithuoc_, string tenthuoc_, int madvt_, string noisanxuat_, string ghichu_)
        {
            this.mathuoc = mathuoc_;
            this.maloaithuoc = maloaithuoc_;
            this.tenthuoc = tenthuoc_;
            this.madvt = madvt_;
            this.noisanxuat = noisanxuat_;
            this.ghichu = ghichu_;
        }
    }
}
