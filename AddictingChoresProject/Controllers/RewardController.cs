using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AddictingChoresProject.DAL;
using AddictingChoresProject.Models;

namespace AddictingChoresProject.Controllers
{
    public class RewardController : Controller
    {
        private AddictingChoresContext db = new AddictingChoresContext();

        // GET: Reward
        public ActionResult Index()
        {
            return View(db.Rewards.ToList());
        }

        // GET: Reward/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reward reward = db.Rewards.Find(id);
            if (reward == null)
            {
                return HttpNotFound();
            }
            return View(reward);
        }

        // GET: Reward/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reward/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RewardId,RewardTitle,Description,CreateTime,Cost,CostType")] Reward reward)
        {
            if (ModelState.IsValid)
            {
                db.Rewards.Add(reward);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reward);
        }

        // GET: Reward/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reward reward = db.Rewards.Find(id);
            if (reward == null)
            {
                return HttpNotFound();
            }
            return View(reward);
        }

        // POST: Reward/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RewardId,RewardTitle,Description,CreateTime,Cost,CostType")] Reward reward)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reward).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reward);
        }

        // GET: Reward/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reward reward = db.Rewards.Find(id);
            if (reward == null)
            {
                return HttpNotFound();
            }
            return View(reward);
        }

        // POST: Reward/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reward reward = db.Rewards.Find(id);
            db.Rewards.Remove(reward);
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
