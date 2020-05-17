using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2.Models
{
    public class Prescription
    {
        public int IdPrescription { get; set; }
        public String Date { get; set; }
        public String DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
    }

}
