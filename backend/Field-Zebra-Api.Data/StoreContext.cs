using System;
using Field.Zebra.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Field_Zebra_Api.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {}

        public DbSet<Item> Items { get; set; }
    }
}
