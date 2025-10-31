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
       public DbSet<Gallery> Galleries { get; set; }
       public DbSet<Artist> Artists { get; set; }
       public DbSet<Artwork> Artworks { get; set; }
       public DbSet<Exhibition> Exhibitions { get; set; }
       public DbSet<ExhibitionArtwork> ExhibitionArtworks { get; set; }

        //public DbSet<Queue> Queue { get; set; }
    }
}
