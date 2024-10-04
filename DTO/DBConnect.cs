using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DTO
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-TM2B6F7\MSSQLSERVER03;Initial Catalog=QLPhongTro;Integrated Security=True");
    }
}
