namespace OtobüsOtomasyonProjesi
{
    using OtobüsOtomasyonProjesi.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class OtobusContext : DbContext
    {
        // Your context has been configured to use a 'OtobusContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'OtobüsOtomasyonProjesi.OtobusContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'OtobusContext' 
        // connection string in the application configuration file.
        public OtobusContext()
            : base("name=OtobusContext")
        {
        }

        public virtual DbSet<Sehir> Sehirler { get; set; }
        public virtual DbSet<BiletAl> BiletleriAl { get; set; }
        public virtual DbSet<Otobus> Otobusler { get; set; }
        public virtual DbSet<AracTakip> AraclariTakip { get; set; }

    }
}