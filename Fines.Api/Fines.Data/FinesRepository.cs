using Fines.Core.Dtos;
using Fines.Core.Enums;
using Fines.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static System.Net.WebRequestMethods;

namespace Fines.Data;

public class FinesRepository : IFinesRepository
{
    private readonly FinesDbContext _context;
    private readonly ILogger<FinesRepository> _logger;

    public FinesRepository(FinesDbContext context, ILogger<FinesRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<IEnumerable<FinesEntity>> GetAllFinesAsync(FineFiltersRequest? filters = null)
    {
        _logger.LogInformation("Retrieving fine data");

        IQueryable<FinesEntity> query = _context.Fines
            .Include(f => f.Vehicle)
            .Include(f => f.Customer);

        if (filters != null)
        {
            _logger.LogInformation($"Applying filters: {filters}");
            query = ApplyFilters(query, filters);
        }

        var result = await query.ToListAsync();
        _logger.LogInformation($"Retrieved {result.Count()} fines");

        return result;
    }

    private IQueryable<FinesEntity> ApplyFilters(IQueryable<FinesEntity> query, FineFiltersRequest filters)
    {
        if (!string.IsNullOrWhiteSpace(filters.FineType))
        {
            if (Enum.TryParse<FineType>(
                    filters.FineType,
                    ignoreCase: true,
                    out var fineType))
            {
                query = query.Where(f => f.FineType == fineType);
            }
            else
            {
                _logger.LogWarning($"{filters.FineType} is not a valid fine type.");
            }
        }

        if (!string.IsNullOrWhiteSpace(filters.VehicleRegNo))
        {
            query = query.Where(f => f.Vehicle.RegistrationNumber.ToLower().Contains(filters.VehicleRegNo.ToLower()));
        }

        if (filters.FromDate.HasValue)
        {
            query = query.Where(f => f.FineDate >= filters.FromDate.Value);
        }

        if (filters.ToDate.HasValue)
        {
            query = query.Where(f => f.FineDate <= filters.ToDate.Value);
        }

        return query;
    }
}
