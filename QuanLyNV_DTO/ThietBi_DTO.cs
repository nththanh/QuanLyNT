using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    public class ThietBi_DTO
    {
        private int mathietbi;
        private string tenthietbi;
        private string chucnang;
        private string noisanxuat;
        private int madvt;
        private string ghichu;

        public int Mathietbi
        {
            get
            {
                return mathietbi;
            }

            set
            {
                mathietbi = value;
            }
        }

        public string Tenthietbi
        {
            get
            {
                return tenthietbi;
            }

            set
            {
                tenthietbi = value;
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

        public ThietBi_DTO()
        {

        }

        public ThietBi_DTO(int mathietbi_,
            string tenthietbi_,
            string chucnang_,
            string noisanxuat_,
            int madvt_,
            string ghichu_)
        {
            this.mathietbi = mathietbi_;
            this.tenthietbi = tenthietbi_;
            this.chucnang = chucnang_;
            this.noisanxuat = noisanxuat_;
            this.madvt = madvt_;
            this.ghichu = ghichu_;
        }
    }
}
