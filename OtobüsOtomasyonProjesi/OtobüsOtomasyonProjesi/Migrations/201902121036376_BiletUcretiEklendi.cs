namespace OtobüsOtomasyonProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BiletUcretiEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BiletAls", "BiletUcreti", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BiletAls", "BiletUcreti");
        }
    }
}
