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
    public class StatCategoryController : Controller
    {
        private FFCContext db = new FFCContext();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View(db.StatCategories.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            StatCategory statcategory = db.StatCategories.Find(id);
            if (statcategory == null)
            {
                return HttpNotFound();
            }
            return View(statcategory);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StatCategory statcategory)
        {
            if (ModelState.IsValid)
            {
                db.StatCategories.Add(statcategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statcategory);
        }

        [HttpPost]
        public void UpdateStatCats(List<StatCategory> statcategories)
        {
            foreach (var s in statcategories)
            {

                if (ModelState.IsValid)
                {
                    db.StatCategories.Add(s);
                    db.SaveChanges();
                }
            }
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            StatCategory statcategory = db.StatCategories.Find(id);
            if (statcategory == null)
            {
                return HttpNotFound();
            }
            return View(statcategory);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StatCategory statcategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statcategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statcategory);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            StatCategory statcategory = db.StatCategories.Find(id);
            if (statcategory == null)
            {
                return HttpNotFound();
            }
            return View(statcategory);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StatCategory statcategory = db.StatCategories.Find(id);
            db.StatCategories.Remove(statcategory);
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