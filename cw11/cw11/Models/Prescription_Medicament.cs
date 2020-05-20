﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class Prescription_Medicament
    {
        [Key]
        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }
        [Key]
        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }
        public int Dose { get; set; }
        [MaxLength(100)]
        public string Details { get; set; }

        public virtual Medicament Medicament { get; set; }
        public virtual Prescription Prescription { get; set; }

    }
}
