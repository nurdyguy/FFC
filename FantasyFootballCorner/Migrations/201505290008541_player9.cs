namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlayerBackground", "years", c => c.Int(nullable: false));
            DropColumn("dbo.PlayerBackground", "highSchool");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerBackground", "highSchool", c => c.String());
            DropColumn("dbo.PlayerBackground", "years");
        }
    }
}
