//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Security;
//using System.Web.Mvc;

//using Global.Models;
//using DataAccess.Entities;
//using DataAccess.DBContext;
//using ChatRoomMVC.Global.Models;

//namespace FormsAuthApp.Controllers
//{
//    public class AccountController:Controller
//    {
//        public ActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Login(RegisterModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                // поиск пользователя в бд
//                User user = null;
//                using (EfDbContext db = new EfDbContext())
//                {
//                    user = db.Users.FirstOrDefault(u => u. == model.Name);

//                }
//                //if (user != null)
//                //{
//                //    FormsAuthentication.SetAuthCookie(model.Name, true);
//                //    return RedirectToAction("Index", "Home");
//                //}
//                //else
//                //{
//                //    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
//                //}
//            }

//            return View(model);
//        }

//        public ActionResult Register()
//        {
//            return View();
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Register(RegisterModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                User user = null;
//                using (EfDbContext db = new EfDbContext())
//                {
//                    user = db.Users.FirstOrDefault(u => u. == model.Name);
//                }
//                if (user == null)
//                {
//                    // создаем нового пользователя
//                    using (EfDbContext db = new EfDbContext())
//                    {
//                        db.Users.Add(new User { Name = model.Name});
//                        db.SaveChanges();

//                        user = db.Users.Where(u => u.Name == model.Name).FirstOrDefault();
//                    }
//                    // если пользователь удачно добавлен в бд
//                    if (user != null)
//                    {
//                        FormsAuthentication.SetAuthCookie(model.Name, true);
//                        return RedirectToAction("Index", "Home");
//                    }
//                }
//                else
//                {
//                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
//                }
//            }

//            return View(model);
//        }
//        public ActionResult Logoff()
//        {
//            FormsAuthentication.SignOut();
//            return RedirectToAction("Index", "Home");
//        }
//    }
//}