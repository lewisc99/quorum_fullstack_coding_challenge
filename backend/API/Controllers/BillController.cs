using Application.DTOs;
using Asp.Versioning;
using Domain.Api;
using Domain.Repositories.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace YourApp.WebAPI.Controllers
{
    [Route("api/Bills")]
    [ApiVersion("1.0")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService _service;

        public BillController(IBillService service) => _service = service;

        [HttpGet("summary")]
        public ApiResponse<BillSummaryDto> GetBillsSummary() => _service.GetBillsSummary();
    }
}
