using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNT_DAL
{
    public class DBConnection
    {
        protected SqlConnection con = new SqlConnection(@"Data Source=ADMIN\MSSQLSERVER15;Initial Catalog=QLNT;Integrated Security=True");
    }
}
