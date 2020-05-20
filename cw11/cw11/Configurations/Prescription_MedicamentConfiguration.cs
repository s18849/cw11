using cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Configurations
{
    public class Prescription_MedicamentConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.HasKey(key => new { key.IdMedicament, key.IdPrescription });
            builder.HasOne(e => e.Prescription).WithMany().HasForeignKey(e => e.IdPrescription);
            builder.HasOne(e => e.Medicament).WithMany().HasForeignKey(e => e.IdMedicament);
            builder.Property(e => e.Dose).IsRequired();
            builder.Property(e => e.Details).HasMaxLength(100);
        }
    }
}
