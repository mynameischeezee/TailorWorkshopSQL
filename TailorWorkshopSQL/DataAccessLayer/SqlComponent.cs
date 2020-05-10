using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TailorWorkshopSQL.DataAccessLayer
{
    public static class SqlComponent
    {
        public static SqlConnection ConnectToDataBase()
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source = (local)\SQLEXPRESS; Initial Catalog=TailorWorkshop; Integrated Security = True;");
            return SqlConnection;
            
        }
    }
}
