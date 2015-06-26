using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using FantasyFootballCorner.Models;
using FantasyFootballCorner.Context;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using FantasyFootballCorner.ViewModels;
using System.Text;
using System.Web.Script.Serialization;


namespace FantasyFootballCorner.Controllers
{
    

    public class PlayerController : Controller
    {
        private FFCContext db = new FFCContext();

           

        public void Compare()
        {
            RedirectToAction("Index");
        }

        // posted from Player/Index
        [HttpPost]
        public ActionResult Compare(FormCollection f)
        {
            int player0, player1, player2, player3, player4;
            player0 = Convert.ToInt32(Request.Form["player0"]);
            player1 = Convert.ToInt32(Request.Form["player1"]);
            player2 = Convert.ToInt32(Request.Form["player2"]);
            player3 = Convert.ToInt32(Request.Form["player3"]);
            player4 = Convert.ToInt32(Request.Form["player4"]);
            List<int> pList = new List<int>();

            string position;

            // pick up the first player entry and grab his position
            if (player0 != -1)
            {
                pList.Add(player0);
            }
            
            if (player1 != -1)
            {
                pList.Add(player1);
            }
            if (player2 != -1)
            {
                pList.Add(player2);
            }
            if (player3 != -1)
            {
                pList.Add(player3);
            }
            if (player4 != -1)
            {
                pList.Add(player4);
            }
                                
            if(pList.Count == 0)
                return RedirectToAction("Index");
            else
                position = db.Players.Find(pList[0]).position;

            List<int> cats = new List<int>();

            switch (position)
            {
                case "QB":
                    cats = (from sc in db.StatCategories
                            where sc.isQBStat == true
                            select sc.statId).ToList();
                    break;
                case "RB":
                    cats = (from sc in db.StatCategories
                            where sc.isRBStat == true
                            select sc.statId).ToList();
                    break;
                case "WR":
                    cats = (from sc in db.StatCategories
                            where sc.isWRStat == true
                            select sc.statId).ToList();
                    break;
                case "TE":
                    cats = (from sc in db.StatCategories
                            where sc.isTEStat == true
                            select sc.statId).ToList();
                    break;
                case "K":
                    cats = (from sc in db.StatCategories
                            where sc.isKStat == true
                            select sc.statId).ToList();
                    break;
                case "DEF":
                    cats = (from sc in db.StatCategories
                            where sc.isDEFStat == true
                            select sc.statId).ToList();
                    break;
                default:
                    cats = new List<int>(new int[] { 1, 5, 6, 14, 15, 21, 22, 35, 36, 37, 38, 39, 46, 47, 54 });
                    break;
            }
            var statCats = (from sc in db.StatCategories
                            where cats.Contains(sc.statId)
                            select sc).ToList();

            var pStats = (from ps in db.PlayerStats
                          join pb in db.PlayerBackgrounds on ps.playerId equals pb.playerID
                          join t in db.Teams on ps.player.teamAbbre equals t.teamAbbre
                          where cats.Contains(ps.statCat.statId) && ps.season == 2014
                                && pList.Contains(ps.playerId)
                          group ps by new { ps.player, pb, t, ps.statCat } into g
                          orderby g.Key.player.playerId, g.Key.statCat.statId
                          select new
                          {
                              player = g.Key.player,
                              playerBackground = g.Key.pb,
                              team = g.Key.t,
                              statCat = g.Key.statCat,
                              statAmt = g.Sum(t => t.statAmt)
                          });

            List<PlayerIndexViewModel> players = new List<PlayerIndexViewModel>();
            List<PlayerStat> sList = new List<PlayerStat>();
            foreach (var p in pStats)
            {
                if (players.Count > 0 && players.Last().player.playerId == p.player.playerId)
                {
                    players.Last().statsList.Find(x => x.statId == p.statCat.statId).statAmt = p.statAmt;
                }
                else
                {
                    players.Add(new PlayerIndexViewModel(p.player, p.playerBackground, p.team, new List<PlayerStat>(), statCats));
                    players.Last().statsList.Find(x => x.statId == p.statCat.statId).statAmt = p.statAmt;
                }
            }

            return View(players);
        }

        // posted from ajax on Compare page
        [HttpPost]
        public JsonResult CompareWeeklyStats(List<Player> players)
        {
            string position = "";
            List<int> pList = new List<int>{};
            foreach (var player in players)
            {
                position = player.position;
                pList.Add(player.playerId);
            }

            List<StatCategory> cats = new List<StatCategory>();
            List<int> catIds = new List<int>();
            switch (position)
            {
                case "QB":
                    cats = (from sc in db.StatCategories
                            where sc.isQBStat == true
                            select sc).ToList();
                    catIds = (from s in cats
                               select s.statId).ToList();
                    break;
               case "RB":
                    cats = (from sc in db.StatCategories
                            where sc.isRBStat == true
                            select sc).ToList();
                    catIds = (from s in cats
                               select s.statId).ToList();
                    break;
                case "WR":
                    cats = (from sc in db.StatCategories
                            where sc.isWRStat == true
                            select sc).ToList();
                    catIds = (from s in cats
                               select s.statId).ToList();
                    break;
                case "TE":
                    cats = (from sc in db.StatCategories
                            where sc.isTEStat == true
                            select sc).ToList();
                    catIds = (from s in cats
                               select s.statId).ToList();
                    break;
               case "K":
                    cats = (from sc in db.StatCategories
                            where sc.isKStat == true
                            select sc).ToList();
                    catIds = (from s in cats
                               select s.statId).ToList();
                    break;
                case "DEF":
                    cats = (from sc in db.StatCategories
                            where sc.isDEFStat == true
                            select sc).ToList();
                    catIds = (from s in cats
                               select s.statId).ToList();
                    break;
            }

            var stats = (from ps in db.PlayerStats
                            where 
                                pList.Contains(ps.playerId)
                                && catIds.Contains(ps.statCat.statId)
                            group ps by ps.player.playerId into p
                            select p);

            var resp = new { cats, stats };

            
            return Json(resp);
        }

        public ActionResult Index()
        {
            List<int> cats = new List<int>(new int[] {1, 5, 6, 14, 15, 21, 22, 35, 36, 37, 38, 39, 46, 47, 54} );
            var statCats = (from sc in db.StatCategories
                            where cats.Contains(sc.statId)
                            select sc).ToList();

            var pStats = (from ps in db.PlayerStats
                          join pb in db.PlayerBackgrounds on ps.playerId equals pb.playerID
                          join t in db.Teams on ps.player.teamAbbre equals t.teamAbbre
                          where cats.Contains(ps.statCat.statId) && ps.season == 2014
                          group ps by new { ps.player, pb, t, ps.statCat } into g
                          orderby g.Key.player.playerId, g.Key.statCat.statId
                          select new
                          {
                              player = g.Key.player,
                              playerBackground = g.Key.pb,
                              team = g.Key.t,
                              statCat = g.Key.statCat,
                              statAmt = g.Sum(t => t.statAmt)
                          });

            List<PlayerIndexViewModel> players = new List<PlayerIndexViewModel>();
            List<PlayerStat> sList = new List<PlayerStat>();
            foreach (var p in pStats)
            {
                if (players.Count > 0 && players.Last().player.playerId == p.player.playerId)
                {
                    players.Last().statsList.Find(x => x.statId == p.statCat.statId).statAmt = p.statAmt;
                }
                else
                {
                    players.Add(new PlayerIndexViewModel(p.player, p.playerBackground, p.team, new List<PlayerStat>(), statCats));
                    players.Last().statsList.Find(x => x.statId == p.statCat.statId).statAmt = p.statAmt;
                }
            }
            return View(players);
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            string name = "";
            string position = "";

            if (!String.IsNullOrEmpty(Request.Form["name"]))
            {
                name = Request.Form["name"].ToUpper();
            }

            if (Request.Form["position"].Equals("ALL"))
            {
                if (name == "")
                {
                    return this.Index();
                }
                // to do--- if player match returns players of diff position 
                //      then use default cats list
                position = (from p in db.Players 
                            where p.playerName == name
                            select p.position).First();
            }
            else
            {
                position = Request.Form["position"];
            }

            List<int> cats = new List<int>();
            
            switch (position)
            {
                case "QB":
                    cats = (from sc in db.StatCategories
                            where sc.isQBStat == true
                            select sc.statId).ToList();
                    break;
                case "RB":
                    cats = (from sc in db.StatCategories
                            where sc.isRBStat == true
                            select sc.statId).ToList();
                    break;
                case "WR":
                    cats = (from sc in db.StatCategories
                            where sc.isWRStat == true
                            select sc.statId).ToList();
                    break;
                case "TE":
                    cats = (from sc in db.StatCategories
                            where sc.isTEStat == true
                            select sc.statId).ToList();
                    break;
                case "K":
                    cats = (from sc in db.StatCategories
                            where sc.isKStat == true
                            select sc.statId).ToList();
                    break;
                case "DEF":
                    cats = (from sc in db.StatCategories
                            where sc.isDEFStat == true
                            select sc.statId).ToList();
                    break;
                default:
                    cats = new List<int>(new int[] { 1, 5, 6, 14, 15, 21, 22, 35, 36, 37, 38, 39, 46, 47, 54 });
                    break;
            }
            var statCats = (from sc in db.StatCategories
                           where cats.Contains(sc.statId)
                           select sc).ToList();

            var pStats = (from ps in db.PlayerStats 
                            join pb in db.PlayerBackgrounds on ps.playerId equals pb.playerID
                            join t in db.Teams on ps.player.teamAbbre equals t.teamAbbre 
                            where (ps.player.playerName == name || ps.player.position == position)
                                && cats.Contains(ps.statCat.statId) && ps.season == 2014
                          group ps by new { ps.player, pb, t, ps.statCat } into g
                          orderby g.Key.player.playerId
                          select new
                          {
                              player = g.Key.player,
                              playerBackground = g.Key.pb,
                              team = g.Key.t,
                              statCat = g.Key.statCat,
                              statAmt = g.Sum(t => t.statAmt)
                          });

            List<PlayerIndexViewModel> players = new List<PlayerIndexViewModel>();
            List<PlayerStat> sList = new List<PlayerStat>();
            foreach (var p in pStats)
            {
                if (players.Count > 0 && players.Last().player.playerId == p.player.playerId)
                {
                    players.Last().statsList.Find(x => x.statId == p.statCat.statId).statAmt = p.statAmt;
                }
                else
                {
                    players.Add(new PlayerIndexViewModel(p.player, p.playerBackground, p.team, new List<PlayerStat>(), statCats));
                    players.Last().statsList.Find(x => x.statId == p.statCat.statId).statAmt = p.statAmt;
                }
            }

            return View(players);
        }

        

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id)
        {
            PlayerDetailsViewModel playerDetailVM = new PlayerDetailsViewModel();
            playerDetailVM.player = db.Players.Find(id);
            if (playerDetailVM.player == null)
            {
                return HttpNotFound();
            }
                      
            playerDetailVM.playerBackground = (from pb in db.PlayerBackgrounds where (pb.playerID == id) select pb).FirstOrDefault();
            //playerDetailVM.playerStats = (from ps in db.PlayerStats where playerID = id select ps).ToList();

            return View(playerDetailVM);            
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            return RedirectToAction("Index");
            //return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Player player)
        {
            return RedirectToAction("Index");
            if (ModelState.IsValid)
            {
                try
                {
                    db.Players.Add(player);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                }
                return RedirectToAction("Index");
            }

            return View(player);
        }

        [HttpPost]
        public void AddPlayers(List<Player> players)
        {
            RedirectToAction("Index");
            foreach (var player in players)
            {

                if (ModelState.IsValid)
                {
                    db.Players.Add(player);
                    db.SaveChanges();
                }
            }
        }

        [HttpPost]
        public JsonResult NameList()
        {
            var x = Json(db.Players.ToList());
            return x;
        }
        
        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            return RedirectToAction("Index");
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Player player)
        {
            return RedirectToAction("Index");
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        // GET: /Default1/Update/5

        public ActionResult UpdatePlayers()
        {
            return RedirectToAction("Index");
            return View();
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        public ActionResult UpdatePlayers(List<Player> players)
        {
            return RedirectToAction("Index");
            foreach (var p in players)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(p).State = EntityState.Modified;
                    db.SaveChanges();
                    
                }
            }
            return View();
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            return RedirectToAction("Index");
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction("Index");
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
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