using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_2.DTO;
using Application_2.Models;
using Application_2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application_2.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorDbService _context;
        public DoctorController(IDoctorDbService context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.GetDoctors());
        }

        [HttpPost]

        public IActionResult AddDoctor([FromBody] AddNewDoctorRequest request)
        {
            if (_context.ContainsDoctor(request.Name, request.LastName))
            {
                return BadRequest("Taki lekarz juz istnieje w bazie");
            }

            _context.AddDoctor(new Doctor
            {
                FirstName = request.Name,
                LastName = request.LastName,
                Email = request.Email
            });

            return Ok("Dodano nowego doktora");
        }

        [HttpPut]
        public IActionResult ModifyDoctor([FromBody] ModifyDoctorRequest request)
        {
            if (!_context.ContainsDoctor(request.DoctorId))
            {
                int d = request.DoctorId;
                return BadRequest("Brak lekarza o podanym id");
            }

            _context.ModifyDoctor(request);
            return Ok("Zmodyfikowano dane lekarza");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteDoctor(int id)
        {
            if (!_context.ContainsDoctor(id))
            {
                return BadRequest("taki lekarz nie istnieje");
            }

            _context.DeleteDoctor(id);
          
            return Ok("Usunieto lekarza");
        }
    }
}