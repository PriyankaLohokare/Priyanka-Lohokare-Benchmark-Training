using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using entityfr_demo.Models;

namespace entityfr_demo.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        Demo1Entities1 ent=new Demo1Entities1();  
       
 
        public ActionResult Index()
        {
            return View(ent.employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(employee employee)

            
        {
            try
            {
                using (Demo1Entities1 db = new Demo1Entities1())
                {
                    db.employees.Add(employee);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
         return View(ent.employees.Where(x=>x.empid==id).FirstOrDefault());
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(ent.employees.Where(x => x.empid == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Edit(int id,employee employee)

        {
            try
            {
                using (Demo1Entities1 db = new Demo1Entities1())
                {
                    db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                    ent.SaveChanges();
                }
                return RedirectToAction("Index");   
            }
            catch
            {
                return View();
            }

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }
        [HttpPost]
       public ActionResult Delete(int id,employee employee)
        {
            try
            {
                using (Demo1Entities1 db = new Demo1Entities1())
                {
                    employee = db.employees.Where(x => x.empid == id).FirstOrDefault();
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


    }
}