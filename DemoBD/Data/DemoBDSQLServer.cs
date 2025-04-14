using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoBD.Models;

namespace DemoBD.Data
{
    public class DemoBDSQLServer : DbContext
    {
        public DemoBDSQLServer (DbContextOptions<DemoBDSQLServer> options)
            : base(options)
        {
        }

        public DbSet<DemoBD.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<DemoBD.Models.Facultad> Facultad { get; set; } = default!;
    }
}
