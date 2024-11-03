using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using VisitorRegistrationSystem.Web.Data.Models;

namespace VisitorRegistrationSystem.Web.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options)
        : base(options){}

        public DbSet<Visitor> Visitors {get; set;} = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
             modelBuilder.Entity<Visitor>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Phone).IsRequired();
                entity.Property(e => e.RegistrationDate)
                    .IsRequired()
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });
        }
    }
}