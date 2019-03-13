namespace OtobüsOtomasyonProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AracTakip : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AracTakips",
                c => new
                    {
                        AracTakipID = c.Int(nullable: false, identity: true),
                        AracPlaka = c.String(),
                        AracToplamTutar = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AracTakipID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AracTakips");
        }
    }
}
