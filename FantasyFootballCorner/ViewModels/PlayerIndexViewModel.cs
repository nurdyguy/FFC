using FantasyFootballCorner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FantasyFootballCorner.ViewModels
{
    public class PlayerIndexViewModel
    {
        

        public Player player { get; set; }
        public PlayerBackground playerBackground { get; set; }
        public Team team { get; set; }
        public WeekStat weekStat { get; set; }

        /*
        public PlayerIndexViewModel() { }
        public PlayerIndexViewModel(Player p, PlayerBackground pb, Team t, WeekStat w)
        {
            player = p;
            playerBackground = pb;
            team = t;
            weekStat = w;
        }
        */
        //  QB stats  1-19, 30-32
        //  RB stats  1, 13-27, 30-32
        //  WR stats  1, 13-27, 30-32
        //  TE stats  1, 13-27, 30-32
        //  K stats   1, 33-44
        //  DEF stats 1, 45-69



        // GP
        [Display(Name = "GP")]
        public double statCat_1 { get; set; }
        [Display(Name = "Pass Att")]
        public double statCat_2 { get; set; }
        [Display(Name = "Pass Comp")]
        public double statCat_3 { get; set; }
        [Display(Name = "Pass Inc")]
        public double statCat_4 { get; set; }
        // QB stats
        [Display(Name = "Passing Yds")]
        public double statCat_5 { get; set; }
        [Display(Name = "Passing TD")]
        public double statCat_6 { get; set; }
        [Display(Name = "Pass Int")]
        public double statCat_7 { get; set; }
        [Display(Name = "Sacked")]
        public double statCat_8 { get; set; }
        [Display(Name = "300-399 Pass Yds")]
        public double statCat_9 { get; set; }
        [Display(Name = "400+ Pass yds")]
        public double statCat_10 { get; set; }
        [Display(Name = "40+ Pass TD")]
        public double statCat_11 { get; set; }
        [Display(Name = "50+ Pass Td")]
        public double statCat_12 { get; set; }
        // rushing stats
        [Display(Name = "Rush Att")]
        public double statCat_13 { get; set; }
        [Display(Name = "Rushing Yds")]
        public double statCat_14 { get; set; }
        [Display(Name = "Rushing TD")]
        public double statCat_15 { get; set; }
        [Display(Name = "40+ Rush TD")]
        public double statCat_16 { get; set; }
        [Display(Name = "50+ Rush TD")]
        public double statCat_17 { get; set; }
        [Display(Name = "100-199 Rush Yds")]
        public double statCat_18 { get; set; }
        [Display(Name = "200+ Rush Yds")]
        public double statCat_19 { get; set; }
        // receiver stats
        [Display(Name = "Receptions")]
        public double statCat_20 { get; set; }
        [Display(Name = "Rec Yds")]
        public double statCat_21 { get; set; }
        [Display(Name = "Rec TD")]
        public double statCat_22 { get; set; }
        [Display(Name = "40+ Rec TD")]
        public double statCat_23 { get; set; }
        [Display(Name = "50+ Rec TD")]
        public double statCat_24 { get; set; }
        [Display(Name = "100-199 Rec Yds")]
        public double statCat_25 { get; set; }
        [Display(Name = "200+ Rec Yds")]
        public double statCat_26 { get; set; }

        [Display(Name = "Ret Yds")]
        public double statCat_27 { get; set; }
        [Display(Name = "Ret TD")]
        public double statCat_28 { get; set; }
        [Display(Name = "Fumb TD")]
        public double statCat_29 { get; set; }
        [Display(Name = "Fumb Lost")]
        public double statCat_30 { get; set; }
        [Display(Name = "Fumb")]
        public double statCat_31 { get; set; }
        [Display(Name = "2PT Conv")]
        public double statCat_32 { get; set; }
        // kicker stats
        [Display(Name = "PAT Made")]
        public double statCat_33 { get; set; }
        [Display(Name = "PAT Missed")]
        public double statCat_34 { get; set; }
        [Display(Name = "FG 0-19")]
        public double statCat_35 { get; set; }
        [Display(Name = "FG 20-29")]
        public double statCat_36 { get; set; }
        [Display(Name = "FG 30-39")]
        public double statCat_37 { get; set; }
        [Display(Name = "FG 40-49")]
        public double statCat_38 { get; set; }
        [Display(Name = "FG 50+s")]
        public double statCat_39 { get; set; }
        [Display(Name = "Missed FG 0-19")]
        public double statCat_40 { get; set; }
        [Display(Name = "Missed FG 20-29")]
        public double statCat_41 { get; set; }
        [Display(Name = "Missed FG 30-39")]
        public double statCat_42 { get; set; }
        [Display(Name = "Missed FG 40-49")]
        public double statCat_43 { get; set; }
        [Display(Name = "Missed FG 50+s")]
        public double statCat_44 { get; set; }

        // Def stats
        [Display(Name = "Sack")]
        public double statCat_45 { get; set; }
 
        [Display(Name = "Ints")]
        public double statCat_46 { get; set; }
        [Display(Name = "Fumb Rec")]
        public double statCat_47 { get; set; }
        [Display(Name = "Fumb Forced")]
        public double statCat_48 { get; set; }
        [Display(Name = "Safety")]
        public double statCat_49 { get; set; }
        [Display(Name = "TD")]
        public double statCat_50 { get; set; }
        [Display(Name = "Block")]
        public double statCat_51 { get; set; }
        [Display(Name = "Return Yds")]
        public double statCat_52 { get; set; }
        [Display(Name = "Return TD")]
        public double statCat_53 { get; set; }
        [Display(Name = "Pts Allowed")]
        public double statCat_54 { get; set; }
        [Display(Name = "Pts Allowed 0")]
        public double statCat_55 { get; set; }
        [Display(Name = "Pts Allowed 1-6")]
        public double statCat_56 { get; set; }
        [Display(Name = "Pts Allowed 7-13")]
        public double statCat_57 { get; set; }
        [Display(Name = "Pts Allowed 14-20")]
        public double statCat_58 { get; set; }
        [Display(Name = "Pts Allowed 21-27")]
        public double statCat_59 { get; set; }
        [Display(Name = "Pts Allowed 28-34")]
        public double statCat_60 { get; set; }
        [Display(Name = "Pts Allowed 35+")]
        public double statCat_61 { get; set; }
        [Display(Name = "Yds Allowed")]
        public double statCat_62 { get; set; }
        [Display(Name = "Under 100 Yds Allowed")]
        public double statCat_63 { get; set; }
        [Display(Name = "100-199 Yds Allowed")]
        public double statCat_64 { get; set; }
        [Display(Name = "200-299 Yds Allowed")]
        public double statCat_65 { get; set; }
        [Display(Name = "300-399 Yds Allowed")]
        public double statCat_66 { get; set; }
        [Display(Name = "400-449 Yds Allowed")]
        public double statCat_67 { get; set; }
        [Display(Name = "450-499 Yds Allowed")]
        public double statCat_68 { get; set; }
        [Display(Name = "500+ Yds Allowed")]
        public double statCat_69 { get; set; }
        [Display(Name = "Tackles")]
        public double statCat_70 { get; set; }
        [Display(Name = "Assists")]
        public double statCat_71 { get; set; }
        [Display(Name = "Sack")]
        public double statCat_72 { get; set; }
        [Display(Name = "Int")]
        public double statCat_73 { get; set; }
        [Display(Name = "Frc Fumb")]
        public double statCat_74 { get; set; }
        [Display(Name = "Fumb Rec")]
        public double statCat_75 { get; set; }
        [Display(Name = "Int TD")]
        public double statCat_76 { get; set; }
        [Display(Name = "Fum TD")]
        public double statCat_77 { get; set; }
        [Display(Name = "Blk TD")]
        public double statCat_78 { get; set; }
        [Display(Name = "Blk")]
        public double statCat_79 { get; set; }
        [Display(Name = "Saf")]
        public double statCat_80 { get; set; }
        [Display(Name = "Pass Def")]
        public double statCat_81 { get; set; }
        [Display(Name = "Int Yds")]
        public double statCat_82 { get; set; }
        [Display(Name = "Fumb Yds")]
        public double statCat_83 { get; set; }
        [Display(Name = "TFL")]
        public double statCat_84 { get; set; }
        [Display(Name = "QB Hit")]
        public double statCat_85 { get; set; }
        [Display(Name = "Sack Yds")]
        public double statCat_86 { get; set; }
        [Display(Name = "10+ Tackles")]
        public double statCat_87 { get; set; }
        [Display(Name = "2+ Sacks")]
        public double statCat_88 { get; set; }
        [Display(Name = "3+ Pass Def")]
        public double statCat_89 { get; set; }
        [Display(Name = "50+ Yd Int TD")]
        public double statCat_90 { get; set; }
        [Display(Name = "50+ Yd Fumb Ret TD")]
        public double statCat_91 { get; set; }
        
        /*          moved to WeekStat model         */
        
        
         
         
    }
}