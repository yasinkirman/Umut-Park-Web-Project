using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProje.Models.Model
{
    [Table("Slider")]
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        [DisplayName("Slider Başlık"), Required, StringLength(100, ErrorMessage = "100 Karatker Olmalıdır")]
        public string Baslik { get; set; }
        [DisplayName("Slider Açıklama"), StringLength(250, ErrorMessage = "250 Karatker Olmalıdır")]
        public string Aciklama { get; set; }
        [DisplayName("Slider Resim"), Required, StringLength(250, ErrorMessage = "250 Karatker Olmalıdır")]
        public string ResimURL { get; set; }
    }
}