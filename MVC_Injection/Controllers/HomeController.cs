using MVC_Injection.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Injection.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository;
        //public HomeController()
        //{
        //    repository = new RepositoryExcel();
        //}
        public HomeController(IRepository _repository)
        {
            this.repository = _repository;
        }
        public ActionResult Index()
        {
            var city = repository.FindById(1);
            return View(city);
            // return new HttpStatusCodeResult(409);
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