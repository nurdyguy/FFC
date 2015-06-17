namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Player", "teamAbbre", c => c.String());
            DropColumn("dbo.Player", "teamAbrev");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Player", "teamAbrev", c => c.String());
            DropColumn("dbo.Player", "teamAbbre");
        }
    }
}
