using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Advance_Traning
{
    class Demo_Update
    {
        static void Main(string[] args)
        {
            SqlConnection con = ADO_DBConnect.GetConnection();
            Console.WriteLine("Enter id,nm,percent");
            int rollno = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("update student set sname=@nm,marks=@mk where sid=@id", con);
            cmd.Parameters.AddWithValue("@id", rollno);
            cmd.Parameters.AddWithValue("@nm", nm);
            cmd.Parameters.AddWithValue("@mk", marks);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record updated");
            else
                Console.WriteLine("Record failed to Update");

        }

    }

    class Demo_Update2
    {
        static void Main(string[] args)
        {
            SqlConnection con = ADO_DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("update student set sname=@Kavya,marks=@100 where sid=4", con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record updated");
            else
                Console.WriteLine("Record failed to Update");
        }
    }
}
