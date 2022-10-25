using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DbSet<Product> Products { get; set; }

    }
}
