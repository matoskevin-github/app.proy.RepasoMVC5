using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_ASP.netMVC03.Controllers
{
    public class HomeController : Controller
    {
        public RedirectResult Index()
        {
            // return Redirect("https://www.google.com/"); Redirecciona a una pagina
            RedirectToAction("About");//Redirecciona a la accion de un controlador
            RedirectToAction("About", "Home"); //Redirecciona a la accion de un controlador especifico
            RedirectToRoute("nombre route config"); // Redirecciona a una ruta en especifica en el route config

           // return View();
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