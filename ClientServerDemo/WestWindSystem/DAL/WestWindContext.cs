using Microsoft.EntityFrameworkCore;
using WestWindSystem.Entities;

namespace WestWindSystem.DAL
{
    public class WestWindContext: DbContext
    {
        public WestWindContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BuildVersion> BuildVersions { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
