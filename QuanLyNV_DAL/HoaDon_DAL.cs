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
    public class HoaDon_DAL: DBConnection
    {
        public bool Insert(HoaDon_DTO hd)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblHoaDon values('{0}','{1}','{2}','{3}','{4}','{5}')", hd.Mahoadon, hd.Manv, hd.Makh, hd.Ngaylap, hd.Tongthanhtien, hd.Ghichu);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception)
            {  }

            finally
            {
                con.Close();
            }

            return false;
        }

        public bool Delete(int mahd)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblHoaDon where mahoadon ='{0}'", mahd);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int mahoadon, int manv, int makh, DateTime ngaylap, int tongthanhtien, string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblHoaDon SET manv = '{1}',makh = '{2}',ngaylap = '{3}',tongthanhtien = '{4}',ghichu = '{5}' where mahoadon = {0}", mahoadon, manv, makh, ngaylap, tongthanhtien, ghichu);

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
            DataTable tblHoaDon = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();    
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblHoaDon);  //Fill vào một biến kiểu Datatable
                return tblHoaDon;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
