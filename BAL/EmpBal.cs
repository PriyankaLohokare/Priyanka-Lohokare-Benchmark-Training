using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_crud_.Models;
using MVC_crud_.DAL;
using System.Data;
using System.Data.SqlClient;
     


namespace MVC_crud_.BAL
{
    public class EmpBal
    {
        EmpDal emdal=new EmpDal();
        public List<EmpModel> GetAllEmp()
        {
            SqlDataReader reader = emdal.GetAllEmp();
            List<EmpModel> emplist = new List<EmpModel>();
            while (reader.Read())
            {
                EmpModel emp = new EmpModel();
                emp.empid = Convert.ToInt32(reader["empid"].ToString());
                emp.empname = reader["empname"].ToString();
                emp.salary = Convert.ToInt32(reader["salary"].ToString());
                emp.designation = reader["designation"].ToString();
                emp.mgid = Convert.ToInt32(reader["mgid"].ToString());
                emp.depno = Convert.ToInt32(reader["depno"].ToString());
                emplist.Add(emp);

            }

            return emplist;
        }
        public  EmpModel getempusingempid(int empid)
        {
            SqlDataReader reader = emdal.getempbyempid(empid);
            EmpModel emp = null;


            while (reader.Read())
            {
                emp = new EmpModel();
                emp.empid = Convert.ToInt32(reader["empid"].ToString());
                emp.empname = reader["empname"].ToString();
                emp.salary = Convert.ToInt32(reader["salary"].ToString());
                emp.designation = reader["designation"].ToString();
                emp.mgid = Convert.ToInt32(reader["mgid"].ToString());
                emp.depno = Convert.ToInt32(reader["depno"].ToString());
               

            }

            return emp;
        }
        public int insertemp(EmpModel dm)
        {
            int res = emdal.insertemp(dm.empid, dm.empname, dm.salary, dm.designation, dm.mgid, dm.depno);
                return res;
        }
        public int updateemp(EmpModel dm)
        {
            int res = emdal.updatetemp(dm.empid, dm.empname, dm.salary, dm.designation, dm.mgid, dm.depno);
                return res;
        }
        public int deleteemp(int empid)
        {
            int res = emdal.deleteemp(empid);
                return res;
        }
    }
}