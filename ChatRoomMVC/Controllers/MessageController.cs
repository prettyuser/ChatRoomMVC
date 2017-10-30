using DataAccess.Entities;
using Services.BusinessLogic.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace ChatRoomMVC.Controllers
{
    public class MessageController : Controller
    {
        IMessageService _messageService;
        IUserService _userService;
        public MessageController(IMessageService messageService, IUserService userService)
        {
            _messageService = messageService;
            _userService = userService;
        }

        // GET: /Message/
        public ActionResult Index()
        {
            return View(_messageService.GetAll());
        }

        // GET: /Message/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = _messageService.GetById(id.Value);
            if (message == null)
            {
                return HttpNotFound();
            }
            return View(message);
        }

        // GET: /Message/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: /Message/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MessageText,DateTimeMessage,UserId")] Message message)
        {
            if (ModelState.IsValid)
            {
                _messageService.Create(message);
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "MessageText", message.UserId);
            return View(message);
        }

        // GET: /Message/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = _messageService.GetById(id.Value);
            if (message == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "MessageText", message.UserId);
            return View(message);
        }

        // POST: /Message/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MessageText,DateTimeMessage,UserId")] Message message)
        {
            if (ModelState.IsValid)
            {
                _messageService.Update(message);
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(_userService.GetAll(), "Id", "MessageText", message.UserId);
            return View(message);
        }

        // GET: /Message/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message message = _messageService.GetById(id.Value);
            if (message == null)
            {
                return HttpNotFound();
            }
            return View(message);
        }

        // POST: /Message/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Message message = _messageService.GetById(id);
            _messageService.Delete(message);
            return RedirectToAction("Index");
        }
    }
}