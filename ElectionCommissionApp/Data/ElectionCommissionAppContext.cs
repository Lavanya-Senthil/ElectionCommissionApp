using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ElectionCommissionApp.Models;

namespace ElectionCommissionApp.Data
{
    public class ElectionCommissionAppContext : DbContext
    {
        public ElectionCommissionAppContext (DbContextOptions<ElectionCommissionAppContext> options)
            : base(options)
        {
        }

        public DbSet<ElectionCommissionApp.Models.State> State { get; set; } = default!;
        public DbSet<ElectionCommissionApp.Models.Voters> Voters { get; set; } = default!;
        public DbSet<ElectionCommissionApp.Models.Party> Party { get; set; } = default!;
    }
}
