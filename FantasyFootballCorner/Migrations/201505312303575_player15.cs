namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Team", "imageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Team", "imageURL");
        }
    }
}
