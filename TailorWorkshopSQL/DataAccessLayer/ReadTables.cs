using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TailorWorkshopSQL.DataAccessLayer
{
    public static class ReadTables
    {
        public static List<string> Read()
        {
            List<string> Tables = new List<string>();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT TABLE_NAME FROM TailorWorkshop.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", SqlComponent.ConnectToDataBase());
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                Tables.Add(Convert.ToString(row["TABLE_NAME"]));    
            }
            Tables.RemoveAt(Tables.Count-1);
            return Tables;
            
        }
    }
}
