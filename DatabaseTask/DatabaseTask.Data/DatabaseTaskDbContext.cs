using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Absense> Absences { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<ChildGroupHistory> ChildGroupsHistory { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Menu> Menu { get; set; }
        //public DbSet<Queue> Queue { get; set; }
    }
}
