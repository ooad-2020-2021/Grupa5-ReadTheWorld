using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Writely.Models;

namespace Writely.Data
{
    public class WritelyDbContext : IdentityDbContext
    { 
        public WritelyDbContext (DbContextOptions<WritelyDbContext> options) : base(options)
        {
        }


        
        
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Rad> Rad { get; set; }
        public DbSet<Takmičenje> Takmičenje { get; set; }
        public DbSet<Recenzija> Recenzija { get; set; }
        public DbSet<PrijavaRada> PrijavaRada { get; set; }
        public DbSet<PrijavaKorisnika> PrijavaKorisnika { get; set; }
        public DbSet<TakmičenjeRad> TakmičenjeRad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Korisnik>().ToTable("Korisnik");
            modelBuilder.Entity<Rad>().ToTable("Rad");
            modelBuilder.Entity<Takmičenje>().ToTable("Takmičenje");
            modelBuilder.Entity<Recenzija>().ToTable("Recenzija");
            modelBuilder.Entity<PrijavaRada>().ToTable("PrijavaRada");
            modelBuilder.Entity<PrijavaKorisnika>().ToTable("PrijavaKorisnika");
            modelBuilder.Entity<TakmičenjeRad>().ToTable("TakmičenjeRad");
            base.OnModelCreating(modelBuilder);

        }


       
    }
}
