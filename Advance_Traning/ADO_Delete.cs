using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Advance_Traning
{
    class Demo_Delete
    {
        static void Main(string[] args)
        {
            SqlConnection con = ADO_DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("delete from student where sid=1", con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record deleted");
            else
                Console.WriteLine("Record failed to Delete");
        }
    }

    class Demo_Delete2
    {
        static void Main(string[] args)
        {
            SqlConnection con = ADO_DBConnect.GetConnection();
            Console.WriteLine("Enter id,nm,percent");
            int rollno = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());

            SqlCommand cd = new SqlCommand("delete from student where sid=@id", con);
            cd.Parameters.AddWithValue("@id", rollno);
          
            int i = cd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record deleted");
            else
                Console.WriteLine("Record failed to Delete");
        }

    }
}
