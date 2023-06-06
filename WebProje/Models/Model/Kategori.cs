using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje.Models.Model
{
    [Table("Kategori")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [Required, StringLength(100, ErrorMessage ="100 Karakter Olmalıdır")]
        [DisplayName("Kategori Adı")]
        public string KategoriAd { get; set; }
        [DisplayName("Kategori Açıklaması")]
        public string Aciklama { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}