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
    class LoaiThuoc_DAL : DBConnection
    {
        public bool Insert(LoaiThuoc_DTO lt)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblLoaiThuoc values('{0}','{1}','{2}','{3}','{4}')", lt.Maloaithuoc, lt.Tenthuoc, lt.Thanhphan, lt.Chucnang, lt.Ghichu);

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

        public bool Delete(int maloaithuoc)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblLoaiThuoc where maloaithuoc ='{0}'", maloaithuoc);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(
            string maloaithuoc,
            string tenthuoc,
            string thanhphan,
            string chucnang,
            string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblLoaiThuoc SET tenthuoc = '{1}', thanhphan = '{2}', chucnang = '{3}', ghichu = '{4}' where maloaithuoc = {0}", maloaithuoc, tenthuoc, thanhphan, chucnang, ghichu);

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
            DataTable tblLoaiThuoc = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblLoaiThuoc);  //Fill vào một biến kiểu Datatable
                return tblLoaiThuoc;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
