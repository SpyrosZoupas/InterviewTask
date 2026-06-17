using Fines.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Fines.Data;

public class FinesRepository : IFinesRepository
{
    private readonly FinesDbContext _context;

    public FinesRepository(FinesDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FinesEntity>> GetAllFinesAsync()
    {
        return await _context.Fines
            .Include(f => f.Vehicle)
            .ToListAsync();
    }
}
