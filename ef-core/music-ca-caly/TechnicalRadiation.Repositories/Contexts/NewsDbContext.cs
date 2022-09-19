using Microsoft.EntityFrameworkCore;
using TechnicalRadiation.Repositories.Entities;

namespace TechnicalRadiation.Repositories.Contexts
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Manual configuration of relations (many-to-many)
            modelBuilder.Entity<AlbumArtist>()
                .HasKey(x => new { x.AlbumId, x.ArtistId });
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumArtist> AlbumArtists { get; set; }
        public DbSet<NewsItem> NewsItems{ get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}