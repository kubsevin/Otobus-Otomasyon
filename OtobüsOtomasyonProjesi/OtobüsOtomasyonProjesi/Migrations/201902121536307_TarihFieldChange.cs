namespace OtobüsOtomasyonProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TarihFieldChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AracTakips", "AracHareketTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AracTakips", "AracHareketTarihi");
        }
    }
}
