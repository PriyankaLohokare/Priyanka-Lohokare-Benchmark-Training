using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.ViewModel;
using WebApplication1.BAL;




namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBAL bal=new EmployeeBAL();
            List<EmployeeVM> elist=bal.GetEmpList();  

            return View(elist);
        }
    }
}