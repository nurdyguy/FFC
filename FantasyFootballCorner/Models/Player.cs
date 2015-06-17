using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyFootballCorner.Models
{
    public class Player
    {
        

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int playerId { get; set; }

        [Display(Name = "Player Name")]
        public string playerName { get; set; }

        [Display(Name = "Team Abbreviation")]
        [ForeignKey("teamAbbre")]
        public Team Team { get; set; }
        public string teamAbbre { get; set; }

        [Display(Name = "Position")]
        public string position { get; set; }

        


        //public virtual Stat playerStats { get; set; }
    }
}