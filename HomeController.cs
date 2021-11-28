using ajax_jquerry_26_nov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax_jquerry_26_nov.Controllers
{
    
    public class HomeController : Controller
    {

        question_insertEntities db = new question_insertEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(tbl_insert i)
        {
            db.tbl_insert.Add(i);
            db.SaveChanges();


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
    }
}