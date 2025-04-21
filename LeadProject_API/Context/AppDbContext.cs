using LeadManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using static LeadProject_API.Enum.EnumLead;

namespace LeadManagementAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<LeadBO> Leads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=Marcofsa;Database=LeadProjectDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// SEED INICIAL PARA O BANCO
            //modelBuilder.Entity<LeadBO>().HasData(
            //    new LeadBO { Id = 1, Name = "Bill", Email = "bill@example.com", Phone = "123456789", Suburb = "Yanderra 2574", Category = "Painters", Description = "Need to paint 2 aluminum windows and a sliding glass door", Price = 62.00m, Status = LeadStatus.Invited },
            //    new LeadBO { Id = 2, Name = "Craig", Email = "craig@example.com", Phone = "987654321", Suburb = "Woolooware 2230", Category = "Interior Painters", Description = "Internal walls 3 colours", Price = 49.00m, Status = LeadStatus.Invited }
            //);
        }
    }
}
