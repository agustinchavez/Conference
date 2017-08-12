using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conference.Models;

namespace Conference.Controllers
{
    public class SessionController : Controller
    {
        public ActionResult Index()
        {
            ConferenceContext context = new ConferenceContext();
            List<Session> sessions = context.Sessions.ToList();
            return View ("Index", sessions);
        }

        //Get: Session/Create
        [HttpGet()]
        public ActionResult Create()
        {
            return View();
        }

        //Post: Session/Create
        [HttpPost()]
        public ActionResult Create(Session session)
        {
            if (!ModelState.IsValid){
                return View(session);
            }
            try {
				ConferenceContext context = new ConferenceContext();
				context.Sessions.Add(session);
				context.SaveChanges();
            } catch (Exception ex){
                ModelState.AddModelError("Error", ex.Message);
                return View(session);
            }

            TempData["Message"] = "Created" + session.Title;
            return RedirectToAction("Index");
        }
    }
}
