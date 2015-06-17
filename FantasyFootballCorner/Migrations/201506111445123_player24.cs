namespace FantasyFootballCorner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class player24 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeekStat",
                c => new
                    {
                        season = c.Int(nullable: false),
                        weekNum = c.Int(nullable: false),
                        playerId = c.Int(nullable: false),
                        statCat_1 = c.Double(nullable: false),
                        statCat_2 = c.Double(nullable: false),
                        statCat_3 = c.Double(nullable: false),
                        statCat_4 = c.Double(nullable: false),
                        statCat_5 = c.Double(nullable: false),
                        statCat_6 = c.Double(nullable: false),
                        statCat_7 = c.Double(nullable: false),
                        statCat_8 = c.Double(nullable: false),
                        statCat_9 = c.Double(nullable: false),
                        statCat_10 = c.Double(nullable: false),
                        statCat_11 = c.Double(nullable: false),
                        statCat_12 = c.Double(nullable: false),
                        statCat_13 = c.Double(nullable: false),
                        statCat_14 = c.Double(nullable: false),
                        statCat_15 = c.Double(nullable: false),
                        statCat_16 = c.Double(nullable: false),
                        statCat_17 = c.Double(nullable: false),
                        statCat_18 = c.Double(nullable: false),
                        statCat_19 = c.Double(nullable: false),
                        statCat_20 = c.Double(nullable: false),
                        statCat_21 = c.Double(nullable: false),
                        statCat_22 = c.Double(nullable: false),
                        statCat_23 = c.Double(nullable: false),
                        statCat_24 = c.Double(nullable: false),
                        statCat_25 = c.Double(nullable: false),
                        statCat_26 = c.Double(nullable: false),
                        statCat_27 = c.Double(nullable: false),
                        statCat_28 = c.Double(nullable: false),
                        statCat_29 = c.Double(nullable: false),
                        statCat_30 = c.Double(nullable: false),
                        statCat_31 = c.Double(nullable: false),
                        statCat_32 = c.Double(nullable: false),
                        statCat_33 = c.Double(nullable: false),
                        statCat_34 = c.Double(nullable: false),
                        statCat_35 = c.Double(nullable: false),
                        statCat_36 = c.Double(nullable: false),
                        statCat_37 = c.Double(nullable: false),
                        statCat_38 = c.Double(nullable: false),
                        statCat_39 = c.Double(nullable: false),
                        statCat_40 = c.Double(nullable: false),
                        statCat_41 = c.Double(nullable: false),
                        statCat_42 = c.Double(nullable: false),
                        statCat_43 = c.Double(nullable: false),
                        statCat_44 = c.Double(nullable: false),
                        statCat_45 = c.Double(nullable: false),
                        statCat_46 = c.Double(nullable: false),
                        statCat_47 = c.Double(nullable: false),
                        statCat_48 = c.Double(nullable: false),
                        statCat_49 = c.Double(nullable: false),
                        statCat_50 = c.Double(nullable: false),
                        statCat_51 = c.Double(nullable: false),
                        statCat_52 = c.Double(nullable: false),
                        statCat_53 = c.Double(nullable: false),
                        statCat_54 = c.Double(nullable: false),
                        statCat_55 = c.Double(nullable: false),
                        statCat_56 = c.Double(nullable: false),
                        statCat_57 = c.Double(nullable: false),
                        statCat_58 = c.Double(nullable: false),
                        statCat_59 = c.Double(nullable: false),
                        statCat_60 = c.Double(nullable: false),
                        statCat_61 = c.Double(nullable: false),
                        statCat_62 = c.Double(nullable: false),
                        statCat_63 = c.Double(nullable: false),
                        statCat_64 = c.Double(nullable: false),
                        statCat_65 = c.Double(nullable: false),
                        statCat_66 = c.Double(nullable: false),
                        statCat_67 = c.Double(nullable: false),
                        statCat_68 = c.Double(nullable: false),
                        statCat_69 = c.Double(nullable: false),
                        statCat_70 = c.Double(nullable: false),
                        statCat_71 = c.Double(nullable: false),
                        statCat_72 = c.Double(nullable: false),
                        statCat_73 = c.Double(nullable: false),
                        statCat_74 = c.Double(nullable: false),
                        statCat_75 = c.Double(nullable: false),
                        statCat_76 = c.Double(nullable: false),
                        statCat_77 = c.Double(nullable: false),
                        statCat_78 = c.Double(nullable: false),
                        statCat_79 = c.Double(nullable: false),
                        statCat_80 = c.Double(nullable: false),
                        statCat_81 = c.Double(nullable: false),
                        statCat_82 = c.Double(nullable: false),
                        statCat_83 = c.Double(nullable: false),
                        statCat_84 = c.Double(nullable: false),
                        statCat_85 = c.Double(nullable: false),
                        statCat_86 = c.Double(nullable: false),
                        statCat_87 = c.Double(nullable: false),
                        statCat_88 = c.Double(nullable: false),
                        statCat_89 = c.Double(nullable: false),
                        statCat_90 = c.Double(nullable: false),
                        statCat_91 = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new {t.playerId, t.season, t.weekNum })
                .ForeignKey("dbo.Player", t => t.playerId, cascadeDelete: true)
                .Index(t => t.playerId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.WeekStat", new[] { "playerId" });
            DropForeignKey("dbo.WeekStat", "playerId", "dbo.Player");
            DropTable("dbo.WeekStat");
        }
    }
}
