using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplicacao.Models;

namespace Aplicacao.Controllers
{
    public class TestersController : Controller
    {
        private AplicacaoContext db = new AplicacaoContext();

        // GET: Testers
        public ActionResult Index()
        {
            return View(db.Testers.ToList());
        }

        // GET: Testers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tester tester = db.Testers.Find(id);
            if (tester == null)
            {
                return HttpNotFound();
            }
            return View(tester);
        }

        // GET: Testers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testers/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] Tester tester)
        {
            if (ModelState.IsValid)
            {
                db.Testers.Add(tester);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tester);
        }

        // GET: Testers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tester tester = db.Testers.Find(id);
            if (tester == null)
            {
                return HttpNotFound();
            }
            return View(tester);
        }

        // POST: Testers/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] Tester tester)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tester).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tester);
        }

        // GET: Testers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tester tester = db.Testers.Find(id);
            if (tester == null)
            {
                return HttpNotFound();
            }
            return View(tester);
        }

        // POST: Testers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tester tester = db.Testers.Find(id);
            db.Testers.Remove(tester);
            db.SaveChanges();
            return RedirectToAction("Index");
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
