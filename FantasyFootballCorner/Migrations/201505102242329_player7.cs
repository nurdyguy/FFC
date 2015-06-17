namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerBackground", "playerID", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerBackground", "draftPos", c => c.String());
            AddColumn("dbo.PlayerBackground", "imageUrl", c => c.String());
            AddForeignKey("dbo.PlayerBackground", "playerID", "dbo.Player", "playerId", cascadeDelete: true);
            CreateIndex("dbo.PlayerBackground", "playerID");
            DropColumn("dbo.PlayerBackground", "picUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerBackground", "picUrl", c => c.String());
            DropIndex("dbo.PlayerBackground", new[] { "playerID" });
            DropForeignKey("dbo.PlayerBackground", "playerID", "dbo.Player");
            DropColumn("dbo.PlayerBackground", "imageUrl");
            DropColumn("dbo.PlayerBackground", "draftPos");
            DropColumn("dbo.PlayerBackground", "playerID");
        }
    }
}
