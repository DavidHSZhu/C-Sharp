using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class NorthWndDB//initialize the connection to Northwnd.mdf database
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30";//database connectin string, which is binded to file in solution  
           
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;

        }
    }
}
