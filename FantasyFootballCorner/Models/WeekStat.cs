using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyFootballCorner.Models
{
    public class WeekStat
    {
        [Key]
        [ForeignKey("playerId")]
        [Column(Order = 1)]
        public virtual Player player { get; set; }
        public int playerId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int season { get; set; }

        [Key]
        [Column(Order = 3)]
        public int weekNum { get; set; }

        [Display(Name = "Games Played")]
        public double statCat_1 { get; set; }

        [Display(Name = "Pass Attempts")]
        public double statCat_2 { get; set; }

        [Display(Name = "Pass Completions")]
        public double statCat_3 { get; set; }

        [Display(Name = "Pass Incomplete")]
        public double statCat_4 { get; set; }

        [Display(Name = "Passing Yards")]
        public double statCat_5 { get; set; }

        [Display(Name = "Passing TD")]
        public double statCat_6 { get; set; }

        [Display(Name = "Passing Interceptions")]
        public double statCat_7 { get; set; }

        [Display(Name = "Sacked")]
        public double statCat_8 { get; set; }

        [Display(Name = "300-399 Passing Yards")]
        public double statCat_9 { get; set; }

        [Display(Name = "400+ Passing Yards")]
        public double statCat_10 { get; set; }

        [Display(Name = "40+ Yard Passing TD")]
        public double statCat_11 { get; set; }

        [Display(Name = "50+ Yard Passing TD")]
        public double statCat_12 { get; set; }

        [Display(Name = "Rushing Attempts")]
        public double statCat_13 { get; set; }

        [Display(Name = "Rushing Yards")]
        public double statCat_14 { get; set; }

        [Display(Name = "Rushing TD")]
        public double statCat_15 { get; set; }

        [Display(Name = "40+ Yard Rushing TD")]
        public double statCat_16 { get; set; }

        [Display(Name = "50+ Yard Rushing TD")]
        public double statCat_17 { get; set; }

        [Display(Name = "100-199 Rushing Yards")]
        public double statCat_18 { get; set; }

        [Display(Name = "200+ Rushing Yards")]
        public double statCat_19 { get; set; }

        [Display(Name = "Receptions")]
        public double statCat_20 { get; set; }

        [Display(Name = "Receiving Yards")]
        public double statCat_21 { get; set; }

        [Display(Name = "Receiving TD")]
        public double statCat_22 { get; set; }

        [Display(Name = "40+ Reception TD")]
        public double statCat_23 { get; set; }

        [Display(Name = "50+ Reception TD")]
        public double statCat_24 { get; set; }

        [Display(Name = "100-199 Receiving Yards")]
        public double statCat_25 { get; set; }

        [Display(Name = "200+ Receiving Yards")]
        public double statCat_26 { get; set; }

        [Display(Name = "Return Yards")]
        public double statCat_27 { get; set; }

        [Display(Name = "Return TD")]
        public double statCat_28 { get; set; }

        [Display(Name = "Fumble TD")]
        public double statCat_29 { get; set; }

        [Display(Name = "Fumble Lost")]
        public double statCat_30 { get; set; }

        [Display(Name = "Fumbles")]
        public double statCat_31 { get; set; }

        [Display(Name = "2-pt Conversion")]
        public double statCat_32 { get; set; }

        [Display(Name = "Point After Made")]
        public double statCat_33 { get; set; }
        
        [Display(Name = "Point After Missed")]
        public double statCat_34 { get; set; }
        
        [Display(Name = "Field Goal Made 0-19yds")]
        public double statCat_35 { get; set; }

        [Display(Name = "Field Goal Made 20-29yds")]
        public double statCat_36 { get; set; }

        [Display(Name = "Field Goal Made 30-39yds")]
        public double statCat_37 { get; set; }

        [Display(Name = "Field Goal Made 40-49yds")]
        public double statCat_38 { get; set; }

        [Display(Name = "Field Goal Made 50+yds")]
        public double statCat_39 { get; set; }

        [Display(Name = "Field Goal Missed 0-19yds")]
        public double statCat_40 { get; set; }

        [Display(Name = "Field Goal Missed 20-29yds")]
        public double statCat_41 { get; set; }

        [Display(Name = "Field Goal Missed 30-39yds")]
        public double statCat_42 { get; set; }

        [Display(Name = "Field Goal Missed 40-49yds")]
        public double statCat_43 { get; set; }

        [Display(Name = "Field Goal Missed 50+yds")]
        public double statCat_44 { get; set; }
        
        [Display(Name = "Sacks Made")]
        public double statCat_45 { get; set; }
        
        [Display(Name = "Interceptions Made")]
        public double statCat_46 { get; set; }
        
        [Display(Name = "Fumbles Recovered")]
        public double statCat_47 { get; set; }
        
        [Display(Name = "Fumbles Forced")]
        public double statCat_48 { get; set; }
        
        [Display(Name = "Safeties")]
        public double statCat_49 { get; set; }
        
        [Display(Name = "Defense TD")]
        public double statCat_50 { get; set; }
        
        [Display(Name = "Blocked Kick")]
        public double statCat_51 { get; set; }
        
        [Display(Name = "Kick Return Yards")]
        public double statCat_52 { get; set; }
        
        [Display(Name = "Kick Return TD")]
        public double statCat_53 { get; set; }
        
        [Display(Name = "Points Allowed")]
        public double statCat_54 { get; set; }

        [Display(Name = "Points Allowed 0")]
        public double statCat_55 { get; set; }

        [Display(Name = "Points Allowed 1-6")]
        public double statCat_56 { get; set; }

        [Display(Name = "Points Allowed 7-13")]
        public double statCat_57 { get; set; }

        [Display(Name = "Points Allowed 14-20")]
        public double statCat_58 { get; set; }

        [Display(Name = "Points Allowed 21-27")]
        public double statCat_59 { get; set; }

        [Display(Name = "Points Allowed 28-34")]
        public double statCat_60 { get; set; }

        [Display(Name = "Points Allowed 35+")]
        public double statCat_61 { get; set; }
        
        [Display(Name = "Total Yards Allowed")]
        public double statCat_62 { get; set; }
        
        [Display(Name = "Yards Allowed <100")]
        public double statCat_63 { get; set; }

        [Display(Name = "Yards Allowed 100-199")]
        public double statCat_64 { get; set; }

        [Display(Name = "Yards Allowed 200-299")]
        public double statCat_65 { get; set; }

        [Display(Name = "Yards Allowed 300-399")]
        public double statCat_66 { get; set; }

        [Display(Name = "Yards Allowed 400-449")]
        public double statCat_67 { get; set; }

        [Display(Name = "Yards Allowed 450-499")]
        public double statCat_68 { get; set; }

        [Display(Name = "Yards Allowed 500+")]
        public double statCat_69 { get; set; }
        
        [Display(Name = "Tackle")]
        public double statCat_70 { get; set; }
        
        [Display(Name = "Assist")]
        public double statCat_71 { get; set; }
        
        [Display(Name = "Sack Made")]
        public double statCat_72 { get; set; }
        
        [Display(Name = "Intercepted On")]
        public double statCat_73 { get; set; }
        
        [Display(Name = "Force Fumble (non Def)")]
        public double statCat_74 { get; set; }
        
        [Display(Name = "Fumble Recovery (non Def)")]
        public double statCat_75 { get; set; }
        
        [Display(Name = "Interception TD (non Def)")]
        public double statCat_76 { get; set; }
        
        [Display(Name = "Fumble TD (non Def)")]
        public double statCat_77 { get; set; }
        
        [Display(Name = "Blocked Kick for TD (non Def)")]
        public double statCat_78 { get; set; }
        
        [Display(Name = "Blocked Kick (non Def)")]
        public double statCat_79 { get; set; }
        
        [Display(Name = "Safeties (non Def)")]
        public double statCat_80 { get; set; }
        
        [Display(Name = "Passes Defended (non Def)")]
        public double statCat_81 { get; set; }
        
        [Display(Name = "Interception Yards (non Def)")]
        public double statCat_82 { get; set; }
        
        [Display(Name = "Fumble Yards (non Def)")]
        public double statCat_83 { get; set; }
        
        [Display(Name = "TFL")]
        public double statCat_84 { get; set; }
        
        [Display(Name = "QB Hit")]
        public double statCat_85 { get; set; }
        
        [Display(Name = "Sack Yards")]
        public double statCat_86 { get; set; }
        
        [Display(Name = "10+ Tackles")]
        public double statCat_87 { get; set; }
        
        [Display(Name = "2+ Sacks")]
        public double statCat_88 { get; set; }
        
        [Display(Name = "3+ Passes Defended")]
        public double statCat_89 { get; set; }
        
        [Display(Name = "50+ Yard Interception for TD")]
        public double statCat_90 { get; set; }
        
        [Display(Name = "50+ Yard Fumble Recovery for TD")]
        public double statCat_91 { get; set; }



        
        




    }
}