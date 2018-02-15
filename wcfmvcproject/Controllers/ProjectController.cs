using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wcfmvcproject.ServiceReference2;

namespace wcfmvcproject.Controllers
{


    public class ProjectController : Controller
    {

        Service1Client c = new Service1Client();
        // GET: Home
        public ActionResult Index()
        {
             List<tblEmployee> employees = c.getemployee().ToList();
            return View(employees);
        }
        public ActionResult Customer()
        {
            List<customer> customers = c.getcustomer().ToList();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var e = c.GetEmployeeById(id);
            return View(e);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblEmployee e)
        {
            c.addrecord(e);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var e = c.GetEmployeeById(id);
            return View(e);
        }

        [HttpPost]
        public ActionResult DeleteConfirm(int id)
        {

            c.DeleteRecordById(id);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var g = c.GetEmployeeById(id);
            return View(g);
        }
        [HttpPost]
        public ActionResult Edit(tblEmployee t)
        {
            c.EditRowById(t);
            return RedirectToAction("Index");

        }
    } 
}