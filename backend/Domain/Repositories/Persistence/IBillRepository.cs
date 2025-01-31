using Domain.Entities;

namespace Domain.Repositories.Persistence
{
    public interface IBillRepository
    {
        public RepositoryResult<BillSummary> GetBillsSummary();
    }
}
