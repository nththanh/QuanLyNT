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
    class ChiTietHoaDon_DAL : DBConnection
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

            catch (Exception e)
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

                string SQL = string.Format("Delete from tblChiTietHoaDon where mahoadon ='{0}', mathuoc_mathietbi ='{1}'", mahd, mathuoc_mathietbi);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int maChiTietHoaDon, int manv, int makh, DateTime ngaylap, int tongthanhtien, string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblChiTietHoaDon SET manv = '{1}',makh = '{2}',ngaylap = '{3}',tongthanhtien = '{4}',ghichu = '{5}' where maChiTietHoaDon = {0}", maChiTietHoaDon, manv, makh, ngaylap, tongthanhtien, ghichu);

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

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
