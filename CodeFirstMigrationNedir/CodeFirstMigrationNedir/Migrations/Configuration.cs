namespace CodeFirstMigrationNedir.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstMigrationNedir.Models.EtkinlikArsivModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CodeFirstMigrationNedir.Models.EtkinlikArsivModel context)
        {
            context.Etkinlikler.AddOrUpdate(x => x.ID, new Models.Etkinlik() { ID = 1, Isim = "Yapay Zeka Kulübü Yarışma", Tarih = DateTime.Now, Durum = true });

        }
    }
}
