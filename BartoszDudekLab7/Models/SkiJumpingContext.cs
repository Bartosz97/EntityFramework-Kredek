using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BartoszDudekLab7.Models
{
    public class SkiJumpingContext : DbContext
    {
        public SkiJumpingContext(DbContextOptions<SkiJumpingContext> options) : base(options)
        {
            
        }

        public DbSet<Jumper> Jumpers { get; set; }
        public DbSet<Country> Countries { get; set; }

    }  
}
