using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Advance_Traning
{
   

    class DemoInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = ADO_DBConnect.GetConnection();
            Console.WriteLine("Enter id,nm,percent");
            int rollno = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("insert into student values(@id,@nm,@mk)", con);
            cmd.Parameters.AddWithValue("@id", rollno);
            cmd.Parameters.AddWithValue("@nm", nm);
            cmd.Parameters.AddWithValue("@mk", marks);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record inserted");
            else
                Console.WriteLine("Record failed to Insert");

        }
 
    }

    class Demo_Insert2
    {
        static void Main(string[] args)
        {
            SqlConnection con = ADO_DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("insert into student values(2,'Aman',90)", con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record inserted");
            else
                Console.WriteLine("Record failed to Insert");
        }
    }
}
