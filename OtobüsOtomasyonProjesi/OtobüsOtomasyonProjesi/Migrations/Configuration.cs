namespace OtobüsOtomasyonProjesi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OtobüsOtomasyonProjesi.OtobusContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "OtobüsOtomasyonProjesi.OtobusContext";
        }

        protected override void Seed(OtobüsOtomasyonProjesi.OtobusContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
