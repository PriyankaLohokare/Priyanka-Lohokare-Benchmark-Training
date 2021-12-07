using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVC_crud_.DAL
{
    public class EmpDal
    {
        public SqlDataReader GetAllEmp()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection("server=.;Database=Demo1;trusted_connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("getemp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }
        public SqlDataReader getempbyempid(int empid)

        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection("server=.;Database=Demo1;trusted_connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("getempusingempid", con);
                SqlParameter p1 = new SqlParameter("empid", empid);
                cmd.Parameters.Add(p1);

                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;

        }
        public int insertemp(int empid, string empname, int salary, string designation,int mgid, int depno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection("server=.;Database=Demo1;trusted_connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("insertemp", con);
                cmd.Parameters.AddWithValue("empid", empid);
                cmd.Parameters.AddWithValue("empname", empname);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("designation", designation);
                cmd.Parameters.AddWithValue("mgid", mgid);
                cmd.Parameters.AddWithValue("depno", depno);
                cmd.CommandType = CommandType.StoredProcedure;
                

                no = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return no;


        }
        public int updatetemp(int empid, string empname, int salary, string designation, int mgid, int depno)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection("server=.;Database=Demo1;trusted_connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("updateemp", con);
                SqlParameter p1 = new SqlParameter("empid", empid);
                SqlParameter p2 = new SqlParameter("empname", empname);
                SqlParameter p3 = new SqlParameter("salary", salary);
                SqlParameter p4 = new SqlParameter("designation", designation);
                SqlParameter p5 = new SqlParameter("mgid", mgid);
                SqlParameter p6 = new SqlParameter("depid", depno);
                cmd.CommandType = CommandType.StoredProcedure;


                no = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return no;


        }
        public int deleteemp(int empid)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection("server=.;Database=Demo1;trusted_connection=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("deleteemp", con);
                SqlParameter p1 = new SqlParameter("empid", empid);
                cmd.Parameters.Add(p1);
                
                cmd.CommandType = CommandType.StoredProcedure;

                no = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return no;


        }





    }
}