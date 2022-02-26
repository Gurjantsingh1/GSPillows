using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GSPillows.Models;

namespace GSPillows.Data
{
    public class GSPillowsContext : DbContext
    {
        public GSPillowsContext (DbContextOptions<GSPillowsContext> options)
            : base(options)
        {
        }

        public DbSet<GSPillows.Models.Pillow> Pillow { get; set; }
    }
}
