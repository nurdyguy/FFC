using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FantasyFootballCorner.Models;
using FantasyFootballCorner.Context;

namespace FantasyFootballCorner.Controllers
{
    public class WeekStatController : Controller
    {
        private FFCContext db = new FFCContext();

        //
        // GET: /WeekStat/

        public ActionResult Index()
        {
            var weekstats = db.WeekStats.Include(w => w.player);
            return View(weekstats.ToList());
        }

        //
        // GET: /WeekStat/Details/5

        public ActionResult Details(int id = 0)
        {
            WeekStat weekstat = db.WeekStats.Find(id);
            if (weekstat == null)
            {
                return HttpNotFound();
            }
            return View(weekstat);
        }

        //
        // GET: /WeekStat/Create

        public ActionResult Create()
        {
            ViewBag.playerId = new SelectList(db.Players, "playerId", "playerName");
            return View();
        }

        //
        // POST: /WeekStat/Create

        [HttpPost]
        public ActionResult Create(WeekStat weekstat)
        {
            if (ModelState.IsValid)
            {
                db.WeekStats.Add(weekstat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.playerId = new SelectList(db.Players, "playerId", "playerName", weekstat.playerId);
            return View(weekstat);
        }

        //
        // GET: /WeekStat/Edit/5

        public ActionResult Edit(int id = 0)
        {
            WeekStat weekstat = db.WeekStats.Find(id);
            if (weekstat == null)
            {
                return HttpNotFound();
            }
            ViewBag.playerId = new SelectList(db.Players, "playerId", "playerName", weekstat.playerId);
            return View(weekstat);
        }

        //
        // POST: /WeekStat/Edit/5

        [HttpPost]
        public ActionResult Edit(WeekStat weekstat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(weekstat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.playerId = new SelectList(db.Players, "playerId", "playerName", weekstat.playerId);
            return View(weekstat);
        }

        // bulk create from API
        [HttpPost]
        public void CreateBulk(List<WeekStat> weekStat)
        {
            foreach (var w in weekStat)
            {

                if (ModelState.IsValid)
                {
                    db.WeekStats.Add(w);
                    db.SaveChanges();

                }
            }

        }

        //
        // GET: /WeekStat/Delete/5

        public ActionResult Delete(int id = 0)
        {
            WeekStat weekstat = db.WeekStats.Find(id);
            if (weekstat == null)
            {
                return HttpNotFound();
            }
            return View(weekstat);
        }

        //
        // POST: /WeekStat/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            WeekStat weekstat = db.WeekStats.Find(id);
            db.WeekStats.Remove(weekstat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}