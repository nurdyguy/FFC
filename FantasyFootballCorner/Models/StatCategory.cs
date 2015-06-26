using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FantasyFootballCorner.Models
{
    public class StatCategory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int statId { get; set; }
        
        public string abbr { get; set; }
        public string statName { get; set; }
        public string shortName { get; set; }
        
        // booleans determining which positions use it
        public bool isQBStat { get; set; }
        public bool isRBStat { get; set; }
        public bool isWRStat { get; set; }
        public bool isTEStat { get; set; }
        public bool isKStat { get; set; }
        public bool isDEFStat { get; set; }
        
    }
}