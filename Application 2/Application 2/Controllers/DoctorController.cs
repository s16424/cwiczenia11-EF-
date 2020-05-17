using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application_2.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly MedDbContext _context;
        public DoctorController(MedDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok();
        }

    }
}