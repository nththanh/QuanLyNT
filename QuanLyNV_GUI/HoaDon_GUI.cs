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

namespace QuanLyNT_GUI
{
    public partial class HoaDon_GUI : Form
    {
        HoaDon_BUS hd_BUS = new HoaDon_BUS();
        public HoaDon_GUI()
        {
            InitializeComponent();
        }

       

        private void btDelete_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Are you sure you want to delete this row?", "Deleting employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            //MessageBox.Show(blresult.ToString());
            if (blresult == 1)
            {        
                if (txtMaHD.Text != "")
                {
                    if (hd_BUS.Delete(Convert.ToInt32(txtMaHD.Text)))
                    {
                        MessageBox.Show("Deleting success");
                        HoaDon_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Deleting fail");
                }
                else
                {
                    MessageBox.Show("Please select one employee to delete");
                }
            }//Kết thúc thao tác xóa nhân viên
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "")
            {
                HoaDon_DTO nv_DTO = new HoaDon_DTO(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(cbMaNV.Text), Convert.ToInt32(cbMaKH.Text), dtpNgayLap.Value, Convert.ToInt32(txtTongThanhTien.Text), txtGhiChu.Text);
                if (hd_BUS.Insert(nv_DTO))
                {

                    MessageBox.Show("Adding success");
                }
                else
                    MessageBox.Show("Adding fail");
            }
            else
            {
                MessageBox.Show("Please fill required data");
            }
           HoaDon_GUI_Load(sender,e);
        }

        private void HoaDon_GUI_Load(object sender, EventArgs e)
        {          
            DataTable tblHD = new DataTable();
            tblHD = hd_BUS.Display("Select * from tblHoaDon");
            dataGridView1.DataSource = tblHD;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.DataSource = tblHD;
            dataGridView2.AllowUserToAddRows = false;

            object mahd;
            mahd = tblHD.Compute("Max(mahoadon)", "");
            txtMaHD.Text = (Convert.ToInt32(mahd) + 1).ToString();


            DataTable tblNV = new DataTable();
            tblNV = hd_BUS.Display("Select * from tblNhanVien");

            cbMaNV.DataSource = tblNV;
            cbMaNV.DisplayMember = "manv";
            cbMaNV.ValueMember = "manv";

            cbMaNV2.DataSource = tblNV;
            cbMaNV2.DisplayMember = "manv";
            cbMaNV2.ValueMember = "manv";

            DataTable tblKH = new DataTable();
            tblKH = hd_BUS.Display("Select * from tblKhachHang");

            cbMaKH.DataSource = tblKH;
            cbMaKH.DisplayMember = "makh";
            cbMaKH.ValueMember = "makh";

            cbMaKH2.DataSource = tblKH;
            cbMaKH2.DisplayMember = "makh";
            cbMaKH2.ValueMember = "makh";

            if (tblHD.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hóa đơn nào trong danh sách");
            }                         
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.Rows.Count == 0)
        //    {
               
        //    }
        //    else
        //    {
        //        txtMaHD.Text = dataGridView1.CurrentRow.Cells["mahoadon"].Value.ToString();
        //        cbMaNV.Text = dataGridView1.CurrentRow.Cells["manv"].Value.ToString();
        //    }
        //}

        



        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtMaHD2.Text != "")
            {
                int mahoadon = Convert.ToInt32(txtMaHD2.Text);
                int manv = Convert.ToInt32(cbMaNV2.Text);
                int makh = Convert.ToInt32(cbMaKH2.Text);
                DateTime ngaylap = Convert.ToDateTime(dtpNgayLap2.Text);
                int tongthanhtien = Convert.ToInt32(txtTongThanhTien2.Text);
                string ghichu = txtGhiChu2.Text;
                //HoaDon_DTO nv_DTO = new HoaDon_DTO(txtMaHD.Text, cbMaNV.Text);
                if (hd_BUS.Edit(mahoadon, manv, makh, ngaylap, tongthanhtien, ghichu))
                {
                    MessageBox.Show("Editing success");
                    HoaDon_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Editing fail");
            }
            else
            {
                MessageBox.Show("Please fill required data");
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {

            }
            else
            {
                txtMaHD2.Text = dataGridView2.CurrentRow.Cells["mahoadon"].Value.ToString();
                cbMaNV2.Text = dataGridView2.CurrentRow.Cells["manv"].Value.ToString();
                cbMaKH2.Text = dataGridView2.CurrentRow.Cells["makh"].Value.ToString();
                dtpNgayLap2.Text = dataGridView2.CurrentRow.Cells["ngaylap"].Value.ToString();
                txtTongThanhTien2.Text = dataGridView2.CurrentRow.Cells["tongthanhtien"].Value.ToString();
                txtGhiChu2.Text = dataGridView2.CurrentRow.Cells["ghichu"].Value.ToString();
            }
        }
    }
}
