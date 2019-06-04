using QuanLyNT_BUS;
using QuanLyNT_DTO;
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
    public partial class QuanLyNhanVien_GUI : Form
    {
        private NhanVien_BUS nhanvienBus;
        private ChucVu_BUS chucvuBus;
        private DataTable listNhanVien;
        public QuanLyNhanVien_GUI()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            this.listNhanVien = new DataTable();
            this.nhanvienBus = new NhanVien_BUS();
            this.chucvuBus = new ChucVu_BUS();
            //Chức vụ
            DataTable listChucVu = new DataTable();
            listChucVu = chucvuBus.Display("select * from tblChucVu");
            DataRow row = listChucVu.NewRow();
            row["macv"] = -1;
            row["tenchucvu"] = "Tất cả";
            listChucVu.Rows.Add(row);
            cbChucVu.DataSource = listChucVu;
            cbChucVu.DisplayMember = "tenchucvu";
            cbChucVu.ValueMember = "macv";
            cbChucVu.SelectedValue = -1;
            //Giới tính
            DataTable listGioiTinh = new DataTable();
            listGioiTinh.Columns.Add("gioitinh");
            listGioiTinh.Columns.Add("magt");
            row = listGioiTinh.NewRow();
            row["gioitinh"] = "Nam";
            row["magt"] = "Nam";
            listGioiTinh.Rows.Add(row);
            row = listGioiTinh.NewRow();
            row["gioitinh"] = "Nữ";
            row["magt"] = "Nu";
            listGioiTinh.Rows.Add(row);
            row = listGioiTinh.NewRow();
            row["gioitinh"] = "Tất cả";
            row["magt"] = "All";
            listGioiTinh.Rows.Add(row);
            cbGioiTinh.DataSource = listGioiTinh;
            cbGioiTinh.DisplayMember = "gioitinh";
            cbGioiTinh.ValueMember = "magt";
            cbGioiTinh.SelectedValue = "All";
            ReloadList("", "", -1);
        }

        private void ReloadList(string ten, string gioitinh, int macv)
        {
            string sqlcmd = "select * from tblNhanVien where 1=1";
           
            if (ten != "")
            {
                sqlcmd += String.Format(" and charindex('{0}',tennhanvien)>0", ten);
            }
            if (gioitinh != "")
            {
                sqlcmd += String.Format(" and gioitinh = '{0}'", gioitinh);
            }
            if (macv != -1)
            {             
                sqlcmd += String.Format(" and machucvu = {0}", macv);
            }
            listNhanVien = nhanvienBus.Display(sqlcmd);
            ReloadGrid();
        }
        private void ReloadGrid()
        {
            dgvNhanVien.DataSource = listNhanVien;   
            dgvNhanVien.AutoGenerateColumns = true;
            dgvNhanVien.AllowUserToAddRows = false;
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtGhiChu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string ten = "";
            string gioitinh = "";
            int macv = -1;

            ten = txtTenNhanVien.Text;
            if (cbGioiTinh.SelectedValue.ToString()!="All")
            gioitinh = cbGioiTinh.SelectedValue.ToString();
            macv = (int)cbChucVu.SelectedValue;

            ReloadList(ten, gioitinh, macv);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
