using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakip.Models
{
    public static class Veriler
    {
        public static AppDbContext Context = new AppDbContext(); // Veritabanı bağlantısı için gerekli context sınıfını oluşturur.

        // Static Constructor (Başlangıçta bir kez çalışır)
        static Veriler()
        {
            Context.Database.Migrate(); // Yapısal değişiklikleri otomatik olarak uygular (Code-First Migration)

            if (Context.Araclar.Count() == 0) // Eğer veritabanında araç yoksa örnek veri ekler
                OrnekVeri();
        }

        private static void OrnekVeri() // Örnek araçları ekleyen metod
        {
            Context.Araclar.Add(new Arac()
            {
                Marka = "Fiat",
                Model = "Egea 1.6 M.Jet 130 HP DCT",
                ÜretimTarihi = new DateTime(2022, 4, 22),
                Fiyat = 544_900
            });

            Context.Araclar.Add(new Arac()
            {
                Marka = "Ford",
                Model = "Focus Titanium 1.5L EcoBlue (Dizel)",
                ÜretimTarihi = new DateTime(2022, 1, 17),
                Fiyat = 584_900
            });

            Context.SaveChanges(); // Değişiklikleri veritabanına kaydeder
        }
    }

}
