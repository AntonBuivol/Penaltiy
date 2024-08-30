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
            AccountController accountController = db.Users.Find(id);
            if (accountController == null)
            {
                return HttpNotFound();
            }
            return View(accountController);
        }

        [HttpPost, ActionName("Penalty_Edit")]
        public ActionResult Penalty_EditConfirmed(AccountController accountController)
        {
            db.Entry(accountController).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }





        //users

        public ActionResult Accounts()
        {
            IEnumerable<AccountController> accountController = db.Users;
            return View(accountController);
        }

        [HttpGet]
        public ActionResult Accounts_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Accounts_Create(AccountController accountController)
        {
            db.Users.Add(accountController);
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }

        [HttpGet]
        public ActionResult Accounts_Delete(int id)
        {
            AccountController accountController = db.Users.Find(id);
            if (accountController == null)
            {
                return HttpNotFound();
            }
            return View(accountController);
        }

        [HttpPost, ActionName("Penalty_Delete")]
        public ActionResult Accounts_DeleteConfirmed(int id)
        {
            AccountController accountController = db.Users.Find(id);
            if (accountController == null)
            {
                return HttpNotFound();
            }
            db.Users.Remove(accountController);
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }

        [HttpGet]
        public ActionResult Accounts_Edit(int? id)
        {
            AccountController accountController = db.Users.Find(id);
            if (accountController == null)
            {
                return HttpNotFound();
            }
            return View(accountController);
        }

        [HttpPost, ActionName("Penalty_Edit")]
        public ActionResult Accounts_EditConfirmed(AccountController accountController)
        {
            db.Entry(accountController).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }
    }
}