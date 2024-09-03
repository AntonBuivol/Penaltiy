using Koolitused.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Koolitused.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        PenaltyContext db = new PenaltyContext();


        public ActionResult Penalties()
        {
            IEnumerable<Penalty> penalty = db.Penalty;
            return View(penalty);
        }

        [HttpGet]
        public ActionResult Penalty_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Penalty_Create(Penalty penalty)
        {
            db.Penalty.Add(penalty);
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }

        [HttpGet]
        public ActionResult Penalty_Delete(int id)
        {
            Penalty penalty = db.Penalty.Find(id);
            if (penalty == null)
            {
                return HttpNotFound();
            }
            return View(penalty);
        }

        [HttpPost, ActionName("Penalty_Delete")]
        public ActionResult Penalty_DeleteConfirmed(int id)
        {
            Penalty penalty = db.Penalty.Find(id);
            if (penalty == null)
            {
                return HttpNotFound();
            }
            db.Penalty.Remove(penalty);
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }

        [HttpGet]
        public ActionResult Penalty_Edit(int? id)
        {
            Penalty penalty = db.Penalty.Find(id);
            if (penalty == null)
            {
                return HttpNotFound();
            }
            return View(penalty);
        }

        [HttpPost, ActionName("Penalty_Edit")]
        public ActionResult Penalty_EditConfirmed(Penalty penalty)
        {
            db.Entry(penalty).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }





        //users

        
    }
}