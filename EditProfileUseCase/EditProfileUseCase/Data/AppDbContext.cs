using System.Collections.Generic;
using System.Reflection.Emit;
using EditProfileUseCase.Models;
using Microsoft.EntityFrameworkCore;

namespace EditProfileUseCase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Users>(entity =>
            {
                entity.ToTable("travelers");

                entity.HasKey(e => e.Id);
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
