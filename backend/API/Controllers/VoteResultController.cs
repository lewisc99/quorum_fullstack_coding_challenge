using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/VoteResult")]
    [ApiController]
    public class VoteResultController : ControllerBase
    {
        private readonly CsvDbContext _context;

        public VoteResultController(CsvDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetVoteResults()
        {
            var voteresults = _context.VoteResults;
            return Ok(voteresults);
        }

        [HttpGet("{id}")]
        public IActionResult GetBillById(int id)
        {
            var bill = _context.VoteResults.FirstOrDefault(b => b.Id == id);
            if (bill == null)
                return NotFound();
            return Ok(bill);
        }
    }
}
