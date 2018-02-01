using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFA.EventManager.Areas.Admin.Controllers
{
    public class InvitationController : Controller
    {
        // GET: Admin/Invitation
        public ActionResult Selectinvitant()
        {
            return View();
        }

        // GET: Admin/Invitation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Invitation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Invitation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Invitation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Invitation/Edit/5
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

        // GET: Admin/Invitation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Invitation/Delete/5
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
