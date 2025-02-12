using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstMigrationNedir.Models
{
    public partial class EtkinlikArsivModel : DbContext
    {
        public EtkinlikArsivModel()
            : base("name=EtkinlikArsivModel")
        {
        }
        public DbSet<Etkinlik> Etkinlikler { get; set; }
        public DbSet<Soru> Sorular { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
