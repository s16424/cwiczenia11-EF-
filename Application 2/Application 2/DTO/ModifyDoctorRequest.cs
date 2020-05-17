using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2.DTO
{
    public class ModifyDoctorRequest
    {
        [Required (ErrorMessage = "Podaj id lekarza, ktorego dane chcesz zmodyfikowac")]
        public int DoctorId { get; set; }
        public string newName { get; set; }
        public string newLastName { get; set; }
        public string newMail { get; set; }
    }
}
