using Domain.Entities;

namespace Domain.Repositories.Persistence
{
    public interface ILegislatorRepository
    {
        public RepositoryResult<LegislatorVote> GetLegislatorsVotes();
    }
}
