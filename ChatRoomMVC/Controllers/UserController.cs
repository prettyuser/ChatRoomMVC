using DataAccess.Entities;
using Services.BusinessLogic.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatRoomMVC.Controllers
{
    public class UserController : Controller
    {
        //initialize service object
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //
        // GET: /User/
        public ActionResult Index()
        {
            return View(_userService.GetAll());
        }

        //
        // GET: /User/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {

            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _userService.Create(user);
                return RedirectToAction("Index");
            }
            return View(user);

        }

        //
        // GET: /User/Edit/5
        public ActionResult Edit(int id)
        {
            User user = _userService.GetById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /User/Edit
        [HttpPost]
        public ActionResult Edit(User user)
        {

            if (ModelState.IsValid)
            {
                _userService.Update(user);
                return RedirectToAction("Index");
            }
            return View(user);

        }

        //
        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            User user = _userService.GetById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection data)
        {
            User user = _userService.GetById(id);
            _userService.Delete(user);
            return RedirectToAction("Index");
        }
    }
}