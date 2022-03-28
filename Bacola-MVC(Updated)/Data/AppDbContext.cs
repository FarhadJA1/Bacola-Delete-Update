using Bacola_MVC_Updated_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bacola_MVC_Updated_.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<DiscountProducts> DiscountProducts { get; set; }
        public DbSet<Settings> Settings { get; set; }


    }
}
