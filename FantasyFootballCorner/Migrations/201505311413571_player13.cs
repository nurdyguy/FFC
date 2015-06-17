namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Team", "conference", c => c.String());
            AddColumn("dbo.Team", "division", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Team", "division");
            DropColumn("dbo.Team", "conference");
        }
    }
}
