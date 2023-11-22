using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Web.Mail;
using KurumsalWeb.Models.Model;
using KurumsalWeb.Models.DataContext;
using System.Web.Security;

namespace KurumsalWeb.Controllers
{
    public class AdminController : Controller
    {
        private KurumsalWebDB db = new KurumsalWebDB();

        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Users.ToList();

            return View(sorgu);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var login = db.Users.Where(x => x.UserMail == user.UserMail).SingleOrDefault();
            if (login.UserMail == user.UserMail && login.UserPassword == Crypto.Hash(user.UserPassword,"MD5"))
            {
               

                Session["UserID"] = login.UserID;
                Session["RoleID"] = login.RoleID;
                Session["UserName"] = login.UserName;
                Session["UserSurname"] = login.UserSurname;
                Session["UserMail"] = login.UserMail;
                return RedirectToAction("Index", "Admin");

            }
            ViewBag.Uyari = "Kullanıcı adı yada sifre yanlis";
            return View(user);
        }
        public ActionResult ForgotMyPassword()
        {
            return View();

        }
        [HttpPost]
        public ActionResult ForgotMyPassword(string usermail)
        {
            var mail = db.Users.Where(x => x.UserMail == usermail).SingleOrDefault();
            
           
            if (mail != null)
            {

                Random rnd = new Random();
                int yeniSifre = rnd.Next();
                User user = new User();
                

                mail.UserPassword = Crypto.Hash(Convert.ToString(yeniSifre),"MD5");
                db.SaveChanges();

                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.EnableSsl = true;
                WebMail.UserName = "lastgamle@gmail.com";
                WebMail.Password = "lyzokvwbthwpdeyg";
                WebMail.SmtpPort = 587;
                WebMail.Send(usermail, "Şifre Sıfırlama İşlemi", "Merhaba" +"," + " <br/> Yeni şifreniz: " + yeniSifre + " olarak belirlenmiştir." + "<br/> İyi günler dileriz.");
                ViewBag.Uyari = "Şifreniz başarı ile gönderilmştir";
            }
            return View();

        }
        public ActionResult Logout()
        {
            Session["AdminId"] = null;
            Session["Sifre"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Admin");
        }

    }
}