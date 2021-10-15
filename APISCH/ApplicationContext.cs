using APISCH.ConfigureEntities;
using Microsoft.EntityFrameworkCore;
using APISCH.Entities;

namespace APISCH
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(
                "Data Source=(local);Initial Catalog=APISCHDB;user id=sa;password=sa123sa;MultipleActiveResultSets=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ImportExportConfigure());
            modelBuilder.ApplyConfiguration(new PersonConfigure());
            modelBuilder.ApplyConfiguration(new CompanyConfigure());
        }

        public virtual DbSet<ImportExport> ImportExports { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Company> Companies { get; set; }

    }
}