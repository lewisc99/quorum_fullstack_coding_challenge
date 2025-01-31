using Application.DTOs;
using Domain.Entities;

namespace Application.Mappers
{
    public static class DtoMapper
    {
        public static BillSummaryDto ToDto(this BillSummary billSummary)
        {
            return new BillSummaryDto
            {
                Id = billSummary.Id,
                BillTitle = billSummary.BillTitle,
                Supporters = billSummary.Supporters,
                Opposers = billSummary.Opposers,
                PrimarySponsor = billSummary.PrimarySponsor
            };
        }

        public static List<BillSummaryDto> ToDtoList(this List<BillSummary> billSummaries) => billSummaries.Select(b => b.ToDto()).ToList();
       
        public static LegislatorVoteDto ToDto(this LegislatorVote legislatorVote)
        {
            return new LegislatorVoteDto
            {
                LegislatorId = legislatorVote.LegislatorId,
                LegislatorName = legislatorVote.LegislatorName,
                OpposedBills  = legislatorVote.OpposedBills,
                SupportedBills = legislatorVote.SupportedBills,
            };
        }

        public static List<LegislatorVoteDto> ToDtoList(this List<LegislatorVote> legislatorVotes) => legislatorVotes.Select(l => l.ToDto()).ToList();
    }
}
