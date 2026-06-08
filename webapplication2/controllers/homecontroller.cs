using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Indexuser()
        {
            return View();
        }
        public ActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ForgetPassword(Admin a)
        {
            var admin = db.Admins.FirstOrDefault(x => x.Admin_Email == a.Admin_Email);

            if (admin != null)
            {
                admin.Admin_password = a.Admin_newpassword;
                db.SaveChanges();
                return RedirectToAction("Login" , "Home");
            }
            else
            {
               
                return View();
            }
        }
        public ActionResult Indexadmin()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Login(Admin obj)
        {
          int r=  db.Admins.Where(x => x.Admin_Email == obj.Admin_Email && x.Admin_password == obj.Admin_password).Count();
            
            if (r == 1)
            {
                return RedirectToAction("Indexadmin", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid Credentials";
                return View();
            }
        
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Admin obj)
        {
            
            var check = db.Admins.Where(x => x.Admin_Email == obj.Admin_Email).FirstOrDefault();

            if (check != null)
            {
                ViewBag.Message = "Email already exists!";
                return View();
            }
            else
            {
               
                db.Admins.Add(obj);
                db.SaveChanges();

                ViewBag.Message = "Account Created Successfully!";
                return RedirectToAction("Login");
            }
        }
        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult addcart(int? id)
        {
            List<Product> lst = new List<Product>();
            lst.Add(db.Products.Where(p => p.Product_ID == id).FirstOrDefault());
            Session["crt"] = lst;
            return RedirectToAction("Cart");
        }

        shopmodel s;
        public ActionResult Shop()
        {
            shopmodel s = new shopmodel();
            s.cat = db.Categories.ToList();
            s.pro = db.Products.ToList();
            return View(s);
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