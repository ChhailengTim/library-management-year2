using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_E7
{
    class DataConnection
    {


        public static SqlConnection Datacon { get; set; }
        /// <summary>
        /// User for SQL Sever Authentication
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="dbname"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public static void ConnectionDB(string ip, string dbname, string username, string password)
        {
            string ConnectionString= "Server = "+ip+"; Database = "+dbname+"; User Id = "+username+";Password = "+password+";";
            Datacon = new SqlConnection(ConnectionString);
            Datacon.Open();
        }
        /// <summary>
        /// Use for Windows Authentication
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="dbname"></param>
        public static void ConnectionDB(string ip,string dbname)
        {
            string ConnectionString = "Server=" + ip + ";Database=" + dbname + ";Trusted_Connection=True;";
            Datacon = new SqlConnection(ConnectionString);
            Datacon.Open();
        }
    }
}
