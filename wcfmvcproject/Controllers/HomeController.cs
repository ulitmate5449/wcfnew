using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wcfmvcproject.ServiceReference2;
using wcfmvcproject.Models;

namespace wcfmvcproject.Controllers
{
    public class HomeController : Controller
    {
        Service1Client c = new Service1Client();
        // GET: Home
        public ActionResult Index()
        {

            return RedirectToAction("Login", "Home");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login l)
        {
            if (c.authenticate(l.ename,l.pswd))
            {
                Session["uname"] = l.ename;
                return RedirectToAction("Index", "Project");
            }
            Response.Write("Invalid Input credentials");
            return View();

        }
        public ActionResult LogOutt()
        {
            string uname = Session["uname"].ToString();
            ViewBag.msg =uname+ " logout sucessful";
            Session.Abandon();
            return View();
        }
       
    }
}