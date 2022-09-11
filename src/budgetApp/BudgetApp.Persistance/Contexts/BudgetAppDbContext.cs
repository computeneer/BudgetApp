using BudgetApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BudgetApp.Persistance.Contexts
{
    public class BudgetAppDbContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public DbSet<CompanyType> CompanyTypes { get; set; }

        public BudgetAppDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyType>(companyType =>
            {
                companyType.ToTable("CompanyTypes").HasKey(key => key.Id);
                companyType.Property(a => a.Name).HasColumnName("Name");
                companyType.Property(a => a.Description).HasColumnName("Description");
            });



            CompanyType[] companyTypes =
            {
                new(Guid.NewGuid(), "ECommerce", "Commerce over Internet"),
                new(Guid.NewGuid(), "Mechanics", "Car and motorcycle repair"),
                new(Guid.NewGuid(), "Science", "Scientific research")
            };
            modelBuilder.Entity<CompanyType>().HasData(companyTypes);

        }
    }
}
