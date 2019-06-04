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
    public class KhoHang_DAL : DBConnection
    {
        public bool Insert(KhoHang_DTO kh)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblKhoHang values('{0}','{1}','{2}','{3}')", kh.Malohang, kh.Mathuoc_mathietbi, kh.Soluong, kh.Giaban);
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

        public bool Delete(int malohang, int mathuoc_mathietbi)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblKhoHang where malohang ='{0}' and mathuoc_mathietbi = '{1}'", malohang, mathuoc_mathietbi);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(string malohang, int mathuoc_mathietbi, int soluong, int giaban)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblKhoHang SET sl = '{2}', giaban ='{3}' where malohang = '{0}' and mathuoc_mathietbi = '{1}'", malohang, mathuoc_mathietbi, soluong, giaban);
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
            DataTable tblKhoHang = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblKhoHang);  //Fill vào một biến kiểu Datatable
                return tblKhoHang;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
