using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2.DTO
{
    public class AddNewDoctorRequest
    {
        [Required (ErrorMessage = "Imie jest wymagane")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Kontakt email jest wymagany")]
        public string Email { get; set; }
    }
}
