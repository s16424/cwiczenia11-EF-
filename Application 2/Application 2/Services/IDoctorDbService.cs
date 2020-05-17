using Application_2.DTO;
using Application_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2.Services
{
    public interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();

        public void AddDoctor(Doctor doc);
        public bool ContainsDoctor(string name, string lastname);
        public bool ContainsDoctor(int id);
        public void ModifyDoctor(ModifyDoctorRequest r);

        public void DeleteDoctor(int id);
    }
}
