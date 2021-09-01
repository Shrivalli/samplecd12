using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstEg.Models;

namespace CodeFirstEg.Data
{
    public class VehicleContext : DbContext
    {
        public VehicleContext (DbContextOptions<VehicleContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirstEg.Models.Car> Car { get; set; }
        public DbSet<CodeFirstEg.Models.Bike> Bikes { get; set; }
    }
}
