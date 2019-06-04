using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNT_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for theD:\1. Phân tích thiết kế hệ thống thông tin\Project\QuanLyNT\QuanLyNV_GUI\Program.cs application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DangNhap_GUI());
        }
    }
}
