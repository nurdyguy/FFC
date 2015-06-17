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

namespace FantasyFootballCorner.Controllers
{
    

    public class PlayerController : Controller
    {
        private FFCContext db = new FFCContext();

        
        //
        // GET: /Default1/

        public ActionResult Index4()
        {
            return RedirectToAction("Index");
            //List<PlayerIndexViewModel> players = new List<PlayerIndexViewModel>();


            List<PlayerIndexViewModel> p = db.Database.SqlQuery<PlayerIndexViewModel>(
                    "select  p.playerId, isnull(p.playerName, '') playerName, pb.height, pb.weight, pb.dob, pb.college, pb.imageUrl, pb.years, "
                    + "isnull([statCat_1],0) [statCat_1],isnull([statCat_2],0) [statCat_2],isnull([statCat_3],0) [statCat_3],isnull([statCat_4],0) [statCat_4],isnull([statCat_5],0) [statCat_5],isnull([statCat_6],0) [statCat_6],isnull([statCat_7],0) [statCat_7],isnull([statCat_8],0) [statCat_8],isnull([statCat_9],0) [statCat_9],isnull([statCat_10],0) [statCat_10],"
                    + "isnull([statCat_11],0) [statCat_11],isnull([statCat_12],0) [statCat_12],isnull([statCat_13],0) [statCat_13],isnull([statCat_14],0) [statCat_14],isnull([statCat_15],0) [statCat_15],isnull([statCat_16],0) [statCat_16],isnull([statCat_17],0) [statCat_17],isnull([statCat_18],0) [statCat_18],isnull([statCat_19],0) [statCat_19],isnull([statCat_20],0) [statCat_20],"
                    + "isnull([statCat_21],0) [statCat_21],isnull([statCat_22],0) [statCat_22],isnull([statCat_23],0) [statCat_23],isnull([statCat_24],0) [statCat_24],isnull([statCat_25],0) [statCat_25],isnull([statCat_26],0) [statCat_26],isnull([statCat_27],0) [statCat_27],isnull([statCat_28],0) [statCat_28],isnull([statCat_29],0) [statCat_29],isnull([statCat_30],0) [statCat_30],"
                    + "isnull([statCat_31],0) [statCat_31],isnull([statCat_32],0) [statCat_32],isnull([statCat_33],0) [statCat_33],isnull([statCat_34],0) [statCat_34],isnull([statCat_35],0) [statCat_35],isnull([statCat_36],0) [statCat_36],isnull([statCat_37],0) [statCat_37],isnull([statCat_38],0) [statCat_38],isnull([statCat_39],0) [statCat_39],isnull([statCat_40],0) [statCat_40],"
                    + "isnull([statCat_41],0) [statCat_41],isnull([statCat_42],0) [statCat_42],isnull([statCat_43],0) [statCat_43],isnull([statCat_44],0) [statCat_44],isnull([statCat_45],0) [statCat_45],isnull([statCat_46],0) [statCat_46],isnull([statCat_47],0) [statCat_47],isnull([statCat_48],0) [statCat_48],isnull([statCat_49],0) [statCat_49],isnull([statCat_50],0) [statCat_50],"
                    + "isnull([statCat_51],0) [statCat_51],isnull([statCat_52],0) [statCat_52],isnull([statCat_53],0) [statCat_53],isnull([statCat_54],0) [statCat_54],isnull([statCat_55],0) [statCat_55],isnull([statCat_56],0) [statCat_56],isnull([statCat_57],0) [statCat_57],isnull([statCat_58],0) [statCat_58],isnull([statCat_59],0) [statCat_59],isnull([statCat_60],0) [statCat_60],"
                    + "isnull([statCat_61],0) [statCat_61],isnull([statCat_62],0) [statCat_62],isnull([statCat_63],0) [statCat_63],isnull([statCat_64],0) [statCat_64],isnull([statCat_65],0) [statCat_65],isnull([statCat_66],0) [statCat_66],isnull([statCat_67],0) [statCat_67],isnull([statCat_68],0) [statCat_68],isnull([statCat_69],0) [statCat_69],isnull([statCat_70],0) [statCat_70],"
                    + "isnull([statCat_71],0) [statCat_71],isnull([statCat_72],0) [statCat_72],isnull([statCat_73],0) [statCat_73],isnull([statCat_74],0) [statCat_74],isnull([statCat_75],0) [statCat_75],isnull([statCat_76],0) [statCat_76],isnull([statCat_77],0) [statCat_77],isnull([statCat_78],0) [statCat_78],isnull([statCat_79],0) [statCat_79],isnull([statCat_80],0) [statCat_80],"
                    + "isnull([statCat_81],0) [statCat_81],isnull([statCat_82],0) [statCat_82],isnull([statCat_83],0) [statCat_83],isnull([statCat_84],0) [statCat_84],isnull([statCat_85],0) [statCat_85],isnull([statCat_86],0) [statCat_86],isnull([statCat_87],0) [statCat_87],isnull([statCat_88],0) [statCat_88],isnull([statCat_89],0) [statCat_89],isnull([statCat_90],0) [statCat_90],isnull([statCat_91],0) [statCat_91]"
                    + "from ( "
                    + "select  ps.playerId, ps.statValue val, 'statCat_' + cast(sc.id as varchar) statNum from PlayerStat ps "
                    + " join StatCategory sc on ps.statNum = sc.id ) as sourceTable "
                    + " PIVOT ("
                    + " sum(val) "
                    + " for statNum in (  "
                    + "[statCat_1],[statCat_2],[statCat_3],[statCat_4],[statCat_5],[statCat_6],[statCat_7],[statCat_8],[statCat_9],[statCat_10],"
                    + "[statCat_11],[statCat_12],[statCat_13],[statCat_14],[statCat_15],[statCat_16],[statCat_17],[statCat_18],[statCat_19],[statCat_20],"
                    + "[statCat_21],[statCat_22],[statCat_23],[statCat_24],[statCat_25],[statCat_26],[statCat_27],[statCat_28],[statCat_29],[statCat_30],"
                    + "[statCat_31],[statCat_32],[statCat_33],[statCat_34],[statCat_35],[statCat_36],[statCat_37],[statCat_38],[statCat_39],[statCat_40],"
                    + "[statCat_41],[statCat_42],[statCat_43],[statCat_44],[statCat_45],[statCat_46],[statCat_47],[statCat_48],[statCat_49],[statCat_50],"
                    + "[statCat_51],[statCat_52],[statCat_53],[statCat_54],[statCat_55],[statCat_56],[statCat_57],[statCat_58],[statCat_59],[statCat_60],"
                    + "[statCat_61],[statCat_62],[statCat_63],[statCat_64],[statCat_65],[statCat_66],[statCat_67],[statCat_68],[statCat_69],[statCat_70],"
                    + "[statCat_71],[statCat_72],[statCat_73],[statCat_74],[statCat_75],[statCat_76],[statCat_77],[statCat_78],[statCat_79],[statCat_80],"
                    + "[statCat_81],[statCat_82],[statCat_83],[statCat_84],[statCat_85],[statCat_86],[statCat_87],[statCat_88],[statCat_89],[statCat_90],"
                    + "[statCat_91]"
                    + " )) as pivotTable "
                    + " join Player p on p.playerId = pivotTable.playerId and p.position = 'QB' "
                    + " join PlayerBackground pb on pb.playerID = p.playerId "
                    + " join Team t on t.teamAbbre = p.teamAbbre "
                    ).ToList();
            


            return View(p);
        }

        public void Compare()
        {
            RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Compare(FormCollection f)
        {

            int player0, player1, player2, player3, player4;
            player0 = Convert.ToInt32(Request.Form["player0"]);
            player1 = Convert.ToInt32(Request.Form["player1"]);
            player2 = Convert.ToInt32(Request.Form["player2"]);
            player3 = Convert.ToInt32(Request.Form["player3"]);
            player4 = Convert.ToInt32(Request.Form["player4"]);

            string position;

            // pick up the first player entry and grab his position
            if (player0 != -1)
            {
                position = db.Players.Find(player0).position;
            }
            else
                if (player1 != -1)
                {
                    position = db.Players.Find(player1).position;
                }
                else
                    if (player2 != -1)
                    {
                        position = db.Players.Find(player2).position;
                    }
                    else
                        if (player3 != -1)
                        {
                            position = db.Players.Find(player3).position;
                        }
                        else
                            if (player4 != -1)
                            {
                                position = db.Players.Find(player4).position;
                            }
                            else // if no players then redirect
                                return RedirectToAction("Index");

            if(position == "QB")
            {
                /*
                var statAggs = from sw in db.WeekStats
                               where sw.season == 2014
                               group sw by sw.playerId into ps
                               select new //WeekStat
                               {
                                   playerId = ps.Key,
                                   statCat_1 = ps.Sum(x => x.statCat_1), statCat_2 = ps.Sum(x => x.statCat_2), statCat_3 = ps.Sum(x => x.statCat_3), statCat_4 = ps.Sum(x => x.statCat_4),
                                   statCat_5 = ps.Sum(x => x.statCat_5), statCat_6 = ps.Sum(x => x.statCat_6), statCat_7 = ps.Sum(x => x.statCat_7), statCat_8 = ps.Sum(x => x.statCat_8),
                                   statCat_9 = ps.Sum(x => x.statCat_9), statCat_10 = ps.Sum(x => x.statCat_10), statCat_11 = ps.Sum(x => x.statCat_11), statCat_12 = ps.Sum(x => x.statCat_12),
                                   statCat_13 = ps.Sum(x => x.statCat_13), statCat_14 = ps.Sum(x => x.statCat_14), statCat_15 = ps.Sum(x => x.statCat_15), statCat_16 = ps.Sum(x => x.statCat_16),
                                   statCat_17 = ps.Sum(x => x.statCat_17), statCat_18 = ps.Sum(x => x.statCat_18), statCat_19 = ps.Sum(x => x.statCat_19), statCat_30 = ps.Sum(x => x.statCat_30),
                                   statCat_31 = ps.Sum(x => x.statCat_31), statCat_32 = ps.Sum(x => x.statCat_32)
                                   
                               };
                var players = from p in db.Players
                              join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                              join t in db.Teams on p.teamAbbre equals t.teamAbbre
                              join s in statAggs on p.playerId equals s.playerId
                              where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                              orderby s.statCat_1 descending
                              select new PlayerIndexViewModel
                              {
                                  player = p,
                                  playerBackground = pb,
                                  team = t,
                                  statCat_1 = s.statCat_1, statCat_2 = s.statCat_2, statCat_3 = s.statCat_3, statCat_4 = s.statCat_4, statCat_5 = s.statCat_5,
                                  statCat_6 = s.statCat_6, statCat_7 = s.statCat_7, statCat_8 = s.statCat_8, statCat_9 = s.statCat_9, statCat_10 = s.statCat_10,
                                  statCat_11 = s.statCat_11, statCat_12 = s.statCat_12, statCat_13 = s.statCat_13, statCat_14 = s.statCat_14, statCat_15 = s.statCat_15,
                                  statCat_16 = s.statCat_16, statCat_17 = s.statCat_17, statCat_18 = s.statCat_18, statCat_19 = s.statCat_19, statCat_30 = s.statCat_30,
                                  statCat_31 = s.statCat_31, statCat_32 = s.statCat_32
                                  
                              };
                 */
                var weekStats = from p in db.Players
                                join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                                join w in db.WeekStats on p.playerId equals w.playerId 
                                join t in db.Teams on p.teamAbbre equals t.teamAbbre
                                
                                where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                                    && w.season == 2014
                                orderby w.weekNum, p.playerName
                                select new PlayerIndexViewModel
                                {
                                    player = p,
                                    playerBackground = pb,
                                    team = t,
                                    weekStat = w,
                                    statCat_1 = w.statCat_1,
                                    statCat_2 = w.statCat_2,
                                    statCat_3 = w.statCat_3,
                                    statCat_4 = w.statCat_4,
                                    statCat_5 = w.statCat_5,
                                    statCat_6 = w.statCat_6,
                                    statCat_7 = w.statCat_7,
                                    statCat_8 = w.statCat_8,
                                    statCat_9 = w.statCat_9,
                                    statCat_10 = w.statCat_10,
                                    statCat_11 = w.statCat_11,
                                    statCat_12 = w.statCat_12,
                                    statCat_13 = w.statCat_13,
                                    statCat_14 = w.statCat_14,
                                    statCat_15 = w.statCat_15,
                                    statCat_16 = w.statCat_16,
                                    statCat_17 = w.statCat_17,
                                    statCat_18 = w.statCat_18,
                                    statCat_19 = w.statCat_19,
                                    statCat_30 = w.statCat_30,
                                    statCat_31 = w.statCat_31,
                                    statCat_32 = w.statCat_32
                                    
                                };
                 
                var weekStats2 = from w in db.WeekStats
                                where (w.playerId == player0 || w.playerId == player1 || w.playerId == player2 || w.playerId == player3 || w.playerId == player4)
                                    && w.season == 2014
                                select new PlayerIndexViewModel
                                {
                                    player = w.player,
                                    
                                    team = w.player.Team,
                                    weekStat = w,
                                    statCat_5 = w.statCat_5

                                };
               

                return View(weekStats);
            }
            
            if (position == "RB" || position == "WR" || position == "TE")
            {
                var statAggs = from sw in db.WeekStats
                               where sw.season == 2014
                               group sw by sw.playerId into ps
                               select new //WeekStat
                               {
                                   playerId = ps.Key,   
                                   statCat_1 = ps.Sum(x => x.statCat_1),
                                   statCat_13 = ps.Sum(x => x.statCat_13), statCat_14 = ps.Sum(x => x.statCat_14), statCat_15 = ps.Sum(x => x.statCat_15), statCat_16 = ps.Sum(x => x.statCat_16),
                                   statCat_17 = ps.Sum(x => x.statCat_17), statCat_18 = ps.Sum(x => x.statCat_18), statCat_19 = ps.Sum(x => x.statCat_19), statCat_20 = ps.Sum(x => x.statCat_20),
                                   statCat_21 = ps.Sum(x => x.statCat_21), statCat_22 = ps.Sum(x => x.statCat_22), statCat_23 = ps.Sum(x => x.statCat_23), statCat_24 = ps.Sum(x => x.statCat_24),
                                   statCat_25 = ps.Sum(x => x.statCat_25), statCat_26 = ps.Sum(x => x.statCat_26), statCat_27 = ps.Sum(x => x.statCat_27), statCat_30 = ps.Sum(x => x.statCat_30),
                                   statCat_31 = ps.Sum(x => x.statCat_31), statCat_32 = ps.Sum(x => x.statCat_32)
                               };

                var players = from p in db.Players
                              join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                              join t in db.Teams on p.teamAbbre equals t.teamAbbre
                              join s in statAggs on p.playerId equals s.playerId
                              where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                              orderby s.statCat_1 descending
                              select new PlayerIndexViewModel
                              {
                                  player = p,
                                  playerBackground = pb,
                                  team = t,
                                  statCat_1 = s.statCat_1,
                                  statCat_13 = s.statCat_13, statCat_14 = s.statCat_14, statCat_15 = s.statCat_15, statCat_16 = s.statCat_16, statCat_17 = s.statCat_17, 
                                  statCat_18 = s.statCat_18, statCat_19 = s.statCat_19, statCat_20 = s.statCat_20, statCat_21 = s.statCat_21, statCat_22 = s.statCat_22, 
                                  statCat_23 = s.statCat_23, statCat_24 = s.statCat_24, statCat_25 = s.statCat_25, statCat_26 = s.statCat_26, statCat_27 = s.statCat_27,
                                  statCat_30 = s.statCat_30, statCat_31 = s.statCat_31, statCat_32 = s.statCat_32
                              };

                var weekStats = from p in db.Players
                                join t in db.Teams on p.teamAbbre equals t.teamAbbre
                                join w in db.WeekStats on p.playerId equals w.playerId
                                where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                                    && w.season == 2014
                                select new PlayerIndexViewModel
                                {
                                    player = p,
                                    team = t,
                                    weekStat = w
                                };
                return View(players);

            }

            if (position == "K")
            {
                var statAggs = from sw in db.WeekStats
                               where sw.season == 2014
                               group sw by sw.playerId into ps
                               select new //WeekStat
                               {
                                   playerId = ps.Key,
                                   statCat_1 = ps.Sum(x => x.statCat_1), statCat_33 = ps.Sum(x => x.statCat_33), statCat_34 = ps.Sum(x => x.statCat_34), statCat_35 = ps.Sum(x => x.statCat_35),
                                   statCat_36 = ps.Sum(x => x.statCat_36), statCat_37 = ps.Sum(x => x.statCat_37), statCat_38 = ps.Sum(x => x.statCat_38), statCat_39 = ps.Sum(x => x.statCat_39),
                                   statCat_40 = ps.Sum(x => x.statCat_40), statCat_41 = ps.Sum(x => x.statCat_41), statCat_42 = ps.Sum(x => x.statCat_42), statCat_43 = ps.Sum(x => x.statCat_43),
                                   statCat_44 = ps.Sum(x => x.statCat_44)
                               };

                var players = from p in db.Players
                              join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                              join t in db.Teams on p.teamAbbre equals t.teamAbbre
                              join s in statAggs on p.playerId equals s.playerId
                              where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                              orderby s.statCat_1 descending
                              select new PlayerIndexViewModel
                              {
                                  player = p,
                                  playerBackground = pb,
                                  team = t,
                                  statCat_1 = s.statCat_1, statCat_33 = s.statCat_33, statCat_34 = s.statCat_34, statCat_35 = s.statCat_35,
                                  statCat_36 = s.statCat_36, statCat_37 = s.statCat_37, statCat_38 = s.statCat_38, statCat_39 = s.statCat_39,
                                  statCat_40 = s.statCat_40, statCat_41 = s.statCat_41, statCat_42 = s.statCat_42, statCat_43 = s.statCat_43, statCat_44 = s.statCat_44
                              };

                var weekStats = from p in db.Players
                                join t in db.Teams on p.teamAbbre equals t.teamAbbre
                                join w in db.WeekStats on p.playerId equals w.playerId
                                where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                                    && w.season == 2014
                                select new PlayerIndexViewModel
                                {
                                    player = p,
                                    team = t,
                                    weekStat = w
                                };
                return View(players);
            }

            if (position == "DEF")
            {
                var statAggs = from sw in db.WeekStats
                               where sw.season == 2014
                               group sw by sw.playerId into ps
                               select new //WeekStat
                               {
                                   playerId = ps.Key,
                                   statCat_1 = ps.Sum(x => x.statCat_1),
                                   statCat_45 = ps.Sum(x => x.statCat_45), statCat_46 = ps.Sum(x => x.statCat_46), statCat_47 = ps.Sum(x => x.statCat_47), statCat_48 = ps.Sum(x => x.statCat_48),
                                   statCat_49 = ps.Sum(x => x.statCat_49), statCat_50 = ps.Sum(x => x.statCat_50), statCat_51 = ps.Sum(x => x.statCat_51), statCat_52 = ps.Sum(x => x.statCat_52),
                                   statCat_53 = ps.Sum(x => x.statCat_53), statCat_54 = ps.Sum(x => x.statCat_54), statCat_55 = ps.Sum(x => x.statCat_55), statCat_56 = ps.Sum(x => x.statCat_56),
                                   statCat_57 = ps.Sum(x => x.statCat_57), statCat_58 = ps.Sum(x => x.statCat_58), statCat_59 = ps.Sum(x => x.statCat_59), statCat_60 = ps.Sum(x => x.statCat_60),
                                   statCat_61 = ps.Sum(x => x.statCat_61), statCat_62 = ps.Sum(x => x.statCat_62), statCat_63 = ps.Sum(x => x.statCat_63), statCat_64 = ps.Sum(x => x.statCat_64),
                                   statCat_65 = ps.Sum(x => x.statCat_65), statCat_66 = ps.Sum(x => x.statCat_66), statCat_67 = ps.Sum(x => x.statCat_67), statCat_68 = ps.Sum(x => x.statCat_68),
                                   statCat_69 = ps.Sum(x => x.statCat_69)
                               };

                var players = from p in db.Players
                              join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                              join t in db.Teams on p.teamAbbre equals t.teamAbbre
                              join s in statAggs on p.playerId equals s.playerId
                              where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                              orderby s.statCat_1 descending
                              select new PlayerIndexViewModel
                              {
                                  player = p,
                                  playerBackground = pb,
                                  team = t,
                                  statCat_1 = s.statCat_1,
                                  statCat_45 = s.statCat_45, statCat_46 = s.statCat_46, statCat_47 = s.statCat_47, statCat_48 = s.statCat_48, statCat_49 = s.statCat_49,
                                  statCat_50 = s.statCat_50, statCat_51 = s.statCat_51, statCat_52 = s.statCat_52, statCat_53 = s.statCat_53, statCat_54 = s.statCat_54,
                                  statCat_55 = s.statCat_55, statCat_56 = s.statCat_56, statCat_57 = s.statCat_57, statCat_58 = s.statCat_58, statCat_59 = s.statCat_59,
                                  statCat_60 = s.statCat_60, statCat_61 = s.statCat_61, statCat_62 = s.statCat_62, statCat_63 = s.statCat_63, statCat_64 = s.statCat_64,
                                  statCat_65 = s.statCat_65, statCat_66 = s.statCat_66, statCat_67 = s.statCat_67, statCat_68 = s.statCat_68, statCat_69 = s.statCat_69
                              };


                return View(players);
            }

            // if we get to here then the position was invalid so redirect
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Compare2(FormCollection f)
        {
            
            
            int player0, player1, player2, player3, player4;
            player0 = Convert.ToInt32(Request.Form["player0"]);
            player1 = Convert.ToInt32(Request.Form["player1"]);
            player2 = Convert.ToInt32(Request.Form["player2"]);
            player3 = Convert.ToInt32(Request.Form["player3"]);
            player4 = Convert.ToInt32(Request.Form["player4"]);

            string position;

            // pick up the first player entry and grab his position
            if (player0 == -1 && player1 == -1 && player2 == -1 && player3 == -1 && player4 == -1)
                return RedirectToAction("Index");

            var statAggs = from sw in db.WeekStats
                           where sw.season == 2014
                           group sw by sw.playerId into ps
                           select new //WeekStat
                           {
                               playerId = ps.Key,
                               statCat_1 = ps.Sum(x => x.statCat_1), statCat_2 = ps.Sum(x => x.statCat_2), statCat_3 = ps.Sum(x => x.statCat_3), statCat_4 = ps.Sum(x => x.statCat_4),
                               statCat_5 = ps.Sum(x => x.statCat_5), statCat_6 = ps.Sum(x => x.statCat_6), statCat_7 = ps.Sum(x => x.statCat_7), statCat_8 = ps.Sum(x => x.statCat_8),
                               statCat_9 = ps.Sum(x => x.statCat_9), statCat_10 = ps.Sum(x => x.statCat_10), statCat_11 = ps.Sum(x => x.statCat_11), statCat_12 = ps.Sum(x => x.statCat_12),
                               statCat_13 = ps.Sum(x => x.statCat_13), statCat_14 = ps.Sum(x => x.statCat_14), statCat_15 = ps.Sum(x => x.statCat_15), statCat_16 = ps.Sum(x => x.statCat_16),
                               statCat_17 = ps.Sum(x => x.statCat_17), statCat_18 = ps.Sum(x => x.statCat_18), statCat_19 = ps.Sum(x => x.statCat_19), statCat_20 = ps.Sum(x => x.statCat_20),
                               statCat_21 = ps.Sum(x => x.statCat_21), statCat_22 = ps.Sum(x => x.statCat_22), statCat_23 = ps.Sum(x => x.statCat_23), statCat_24 = ps.Sum(x => x.statCat_24),
                               statCat_25 = ps.Sum(x => x.statCat_25), statCat_26 = ps.Sum(x => x.statCat_26), statCat_27 = ps.Sum(x => x.statCat_27), statCat_28 = ps.Sum(x => x.statCat_28),
                               statCat_29 = ps.Sum(x => x.statCat_29), statCat_30 = ps.Sum(x => x.statCat_30), statCat_31 = ps.Sum(x => x.statCat_31), statCat_32 = ps.Sum(x => x.statCat_32),
                               statCat_33 = ps.Sum(x => x.statCat_33), statCat_34 = ps.Sum(x => x.statCat_34), statCat_35 = ps.Sum(x => x.statCat_35), statCat_36 = ps.Sum(x => x.statCat_36),
                               statCat_37 = ps.Sum(x => x.statCat_37), statCat_38 = ps.Sum(x => x.statCat_38), statCat_39 = ps.Sum(x => x.statCat_39), statCat_40 = ps.Sum(x => x.statCat_40),   
                               statCat_41 = ps.Sum(x => x.statCat_41), statCat_42 = ps.Sum(x => x.statCat_42), statCat_43 = ps.Sum(x => x.statCat_43), statCat_44 = ps.Sum(x => x.statCat_44),
                               statCat_45 = ps.Sum(x => x.statCat_45), statCat_46 = ps.Sum(x => x.statCat_46), statCat_47 = ps.Sum(x => x.statCat_47), statCat_48 = ps.Sum(x => x.statCat_48),
                               statCat_49 = ps.Sum(x => x.statCat_49), statCat_50 = ps.Sum(x => x.statCat_50), statCat_51 = ps.Sum(x => x.statCat_51), statCat_52 = ps.Sum(x => x.statCat_52),
                               statCat_53 = ps.Sum(x => x.statCat_53), statCat_54 = ps.Sum(x => x.statCat_54), statCat_55 = ps.Sum(x => x.statCat_55), statCat_56 = ps.Sum(x => x.statCat_56),
                               statCat_57 = ps.Sum(x => x.statCat_57), statCat_58 = ps.Sum(x => x.statCat_58), statCat_59 = ps.Sum(x => x.statCat_59), statCat_60 = ps.Sum(x => x.statCat_60),
                               statCat_61 = ps.Sum(x => x.statCat_61), statCat_62 = ps.Sum(x => x.statCat_62), statCat_63 = ps.Sum(x => x.statCat_63), statCat_64 = ps.Sum(x => x.statCat_64),
                               statCat_65 = ps.Sum(x => x.statCat_65), statCat_66 = ps.Sum(x => x.statCat_66), statCat_67 = ps.Sum(x => x.statCat_67), statCat_68 = ps.Sum(x => x.statCat_68),
                               statCat_69 = ps.Sum(x => x.statCat_69), statCat_70 = ps.Sum(x => x.statCat_70), statCat_71 = ps.Sum(x => x.statCat_71), statCat_72 = ps.Sum(x => x.statCat_72),
                               statCat_73 = ps.Sum(x => x.statCat_73), statCat_74 = ps.Sum(x => x.statCat_74), statCat_75 = ps.Sum(x => x.statCat_75), statCat_76 = ps.Sum(x => x.statCat_76),
                               statCat_77 = ps.Sum(x => x.statCat_77), statCat_78 = ps.Sum(x => x.statCat_78), statCat_79 = ps.Sum(x => x.statCat_79), statCat_80 = ps.Sum(x => x.statCat_80),
                               statCat_81 = ps.Sum(x => x.statCat_81), statCat_82 = ps.Sum(x => x.statCat_82), statCat_83 = ps.Sum(x => x.statCat_83), statCat_84 = ps.Sum(x => x.statCat_84),
                               statCat_85 = ps.Sum(x => x.statCat_85), statCat_86 = ps.Sum(x => x.statCat_86), statCat_87 = ps.Sum(x => x.statCat_87), statCat_88 = ps.Sum(x => x.statCat_88),
                               statCat_89 = ps.Sum(x => x.statCat_89), statCat_90 = ps.Sum(x => x.statCat_90), statCat_91 = ps.Sum(x => x.statCat_91)
                           };

            var players = from p in db.Players
                          join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                          join t in db.Teams on p.teamAbbre equals t.teamAbbre
                          join s in statAggs on p.playerId equals s.playerId 
                          where (p.playerId == player0 || p.playerId == player1 || p.playerId == player2 || p.playerId == player3 || p.playerId == player4)
                          orderby s.statCat_1 descending
                          select new PlayerIndexViewModel
                          {
                              player = p,
                              playerBackground = pb,
                              team = t,
                              statCat_1 = s.statCat_1, statCat_2 = s.statCat_2, statCat_3 = s.statCat_3, statCat_4 = s.statCat_4, statCat_5 = s.statCat_5,
                              statCat_6 = s.statCat_6, statCat_7 = s.statCat_7, statCat_8 = s.statCat_8, statCat_9 = s.statCat_9,
                              statCat_10 = s.statCat_10, statCat_11 = s.statCat_11, statCat_12 = s.statCat_12, statCat_13 = s.statCat_13, statCat_14 = s.statCat_14,
                              statCat_15 = s.statCat_15, statCat_16 = s.statCat_16, statCat_17 = s.statCat_17, statCat_18 = s.statCat_18, statCat_19 = s.statCat_19,
                              statCat_20 = s.statCat_20, statCat_21 = s.statCat_21, statCat_22 = s.statCat_22, statCat_23 = s.statCat_23, statCat_24 = s.statCat_24,
                              statCat_25 = s.statCat_25, statCat_26 = s.statCat_26, statCat_27 = s.statCat_27, statCat_28 = s.statCat_28, statCat_29 = s.statCat_29,
                              statCat_30 = s.statCat_30, statCat_31 = s.statCat_31, statCat_32 = s.statCat_32, statCat_33 = s.statCat_33, statCat_34 = s.statCat_34,
                              statCat_35 = s.statCat_35, statCat_36 = s.statCat_36, statCat_37 = s.statCat_37, statCat_38 = s.statCat_38, statCat_39 = s.statCat_39,
                              statCat_40 = s.statCat_40, statCat_41 = s.statCat_41, statCat_42 = s.statCat_42, statCat_43 = s.statCat_43, statCat_44 = s.statCat_44,
                              statCat_45 = s.statCat_45, statCat_46 = s.statCat_46, statCat_47 = s.statCat_47, statCat_48 = s.statCat_48, statCat_49 = s.statCat_49,
                              statCat_50 = s.statCat_50, statCat_51 = s.statCat_51, statCat_52 = s.statCat_52, statCat_53 = s.statCat_53, statCat_54 = s.statCat_54,
                              statCat_55 = s.statCat_55, statCat_56 = s.statCat_56, statCat_57 = s.statCat_57, statCat_58 = s.statCat_58, statCat_59 = s.statCat_59,
                              statCat_60 = s.statCat_60, statCat_61 = s.statCat_61, statCat_62 = s.statCat_62, statCat_63 = s.statCat_63, statCat_64 = s.statCat_64,
                              statCat_65 = s.statCat_65, statCat_66 = s.statCat_66, statCat_67 = s.statCat_67, statCat_68 = s.statCat_68, statCat_69 = s.statCat_69,
                              statCat_70 = s.statCat_70, statCat_71 = s.statCat_71, statCat_72 = s.statCat_72, statCat_73 = s.statCat_73, statCat_74 = s.statCat_74,
                              statCat_75 = s.statCat_75, statCat_76 = s.statCat_76, statCat_77 = s.statCat_77, statCat_78 = s.statCat_78, statCat_79 = s.statCat_79,
                              statCat_80 = s.statCat_80, statCat_81 = s.statCat_81, statCat_82 = s.statCat_82, statCat_83 = s.statCat_83, statCat_84 = s.statCat_84,
                              statCat_85 = s.statCat_85, statCat_86 = s.statCat_86, statCat_87 = s.statCat_87, statCat_88 = s.statCat_88, statCat_89 = s.statCat_89,
                              statCat_90 = s.statCat_90, statCat_91 = s.statCat_91
                          };
            
  
            return View(players);
        }



        public ActionResult Index()
        {
            //List<PlayerIndexViewModel> players = new List<PlayerIndexViewModel>();

            var statAggs = from sw in db.WeekStats
                    where sw.season == 2014
                    group sw by sw.playerId into ps
                    select new //WeekStat
                    { 
                        playerId = ps.Key,
                        statCat_1 = ps.Sum(x => x.statCat_1),
                        statCat_5 = ps.Sum(x => x.statCat_5),
                        statCat_6 = ps.Sum(x => x.statCat_6),
                        statCat_14 = ps.Sum(x => x.statCat_14),
                        statCat_15 = ps.Sum(x => x.statCat_15),
                        statCat_21 = ps.Sum(x => x.statCat_21),
                        statCat_22 = ps.Sum(x => x.statCat_22),
                        statCat_35 = ps.Sum(x => x.statCat_35),
                        statCat_36 = ps.Sum(x => x.statCat_36),
                        statCat_37 = ps.Sum(x => x.statCat_37),
                        statCat_38 = ps.Sum(x => x.statCat_38),
                        statCat_39 = ps.Sum(x => x.statCat_39),
                        statCat_46 = ps.Sum(x => x.statCat_46),
                        statCat_47 = ps.Sum(x => x.statCat_47),
                        statCat_54 = ps.Sum(x => x.statCat_54)
 
                    };

            var players = from p in db.Players
                      join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                      join t in db.Teams on p.teamAbbre equals t.teamAbbre
                      join s in statAggs on p.playerId equals s.playerId //into ws
                      orderby s.statCat_1 descending
                      select new PlayerIndexViewModel
                      {
                          player = p,
                          playerBackground = pb,
                          team = t,
                          statCat_1  = s.statCat_1 ,
                          statCat_5  = s.statCat_5 ,
                          statCat_6  = s.statCat_6 ,
                          statCat_14 = s.statCat_14,
                          statCat_15 = s.statCat_15,
                          statCat_21 = s.statCat_21,
                          statCat_22 = s.statCat_22,
                          statCat_35 = s.statCat_35,
                          statCat_36 = s.statCat_36,
                          statCat_37 = s.statCat_37,
                          statCat_38 = s.statCat_38,
                          statCat_39 = s.statCat_39,
                          statCat_46 = s.statCat_46,
                          statCat_47 = s.statCat_47,
                          statCat_54 = s.statCat_54
                    };


            return View(players.ToList());
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            string nameStr = "";
            string posStr = "";
            
            if (!String.IsNullOrEmpty(Request.Form["name"]))
            {
                nameStr = Request.Form["name"].ToUpper();
            }
          
            if (!Request.Form["position"].Equals("ALL"))
            {
                posStr = Request.Form["position"];
            }
            var statAggs = from sw in db.WeekStats
                           where sw.season == 2014
                           group sw by sw.playerId into ps
                           select new //WeekStat
                           {
                               playerId = ps.Key,
                               statCat_1 = ps.Sum(x => x.statCat_1),
                               statCat_5 = ps.Sum(x => x.statCat_5),
                               statCat_6 = ps.Sum(x => x.statCat_6),
                               statCat_14 = ps.Sum(x => x.statCat_14),
                               statCat_15 = ps.Sum(x => x.statCat_15),
                               statCat_21 = ps.Sum(x => x.statCat_21),
                               statCat_22 = ps.Sum(x => x.statCat_22),
                               statCat_35 = ps.Sum(x => x.statCat_35),
                               statCat_36 = ps.Sum(x => x.statCat_36),
                               statCat_37 = ps.Sum(x => x.statCat_37),
                               statCat_38 = ps.Sum(x => x.statCat_38),
                               statCat_39 = ps.Sum(x => x.statCat_39),
                               statCat_46 = ps.Sum(x => x.statCat_46),
                               statCat_47 = ps.Sum(x => x.statCat_47),
                               statCat_54 = ps.Sum(x => x.statCat_54)

                           };

            var players = from p in db.Players
                          join pb in db.PlayerBackgrounds on p.playerId equals pb.playerID
                          join t in db.Teams on p.teamAbbre equals t.teamAbbre
                          join s in statAggs on p.playerId equals s.playerId 
                          where p.playerName.ToUpper().Contains(nameStr) && p.position.ToUpper().Contains(posStr)
                          orderby s.statCat_1 descending
                          select new PlayerIndexViewModel
                          {
                              player = p,
                              playerBackground = pb,
                              team = t,
                              statCat_1 = s.statCat_1,
                              statCat_5 = s.statCat_5,
                              statCat_6 = s.statCat_6,
                              statCat_14 = s.statCat_14,
                              statCat_15 = s.statCat_15,
                              statCat_21 = s.statCat_21,
                              statCat_22 = s.statCat_22,
                              statCat_35 = s.statCat_35,
                              statCat_36 = s.statCat_36,
                              statCat_37 = s.statCat_37,
                              statCat_38 = s.statCat_38,
                              statCat_39 = s.statCat_39,
                              statCat_46 = s.statCat_46,
                              statCat_47 = s.statCat_47,
                              statCat_54 = s.statCat_54
                          };
            
  
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
            return View();
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