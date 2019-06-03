using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNT_DTO;
using QuanLyNT_BUS;
using QuanLyNT_DAL;

namespace QuanLyNT_GUI
{
    public partial class DangNhap_GUI : Form
    {
        TaiKhoan_BUS tk_BUS = new TaiKhoan_BUS();
        NhanVien_DAL nv_DAL = new NhanVien_DAL();
        public DangNhap_GUI()
        {
            InitializeComponent();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != null && txtMatKhau.Text != null)
            {
                DataTable tblTaiKhoan = tk_BUS.Display("Select manv from tblTaiKhoan where manv = " + txtMaNV.Text);
                if (tblTaiKhoan.Rows.Count > 0)
                {
                    DataTable tblTaiKhoan2 = tk_BUS.Display("Select manv, matkhau from tblTaiKhoan where manv = " + txtMaNV.Text + " and matkhau = " + txtMatKhau.Text);
                    if (tblTaiKhoan2.Rows.Count > 0)
                    {
                        this.Hide();
                        DataTable tblNV = nv_DAL.Display("Select machucvu from tblNhanVien where manv = " + txtMaNV.Text);
                        cbMaCV.DataSource = tblNV;
                        cbMaCV.DisplayMember = "machucvu";
                        cbMaCV.ValueMember = "machucvu";
                        Menu_GUI menu = new Menu_GUI(Convert.ToInt32(cbMaCV.Text));
                        menu.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng");
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không đúng");
                }
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin");
            }
        }

        private void DangNhap_GUI_Load(object sender, EventArgs e)
        {
            cbMaCV.Hide();
        }
    }
}
