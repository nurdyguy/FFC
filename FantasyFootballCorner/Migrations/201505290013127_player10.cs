namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player10 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PlayerBackground", "draftYear");
            DropColumn("dbo.PlayerBackground", "draftPos");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerBackground", "draftPos", c => c.String());
            AddColumn("dbo.PlayerBackground", "draftYear", c => c.String());
        }
    }
}
