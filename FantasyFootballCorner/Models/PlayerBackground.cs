using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyFootballCorner.Models
{
    public class PlayerBackground
    {
        
        public int id { get; set; }


        public virtual Player player {get; set;}
        public virtual int playerID { get; set; }

        
        public int height { get; set; }
        public int weight { get; set; }
        public DateTime dob { get; set; }
        public string college { get; set; }

        //public string draftYear { get; set; }
        //public string draftPos { get; set; }
        public string imageUrl { get; set; }

        public int years { get; set; }
    }
}