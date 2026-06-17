using Fines.Core.Dtos;
using Fines.Core.Enums;
using Fines.Data.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace Fines.Data;

public class FinesRepository : IFinesRepository
{
    private readonly FinesDbContext _context;

    public FinesRepository(FinesDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FinesEntity>> GetAllFinesAsync(FineFiltersRequest? filters = null)
    {
        IQueryable<FinesEntity> query = _context.Fines
            .Include(f => f.Vehicle)
            .Include(f => f.Customer);

        if (filters != null)
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
            }

            if (!string.IsNullOrWhiteSpace(filters.VehicleRegNo))
            {
                query = query.Where(f => f.Vehicle.RegistrationNumber.Contains(filters.VehicleRegNo));
            }

            if (filters.Date != DateTime.MinValue)
            {
                query = query.Where(f => f.FineDate.Date == filters.Date.Date);
            }
        }

        return await query.ToListAsync();
    }
}
