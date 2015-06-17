namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Player", "seasonPts");
            DropColumn("dbo.Player", "seasonProjectedPts");
            DropColumn("dbo.Player", "weekPts");
            DropColumn("dbo.Player", "weekProjectedPts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Player", "weekProjectedPts", c => c.Double(nullable: false));
            AddColumn("dbo.Player", "weekPts", c => c.Double(nullable: false));
            AddColumn("dbo.Player", "seasonProjectedPts", c => c.Double(nullable: false));
            AddColumn("dbo.Player", "seasonPts", c => c.Double(nullable: false));
        }
    }
}
