using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstMigrationNedir.Models
{
    public class Soru
    {
        public int ID { get; set; }

        public int Etkinlik_ID { get; set; }

        [ForeignKey("Etkinlik_ID")]
        public virtual Etkinlik Etkinlik { get; set; }

        [Required]
        [StringLength(maximumLength:250)]
        public string Isim { get; set; }

        public string Metin { get; set; }
    }
}