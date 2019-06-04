using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNT_DTO;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyNT_DAL
{
    public class NhanVien_DAL : DBConnection
    {
        public bool Insert(NhanVien_DTO nv)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblNhanVien values('{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}','{9}')", nv.Manv, nv.Tennv, nv.Diachi, nv.Namsinh, nv.Gioitinh, nv.Noilamviec, nv.Macv, nv.Trinhdochuyenmon, nv.Namcapbang_noicap, nv.Ghichu);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public bool Delete(int manv)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblNhanVien where manv ='{0}'", manv);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int manv, string tennv, string diachi, DateTime namsinh, string gioitinh, string noilamviec, int macv, string trinhdochuyenmon, string namcapbang_noicap, string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblNhanVien SET tennhanvien = '{1}', diachi = '{2}', namsinh = '{3}', gioitinh = '{4}', noilamviec = '{5}', machucvu = '{6}', trinhdochuyenmon = '{7}', namcapbang_noicap = '{8}', ghichu = '{9}' where manv = '{0}'", manv, tennv, diachi, namsinh, gioitinh, noilamviec, macv, trinhdochuyenmon, namcapbang_noicap, ghichu);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public DataTable Display(string sql)
        {
            DataTable tblNhanVien = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblNhanVien);  //Fill vào một biến kiểu Datatable
                return tblNhanVien;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
