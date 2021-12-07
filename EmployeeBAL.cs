using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DAL;
using WebApplication1.ViewModel;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1.BAL
{
    public class EmployeeBAL
    {
        public List<EmployeeVM> GetEmpList()
        {
            EmployeeDAL d=new EmployeeDAL();
            SqlDataReader r = d.GetEmp();
            List<EmployeeVM> e=new List<EmployeeVM>();
            while (r.Read())
            {
                EmployeeVM o=new EmployeeVM();
                o.empid = Convert.ToInt32(r["empid"].ToString());
                o.empname = r["empname"].ToString();
                o.salary = Convert.ToInt32(r["salary"].ToString());
                o.designation = r["designation"].ToString();
                o.mgid = Convert.ToInt32(r["mgid"].ToString());
                o.depno = Convert.ToInt32(r["depno"].ToString());
                e.Add(o);
            }
            return e;

        }
    }
}