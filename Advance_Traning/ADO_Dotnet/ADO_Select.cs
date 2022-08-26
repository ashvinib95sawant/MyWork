using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Advance_Traning
{
    class Demo2
    {
        static void Main(string[] args)
        {
            string str = "server=LAPTOP-LSS4TTI8\\SQLEXPRESS01;Database=hr;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);

                con.Open();
                SqlCommand sqlcommand = new SqlCommand("select last_name,salary from employees", con);
                SqlDataReader dr = sqlcommand.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine("Name=" + dr["last_name"] + "salary=" + dr["salary"]);
                }
            }
            catch (Exception e)
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
