using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FantasyFootballCorner.Models
{
    public class PlayerStat
    {
        [Key]
        public int id { get; set; }

        public int statNum {get; set;}

        public double statValue { get; set; }

        
        
        [ForeignKey("playerId")]
        public virtual Player player { get; set; }
        public int playerId { get; set; }

        public int season { get; set; }
        public int weekNum { get; set; }

        


        /*
        public double GP { get; set; }
          
        // passing stats
        public double passAtt     { get; set; }
        public double passComp     { get; set; }
        public double passInc     { get; set; }
        public double passYds     { get; set; }
        public double passTd     { get; set; }
        public double passInt     { get; set; }
        public double sacked     { get; set; }
        public double passYd300     { get; set; }
        public double passYd400 { get; set; }
        public double passTd40    { get; set; }
        public double passTd50    { get; set; }

        // rushing stats
        public double rushAtt    { get; set; }
        public double rushYds    { get; set; }
        public double rushTd    { get; set; }
        public double rushTd40    { get; set; }
        public double rushTd50    { get; set; }
        public double rushYd100    { get; set; }
        public double rushYd200    { get; set; }

        // reception stats
        public double recep      { get; set; }
        public double recepYds    { get; set; }
        public double recepTds    { get; set; }
        public double recepTd40    { get; set; }
        public double recepTd50    { get; set; }
        public double recepYd100    { get; set; }
        public double recepYd200    { get; set; }

        //  
        public double kickRetTd    { get; set; }
        public double fumbRetTd    { get; set; }
        public double fumbLost    { get; set; }
        public double fumb    { get; set; }
        public double twoPtConv    { get; set; }
        public double PATmade    { get; set; }
        public double fg0    { get; set; }
        public double fg20    { get; set; }
        public double fg30    { get; set; }
        public double fg40    { get; set; }
        public double fg50    { get; set; }
        public double fgMiss0 { get; set; }
        public double fgMiss20 { get; set; }
        public double fgMiss30 { get; set; }
        public double fgMiss40 { get; set; }
        public double fgMiss50 { get; set; }

        public double sacks { get; set; }
        public double ints { get; set; }
        public double fumbRec { get; set; }
        public double fumbForc { get; set; }
        public double saft { get; set; }
        public double td { get; set; }
        public double blockKick { get; set; }
        public double kickRetYds { get; set; }
        public double kickRetTd_2 { get; set; }

        public double ptsAllowed { get; set; }
        public double ptsAllow0 { get; set; }
        public double ptsAllow6 { get; set; }
        public double ptsAllow13 { get; set; }
        public double ptsAllow20 { get; set; }
        public double ptsAllow27 { get; set; }
        public double ptsAllow34 { get; set; }
        public double ptsAllow35 { get; set; }

        public double yesAllow99 { get; set; }
        public double yesAllow199 { get; set; }
        public double yesAllow299 { get; set; }
        public double yesAllow399 { get; set; }
        public double yesAllow499 { get; set; }
        public double yesAllow500 { get; set; }

        public double tack { get; set; }
        public double tackAst { get; set; }
        public double sack { get; set; }
        public double inter { get; set; }
        public double frcFumb { get; set; }
        public double recFumb { get; set; }
        public double intTd { get; set; }
        public double fumbTd { get; set; }
        public double blkKickTd { get; set; }
        public double saf { get; set; }
        public double passDef { get; set; }
        public double intYds { get; set; }
        public double tackForLoss { get; set; }
        public double qbHit { get; set; }
        public double sackYds { get; set; }
        public double tack10 { get; set; }
        public double sack2 { get; set; }
        public double passDef3 { get; set; }
        public double intYdTd50 { get; set; }
        public double fumbYdTd50 { get; set; }

        */
    }
}
