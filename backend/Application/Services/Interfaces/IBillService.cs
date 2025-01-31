using Application.DTOs;
using Domain.Api;

namespace Domain.Repositories.Persistence
{
    public interface IBillService
    {
        public ApiResponse<BillSummaryDto> GetBillsSummary();
    }
}
