using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_crud_.BAL;
using MVC_crud_.Models;
using System.Web.Mvc;


namespace MVC_crud_.Controllers
{

    public class EmpController : Controller
    {
        // GET: Emp
        EmpBal eb=new EmpBal();
        public ActionResult Index()
        {
            List<EmpModel> emplist = eb.GetAllEmp();

            return View(emplist);
        }
        [HttpGet]
        public ActionResult insertemp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insertemp( FormCollection collection)
        {
            try
            {
                EmpModel em = new EmpModel();
                EmpBal bal = new EmpBal();

                em.empid = Convert.ToInt32(collection["empid"].ToString());
                em.empname = collection["empname"].ToString();
                em.salary = Convert.ToInt32(collection["salary"].ToString());
                em.designation = collection["designation"].ToString();
                em.mgid = Convert.ToInt32(collection["mgid"].ToString());
                em.depno = Convert.ToInt32(collection["depno"].ToString());
                bal.insertemp(em);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "insertemp";
                return RedirectToAction("err");
                
            }
           
        }
        [HttpGet]
        public ActionResult updateemp(int empid)
        {
            EmpBal bal = new EmpBal();
            EmpModel em= bal.getempusingempid(empid);
            return View(em);
        }
        [HttpPost]
        public ActionResult updateemp(FormCollection collection)
        {
            try
            {
                EmpModel em = new EmpModel();
                EmpBal bal = new EmpBal();

                em.empid = Convert.ToInt32(collection["empid"].ToString());
                em.empname = collection["empname"].ToString();
                em.salary = Convert.ToInt32(collection["salary"].ToString());
                em.designation = collection["designation"].ToString();
                em.mgid = Convert.ToInt32(collection["mgid"].ToString());
                em.depno = Convert.ToInt32(collection["depno"].ToString());
                bal.updateemp(em);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "index";
                return RedirectToAction("err");

            }

        }
        [HttpGet]
        public ActionResult deleteemp(int empid)
        {
            try
            {
                EmpBal bal = new EmpBal();
                eb.deleteemp(empid);
                return View();
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
                TempData["backpage"] = "index";
                return RedirectToAction("err");

            }
        }
        [HttpGet]
        public ActionResult detailemp(int empid)
        {
         
            EmpModel em = eb.getempusingempid(empid);
            return View(em);
        }

        [HttpGet]
        public ActionResult errorpage()

        {
            TempData.Keep("err");
            TempData.Keep("index");
            return View();

        }
    }
}