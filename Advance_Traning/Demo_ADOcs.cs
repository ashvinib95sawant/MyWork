using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;



namespace Advance_Traning
{
    class DBConnect
    {
        static void Main(string[] args)
        {
            string str = "server=LAPTOP-LSS4TTI8\\SQLEXPRESS01;Database=hr;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                Console.WriteLine("Connection establish");
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }

    
}
