using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


using 

namespace DataAcessObjetcs
{
    public  class Connection 
    {

        SqlConnection con = new SqlConnection();

        public Connection()
        {

            con.ConnectionString = getConnectionString();

            con.Open();

        }

        private string getConnectionString()
        {
            return "";
        }

        public void  Execute(String sql)
        {
            
        }
        public SqlDataReader Select(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }



    }


}
