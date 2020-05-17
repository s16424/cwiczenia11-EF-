using Application_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2.Configurations
{
    public class DoctorsConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            var DoctorsData = new List<Doctor>();

            DoctorsData.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Adam",
                LastName = "Nowak",
                Email = "a.nowak@lecznica.com"
            });

            DoctorsData.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Piotr",
                LastName = "Pietrzak",
                Email = "p.pietrzak@lecznica.com"
            });

            builder.HasData(DoctorsData);
        }
    }
}
