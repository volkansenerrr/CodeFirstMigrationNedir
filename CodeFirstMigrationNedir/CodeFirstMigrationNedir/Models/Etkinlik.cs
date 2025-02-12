using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstMigrationNedir.Models
{
    public class Etkinlik
    {
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Isim { get; set; }
        public DateTime Tarih { get; set; }
        [StringLength(maximumLength:50)]
        public string Resim { get; set; }
        public bool Durum { get; set; }
        public ICollection<Soru> Sorular { get; set; }
    }
}