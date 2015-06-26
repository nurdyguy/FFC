namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class p : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerBackground",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        playerID = c.Int(nullable: false),
                        height = c.Int(nullable: false),
                        weight = c.Int(nullable: false),
                        dob = c.DateTime(nullable: false),
                        college = c.String(),
                        imageUrl = c.String(),
                        years = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Player", t => t.playerID, cascadeDelete: true)
                .Index(t => t.playerID);
            
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        playerId = c.Int(nullable: false),
                        playerName = c.String(),
                        teamAbbre = c.String(maxLength: 128),
                        position = c.String(),
                    })
                .PrimaryKey(t => t.playerId)
                .ForeignKey("dbo.Team", t => t.teamAbbre)
                .Index(t => t.teamAbbre);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        teamAbbre = c.String(nullable: false, maxLength: 128),
                        geoName = c.String(),
                        teamName = c.String(),
                        conference = c.String(),
                        division = c.String(),
                        imageURL = c.String(),
                    })
                .PrimaryKey(t => t.teamAbbre);
            
            CreateTable(
                "dbo.PlayerStat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        statId = c.Int(nullable: false),
                        playerId = c.Int(nullable: false),
                        season = c.Int(nullable: false),
                        weekNum = c.Int(nullable: false),
                        statAmt = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Player", t => t.playerId, cascadeDelete: true)
                .ForeignKey("dbo.StatCategory", t => t.statId, cascadeDelete: true)
                .Index(t => t.statId)
                .Index(t => t.playerId);
            
            CreateTable(
                "dbo.StatCategory",
                c => new
                    {
                        statId = c.Int(nullable: false),
                        abbr = c.String(),
                        statName = c.String(),
                        shortName = c.String(),
                        isQBStat = c.Boolean(nullable: false),
                        isRBStat = c.Boolean(nullable: false),
                        isWRStat = c.Boolean(nullable: false),
                        isTEStat = c.Boolean(nullable: false),
                        isKStat = c.Boolean(nullable: false),
                        isDEFStat = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.statId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerStat", "statId", "dbo.StatCategory");
            DropForeignKey("dbo.PlayerStat", "playerId", "dbo.Player");
            DropForeignKey("dbo.PlayerBackground", "playerID", "dbo.Player");
            DropForeignKey("dbo.Player", "teamAbbre", "dbo.Team");
            DropIndex("dbo.PlayerStat", new[] { "playerId" });
            DropIndex("dbo.PlayerStat", new[] { "statId" });
            DropIndex("dbo.Player", new[] { "teamAbbre" });
            DropIndex("dbo.PlayerBackground", new[] { "playerID" });
            DropTable("dbo.StatCategory");
            DropTable("dbo.PlayerStat");
            DropTable("dbo.Team");
            DropTable("dbo.Player");
            DropTable("dbo.PlayerBackground");
        }
    }
}
