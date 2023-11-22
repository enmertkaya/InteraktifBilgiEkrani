using KurumsalWeb.Models.DataContext;
using KurumsalWeb.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace KurumsalWeb.Controllers
{
    public class TVsController : Controller
    {
        // GET: TVs
        private KurumsalWebDB db = new KurumsalWebDB();
        // GET: Depatments
        public ActionResult Index()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return View(db.Deparments.Include("Faculty").ToList().OrderByDescending(x => x.DepartmentID));
        }
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.Deparments, "DepartmentID", "DepartmentName");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Department department)
        {
            db.Deparments.Add(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faculty faculty = db.Faculties.Find(id);
            if (faculty == null)
            {
                return HttpNotFound();
            }
            return View(faculty);
        }

        // POST: Faculties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Faculty faculty = db.Faculties.Find(id);
            db.Faculties.Remove(faculty);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}