namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        playerId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        teamAbrev = c.String(),
                        position = c.String(),
                        seasonPts = c.Double(nullable: false),
                        seasonProjectedPts = c.Double(nullable: false),
                        weekPts = c.Double(nullable: false),
                        weekProjectedPts = c.Double(nullable: false),
                        playerStats_statId = c.Int(),
                    })
                .PrimaryKey(t => t.playerId)
                .ForeignKey("dbo.Stat", t => t.playerStats_statId)
                .Index(t => t.playerStats_statId);
            
            CreateTable(
                "dbo.Stat",
                c => new
                    {
                        statId = c.Int(nullable: false, identity: true),
                        statValue = c.Double(nullable: false),
                        playerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.statId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Player", new[] { "playerStats_statId" });
            DropForeignKey("dbo.Player", "playerStats_statId", "dbo.Stat");
            DropTable("dbo.Stat");
            DropTable("dbo.Player");
        }
    }
}
