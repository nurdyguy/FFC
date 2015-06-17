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
    public class PlayerBackgroundController : Controller
    {
        private FFCContext db = new FFCContext();

        //
        // GET: /PlayerBackground/

        public ActionResult Index()
        {
            return View(db.PlayerBackgrounds.ToList());
        }

        //
        // GET: /PlayerBackground/Details/5

        public ActionResult Details(int id = 0)
        {
            PlayerBackground playerbackground = db.PlayerBackgrounds.Find(id);
            if (playerbackground == null)
            {
                return HttpNotFound();
            }
            return View(playerbackground);
        }

        //
        // GET: /PlayerBackground/Create
        public ActionResult Create()
        {
            return View();
        }


        //
        // POST: /PlayerBackground/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlayerBackground playerbackground)
        {
            if (ModelState.IsValid)
            {
                db.PlayerBackgrounds.Add(playerbackground);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(playerbackground);
        }

        // adds a single PlayerBackground
        [HttpPost]
        public void UpdatePlayerBackgrounds(PlayerBackground p)
        {
            //foreach (var p in playerbackground)
            {
                // find the playerId based on name



                // if found then insert

                //if (ModelState.IsValid)
                {
                    db.PlayerBackgrounds.Add(p);
                    db.SaveChanges();
                    //return RedirectToAction("Index");
                }
            }
            //return View(player);
        }


        //
        // GET: /PlayerBackground/Edit/
        public ActionResult Edit(int id = 0)
        {
            PlayerBackground playerbackground = db.PlayerBackgrounds.Find(id);
            if (playerbackground == null)
            {
                return HttpNotFound();
            }
            return View(playerbackground);
        }


        //
        // POST: /PlayerBackground/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PlayerBackground playerbackground)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerbackground).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(playerbackground);
        }


        //
        // GET: /PlayerBackground/Delete/5
        public ActionResult Delete(int id = 0)
        {
            PlayerBackground playerbackground = db.PlayerBackgrounds.Find(id);
            if (playerbackground == null)
            {
                return HttpNotFound();
            }
            return View(playerbackground);
        }


        //
        // POST: /PlayerBackground/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerBackground playerbackground = db.PlayerBackgrounds.Find(id);
            db.PlayerBackgrounds.Remove(playerbackground);
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