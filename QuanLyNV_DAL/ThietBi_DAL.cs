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
    class ThietBi_DAL : DBConnection
    {
        public bool Insert(ThietBi_DTO tb)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblThietBi values('{0}','{1}','(2)','(3)','(4)','(5)')", tb.Mathietbi, tb.Tenthietbi, tb.Chucnang, tb.Noisanxuat, tb.Madvt, tb.Ghichu);

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

        public bool Delete(int mathietbi)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblThietBi where mathietbi ='{0}'", mathietbi);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int mathietbi, string tenthietbi, string chucnang, string noisanxuat, int madvt, string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblThietBi SET tenthietbi = '{1}', chucnang = '{2}', noisanxuat = '{3}', madvt = '{4}', ghichu = '{5}' where mathietbi = {0}", mathietbi, tenthietbi, chucnang, noisanxuat, madvt, ghichu);

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
            DataTable tblThietBi = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblThietBi);  //Fill vào một biến kiểu Datatable
                return tblThietBi;
            }

            catch (Exception) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
