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
    public class PlayerStatController : Controller
    {
        private FFCContext db = new FFCContext();

        //
        // GET: /PlayerStat/

        public ActionResult Index()
        {
            var playerstats = db.PlayerStats.Include(p => p.player);
            return View(playerstats.ToList());
        }

        //
        // GET: /PlayerStat/Details/5

        public ActionResult Details(int id = 0)
        {
            PlayerStat playerstat = db.PlayerStats.Find(id);
            if (playerstat == null)
            {
                return HttpNotFound();
            }
            return View(playerstat);
        }

        //
        // GET: /PlayerStat/Create

        public ActionResult Create()
        {
            ViewBag.playerId = new SelectList(db.Players, "playerId", "name");
            return View();
        }

        //
        // POST: /PlayerStat/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerStat playerstat)
        {
            if (ModelState.IsValid)
            {
                db.PlayerStats.Add(playerstat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.playerId = new SelectList(db.Players, "playerId", "name", playerstat.playerId);
            return View(playerstat);
        }

        // bulk create from API
        [HttpPost]
        public void CreateBulk(List<PlayerStat> playerstats)
        {
            foreach (var p in playerstats)
            {

                if (ModelState.IsValid)
                {
                    db.PlayerStats.Add(p);
                    db.SaveChanges();
                   
                }
            }
            
        }


        //
        // GET: /PlayerStat/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PlayerStat playerstat = db.PlayerStats.Find(id);
            if (playerstat == null)
            {
                return HttpNotFound();
            }
            ViewBag.playerId = new SelectList(db.Players, "playerId", "name", playerstat.playerId);
            return View(playerstat);
        }

        //
        // POST: /PlayerStat/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PlayerStat playerstat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerstat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.playerId = new SelectList(db.Players, "playerId", "name", playerstat.playerId);
            return View(playerstat);
        }

        //
        // GET: /PlayerStat/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PlayerStat playerstat = db.PlayerStats.Find(id);
            if (playerstat == null)
            {
                return HttpNotFound();
            }
            return View(playerstat);
        }

        //
        // POST: /PlayerStat/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerStat playerstat = db.PlayerStats.Find(id);
            db.PlayerStats.Remove(playerstat);
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