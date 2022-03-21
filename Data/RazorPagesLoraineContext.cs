#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesLoraine.Models;

namespace RazorPagesLoraine.Data
{
    public class RazorPagesLoraineContext : DbContext
    {
        public RazorPagesLoraineContext (DbContextOptions<RazorPagesLoraineContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesLoraine.Models.Movie> Movie { get; set; }
    }
}
