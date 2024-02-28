using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClinicBigBoarsWeb.Models;

namespace ClinicBigBoarsWeb.Data
{
    public class ClinicBigBoarsWebContext : DbContext
    {
        public ClinicBigBoarsWebContext (DbContextOptions<ClinicBigBoarsWebContext> options)
            : base(options)
        {
        }

        public DbSet<ClinicBigBoarsWeb.Models.Patient> Patient { get; set; } = default!;
        public DbSet<ClinicBigBoarsWeb.Models.Hospitalization> Hospitalization { get; set; } = default!;
        public DbSet<ClinicBigBoarsWeb.Models.TherapMeasures> TherapMeasures { get; set; } = default!;
    }
}
