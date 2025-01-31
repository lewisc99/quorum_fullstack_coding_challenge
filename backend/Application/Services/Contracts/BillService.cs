using Application.DTOs;
using Application.Mappers;
using Domain.Api;
using Domain.Entities;
using Domain.Repositories.Persistence;

namespace Application.Services
{
    public class BillService : IBillService
    {
        private readonly IBillRepository _repository;

        public BillService(IBillRepository repository) => _repository = repository;

        public ApiResponse<BillSummaryDto> GetBillsSummary()
        {
            RepositoryResult<BillSummary> response = _repository.GetBillsSummary();

            if (!response.Status)
                return ApiResponse<BillSummaryDto>.Error(response.Message);

            List<BillSummaryDto> billDtos = response.Data.ToDtoList();
            return ApiResponse<BillSummaryDto>.CreateForList(
                billDtos,
                totalSize: billDtos.Count,
                totalPages: 1
            );
        }
    }
}
