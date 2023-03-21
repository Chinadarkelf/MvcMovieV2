using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieV2.Models;

namespace MvcMovieV2.Data
{
    public class MvcMovieV2Context : DbContext
    {
        public MvcMovieV2Context (DbContextOptions<MvcMovieV2Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieV2.Models.Movie> Movie { get; set; } = default!;
    }
}
