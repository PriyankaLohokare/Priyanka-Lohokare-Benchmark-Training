using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;



/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    SqlConnection con = null;

    public DAL()
    {

        con = new SqlConnection("server=.;database=LoginDB;trusted_connection=true");
        con.Open();
    }
    public Boolean Login(string username1, string Password1)
    {
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "ChkLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", username1);
            SqlParameter p2 = new SqlParameter("password", Password1);
            cmd.Parameters.Add(p1); 
            cmd.Parameters.Add(p2);



            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                return true;
            }

            return false;

        }

        catch (SqlException se)
        {
            return false;
        }
    }
}