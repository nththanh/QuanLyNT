using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNT_DTO;

namespace QuanLyNT_DAL
{
    class KhanhHang_DAL : DBConnection
    {
        public bool Insert(KhachHang_DTO kh)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblKhachHang values('{0}','{1}','{2}','{3}','{4}','{5}')", kh.Makhachhang, kh.Tenkhachhang, kh.Sdt, kh.Diachi, kh.Gioitinh, kh.Ghichu);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public bool Delete(int makhachhang)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblKhachHang where makh ='{0}'", makhachhang);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(
            int makhachhang,
            string tenkhachhang,
            string sdt,
            string diachi,
            string gioitinh,
            string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblKhachHang SET tenkhachhang = '{1}', sdt = '{2}', diachi = '{3}', gioitinh = '{4}', ghichu = '{5}' where makh = {0}", makhachhang, tenkhachhang, sdt, diachi, gioitinh, ghichu);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }

        public DataTable Display(string sql)
        {
            DataTable tblKhachHang = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblKhachHang);  //Fill vào một biến kiểu Datatable
                return tblKhachHang;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
