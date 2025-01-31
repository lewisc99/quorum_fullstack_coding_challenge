using Application.DTOs;
using Asp.Versioning;
using Domain.Api;
using Domain.Repositories.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/Legislator")]
    [ApiVersion("1.0")]
    [ApiController]
    public class LegislatorController : ControllerBase
    {
        private readonly ILegislatorService _service;

        public LegislatorController(ILegislatorService service) => _service = service;

        [HttpGet("votes")]
        public ApiResponse<LegislatorVoteDto> GetLegislatorsVotes() => _service.GetLegislatorsVotes();
    }
}
