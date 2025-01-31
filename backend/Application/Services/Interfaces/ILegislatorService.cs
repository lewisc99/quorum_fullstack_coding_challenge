using Application.DTOs;
using Domain.Api;

namespace Domain.Repositories.Persistence
{
    public interface ILegislatorService
    {
        public ApiResponse<LegislatorVoteDto> GetLegislatorsVotes();
    }
}
