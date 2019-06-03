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
    public partial class Menu_GUI : Form
    {
        private int cv;
        public Menu_GUI()
        {
            InitializeComponent();
        }

        public Menu_GUI(int CV)
        {
            InitializeComponent();
            cv = CV;
        }

        private void Menu_GUI_Load(object sender, EventArgs e)
        {
            if (cv != 1)
            {
                
            }
            else
            {
                btNhanVien.Hide();
            }
        }
    }
}
