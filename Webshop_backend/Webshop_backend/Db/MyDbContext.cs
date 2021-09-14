using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Webshop_backend.Db.Klase;

namespace Webshop_backend.Db
{
    public class MyDbContext : DbContext
    {
        public DbSet<Proizvod> proizvodi { get; set; }
        public DbSet<Narudzba> narudzbe { get; set; }

        public DbSet<Zaposlenik> zaposlenici { get; set; }
        

        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proizvod>().ToTable("Proizvod");
            modelBuilder.Entity<Proizvod>().HasKey(p => p.IdProizvod);

            modelBuilder.Entity<Narudzba>().ToTable("Narudzba");
            modelBuilder.Entity<Narudzba>().HasKey(n => n.IdNarudzba);
            modelBuilder.Entity<Narudzba>().HasOne(n => n.Klijent).WithMany().HasForeignKey(n => n.IdKlijent); //jedan klijent ima više narudžbi
            modelBuilder.Entity<Narudzba>().HasMany(n => n.Detalji).WithOne().HasForeignKey(n => n.IdNarudzba); //ako ide prvo has many onda sljedeci with one i obrnuto

            modelBuilder.Entity<Klijent>().ToTable("Klijent");
            modelBuilder.Entity<Klijent>().HasKey(k => k.IdKlijent);
            modelBuilder.Entity<Klijent>().HasOne(k => k.Osoba).WithMany().HasForeignKey(k => k.IdOsoba);

            modelBuilder.Entity<Osoba>().HasKey(o => o.IdOsoba);

            modelBuilder.Entity<Zaposlenik>().ToTable("Zaposlenik");
            modelBuilder.Entity<Zaposlenik>().HasKey(z => z.IdZaposlenik);

            modelBuilder.Entity<NarudzbaDetalj>().ToTable("NarudzbaDetalj");
            modelBuilder.Entity<NarudzbaDetalj>().HasKey(n => n.IdNarudzbaDetalj);
            modelBuilder.Entity<NarudzbaDetalj>().HasOne(n => n.Proizvod).WithMany().HasForeignKey(n => n.IdProizvod);
            
               
            

        } 
    }
  
}
