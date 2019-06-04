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
    public class ChucVu_DAL : DBConnection
    {
        public bool Insert(ChucVu_DTO cv)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblChucVu values('{0}','{1}','{2}')", cv.Machucvu, cv.Chucvu, cv.Ghichu);

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

        public bool Delete(int machucvu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblChucVu where machucvu ='{0}'", machucvu);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int machucvu, string chucvu, string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblChucVu SET tenchucvu = '{1}', ghichu = '{2}' where macv = {0}", machucvu, chucvu, ghichu);

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
            DataTable tblChucVu = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblChucVu);  //Fill vào một biến kiểu Datatable
                return tblChucVu;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
