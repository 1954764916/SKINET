using Core.Entities;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKINET.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext( DbContextOptions<StoreContext> options) : base(options)
        {


        }
        public DbSet<Product> Products { get; set; }
    }
}
