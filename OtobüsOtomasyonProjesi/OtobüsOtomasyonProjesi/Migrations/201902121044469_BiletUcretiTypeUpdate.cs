namespace OtobüsOtomasyonProjesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BiletUcretiTypeUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BiletAls", "BiletUcreti", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BiletAls", "BiletUcreti", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
