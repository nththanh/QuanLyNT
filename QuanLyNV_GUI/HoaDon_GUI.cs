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
    public partial class HoaDon_GUI : Form
    {
        HoaDon_BUS hd_BUS = new HoaDon_BUS();
        ChiTietHoaDon_DAL cthd_DAL = new ChiTietHoaDon_DAL();
        KhoHang_DAL khohang_DAL = new KhoHang_DAL();
        public HoaDon_GUI()
        {
            InitializeComponent();
        }



        private void btDeleteHD_Click(object sender, EventArgs e)
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



        private void HoaDon_GUI_Load(object sender, EventArgs e)
        {
            btDelete_CTHD.Enabled = false;
            DataTable tblHD = new DataTable();
            tblHD = hd_BUS.Display("Select * from tblHoaDon");
            //dataGridView1.DataSource = tblHD;
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView2.DataSource = tblHD;
            //dataGridView2.AllowUserToAddRows = false;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {

            }
            else
            {
                txtSL_Before.Text = dataGridView1.CurrentRow.Cells["sl"].Value.ToString();
                txtMaHD.Text = dataGridView1.CurrentRow.Cells["mahoadon"].Value.ToString();
                cbMaThuoc_MaThietBi.Text = dataGridView1.CurrentRow.Cells["mathuoc_mathietbi"].Value.ToString();
                txtMaLoHang.Text = dataGridView1.CurrentRow.Cells["malohang"].Value.ToString();
                txtSoLuong.Text = dataGridView1.CurrentRow.Cells["sl"].Value.ToString();
                txtThanhTien.Text = dataGridView1.CurrentRow.Cells["thanhtien"].Value.ToString();
                btDelete_CTHD.Enabled = true;
            }
        }

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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btInsertHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "")
            {
                HoaDon_DTO nv_DTO = new HoaDon_DTO(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(cbMaNV.Text), Convert.ToInt32(cbMaKH.Text), dtpNgayLap.Value, Convert.ToInt32(txtTongThanhTien.Text), txtGhiChu.Text);
                if (hd_BUS.Insert(nv_DTO))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin");
            }
            DataTable tblCTHD = new DataTable();
            tblCTHD = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
            dataGridView1.DataSource = tblCTHD;
            dataGridView1.AllowUserToAddRows = false;
            
            DataTable tblKhoHang = new DataTable();
            tblKhoHang = khohang_DAL.Display("Select malohang from tblKhoHang group by malohang");
            cbMaLoHang.DataSource = tblKhoHang;
            cbMaLoHang.DisplayMember = "malohang";
            cbMaLoHang.ValueMember = "malohang";

            DataTable tblKhoHang2 = new DataTable();
            tblKhoHang2 = khohang_DAL.Display("Select mathuoc_mathietbi from tblKhoHang group by mathuoc_mathietbi");
            cbMaThuoc_MaThietBi.DataSource = tblKhoHang2;
            cbMaThuoc_MaThietBi.DisplayMember = "mathuoc_mathietbi";
            cbMaThuoc_MaThietBi.ValueMember = "mathuoc_mathietbi";
        }

        private void btInsert_CTHD_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                if (Convert.ToInt32(txtSoLuong.Text) <= Convert.ToInt32(cbSoLuong.Text))
                {
                    ChiTietHoaDon_DTO cthd_DTO = new ChiTietHoaDon_DTO(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(cbMaThuoc_MaThietBi.Text), cbMaLoHang.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtThanhTien.Text));
                    if (cthd_DAL.Insert(cthd_DTO))
                    {
                        int mahoadon = Convert.ToInt32(txtMaHD.Text);
                        int manv = Convert.ToInt32(cbMaNV.Text);
                        int makh = Convert.ToInt32(cbMaKH.Text);
                        DateTime ngaylap = Convert.ToDateTime(dtpNgayLap.Text);
                        int tongthanhtien = Convert.ToInt32(txtTongThanhTien.Text);
                        string ghichu = txtGhiChu.Text;
                        hd_BUS.Edit(mahoadon, manv, makh, ngaylap, tongthanhtien, ghichu);
                        txtTongThanhTien.Text = (Convert.ToInt32(txtTongThanhTien.Text) + Convert.ToInt32(txtThanhTien.Text)).ToString();
                        MessageBox.Show("Thêm thành công");
                        DataTable tblCTHD = new DataTable();
                        tblCTHD = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
                        dataGridView1.DataSource = tblCTHD;
                        dataGridView1.AllowUserToAddRows = false;

                        string malohang = txtMaLoHang.Text;
                        int mathuoc_mathietbi = Convert.ToInt32(cbMaThuoc_MaThietBi.Text);

                        khohang_DAL.Edit(malohang, mathuoc_mathietbi, Convert.ToInt32(cbSoLuong.Text) - Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(cbGiaBan.Text));                                                                       
                        cbMaThuoc_MaThietBi_SelectedIndexChanged(sender, e);
                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                }
                else
                {
                    MessageBox.Show("Số lượng còn lại không đủ");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin");
            }

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {                
                txtThanhTien.Text = (Convert.ToInt32(txtSoLuong.Text)*Convert.ToInt32(cbGiaBan.Text)).ToString();
            }
            catch (Exception)
            {

            }           
        }

        private void cbMaLoHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMaThuoc_MaThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tblKhoHang = new DataTable();
            tblKhoHang = khohang_DAL.Display("Select * from tblKhoHang where mathuoc_mathietbi = " + cbMaThuoc_MaThietBi.Text);
            cbMaLoHang.DataSource = tblKhoHang;
            cbMaLoHang.DisplayMember = "malohang";
            cbMaLoHang.ValueMember = "malohang";

            object malohang_min;
            malohang_min = tblKhoHang.Compute("Min(malohang)", "");
            txtMaLoHang.Text = malohang_min.ToString();

            DataTable giaban_soluong;
            giaban_soluong = khohang_DAL.Display("Select * from tblKhoHang where mathuoc_mathietbi = " + cbMaThuoc_MaThietBi.Text 
                                         + " and malohang = " + txtMaLoHang.Text);
            cbGiaBan.DataSource = giaban_soluong;
            cbGiaBan.DisplayMember = "giaban";
            cbGiaBan.ValueMember = "giaban";

            cbSoLuong.DataSource = giaban_soluong;
            cbSoLuong.DisplayMember = "sl";
            cbSoLuong.ValueMember = "sl";
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            HoaDon_GUI_Load(sender, e);
        }

        private void btEdit_CTHD_Click(object sender, EventArgs e)
        {           
            if (txtSoLuong.Text != "")
            {
                int mahoadon = Convert.ToInt32(txtMaHD.Text);
                int mathuoc_mathietbi = Convert.ToInt32(cbMaThuoc_MaThietBi.Text);
                string malohang = txtMaLoHang.Text;   
                int soluong = Convert.ToInt32(txtSoLuong.Text);
                int thanhtien = Convert.ToInt32(txtThanhTien.Text);

                int soluong_kho = Convert.ToInt32(cbSoLuong.Text) + Convert.ToInt32(txtSL_Before.Text) - Convert.ToInt32(txtSoLuong.Text);
                khohang_DAL.Edit(malohang, mathuoc_mathietbi, soluong_kho, Convert.ToInt32(cbGiaBan.Text));
                cbMaThuoc_MaThietBi_SelectedIndexChanged(sender, e);

                int tongthanhtien = Convert.ToInt32(txtTongThanhTien.Text) - Convert.ToInt32(txtSL_Before.Text) * Convert.ToInt32(cbGiaBan.Text) + Convert.ToInt32(txtThanhTien.Text);
                hd_BUS.Edit(mahoadon, Convert.ToInt32(cbMaNV.Text), Convert.ToInt32(cbMaKH.Text), Convert.ToDateTime(dtpNgayLap.Text), tongthanhtien, txtGhiChu.Text);
                txtTongThanhTien.Text = tongthanhtien.ToString();
                //HoaDon_DTO nv_DTO = new HoaDon_DTO(txtMaHD.Text, cbMaNV.Text);                
                if (cthd_DAL.Edit(mahoadon, mathuoc_mathietbi, malohang, soluong, thanhtien))
                {
                    DataTable tblCTHD = new DataTable();
                    tblCTHD = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
                    dataGridView1.DataSource = tblCTHD;
                    dataGridView1.AllowUserToAddRows = false;                    
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSLConLai.Text = cbSoLuong.Text;
        }

        private void btDelete_CTHD_Click(object sender, EventArgs e)
        {
            DataTable tblCTHD = new DataTable();
            tblCTHD = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
            if (tblCTHD.Rows.Count > 0)
            {
                string malohang = txtMaLoHang.Text;
                int mathuoc_mathietbi = Convert.ToInt32(cbMaThuoc_MaThietBi.Text);
                int soluong = Convert.ToInt32(cbSoLuong.Text) + Convert.ToInt32(txtSoLuong.Text);
                int giaban = Convert.ToInt32(cbGiaBan.Text);
                if (khohang_DAL.Edit(malohang, mathuoc_mathietbi, soluong, giaban))
                {
                    cthd_DAL.Delete(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(cbMaThuoc_MaThietBi.Text));
                    cbMaThuoc_MaThietBi_SelectedIndexChanged(sender, e);

                    DataTable tblCTHD2 = new DataTable();
                    tblCTHD2 = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
                    dataGridView1.DataSource = tblCTHD2;
                    dataGridView1.AllowUserToAddRows = false;

                    int tongthanhtien = Convert.ToInt32(txtTongThanhTien.Text) - Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(cbGiaBan.Text);
                    hd_BUS.Edit(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(cbMaNV.Text), Convert.ToInt32(cbMaKH.Text), Convert.ToDateTime(dtpNgayLap.Text), tongthanhtien, txtGhiChu.Text);
                    txtTongThanhTien.Text = tongthanhtien.ToString();
                    MessageBox.Show("Xóa thành công");
                    btDelete_CTHD.Enabled = false;
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
           
        }
    }
}
