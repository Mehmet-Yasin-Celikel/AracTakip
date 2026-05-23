using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakip.Models
{
    [Table("Araclar")] // Veritabanında oluşturulacak tablonun adı "Araclar" olacak
    public class Arac
    {
        public int Id { get; set; } // Birincil Anahtar (Primary Key) olarak tanımlanır.
        public required string Marka { get; set; } // Aracın markasını tutan özellik.
        public required string Model { get; set; } // Aracın modelini tutan özellik.
        public DateTime ÜretimTarihi { get; set; } // Aracın üretim tarihini tutar
        public decimal Fiyat { get; set; } // Aracın fiyatını tutar
    }


    /*
     
     Not : Marka ve Model propertylerinin altı çizili olmasının nedeni bu özelliklerin null değer alması halinde potansiyel bir hata alabileceği uyarısıdır. 
           Potansiyel hataları birden fazla yolla çözebiliriz.

     1. public string? Marka { get; set; } -- Bu sayede derleyici, bu özelliklerin boş olabileceğini bilir(Nullable)
     2. public required string Marka { get; set; } -- Bu kullanımda derleyiciye bu alanların zorunlu alan olduğunu bildiririz. Özelliklere değer girilmediğinde hata alınacaktır.
     .
     .
     .

     */

}
