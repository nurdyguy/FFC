namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "imageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Player", "imageUrl");
        }
    }
}
