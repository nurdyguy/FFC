namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PlayerBackground", "draftYear", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PlayerBackground", "draftYear", c => c.Int(nullable: false));
        }
    }
}
