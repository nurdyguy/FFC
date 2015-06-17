namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player23 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "playerName", c => c.String());
            AddColumn("dbo.Team", "teamName", c => c.String());
            AddColumn("dbo.StatCategory", "statName", c => c.String());
            DropColumn("dbo.Player", "name");
            DropColumn("dbo.Team", "name");
            DropColumn("dbo.StatCategory", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StatCategory", "name", c => c.String());
            AddColumn("dbo.Team", "name", c => c.String());
            AddColumn("dbo.Player", "name", c => c.String());
            DropColumn("dbo.StatCategory", "statName");
            DropColumn("dbo.Team", "teamName");
            DropColumn("dbo.Player", "playerName");
        }
    }
}
