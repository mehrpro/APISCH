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
                "Data Source=(local);Initial Catalog=SchoolServiceDB;user id=sa;password=sa123sa;MultipleActiveResultSets=True;");

        }

        public virtual DbSet<ImportExport> ImportExports { get; set; }

    }
}