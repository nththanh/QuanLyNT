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
    public class Thuoc_DAL : DBConnection
    {
        public bool Insert(Thuoc_DTO t)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Insert into tblThuoc values('{0}','{1}','{2}','{3}','{4}','{5}')", t.Mathuoc, t.Maloaithuoc,t.Tenthuoc, t.Madvt, t.Noisanxuat, t.Ghichu);

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

        public bool Delete(int mathuoc)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from tblThuoc where mathuoc ='{0}'", mathuoc);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }

        public bool Edit(int mathuoc, int maloaithuoc,string tenthuoc, int madvt, string noisanxuat, string ghichu)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE tblThuoc SET maloaithuoc = '{1}', tenthuoc = '{2}',madvt = '{3}',noisanxuat = '{4}',ghichu = '{5}' where mathuoc = {0}", mathuoc, maloaithuoc, tenthuoc, madvt, noisanxuat, ghichu);

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
            DataTable tblThuoc = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblThuoc);  //Fill vào một biến kiểu Datatable
                return tblThuoc;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }
}
