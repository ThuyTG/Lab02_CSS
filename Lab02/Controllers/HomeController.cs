using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lab02_Table_Bai1()
        {
            return View();
        }

        public ActionResult Lab02_Table_Bai2()
        {
            return View();
        }
        public ActionResult Lab02_Table_Bai3()
        {
            return View();
        }
        public ActionResult Lab02_Table_Bai4()
        {
            return View();
        }
        public ActionResult Lab02_Layout_Bai1()
        {
            return View();
        }
        public ActionResult Lab02_Layout_Bai2()
        {
            return View();
        }
        public ActionResult Lab02_Layout_Bai3()
        {
            return View();
        }

    }
}