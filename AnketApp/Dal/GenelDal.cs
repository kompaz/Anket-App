using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace AnketApp.Dal
{
    public class GenelDal
    {
        public static string ConnStr =@"Server=DESKTOP-6B9BTID;Database=AnketData;Trusted_Connection=True;";
        public static SqlConnection Conn1 = new SqlConnection(ConnStr);
        public static SqlConnection Conn2 = new SqlConnection(ConnStr);

    }
}
