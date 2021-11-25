//Display all crud operations(insert,update,delete) using ado.net dissconnected architecture.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace crudoperations2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int choice;
                char ch;
                SqlConnection con = new SqlConnection("server=.;database=Demo1;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("Select * from employee", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder cb = new SqlCommandBuilder(adapter);


                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1.Print All Employees");
                    Console.WriteLine("2.Print Employee Details based on Employee Id");
                    Console.WriteLine("3.Insert Employee Details");
                    Console.WriteLine("4.Update Employee Detaails");
                    Console.WriteLine("5.Delete Employee");
                    Console.WriteLine("Enter Your Choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:



                            foreach (DataRow dr in dt.Rows)
                            {

                                Console.WriteLine(dr[0].ToString() + "\t" + dr[1].ToString() + "\t" +
                                    dr[2].ToString() + "\t" + dr[3].ToString() + "\t" + dr[4].ToString() + "\t" +
                                    dr[5].ToString() + "\t");
                            }
                            Console.ReadKey();
                            break;

                        case 2:

                            int eid;

                            //DataColumn[] dc; 

                            Console.WriteLine("enter employee id to search employee");
                            int empid = Convert.ToInt32(Console.ReadLine());

                            DataRow[] dr1 = dt.Select("empid=" + empid);
                            DataColumn dc1 = new DataColumn();

                            Console.WriteLine("employee details are");

                            foreach (DataRow dr in dr1)
                            {

                                Console.WriteLine(dr[0].ToString() + "\t" + dr[1].ToString() + "\t" +
                                    dr[2].ToString() + "\t" + dr[3].ToString() + "\t" + dr[4].ToString() + "\t" +
                                    dr[5].ToString() + "\t");
                            }
                            Console.ReadKey();
                            break;

                        case 3:

                            int mgid1, salary1, depno1, eid1;
                            string ename1, designation1;
                            Console.WriteLine("enter employee id");
                            eid1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter employee name");
                            ename1 = Console.ReadLine();
                            Console.WriteLine("enter employee salary");
                            salary1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter employee designation");
                            designation1 = Console.ReadLine();
                            Console.WriteLine("enter employee manager id");
                            mgid1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter employee department no");
                            depno1 = Convert.ToInt32(Console.ReadLine());
                            DataRow nr = dt.NewRow();
                            nr["empid"] = eid1;
                            nr["empname"] = ename1;
                            nr["salary"] = salary1;
                            nr["designation"] = designation1;
                            nr["mgid"] = mgid1;
                            nr["depno"] = depno1;
                            dt.Rows.Add(nr);
                            adapter.Update(dt);
                            Console.WriteLine("employee details insert successfully");



                            break;
                        case 4:
                            int mgid2, salary2, depno2, eid2;
                            string ename2, designation2;

                            Console.WriteLine("enter employee id");
                            eid2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter employee name");
                            ename2 = Console.ReadLine();
                            Console.WriteLine("enter employee salary");
                            salary2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter employee designation");
                            designation2 = Console.ReadLine();
                            Console.WriteLine("enter employee manager id");
                            mgid2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter employee department no");
                            depno2 = Convert.ToInt32(Console.ReadLine());
                            DataRow[] r = dt.Select("empid=" + eid2);
                            DataRow row = r[0];
                            row["empname"] = ename2;
                            row["salary"] = salary2;
                            row["designation"] = designation2;
                            row["mgid"] = mgid2;
                            row["depno"] = depno2;

                            adapter.Update(dt);
                            Console.WriteLine("employee details updated successfully");

                            break;
                        case 5:
                            Console.WriteLine("enter employee id to delete record");
                            int eid3 = Convert.ToInt32(Console.ReadLine());
                            DataRow[] r1 = dt.Select("empid=" + eid3);
                            DataRow row1 = r1[0];
                            dt.Rows.Remove(row1);
                            adapter.Update(dt);
                            Console.WriteLine("employee details deleted successfully");

                            break;
                        default:
                            Console.Write("Invalid case!!");
                            break;
                    }

                    Console.Write("Enter y or Y to continue");
                     ch = Convert.ToChar(Console.ReadLine());
                    Console.ReadKey();






                }
                while (ch == 'Y' || ch == 'y');

           

        }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured!!!!" + ex.Message);
            }
        }
    }
}
    
