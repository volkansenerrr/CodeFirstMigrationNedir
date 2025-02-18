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

        [Required(ErrorMessage ="Bu alan zorunludur")]
        [StringLength(maximumLength:50, ErrorMessage ="Etkinlik adı en fazla 50 karakter olmalıdır")]
        public string Isim { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Tarih { get; set; }

        [StringLength(maximumLength: 50)]
        public string Resim { get; set; }
        public bool Durum { get; set; }
        public virtual ICollection<Soru> Sorular { get; set; }
    }
}