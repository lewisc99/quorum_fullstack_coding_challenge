using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace YourApp.WebAPI.Controllers
{
    [Route("api/bills")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly CsvDbContext _context;

        public BillController(CsvDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBills()
        {
            var bills = _context.Bills;
            return Ok(bills);
        }

        [HttpGet("{id}")]
        public IActionResult GetBillById(int id)
        {
            var bill = _context.Bills.FirstOrDefault(b => b.Id == id);
            if (bill == null)
                return NotFound();
            return Ok(bill);
        }
    }
}
