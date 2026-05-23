using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracTakip.Models
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Arac> Araclar { get; set; } // Arac tablosunu temsil eden DbSet (Arac sınıfı için bir veritabanı tablosu oluşturur.) 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // veri tabanı bağlantı yolu.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=|DataDirectory|Db.mdf;").UseLazyLoadingProxies();
        }


    }
}
