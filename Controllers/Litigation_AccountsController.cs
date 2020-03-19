using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ActivityUpdate.DAL;
using ActivityUpdate.Models;

namespace ActivityUpdate.Controllers
{
    public class Litigation_AccountsController : Controller
    {
        private AccountEntitiesContext db = new AccountEntitiesContext();

        // GET: Litigation_Accounts
        public ActionResult Index()
        {
            return View(db.Litigation_Accounts.ToList());
        }

        // GET: Litigation_Accounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Litigation_Accounts litigation_Accounts = db.Litigation_Accounts.Find(id);
            if (litigation_Accounts == null)
            {
                return HttpNotFound();
            }
            return View(litigation_Accounts);
        }

        // GET: Litigation_Accounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Litigation_Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LitigationAccountID,LitigationCaseID,AccountNumber")] Litigation_Accounts litigation_Accounts)
        {
            if (ModelState.IsValid)
            {
                db.Litigation_Accounts.Add(litigation_Accounts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(litigation_Accounts);
        }

        // GET: Litigation_Accounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Litigation_Accounts litigation_Accounts = db.Litigation_Accounts.Find(id);
            if (litigation_Accounts == null)
            {
                return HttpNotFound();
            }
            return View(litigation_Accounts);
        }

        // POST: Litigation_Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LitigationAccountID,LitigationCaseID,AccountNumber")] Litigation_Accounts litigation_Accounts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(litigation_Accounts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(litigation_Accounts);
        }

        // GET: Litigation_Accounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Litigation_Accounts litigation_Accounts = db.Litigation_Accounts.Find(id);
            if (litigation_Accounts == null)
            {
                return HttpNotFound();
            }
            return View(litigation_Accounts);
        }

        // POST: Litigation_Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Litigation_Accounts litigation_Accounts = db.Litigation_Accounts.Find(id);
            db.Litigation_Accounts.Remove(litigation_Accounts);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
        public ActionResult LinkAccounts()
        {
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LinkAccounts([Bind(Include = "LitigationAccountID,LitigationCaseID,AccountNumber")] Litigation_Accounts litigation_Accounts)
        {
            if (ModelState.IsValid)
            {
                db.Litigation_Accounts.Add(litigation_Accounts);
                db.SaveChanges();
                int id = litigation_Accounts.LitigationAccountID;
                return RedirectToAction("Index");
            }

            return View(litigation_Accounts);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
