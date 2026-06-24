using GymSystemManagement.Configurations;
using GymSystemManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace GymSystemManagement.DbContexts
{
    public class GymDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GymManagementSystem;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfiguration());
        }
        
       public DbSet<Plan> Plans { get; set; }
    }
}
