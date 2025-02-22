using System.Collections.Generic;
using System.Reflection.Emit;
using OptionalUseCase.Models;
using Microsoft.EntityFrameworkCore;

namespace OptionalUseCase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet for Users that repesents the "travelers" table
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Users>(entity =>
            {
                // Map the entity with the "travelers" table
                entity.ToTable("travelers");

                // Set the primary key
                entity.HasKey(e => e.Id);

                // Map attributes to the columns of the DB
                entity.Property(e => e.Id).HasColumnName("userid").ValueGeneratedOnAdd();
                entity.Property(e => e.UserName).HasColumnName("UserName");
                entity.Property(e => e.Password).HasColumnName("Password");
                entity.Property(e => e.Email).HasColumnName("Email");
                entity.Property(e => e.FirstName).HasColumnName("FirstName");
                entity.Property(e => e.LastName).HasColumnName("LastName");
                entity.Property(e => e.Country).HasColumnName("OriginCountry");
            });
        }
    }
}

