using Microsoft.EntityFrameworkCore;
using Pabeda.Projem.Entities.Concrete;


namespace Pabeda.Projem.DataAccess.Concrete.EntityFramework
{
    public class ProjemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; DataBase=ProjemContext; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OgretmenOgrenci>()
          .HasKey(bc => new { bc.OgretmenId, bc.OgrenciId });
            modelBuilder.Entity<OgretmenOgrenci>()
                .HasOne(bc => bc.Ogretmen)
                .WithMany(b => b.OgretmenOgrencis)
                .HasForeignKey(bc => bc.OgretmenId);
            modelBuilder.Entity<OgretmenOgrenci>()
                .HasOne(bc => bc.Ogrenci)
                .WithMany(c => c.OgretmenOgrencis)
                .HasForeignKey(bc => bc.OgrenciId);
        }

        public DbSet<Ogrenci> Ogrencis { get; set; }

        public DbSet<Okul> Okuls { get; set; }

        public DbSet<Ogretmen> Ogretmens { get; set; }

        public DbSet<OgretmenOgrenci> OgretmenOgrencis { get; set; }
    }
}
