using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Writely.Data
{
    public class WritelyContext : DbContext
    { 
        public WritelyContext (DbContextOptions<WritelyContext> options) : base(options)
        {
        }


        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<Žanr> Žanr { get; set; }
        public DbSet<StatusPrijave> StatusPrijave { get; set; }
        public DbSet<Titula> Titula { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Rad> Rad { get; set; }
        public DbSet<Takmičenje> Takmičenje { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<Prijava> Prijava { get; set; }
        public DbSet<PrijavaRada> PrijavaRada { get; set; }
        public DbSet<PrijavaKorisnika> PrijavaKorisnika { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategorija>().ToTable("Kategorija");
            modelBuilder.Entity<Žanr>().ToTable("Žanr");
            modelBuilder.Entity<StatusPrijave>().ToTable("StatusPrijave");
            modelBuilder.Entity<Titula>().ToTable("Titula");
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Rad>().ToTable("Rad");
            modelBuilder.Entity<Takmičenje>().ToTable("Takmičenje");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Entity<PrijavaRada>().ToTable("PrijavaRada");
            modelBuilder.Entity<PrijavaKorisnika>().ToTable("PrijavaKorisnika");
            modelBuilder.Entity<Prijava>().ToTable("Prijava");

        }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}
