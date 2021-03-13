using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DrinkAndGo.DataAccess
{
    public class AppContext:DbContext
    {
        public AppContext(DbContextOptions<AppContext>options):base(options)
        {
        }
        public DbSet<Drink>Drinks { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}
