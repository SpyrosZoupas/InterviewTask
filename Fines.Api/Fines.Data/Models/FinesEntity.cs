using Fines.Core.Enums;

namespace Fines.Data.Models;

public class FinesEntity
{
    public int Id { get; set; }
    public string FineNo { get; set; } = string.Empty;
    public DateTime FineDate { get; set; }
    public FineType FineType { get; set; }
    public string VehicleDriverName { get; set; } = string.Empty;
    
    // Vehicle relationship
    public int VehicleId { get; set; }
    public VehicleEntity Vehicle { get; set; } = null!;

    // Customer relationship
    public int CustomerId { get; set; }
}