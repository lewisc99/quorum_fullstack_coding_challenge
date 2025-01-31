using Domain.Entities;
using Domain.Repositories.Persistence;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Interfaces
{
    public class LegislatorRepository : ILegislatorRepository
    {

        private readonly CsvDbContext _context;

        public LegislatorRepository(CsvDbContext context) => _context = context;

        public RepositoryResult<LegislatorVote> GetLegislatorsVotes()
        {
            try
            {
                List<LegislatorVote> legislatorsVotes = _context.VoteResults
                     .GroupBy(v => v.LegislatorId)
                     .Select(group => new LegislatorVote
                     {
                         LegislatorId = group.Key,
                         LegislatorName = _context.Legislators
                             .Where(l => l.Id == group.Key)
                             .Select(l => l.Name)
                             .FirstOrDefault(),
                         SupportedBills = group.Count(v => v.VoteType == 1),
                         OpposedBills = group.Count(v => v.VoteType == 2)
                     })
                     .ToList();

                throw new Exception("error");

                return RepositoryResult<LegislatorVote>.Success(legislatorsVotes);
            }
            catch (Exception)
            {
                return RepositoryResult<LegislatorVote>.Error($"Error fetching bills, please try again later");
            }
        }
    }
}
