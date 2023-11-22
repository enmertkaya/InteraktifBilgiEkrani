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
    public class DepartmentsController : Controller
    {
        private KurumsalWebDB  db = new KurumsalWebDB();
        // GET: Depatments
        public ActionResult Index()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return View(db.Deparments.Include("Faculty").ToList().OrderByDescending(x=>x.DepartmentID));
        }
        public ActionResult Create()
        {
            ViewBag.FacultyID = new SelectList(db.Faculties, "FacultyID", "FacultyName");
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
        
        public ActionResult Edit(int id)
        {
            
            var b = db.Deparments.Where(x => x.DepartmentID == id).SingleOrDefault();
           
            ViewBag.FacultyID = new SelectList(db.Faculties, "FacultyID", "FacultyName", b.FacultyID);
            return View(b);
        }

        [HttpPost]
        [ValidateInput(false)]
        

        public ActionResult Edit(int id, Department department)
        {
            if (ModelState.IsValid)
            {
                var b = db.Deparments.Where(x => x.DepartmentID == id).SingleOrDefault();
                b.DepartmentName = department.DepartmentName;
                b.DepartmentCreationDate = department.DepartmentCreationDate;
                b.FacultyID = department.FacultyID;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Deparments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Faculties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = db.Deparments.Find(id);
            db.Deparments.Remove(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}