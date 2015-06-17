namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player14 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Player", "teamAbbre", c => c.String(maxLength: 128));
            AddForeignKey("dbo.Player", "teamAbbre", "dbo.Team", "teamAbbre");
            CreateIndex("dbo.Player", "teamAbbre");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Player", new[] { "teamAbbre" });
            DropForeignKey("dbo.Player", "teamAbbre", "dbo.Team");
            AlterColumn("dbo.Player", "teamAbbre", c => c.String());
        }
    }
}
