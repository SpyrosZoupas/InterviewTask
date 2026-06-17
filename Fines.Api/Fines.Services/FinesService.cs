using Fines.Core.Dtos;
using Fines.Data.Models;
using Microsoft.Extensions.Logging;

namespace Fines.Services;

public class FinesService : IFinesService
{
    private readonly IFinesRepository _finesRepository;
    private readonly ILogger<FinesService> _logger;

    public FinesService(IFinesRepository finesRepository, ILogger<FinesService> logger)
    {
        _finesRepository = finesRepository;
        _logger = logger;
    }

    public async Task<IEnumerable<FinesResponse>> GetFinesAsync(FineFiltersRequest? filters = null)
    {
        var fines = await _finesRepository.GetAllFinesAsync(filters);

        var mappedFines = fines.Select(MapToResponse).ToList();
        _logger.LogInformation($"Successfully mapped {mappedFines.Count} fines.");

        return mappedFines;
    }

    private FinesResponse MapToResponse(FinesEntity fine)
    {
        return new FinesResponse
        {
            Id = fine.Id,
            FineNo = fine.FineNo,
            FineDate = fine.FineDate,
            FineType = fine.FineType,
            VehicleRegNo = fine.Vehicle.RegistrationNumber,
            VehicleDriverName = fine.VehicleDriverName,
            CustomerCompanyName = fine.Customer.CompanyName
        };
    }
}
