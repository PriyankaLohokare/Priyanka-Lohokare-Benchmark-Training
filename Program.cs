//implement dissconnected architecture to display employee data

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ado2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=.;database=Demo1;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("Select * from employee", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
         
                DataSet ds = new DataSet();
              
                 adapter.Fill(ds);
                //adapter.Fill(ds,"employee");
                DataTable dt = ds.Tables[0];

                    foreach (DataRow dr in dt.Rows)
                {

                    Console.WriteLine(dr[0].ToString()+"\t"+ dr[1].ToString() + "\t"+
                        dr[2].ToString() + "\t"+ dr[3].ToString() + "\t"+ dr[4].ToString() + "\t"+
                        dr[5].ToString() + "\t");
                }
                Console.ReadKey();


            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception occured!!!!"+ex.Message);
            }
        }
    }
}