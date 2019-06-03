using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    public class DVT_DTO
    {
        private int madvt;
        private string dvt;
        private string ghichu;

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

        public string Dvt
        {
            get
            {
                return dvt;
            }

            set
            {
                dvt = value;
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

        public DVT_DTO() { }

        public DVT_DTO(int madvt_, string dvt_, string ghichu_)
        {
            this.madvt = madvt_;
            this.dvt = dvt_;
            this.ghichu = ghichu_;
        }
    }
}
