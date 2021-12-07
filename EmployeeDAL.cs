using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.DAL
{
    public class EmployeeDAL
    {
        public SqlDataReader GetEmp()
        {
            SqlConnection con = new SqlConnection("Server=.;Database=Demo1;trusted_connection=true");
            SqlCommand cmd = new SqlCommand("Select * from employee", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}