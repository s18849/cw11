using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/medicament")]
    [ApiController]
    public class MedicamentsController : ControllerBase
    {
        public readonly MedicamentDbContext _context;
        public MedicamentsController(MedicamentDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetMedicament()
        {
            return Ok();
        }
    }
}