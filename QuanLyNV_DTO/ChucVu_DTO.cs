using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DTO
{
    public class ChucVu_DTO
    {
        private int machucvu;
        private string chucvu;
        private string ghichu;

        public int Machucvu
        {
            get
            {
                return machucvu;
            }

            set
            {
                machucvu = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
            }
        }

        public string Ghichu { get => ghichu; set => ghichu = value; }

        public ChucVu_DTO() { }

        public ChucVu_DTO(int machucvu_, string chucvu_, string ghichu_)
        {
            this.machucvu = machucvu_;
            this.chucvu = chucvu_;
            this.ghichu = ghichu_;
        }
    }
}
