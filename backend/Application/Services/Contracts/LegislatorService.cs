using Application.DTOs;
using Application.Mappers;
using Domain.Api;
using Domain.Entities;
using Domain.Repositories.Persistence;

namespace Application.Services
{
    public class LegislatorService : ILegislatorService
    {
        private readonly ILegislatorRepository _repository;

        public LegislatorService(ILegislatorRepository repository) => _repository = repository;

        public ApiResponse<LegislatorVoteDto> GetLegislatorsVotes()
        {
            RepositoryResult<LegislatorVote> response = _repository.GetLegislatorsVotes();

            if (!response.Status)
                return ApiResponse<LegislatorVoteDto>.Error(response.Message);

            List<LegislatorVoteDto> legislatorDtos = response.Data.ToDtoList();
            return ApiResponse<LegislatorVoteDto>.CreateForList(
                legislatorDtos,
                totalSize: legislatorDtos.Count,
                totalPages: 1
            );
        }
    }
}
