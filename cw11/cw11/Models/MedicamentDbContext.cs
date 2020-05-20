using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class MedicamentDbContext : DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        public MedicamentDbContext() { }
        public MedicamentDbContext(DbContextOptions options)
            :base(options)
        {

        }
    }
}
