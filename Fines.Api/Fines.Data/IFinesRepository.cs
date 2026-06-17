using Fines.Data.Models;

public interface IFinesRepository
{
    Task<IEnumerable<FinesEntity>> GetAllFinesAsync();
}