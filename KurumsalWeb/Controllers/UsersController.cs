using KurumsalWeb.Models.DataContext;
using KurumsalWeb.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace KurumsalWeb.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        private KurumsalWebDB db = new KurumsalWebDB();
        // GET: Depatments
        public ActionResult Index()
        {
            db.Configuration.LazyLoadingEnabled = false;
            return View(db.Users.Include("Faculty").ToList().OrderByDescending(x => x.UserID));
        }
        public ActionResult Create()
        {
            ViewBag.FacultyID = new SelectList(db.Faculties, "FacultyID", "FacultyName");
            ViewBag.RoleID= new SelectList(db.Roles, "RoleID", "RoleName");

            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "UserName,UserSurname,UserPassword,UserMail,FacultyID,RoleID")] User user,string UserPassword,string UserMail)
        {
            if (ModelState.IsValid)
            {
                user.UserPassword = Crypto.Hash(UserPassword, "MD5");
            }
            
            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //public ActionResult Edit(int id)
        //{

        //    var b = db.Users.Where(x => x.UserID == id).SingleOrDefault();

        //    ViewBag.FacultyID = new SelectList(db.Faculties, "FacultyID", "FacultyName", b.FacultyID);
        //    ViewBag.RoleID = new SelectList(db.Roles, "RoleID", "RoleName");
        //    ViewBag.RoleID = new SelectList(db.Roles, "DepartmentID", "DepartmentName");
        //    return View(b);
        //}
        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult Edit(int id, User user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var b = db.Users.Where(x => x.UserID == id).SingleOrDefault();
        //        b.UserName = user.UserName;
        //        b.UserSurname = user.UserSurname;
        //        b.UserPassword = user.UserPassword;
        //        b.UserMail = user.UserMail;

        //        b.FacultyID = user.FacultyID;

        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(user);
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Faculties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
  

    
}