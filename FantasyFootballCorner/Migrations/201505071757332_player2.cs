namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Player", "playerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Player", "playerId", c => c.Int(nullable: false, identity: true));
        }
    }
}
