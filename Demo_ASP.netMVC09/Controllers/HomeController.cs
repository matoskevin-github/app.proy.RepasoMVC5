using Demo_ASP.netMVC09.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_ASP.netMVC09.Controllers
{
    public class HomeController : Controller
    {
        private PeliculaRepository _peliculasRepository;

        public HomeController()
        {
            _peliculasRepository = new PeliculaRepository();
        }

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
            var model = _peliculasRepository.ObtenerPeliculas();

            return View(model);
        }
    }
}