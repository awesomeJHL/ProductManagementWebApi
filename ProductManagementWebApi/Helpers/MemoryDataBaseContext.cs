using Microsoft.EntityFrameworkCore;
using ProductManagementWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagementWebApi.Helpers
{
    public class MemoryDataBaseContext : DbContext
    {
        public MemoryDataBaseContext(DbContextOptions<MemoryDataBaseContext> options) : base(options)
        {
        }

        public DbSet<CommonCode> CommonCode { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
