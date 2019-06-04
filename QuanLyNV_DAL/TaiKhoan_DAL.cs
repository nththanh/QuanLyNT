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
    public class TaiKhoan_DAL : DBConnection
    {
        public bool Insert(TaiKhoan_DTO tk)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblTaiKhoan values('{0}','{1}','{2}','{3}','{4}')", tk.Matk, tk.Manv, tk.Matkhau, tk.Tinhtrang, tk.Ghichu);

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

        public bool Delete(int matk)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblTaiKhoan where matk ='{0}'", matk);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int matk, int manv, string matkhau, string tinhtrang, string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblTaiKhoan SET manv = '{1}',matkhau = '{2}', tinhtrang = '{3}', ghichu = '{4}' where matk = '{0}'", matk, manv, matkhau, tinhtrang, ghichu);

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
            DataTable tblTaiKhoan = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblTaiKhoan);  //Fill vào một biến kiểu Datatable
                return tblTaiKhoan;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
