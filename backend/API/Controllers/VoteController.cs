using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/Vote")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private readonly CsvDbContext _context;

        public VoteController(CsvDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetVotes()
        {
            var votes = _context.Votes;
            return Ok(votes);
        }

        [HttpGet("{id}")]
        public IActionResult GetBillById(int id)
        {
            var bill = _context.Votes.FirstOrDefault(b => b.Id == id);
            if (bill == null)
                return NotFound();
            return Ok(bill);
        }
    }
}
