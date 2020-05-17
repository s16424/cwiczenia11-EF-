using Application_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2.Configurations
{
    public class PatientsConfiuration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            var PatientList = new List<Patient>();
            PatientList.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "Kajetan",
                LastName = "Kajetanowicz",
                Birthdate = new DateTime(1990, 10, 27)
            }) ;
            PatientList.Add(new Patient
            {
                IdPatient = 2,
                FirstName = "Aleksandra",
                LastName = "Iksinska",
                Birthdate = new DateTime(1994, 01, 21)
            });
            builder.HasData(PatientList);
        }
    }
}
