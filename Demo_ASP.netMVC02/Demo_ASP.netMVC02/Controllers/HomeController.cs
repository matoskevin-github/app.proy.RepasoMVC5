using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_ASP.netMVC02.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            var persona1 = new Persona() { Nombre = "Felipe", Edad = 99 };
            var persona2 = new Persona() { Nombre = "Claudia", Edad = 90 };
            return Json(new List<Persona>() { persona1, persona2 }, JsonRequestBehavior.AllowGet);
            //return View();
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

    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}