using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNT_GUI
{
    public partial class BaoCaoDoanhThu_GUI : Form
    {
        public BaoCaoDoanhThu_GUI()
        {
            InitializeComponent();
        }

        private void btnBaoCaoTheoNgay_Click(object sender, EventArgs e)
        {
            int Ngay = dtpNgayLap.Value.Day;
        }

        private void btnBaoCaoTheoThang_Click(object sender, EventArgs e)
        {
            int Thang = dtpNgayLap.Value.Month;
        }

        private void btnBaoCaoTongQuan_Click(object sender, EventArgs e)
        {

        }
    }
}
