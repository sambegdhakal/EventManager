using AutoMapper;
using LFA.EventManager.Models;
using LFA.EventManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFA.EventManager.Areas.Admin.Controllers
{
    public class EventController : Controller
    {
        private EventManagerDbContext db = new EventManagerDbContext();
        // GET: Admin/Event
        public ActionResult Index()
        {
            Event evt = new Event();
            evt.Events = from @event in db.Events.ToList()
                         select new Event
                         {
                             Id = @event.Id,
                             Title = @event.Title,
                             Description = @event.Description,
                             EventDate = @event.EventDate,
                             AddedDate = @event.AddedDate,
                             ModifiedDate = @event.ModifiedDate,
                             
                             
                         };
            evt.Contacts = from contacts in db.Contacts.ToList()
                           select new SelectListItem
                           {
                               Text = contacts.FirstName + " " + contacts.LastName,
                               Value = contacts.Id.ToString()
                           };

            return View(evt);
        }

        // GET: Admin/Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Event/Create
        [HttpPost]
        public ActionResult Create(EventViewModel evm)
        {
            if (ModelState.IsValid)
            {
                Event evt = Mapper.Map<Event>(evm);
                evt.AddedDate = DateTime.Now;
                db.Events.Add(evt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evm);
        }

        public ActionResult Selectinvites(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Event evt = db.Events.Find(id);
           SelectInvitationViewModel svm = new SelectInvitationViewModel();
            svm.EventId = evt.Id;
            svm.EventName = evt.Title;
            svm.Contacts = from contacts in db.Contacts.ToList()
                          select new SelectListItem
                          {
                             
                              Text = contacts.FirstName +" " + contacts.LastName,
                              Value = contacts.Id.ToString()
                          };

          

            return View(svm);


        }
        [HttpPost]
        public ActionResult Selectinvites(int? id, SelectInvitationViewModel sivm)
        {
            
            return View();
        }
        // GET: Admin/Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Event/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
