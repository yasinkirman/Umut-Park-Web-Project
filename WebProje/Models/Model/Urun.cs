using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje.Models.Model
{
    [Table("Urun")]
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        [Required, StringLength(100, ErrorMessage = "100 Karakter Olmalıdır")]
        [DisplayName("Ürün Adı")]
        public string UrunAd { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Aciklama { get; set; }
        [DisplayName("Ürün Fotoğrafı")]
        public string ResimUrl { get; set; }
        public int? KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}