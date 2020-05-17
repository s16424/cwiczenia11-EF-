using Application_2.DTO;
using Application_2.Models;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_2.Services
{
    public class EfDoctorDbService : IDoctorDbService
    {
        private readonly MedDbContext _context;
        public EfDoctorDbService(MedDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList();

        }

        public void AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public bool ContainsDoctor(string name, string lastname)
        {
            var check = _context.Doctors.Any(e => e.FirstName == name && e.LastName == lastname);
                return check;
                    }
        public bool ContainsDoctor(int id)
        {
            var check = _context.Doctors.Any(e => e.IdDoctor == id );
            return check;
        }

        public void ModifyDoctor(ModifyDoctorRequest req) 
        {
            var doctor = _context.Doctors.FirstOrDefault(e => e.IdDoctor == req.DoctorId);
           
                if (req.newName != null)
                    doctor.FirstName = req.newName;
                if (req.newLastName != null)
                    doctor.LastName = req.newLastName;
                if (req.newMail != null)
                    doctor.Email = req.newMail;

                _context.SaveChanges();
           
        }
        public void DeleteDoctor(int id)
        {

            Doctor toRemove = new Doctor { IdDoctor = id };
            _context.Doctors.Remove(toRemove);
            _context.SaveChanges();
        }


    }
}
