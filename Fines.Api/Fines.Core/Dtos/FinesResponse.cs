using Fines.Core.Enums;

namespace Fines.Core.Dtos;

public class FinesResponse
{
    public int Id { get; set; }
    public string FineNo { get; set; } = string.Empty;
    public DateTime FineDate { get; set; }
    public FineType FineType { get; set; }
    public string VehicleRegNo { get; set; } = string.Empty;
    public string VehicleDriverName { get; set; } = string.Empty;
}
