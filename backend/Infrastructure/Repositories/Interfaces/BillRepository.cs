using Domain.Entities;
using Domain.Repositories.Persistence;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Interfaces
{
    public class BillRepository : IBillRepository
    {
        private readonly CsvDbContext _context;

        public BillRepository(CsvDbContext context) => _context = context;

        public RepositoryResult<BillSummary> GetBillsSummary()
        {
            try
            {
                var bills = _context.Bills;
                var legislators = _context.Legislators;
                var votes = _context.Votes;
                var voteResults = _context.VoteResults;

                List<BillSummary> billSummaryList = bills.Select(b =>
                {
                    var billVotes = votes.Where(v => v.BillId == b.Id).Select(v => v.Id).ToList();
                    var supporters = voteResults.Count(vr => billVotes.Contains(vr.VoteId) && vr.VoteType == 1);
                    var opposers = voteResults.Count(vr => billVotes.Contains(vr.VoteId) && vr.VoteType == 2);
                    var primarySponsor = legislators.FirstOrDefault(l => l.Id == b.SponsorId)?.Name ?? "Unknown";

                    return new BillSummary
                    {
                        Id = b.Id,
                        BillTitle = b.Title,
                        Supporters = supporters,
                        Opposers = opposers,
                        PrimarySponsor = primarySponsor
                    };
                }).ToList();

                return RepositoryResult<BillSummary>.Success(billSummaryList);

            }
            catch (Exception)
            {
                return RepositoryResult<BillSummary>.Error($"Error fetching bills, please try again later");
            }
        }

    }
}
