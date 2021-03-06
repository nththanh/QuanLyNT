﻿using System;
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
        Thuoc_DAL thuoc_DAL = new Thuoc_DAL();
        public HoaDon_GUI()
        {
            InitializeComponent();
        }



        private void btDeleteHD_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            
            if (blresult == 1)
            {
                if (txtMaHD.Text != "")
                {
                    cthd_DAL.DeleteALL(Convert.ToInt32(txtMaHD.Text));
                    if (hd_BUS.Delete(Convert.ToInt32(txtMaHD.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                        HoaDon_GUI_Load(sender, e);
                        dataGridView1.DataSource = null;
                        btInsert_HD.Enabled = true;
                        btInsert_CTHD.Enabled = false;
                    }
                    else
                        MessageBox.Show("Xóa thất bại");
                }
                else
                {
                    MessageBox.Show("Xin chọn chi tiết cần xóa");
                }
            }
        }



        private void HoaDon_GUI_Load(object sender, EventArgs e)
        {
            btDelete_CTHD.Enabled = false;
            btEdit_CTHD.Enabled = false;
            btEdit_HD.Enabled = false;
            btDelete_HD.Enabled = false;
            btThemMoi.Enabled = false;
            btInsert_CTHD.Enabled = false;

            cbMaLoHang.Hide();
            txtSL_Before.Hide();
            cbGiaBan.Hide();
            cbSoLuong.Hide();
            cbMaThuoc_MaThietBi.Hide();
            txtMaThuoc.Hide();

            DataTable tblHD = new DataTable();
            tblHD = hd_BUS.Display("Select * from tblHoaDon");           
            dataGridView2.DataSource = tblHD;
            dataGridView2.AllowUserToAddRows = false;                     

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

            try
            {
                object mahd;
                mahd = tblHD.Compute("Max(mahoadon)", "");
                txtMaHD.Text = (Convert.ToInt32(mahd) + 1).ToString();
            }
            catch (Exception)
            {
                txtMaHD.Text = (Convert.ToInt32("1")).ToString();
            }

            if (tblHD.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hóa đơn nào trong danh sách");
            }
            else
            {
                object mahd;
                mahd = tblHD.Compute("Max(mahoadon)", "");
                txtMaHD.Text = (Convert.ToInt32(mahd) + 1).ToString();
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
                txtMaThuoc.Text = dataGridView1.CurrentRow.Cells["mathuoc_mathietbi"].Value.ToString();
                txtMaLoHang.Text = dataGridView1.CurrentRow.Cells["malohang"].Value.ToString();
                txtSoLuong.Text = dataGridView1.CurrentRow.Cells["sl"].Value.ToString();
                txtThanhTien.Text = dataGridView1.CurrentRow.Cells["thanhtien"].Value.ToString();
                btDelete_CTHD.Enabled = true;
                btEdit_CTHD.Enabled = true;
            }
        }

        private void btEditHD_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Sửa thành công");
                    HoaDon_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thất bại");
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin");
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
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
                btEdit_HD.Enabled = true;
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
                    DataTable tblHD = new DataTable();
                    tblHD = hd_BUS.Display("Select * from tblHoaDon");
                    dataGridView2.DataSource = tblHD;
                    dataGridView2.AllowUserToAddRows = false;
                    MessageBox.Show("Thêm thành công");

                    DataTable tblCTHD = new DataTable();
                    tblCTHD = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
                    dataGridView1.DataSource = tblCTHD;
                    dataGridView1.AllowUserToAddRows = false;


                    DataTable tblThuoc = new DataTable();
                    tblThuoc = thuoc_DAL.Display("Select tenthuoc from tblThuoc group by tenthuoc");
                    cbTenThuoc.DataSource = tblThuoc;
                    cbTenThuoc.DisplayMember = "tenthuoc";
                    cbTenThuoc.ValueMember = "tenthuoc";

                    DataTable tblThuoc2 = new DataTable();
                    tblThuoc2 = thuoc_DAL.Display("select * from tblThuoc where tenthuoc = '" + cbTenThuoc.Text + "'");
                    cbNuocSanXuat.DataSource = tblThuoc2;
                    cbNuocSanXuat.DisplayMember = "noisanxuat";
                    cbNuocSanXuat.ValueMember = "noisanxuat";

                    DataTable tblThuoc3 = new DataTable();
                    tblThuoc3 = thuoc_DAL.Display("select * from tblThuoc where tenthuoc = '" + cbTenThuoc.Text + "' and noisanxuat = '" + cbNuocSanXuat.Text + "'");
                    cbMaThuoc_MaThietBi.DataSource = tblThuoc3;
                    cbMaThuoc_MaThietBi.DisplayMember = "mathuoc";
                    cbMaThuoc_MaThietBi.ValueMember = "mathuoc";

                    DataTable tblKhoHang = new DataTable();
                    tblKhoHang = khohang_DAL.Display("Select malohang from tblKhoHang where mathuoc_mathietbi = " + cbMaThuoc_MaThietBi.Text);
                    cbMaLoHang.DataSource = tblKhoHang;
                    cbMaLoHang.DisplayMember = "malohang";
                    cbMaLoHang.ValueMember = "malohang";

                    btDelete_HD.Enabled = true;
                    btInsert_HD.Enabled = false;
                    btInsert_CTHD.Enabled = true;
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
            else
            {
                MessageBox.Show("Xin điền đầy đủ thông tin");
            }
            


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
                        cbMaThuoc_MaThietBi_SelectedValueChanged(sender, e);

                        btThemMoi.Enabled = true;
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

        private void cbMaThuoc_MaThietBi_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMaThuoc.Text = cbMaThuoc_MaThietBi.Text;
            DataTable tblKhoHang = new DataTable();
            tblKhoHang = khohang_DAL.Display("Select * from tblKhoHang where mathuoc_mathietbi = '" + cbMaThuoc_MaThietBi.Text + "'");
            cbMaLoHang.DataSource = tblKhoHang;
            cbMaLoHang.DisplayMember = "malohang";
            cbMaLoHang.ValueMember = "malohang";

            txtMaLoHang.Text = cbMaLoHang.Text;

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

        private void cbMaThuoc_MaThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            HoaDon_GUI_Load(sender, e);
            btInsert_HD.Enabled = true; 
        }

        private void btEdit_CTHD_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                if (Convert.ToInt32(txtSoLuong.Text) <= Convert.ToInt32(txtSLConLai.Text) + Convert.ToInt32(txtSL_Before.Text))
                {
                    int mahoadon = Convert.ToInt32(txtMaHD.Text);
                    int mathuoc_mathietbi = Convert.ToInt32(cbMaThuoc_MaThietBi.Text);
                    string malohang = txtMaLoHang.Text;
                    int soluong = Convert.ToInt32(txtSoLuong.Text);
                    int thanhtien = Convert.ToInt32(txtThanhTien.Text);

                    int soluong_kho = Convert.ToInt32(cbSoLuong.Text) + Convert.ToInt32(txtSL_Before.Text) - Convert.ToInt32(txtSoLuong.Text);
                    khohang_DAL.Edit(malohang, mathuoc_mathietbi, soluong_kho, Convert.ToInt32(cbGiaBan.Text));
                    cbMaThuoc_MaThietBi_SelectedValueChanged(sender, e);

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
                        btEdit_CTHD.Enabled = false;
                        btDelete_CTHD.Enabled = false;
                    }
                    else
                        MessageBox.Show("Sửa thất bại");
                }
                else
                    MessageBox.Show("Số lượng không đủ");
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
                int mathuoc_mathietbi = Convert.ToInt32(txtMaThuoc.Text);
                int soluong = Convert.ToInt32(cbSoLuong.Text) + Convert.ToInt32(txtSoLuong.Text);
                int giaban = Convert.ToInt32(cbGiaBan.Text);

                if (khohang_DAL.Edit(malohang, mathuoc_mathietbi, soluong, giaban))
                {
                    cthd_DAL.Delete(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(txtMaThuoc.Text));
                    cbMaThuoc_MaThietBi_SelectedValueChanged(sender, e);

                    DataTable tblCTHD2 = new DataTable();
                    tblCTHD2 = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
                    dataGridView1.DataSource = tblCTHD2;
                    dataGridView1.AllowUserToAddRows = false;

                    int tongthanhtien = Convert.ToInt32(txtTongThanhTien.Text) - Convert.ToInt32(txtSoLuong.Text) * Convert.ToInt32(cbGiaBan.Text);
                    hd_BUS.Edit(Convert.ToInt32(txtMaHD.Text), Convert.ToInt32(cbMaNV.Text), Convert.ToInt32(cbMaKH.Text), Convert.ToDateTime(dtpNgayLap.Text), tongthanhtien, txtGhiChu.Text);
                    txtTongThanhTien.Text = tongthanhtien.ToString();
                    MessageBox.Show("Xóa thành công");
                    btDelete_CTHD.Enabled = false;
                    btEdit_CTHD.Enabled = false;

                    DataTable tblCTHD3 = new DataTable();
                    tblCTHD3 = cthd_DAL.Display("Select * from tblChiTietHoaDon where mahoadon = " + txtMaHD.Text);
                    if (tblCTHD3.Rows.Count == 0)
                    {
                        dataGridView1.DataSource = null;
                        btThemMoi.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
           
        }

        private void cbTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tblThuoc2 = new DataTable();
            tblThuoc2 = thuoc_DAL.Display("select * from tblThuoc where tenthuoc = '" + cbTenThuoc.Text + "'");
            cbNuocSanXuat.DataSource = tblThuoc2;
            cbNuocSanXuat.DisplayMember = "noisanxuat";
            cbNuocSanXuat.ValueMember = "noisanxuat";
            txtMaLoHang.Text = cbMaLoHang.Text;

            //DataTable tblKhoHang = new DataTable();
            //tblKhoHang = khohang_DAL.Display("Select malohang from tblKhoHang where mathuoc_mathietbi = " + cbMaThuoc_MaThietBi.Text);
            //cbMaLoHang.DataSource = tblKhoHang;
            //cbMaLoHang.DisplayMember = "malohang";
            //cbMaLoHang.ValueMember = "malohang";
        }

        private void cbNuocSanXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tblThuoc3 = new DataTable();
            tblThuoc3 = thuoc_DAL.Display("select * from tblThuoc where tenthuoc = '" + cbTenThuoc.Text + "' and noisanxuat = '" + cbNuocSanXuat.Text + "'");
            cbMaThuoc_MaThietBi.DataSource = tblThuoc3;
            cbMaThuoc_MaThietBi.DisplayMember = "mathuoc";
            cbMaThuoc_MaThietBi.ValueMember = "mathuoc";
            txtMaLoHang.Text = cbMaLoHang.Text;

            //DataTable tblKhoHang = new DataTable();
            //tblKhoHang = khohang_DAL.Display("Select malohang from tblKhoHang where mathuoc_mathietbi = '" + cbMaThuoc_MaThietBi.Text + "'");
            //cbMaLoHang.DataSource = tblKhoHang;
            //cbMaLoHang.DisplayMember = "malohang";
            //cbMaLoHang.ValueMember = "malohang";
        }
    }
}
