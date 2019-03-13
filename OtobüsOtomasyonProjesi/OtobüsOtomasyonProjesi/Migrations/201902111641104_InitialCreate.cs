namespace OtobüsOtomasyonProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BiletAls",
                c => new
                    {
                        BiletAlID = c.Int(nullable: false, identity: true),
                        OtobusID = c.Int(nullable: false),
                        KalkisSehriID = c.Int(nullable: false),
                        VarisSehriID = c.Int(nullable: false),
                        KoltukNo = c.Int(nullable: false),
                        YolcuAdiSoyadi = c.String(),
                        Cinsiyet = c.Int(nullable: false),
                        Sehir_SehirID = c.Int(),
                    })
                .PrimaryKey(t => t.BiletAlID)
                .ForeignKey("dbo.Otobus", t => t.OtobusID, cascadeDelete: true)
                .ForeignKey("dbo.Sehirs", t => t.Sehir_SehirID)
                .Index(t => t.OtobusID)
                .Index(t => t.Sehir_SehirID);
            
            CreateTable(
                "dbo.Otobus",
                c => new
                    {
                        OtobusID = c.Int(nullable: false, identity: true),
                        Plaka = c.String(),
                        OtobusModel = c.String(),
                        OtobusResim = c.Binary(),
                    })
                .PrimaryKey(t => t.OtobusID);
            
            CreateTable(
                "dbo.Sehirs",
                c => new
                    {
                        SehirID = c.Int(nullable: false, identity: true),
                        SehirNo = c.Int(nullable: false),
                        SehirAdi = c.String(),
                    })
                .PrimaryKey(t => t.SehirID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BiletAls", "Sehir_SehirID", "dbo.Sehirs");
            DropForeignKey("dbo.BiletAls", "OtobusID", "dbo.Otobus");
            DropIndex("dbo.BiletAls", new[] { "Sehir_SehirID" });
            DropIndex("dbo.BiletAls", new[] { "OtobusID" });
            DropTable("dbo.Sehirs");
            DropTable("dbo.Otobus");
            DropTable("dbo.BiletAls");
        }
    }
}
