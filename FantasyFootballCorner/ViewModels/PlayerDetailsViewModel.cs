using FantasyFootballCorner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FantasyFootballCorner.ViewModels
{
    public class PlayerDetailsViewModel
    {

        public Player player { get; set; }
        public PlayerBackground playerBackground { get; set; }
        public PlayerStat playerStat { get; set; }

        /*
        public PlayerDetailsViewModel(Player p)
        {
            player = p;

            playerBackground = from pb in 
            playerBackground = pl
            //playerStat = 
        }
        */
        
    }
}