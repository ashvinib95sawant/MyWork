using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Advance_Traning
{
    static class ADO_DBConnect
    {
        public static SqlConnection GetConnection()
        {
            string str = "server=LAPTOP-LSS4TTI8\\SQLEXPRESS01;Database=hr;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
}
