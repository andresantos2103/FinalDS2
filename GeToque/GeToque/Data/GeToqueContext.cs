using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GeToque.Models;

namespace GeToque.Data
{
    public class GeToqueContext : DbContext
    {
        public GeToqueContext (DbContextOptions<GeToqueContext> options)
            : base(options)
        {
        }

        public DbSet<GeToque.Models.Roupa> Roupa { get; set; }

        public DbSet<GeToque.Models.Confeccao> Confeccao { get; set; }
    }
}
