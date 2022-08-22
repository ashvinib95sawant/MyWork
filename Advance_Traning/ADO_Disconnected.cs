using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Advance_Traning
{
    class ADO_Disconnected
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            con = ADO_DBConnect.GetConnection();

            SqlDataAdapter sda = new SqlDataAdapter("select * from student", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");

            foreach(DataRow dr1 in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr1[0]+" "+dr1[1]+" "+dr1[2]);
            }

        }
    }
}
