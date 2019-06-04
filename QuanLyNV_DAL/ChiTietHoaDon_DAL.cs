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
    public class ChiTietHoaDon_DAL : DBConnection
    {
        public bool Insert(ChiTietHoaDon_DTO cthd)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblChiTietHoaDon values('{0}','{1}','{2}','{3}','{4}')", cthd.Mahoadon, cthd.Mathuoc_mathietbi, cthd.Malohang, cthd.Sl, cthd.Thanhtien);
                
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

        public bool Delete(int mahd, int mathuoc_mathietbi)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblChiTietHoaDon where mahoadon ='{0}' and mathuoc_mathietbi ='{1}'", mahd, mathuoc_mathietbi);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool DeleteALL(int mahd)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblChiTietHoaDon where mahoadon ='{0}'", mahd);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int mahoadon, int mathuoc_mathietbi, string malohang, int sl , int thanhtien)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblChiTietHoaDon SET malohang = '{2}', sl = '{3}',thanhtien = '{4}' where mahoadon = '{0}' and mathuoc_mathietbi = '{1}'", mahoadon, mathuoc_mathietbi, malohang, sl, thanhtien);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) {
                return false;
            }

            finally
            { con.Close(); }

            return false;
        }

        public DataTable Display(string sql)
        {
            DataTable tblChiTietHoaDon = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblChiTietHoaDon);  //Fill vào một biến kiểu Datatable
                return tblChiTietHoaDon;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
