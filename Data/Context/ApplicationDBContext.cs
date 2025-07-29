using AltınFiyatWeb__SignalR_.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace AltınFiyatWeb__SignalR_.Data.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
       : base(dbContextOptions)
        {
        }

        public DbSet<PropertySuffixList> PropertySuffixLists { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
