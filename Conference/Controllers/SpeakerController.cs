using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conference.Models;

namespace Conference.Controllers
{
    public class SpeakerController : Controller
    {
        private ConferenceContext db = new ConferenceContext();

        public ActionResult Index()
        {
            return View (db.Speakers.ToList());
        }

        public ActionResult Details(int id = 0)
        {
            Speaker speaker = db.Speakers.Find(id);
            if (speaker == null)
            {
                return HttpNotFound();
            }
            return View(speaker);
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id = 0)
        {
            Speaker speaker = db.Speakers.Find(id);
            if(speaker == null)
            {
                return HttpNotFound();
            }
            return View(speaker);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}