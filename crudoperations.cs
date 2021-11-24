//Display all crud operations(insert,update,delete) using sql stored procedures.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace crudoperations
{
    class employee
    {
        public SqlDataReader getEmployee()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Demo1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getemp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();



            }
            catch (SqlException ex)

            {
                Console.Write("Exception Occured!!!!" + ex.Message);
            }
            return reader;
        }
        public SqlDataReader Getempusingempid(int empid)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Demo1;trusted_connection=true";
                con.Open();
                SqlCommand cmd = new SqlCommand("getempusingempid", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("empid", empid);
                cmd.Parameters.Add(param);
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.Write("Exception Occured!!!!" + ex.Message);
            }

            return reader;
        }
        public int insertemp(int empid, string empname, int salary, string designation, int mgid, int depno)
        {
            int n = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Demo1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("insertemp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empid", empid);
                cmd.Parameters.AddWithValue("empname", empname);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("designation", designation);
                cmd.Parameters.AddWithValue("mgid", mgid);
                cmd.Parameters.AddWithValue("depno", depno);

                n = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            return n;
        }
        public int updateemp(int empid, string empname, int salary, string designation, int mgid, int depno)

        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Demo1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateemp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empname", empname);
                cmd.Parameters.AddWithValue("salary", salary);
                cmd.Parameters.AddWithValue("designation", designation);
                cmd.Parameters.AddWithValue("mgid", mgid);
                cmd.Parameters.AddWithValue("depno", depno);


                no = cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            return no;
        }
        public int deleteemp(int empid)
        {
            int n = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=Demo1;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("deletemp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empid", empid);
                n = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
            }
            return n;
        }
    }


        class employee1
        {
            employee emp = new employee();
            public int empid
            {
                get;
                set;
            }

            public string empname
            {
                get;
                set;
            }

            public int salary
            {
                get;
                set;
            }

            public string designation
            {
                get;
                set;
            }

            public int mgid
            {
                get;
                set;
            }
            public int depno
            {
                get;
                set;
            }

        public void printdata()
        {
            SqlDataReader reader = emp.getEmployee();
            Console.WriteLine("empno\tempname\tsalary\tdesignation\tmgid\tdepno");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3]+
                    "\t" + reader[4] +"\t" +reader[5]);

            }
        }

        public void printemp()
        {
            SqlDataReader reader = emp.Getempusingempid(empid);
            Console.WriteLine("empno\tempname\tsalary\tdesignation\tmgid\tdepno");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2] + "\t" + reader[3] +
                    "\t" + reader[4] + "\t" + reader[5]);

            }
        }
        public void insertemp()
        {
            int n = emp.insertemp(empid,empname,salary,designation,mgid,depno);
            if (n > 0)
            {
                Console.WriteLine("Youre Data Inserted Successfully!!!!");
            }
        }
        public void updateemp()
        {
            int n = emp.updateemp(empid, empname, salary, designation, mgid, depno); ;
            if (n > 0)
            {
                Console.WriteLine("Youre Data Updated Successfully!!!!");
            }
        }

        public void deleteemp()
        {
            int no = emp.deleteemp(empid);
            if (no > 0)
            {
                Console.WriteLine("Data Deleted Successfully!!!!!");
            }
        }




    }

    class final
    {
        static void Main(string[] args)
        {
            int choice;
            char ch;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1.print all employee details");
                Console.WriteLine("2.print employee details based on employee id");
                Console.WriteLine("3.insert new employee");
                Console.WriteLine("4.update any employee");
                Console.WriteLine("5.delete any employee");
                Console.WriteLine("enter youre choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employee1 e = new employee1();
                        e.printdata();
                        break;

                    case 2:
                        employee1 e1 = new employee1();
                        Console.WriteLine("enter employee id to display employee details");
                        e1.empid = Convert.ToInt32(Console.ReadLine());
                        e1.printemp();
                        break;

                    case 3:
                        employee1 e2 = new employee1();
                        Console.WriteLine("enter following details to insert new employee record");
                        Console.WriteLine("employee id,employee name,slary,designation,manager id,department no");
                        e2.empid = Convert.ToInt32(Console.ReadLine());
                        e2.empname = Console.ReadLine();
                        e2.salary= Convert.ToInt32(Console.ReadLine());
                        e2.designation = Console.ReadLine();
                        e2.mgid = Convert.ToInt32(Console.ReadLine());
                        e2.depno = Convert.ToInt32(Console.ReadLine());
                        e2.insertemp();
                        break;

                    case 4:
                        employee1 e3=new employee1();
                        Console.WriteLine("enter employee id whose record you want to update");
                        e3.empid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter following details to update");
                        Console.WriteLine("employee name,employee salary,designation,empployee manager id,department no");
                        e3.empname = Console.ReadLine();
                        e3.salary = Convert.ToInt32(Console.ReadLine());
                        e3.designation = Console.ReadLine();
                        e3.mgid = Convert.ToInt32(Console.ReadLine());
                        e3.depno = Convert.ToInt32(Console.ReadLine());
                        e3.updateemp();
                        break;

                    case 5:
                        employee1 e4 = new employee1();
                        Console.WriteLine("enter employee id to delete that employee");
                        e4.empid = Convert.ToInt32(Console.ReadLine());
                        e4.deleteemp();
                        break;

                    default:
                        Console.WriteLine("Invalid case");
                        break;
                }

                Console.WriteLine("Enter Y or y to continue");
                ch = Convert.ToChar(Console.ReadLine());

            }
            while (ch == 'Y' || ch == 'y');
            Console.ReadLine();
        }
    }

}
