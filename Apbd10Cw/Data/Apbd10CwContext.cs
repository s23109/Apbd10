using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apbd10Cw.Models;

namespace Apbd10Cw.Data
{
    public class Apbd10CwContext : DbContext
    {
        public Apbd10CwContext (DbContextOptions<Apbd10CwContext> options)
            : base(options)
        {
        }

        public DbSet<Apbd10Cw.Models.Movie> Movie { get; set; }
    }
}
