using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eVet.Models;

namespace eVet.Data 
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<VeterinerService> VeterinerServis {get; set;}
        public DbSet<AsiKayitlari> AsiKayitlar {get; set;}
        public DbSet<Pet> Hayvanlar {get; set;}
        public DbSet<Randevular> Randevular {get;set;}
        public DbSet<Service> Servisler {get; set;}
        public DbSet<Veteriner> Veterinerler {get; set;}
        public DbSet<VetMusaitlik> Musaitlik {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<VeterinerService>()
            .HasKey(vs=>new {vs.VeterinerId, vs.ServiceId});
        }
    }
}