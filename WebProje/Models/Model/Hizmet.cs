using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje.Models.Model
{
    [Table("Hizmet")]
    public class Hizmet
    {
        [Key]
        public int HizmetId { get; set; }
        [Required, StringLength(100, ErrorMessage = "100 Karakter Olmalıdır")]
        [DisplayName("Hizmet Başlık")]
        public string Baslik { get; set; }
        [DisplayName("Hizmet Açıklaması")]
        public string Aciklama { get; set; }
        [DisplayName("Hizmet fotoğrafı")]
        public string ResimURL { get; set; }
    }
}