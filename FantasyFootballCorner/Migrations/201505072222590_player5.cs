namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player5 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Player", "imageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Player", "imageUrl", c => c.String());
        }
    }
}
