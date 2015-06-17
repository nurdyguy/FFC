using FantasyFootballCorner.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;


namespace FantasyFootballCorner.Context
{

    public class FFCContext: DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerBackground> PlayerBackgrounds { get; set; }
        public DbSet<PlayerStat> PlayerStats { get; set; }
        public DbSet<StatCategory> StatCategories { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<WeekStat> WeekStats { get; set; }


        //public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        

    }
}