using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using KurumsalWeb.Models.DataContext;
using KurumsalWeb.Models.Model;

namespace KurumsalWeb.Controllers
{
    public class NewsController : Controller
    {
        private KurumsalWebDB db = new KurumsalWebDB();

        // GET: News
        public ActionResult Index()
        {
            db.Configuration.LazyLoadingEnabled = false;
            
            return View(db.News.Include("User").ToList().OrderByDescending(x=>x.NewID));
        }

        // GET: News/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            New @new = db.News.Find(id);
            if (@new == null)
            {
                return HttpNotFound();
            }
            return View(@new);
        }

        // GET: News/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName");
            return View();
        }

        // POST: News/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NewID,NewName,NewPath,NewDescription,UserID,TvID")] New @new, HttpPostedFileBase NewPath)
        {
            if (ModelState.IsValid)
            {
                if (NewPath != null)
                {
                    WebImage img = new WebImage(NewPath.InputStream);
                    FileInfo imginfo = new FileInfo(NewPath.FileName);

                    string sliderimgname = Guid.NewGuid().ToString() + imginfo.Extension;
                    img.Resize(1024, 683);
                    img.Save("~/Uploads/New/" + sliderimgname);

                    @new.NewPath = "/Uploads/New/" + sliderimgname;
                }
                db.News.Add(@new);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", @new.UserID);
            return View(@new);
        }

        // GET: News/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            New @new = db.News.Find(id);
            if (@new == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "UserID", "UserName", @new.UserID);
            return View(@new);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NewID,NewName,NewPath,NewDescription,UserID,TvID")] New @new,HttpPostedFileBase NewPath, int id)
        {
            if (ModelState.IsValid)
            {
                var s = db.News.Where(x => x.NewID == id).SingleOrDefault();
                if (NewPath != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(s.NewPath)))
                    {
                        System.IO.File.Delete(Server.MapPath(s.NewPath));
                    }
                    WebImage img = new WebImage(NewPath.InputStream);
                    FileInfo imginfo = new FileInfo(NewPath.FileName);

                    string sliderimgname = NewPath.FileName + imginfo.Extension;
                    img.Resize(1024, 683);
                    img.Save("~/Uploads/New/" + sliderimgname);

                    s.NewPath = "/Uploads/New/" + sliderimgname;
                }
                s.NewName = @new.NewName;
                
                s.NewDescription = @new.NewDescription;
                s.UserID = @new.UserID;
                s.TvID = @new.TvID;

                
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(@new);
        }

        // GET: News/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            New @new = db.News.Find(id);
            if (@new == null)
            {
                return HttpNotFound();
            }
            return View(@new);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            New @new = db.News.Find(id);
            db.News.Remove(@new);
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
