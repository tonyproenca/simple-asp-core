using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie2.Models
{
    public class RazorPagesMovie2Context : DbContext
    {
        public RazorPagesMovie2Context (DbContextOptions<RazorPagesMovie2Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie2.Models.Movie> Movie { get; set; }
    }
}
