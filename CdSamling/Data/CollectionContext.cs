using CdSamling.Models;
using Microsoft.EntityFrameworkCore;

namespace CdSamling.Data
{
    public class CollectionContext : DbContext 
    {
        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options) {
        }

        public DbSet<Collection> Collection { get; set; }

        public DbSet<Artist> Artist { get; set; }   

        public DbSet<Rent> Rent { get; set; }

    }
}
