using Fines.Core.Dtos;
using Fines.Data.Models;

public interface IFinesRepository
{
    Task<IEnumerable<FinesEntity>> GetAllFinesAsync(FineFiltersRequest? filters = null);
}