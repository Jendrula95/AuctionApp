using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AuctionApp.Models;

namespace AuctionApp.Data
{
    public class AuctionAppContext : DbContext
    {
        public AuctionAppContext (DbContextOptions<AuctionAppContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
        public DbSet<Negotiation> Negotiation { get; set; } = default!;
    }
}
