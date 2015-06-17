using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FantasyFootballCorner.Models
{
    public class Team
    {
        [Key]
        public string teamAbbre { get; set; }
        [Display(Name = "Team Location")]
        public string geoName { get; set; }
        [Display(Name = "Team Name")]
        public string teamName { get; set; }
        [Display(Name = "Conference")]
        public string conference { get; set; }
        [Display(Name = "Division")]
        public string division { get; set; }
        public string imageURL { get; set; }
    }
}