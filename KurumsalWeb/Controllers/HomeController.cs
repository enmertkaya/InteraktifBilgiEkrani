using KurumsalWeb.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KurumsalWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private KurumsalWebDB db = new KurumsalWebDB();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SliderPartial()
        {
            return View(db.News.ToList().OrderByDescending(x=>x.NewID));
        }
    }
}