namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "playerId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.Player", new[] { "id" });
            AddPrimaryKey("dbo.Player", "playerId");
            DropColumn("dbo.Player", "id");
            DropColumn("dbo.Player", "nflPid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Player", "nflPid", c => c.Int(nullable: false));
            AddColumn("dbo.Player", "id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Player", new[] { "playerId" });
            AddPrimaryKey("dbo.Player", "id");
            DropColumn("dbo.Player", "playerId");
        }
    }
}
