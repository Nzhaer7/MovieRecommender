using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommender
{
    internal class MovieDbContext:DbContext
    {
        public DbSet<Movies> Movies { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Types> Types { get; set; }
    }
}
