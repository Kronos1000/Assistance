using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Data
{
    public class BackendContext : DbContext
    {
        public BackendContext (DbContextOptions<BackendContext> options)
            : base(options)
        {
        }

        public DbSet<Backend.Models.Vendor> Vendor { get; set; } = default!;

        public DbSet<Backend.Models.Food>? Food { get; set; }

        public DbSet<Backend.Models.Furniture>? Furniture { get; set; }

        public DbSet<Backend.Models.Vehicles>? Vehicles { get; set; }
    }
}
