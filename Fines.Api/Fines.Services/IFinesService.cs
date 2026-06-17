using Fines.Core.Dtos;

public interface IFinesService
{
    Task<IEnumerable<FinesResponse>> GetFinesAsync();
}
