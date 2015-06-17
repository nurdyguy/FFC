namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player18 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StatCategory", "id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StatCategory", "id", c => c.Int(nullable: false));
        }
    }
}
