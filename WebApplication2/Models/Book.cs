using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Book
    {
        public int id { get; set; }
        [DisplayName("Başlık")]
        public string baslik { get; set; }
        [DisplayName("Açıklama")]
        public string aciklama { get; set; }
        [DisplayName("Kitap türü")]
        public string tur { get; set; }
        public DateTime yayintarihi { get; set; }
        [DisplayName("Fiyat")]
        public double fiyat { get; set; }
        [DisplayName("Stok Adeti")]
        public int stokadedi { get; set; }
        [DisplayName("Stokta mı?")]
        public bool discontinued { get; set; }
    }
}
