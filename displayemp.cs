// See https://aka.ms/new-console-template for more informatio/*

//display all employees using sql statement.
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;



namespace dbprograms
{
    class Programdb
    {
        public static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=Demo1;trusted_connection=true";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employee", con);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader re= cmd.ExecuteReader();
           
            while (re.Read())
            {
                Console.WriteLine(re[0].ToString() + "\t" + re[1].ToString() + "\t" + re[2].ToString() + "\t" +
                    re[3].ToString() + "\t" + re[4].ToString() + "\t" + re[5].ToString() + "\t");

                Console.ReadKey();
            }
        }
    }
}

