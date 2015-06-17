namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerStat",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        statNum = c.Int(nullable: false),
                        statValue = c.Double(nullable: false),
                        playerId = c.Int(nullable: false),
                        season = c.Int(nullable: false),
                        weekNum = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Player", t => t.playerId, cascadeDelete: true)
                .Index(t => t.playerId);
            
            DropTable("dbo.NflStat");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NflStat",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        statNum = c.Int(nullable: false),
                        statValue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            DropIndex("dbo.PlayerStat", new[] { "playerId" });
            DropForeignKey("dbo.PlayerStat", "playerId", "dbo.Player");
            DropTable("dbo.PlayerStat");
        }
    }
}
