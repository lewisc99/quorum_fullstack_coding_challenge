using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/Legislator")]
    [ApiController]
    public class LegislatorController : ControllerBase
    {
        private readonly CsvDbContext _context;

        public LegislatorController(CsvDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetLegislators()
        {
            var legislators = _context.Legislators;
            return Ok(legislators);
        }

        [HttpGet("{id}")]
        public IActionResult GetBillById(int id)
        {
            var bill = _context.Legislators.FirstOrDefault(b => b.Id == id);
            if (bill == null)
                return NotFound();
            return Ok(bill);
        }
    }
}
